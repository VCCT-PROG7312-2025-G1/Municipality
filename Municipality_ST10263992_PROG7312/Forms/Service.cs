using Municipality_ST10263992_PROG7312;
using Municipality_ST10263992_PROG7312.Forms;
using Municipality_ST10263992_PROG7312.Forms.Events;
using Municipality_ST10263992_PROG7312.Forms.ReportIssue;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Municipality_ST10263992_PROG7312.Forms
{
    public partial class frmService : Form
    {
        // Fields for graph visualization
        private List<Point> nodePositions;
        private List<(int u, int v, int w)> mstEdges;
        private Dictionary<int, ServiceRequest> vertexMap;
        private int _selectedNodeIndex = -1; // track selected node

        public frmService()
        {
            InitializeComponent();
            pnlMainPage.BackColor = ColorTranslator.FromHtml("#" + ColourScheme.DarkWhite);
            pnlMainInside.BackColor = ColorTranslator.FromHtml("#" + ColourScheme.DarkerGrey);
            pnlInner.BackColor = ColorTranslator.FromHtml("#" + ColourScheme.DarkPurple);
            pnlDisplaySearch.BackColor = ColorTranslator.FromHtml("#" + ColourScheme.LighterPurple);
            pnlOutService.BackColor = ColorTranslator.FromHtml("#" + ColourScheme.LighterPurple);
            pnlSearch.BackColor = ColorTranslator.FromHtml("#" + ColourScheme.LighterPurple);
            redOut.Font = new Font("Courier New", 9.75F, FontStyle.Bold);
            
            // Hook up the Paint event for the graph panel
            pnlGraph.Paint += PnlGraph_Paint;
            pnlGraph.MouseClick += pnlGraph_MouseClick;

            TableView();
        }

        private void Service_Load(object sender, EventArgs e)
        {
            //LoadServiceRequests();
        }

        private void TableView()
        {
            redOut.Clear();
            var serviceRequests = Database.Instance.GetAllServiceRequests().ToList();

            if (!serviceRequests.Any())
            {
                redOut.Text = "No service requests found.";
                return;
            }

            // Determine column widths
            int idWidth = Math.Max("ID".Length, serviceRequests.Max(r => r.Id.ToString().Length));
            int titleWidth = Math.Max("Title".Length, serviceRequests.Max(r => r.Title.Length));
            int categoryWidth = Math.Max("Category".Length, serviceRequests.Max(r => r.Category.Length));
            int locationWidth = Math.Max("Location".Length, serviceRequests.Max(r => r.Location.Length));
            int statusWidth = 10;
            //int enumLength = Enum.GetNames(typeof(Colors)).Length;

            // Add padding
            idWidth += 2;
            titleWidth += 2;
            categoryWidth += 2;
            locationWidth += 2;
            statusWidth += 2;

            // Create format string
            string format = $"{{0,-{idWidth}}} {{1,-{titleWidth}}} {{2,-{categoryWidth}}} {{3,-{locationWidth}}} {{4,-{statusWidth}}}\n";

            // Build the output string
            StringBuilder sb = new StringBuilder();

            // Append Header
            sb.AppendFormat(format, "ID", "Title", "Category", "Location", "Status");

            // Append Separator
            int totalWidth = idWidth + titleWidth + categoryWidth + locationWidth + statusWidth;
            sb.AppendLine(new string('=', totalWidth > 0 ? totalWidth - 1 : 0));

            // Append Data
            foreach (var request in serviceRequests)
            {
                sb.AppendFormat(format, request.Id, request.Title, request.Category, request.Location, request.Status);
            }

            redOut.Text = sb.ToString();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            frmMainMenu mainMenuForm = new frmMainMenu();
            this.Hide();
            mainMenuForm.Show();
        }

        private void DisplayDetailsTab(ServiceRequest request)
        {
            if (request == null)
            {
                redDetails.Clear();
                return;
            }
            
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("===============================");
            sb.AppendLine($"ID: {request.Id}");
            sb.AppendLine($"Title: {request.Title}");
            sb.AppendLine($"Category: {request.Category}");
            sb.AppendLine($"Location: {request.Location}");
            sb.AppendLine($"Status: {request.Status}");
            sb.AppendLine("===============================");
            redDetails.Text = sb.ToString();
            redDetails.Tag = request.Id; // Store the ID in the Tag property
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string searchId = edtSearch.Text;
            if (int.TryParse(searchId, out int id))
            {
                var request = Database.Instance.FindServiceRequestById(id);
                if (request != null)
                {
                    DisplayDetailsTab(request);
                }
                else
                {
                    MessageBox.Show("Service request with the specified ID not found.", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    redDetails.Clear();
                    redDetails.Tag = null;
                }
            }
            else
            {
                MessageBox.Show("Please enter a valid numeric ID.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {


            //var allRequests = Database.Instance.GetAllServiceRequests().OrderBy(r => r.Id).ToList();

            //if (!allRequests.Any())
            //{
            //    MessageBox.Show("No service requests available.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //    return;
            //}

            //int currentId = -1;
            //if (redDetails.Tag is int)
            //{
            //    currentId = (int)redDetails.Tag;
            //}

            //if (currentId == -1)
            //{
            //    // Nothing is displayed, so show the first one
            //    DisplayDetailsTab(allRequests.First());
            //}
            //else
            //{
            //    // Find the current request in the list
            //    int currentIndex = allRequests.FindIndex(r => r.Id == currentId);

            //    if (currentIndex != -1)
            //    {
            //        // Get the next index, wrapping around if necessary
            //        int nextIndex = (currentIndex + 1) % allRequests.Count;
            //        DisplayDetailsTab(allRequests[nextIndex]);
            //    }
            //    else
            //    {
            //        // The currently displayed ID is not in the list anymore, show the first one
            //        DisplayDetailsTab(allRequests.First());
            //    }
            //}
        }

        private void btnGenerateRoute_Click(object sender, EventArgs e)
        {
            redDetails.Clear();
            pnlGraph.BackgroundImage= Municipality_ST10263992_PROG7312.Properties.Resources.cptImageCrop;
            var (totalWeight, routeEdges) = Database.Instance.GetOptimizedRoute();

            // Store data needed for drawing
            var allRequests = Database.Instance.GetAllServiceRequests().ToList();
            vertexMap = allRequests.Select((req, index) => new { req, index })
                                     .ToDictionary(x => x.index, x => x.req);
            
            var idToVertex = allRequests.Select((req, index) => new { req, index })
                                        .ToDictionary(x => x.req.Id, x => x.index);

            mstEdges = routeEdges.Select(edge => (idToVertex[edge.from.Id], idToVertex[edge.to.Id], edge.weight)).ToList();

            // Display textual route details
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Optimal Route Found (Prim's MST)");
            sb.AppendLine($"Total Distance: {totalWeight} units");
            sb.AppendLine(new string('-', 40));
            foreach (var edge in routeEdges)
            {
                sb.AppendLine($"Connect: (ID {edge.from.Id}) {edge.from.Title} <-> (ID {edge.to.Id}) {edge.to.Title} [Dist: {edge.weight}]");
            }
            redDetails.Text = sb.ToString();

            // Trigger a repaint of the graph panel
            pnlGraph.Invalidate();
        }

        private void PnlGraph_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;

            if (vertexMap == null || !vertexMap.Any()) return;

            CalculateNodePositions(vertexMap.Count);

            // Draw MST edges
            if (mstEdges != null)
            {
                using (Pen mstPen = new Pen(Color.Tomato, 3))
                {
                    foreach (var edge in mstEdges)
                    {
                        Point p1 = nodePositions[edge.u];
                        Point p2 = nodePositions[edge.v];
                        g.DrawLine(mstPen, p1, p2);

                        // Draw edge weight
                        Point midPoint = new Point((p1.X + p2.X) / 2, (p1.Y + p2.Y) / 2);
                        g.DrawString(edge.w.ToString(), this.Font, Brushes.White, midPoint);
                    }
                }
            }

            // Draw nodes and labels
            using (Font titleFont = new Font ("Arial", 10 , FontStyle.Bold)) {
                for (int i = 0; i < nodePositions.Count; i++)
                {
                    Point pos = nodePositions[i];

                    Brush nodeBrush = (i == _selectedNodeIndex) ? Brushes.OrangeRed : Brushes.SkyBlue;

                    g.FillEllipse(nodeBrush, pos.X - 10, pos.Y - 10, 20, 20);
                    g.DrawEllipse(Pens.White, pos.X - 10, pos.Y - 10, 20, 20);

                    string title = vertexMap[i].Title;
                    if (title.Length > 12)
                    {
                        title = title.Substring(0, 12) + "...";
                    }
                    SizeF titleSize = g.MeasureString(title, titleFont);
                    PointF titlePos = new PointF(pos.X - titleSize.Width / 2, pos.Y - 25);
                    g.DrawString(title, titleFont, Brushes.Black, titlePos);
                }
            }
        }

        private void CalculateNodePositions(int nodeCount)
        {
            nodePositions = new List<Point>();
            if (nodeCount == 0) return;

            int centerX = pnlGraph.Width / 2;
            int centerY = pnlGraph.Height / 2;
            int radius = Math.Min(centerX, centerY) - 40;
            double angleStep = 2 * Math.PI / nodeCount;

            for (int i = 0; i < nodeCount; i++)
            {
                double angle = i * angleStep;
                int x = (int)(centerX + radius * Math.Cos(angle));
                int y = (int)(centerY + radius * Math.Sin(angle));
                nodePositions.Add(new Point(x, y));
            }
        }

        private void pnlGraph_MouseClick(object sender, MouseEventArgs e)
        {
            const int nodeRadius = 10;
            if (nodePositions == null || !nodePositions.Any()) return;
            for (int i = 0; i < nodePositions.Count; i++)
            {
                Point center = nodePositions[i];
                double distance = Math.Sqrt(Math.Pow(e.X - center.X, 2) + Math.Pow(e.Y - center.Y, 2));
                if (distance <= nodeRadius) {
                    if (vertexMap.TryGetValue(i,out ServiceRequest clickedRequest))
                    {
                        DisplayDetailsTab(clickedRequest);

                        _selectedNodeIndex = i;
                        pnlGraph.Invalidate(); // Redraw to show selection
                        return;
                    }
                }
            }
        }

        private void btnNextPriority_Click(object sender, EventArgs e)
        {
            var urgentRequest = Database.Instance.GetNextUrgentServiceRequest();

            if (urgentRequest != null)
            {
                DisplayDetailsTab(urgentRequest);
                MessageBox.Show($"Processing next urgent task:\nID: {urgentRequest.Id} - {urgentRequest.Title}", "Next Priority Task", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
                // Refresh the main table view since a request has been removed
                TableView();
            }
            else
            {
                MessageBox.Show("No active service requests in the priority queue.", "Queue Empty", MessageBoxButtons.OK, MessageBoxIcon.Information);
                redDetails.Clear();
            }
        }
    }
}
