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
        private ServiceRequest _selectedRequest = null;
        private int _selectedNodeIndex = -1; // track selected node

        public frmService()
        {
            InitializeComponent();
            pnlMainPage.BackColor = ColorTranslator.FromHtml("#" + ColourScheme.DarkGrey);
            pnlMainInside.BackColor = ColorTranslator.FromHtml("#" + ColourScheme.DarkerGrey);
            pnlInner.BackColor = ColorTranslator.FromHtml("#" + ColourScheme.Maroon);
            pnlDisplaySearch.BackColor = ColorTranslator.FromHtml("#" + ColourScheme.DarkRed);
            pnlOutService.BackColor = ColorTranslator.FromHtml("#" + ColourScheme.DarkRed);
            pnlSearch.BackColor = ColorTranslator.FromHtml("#" + ColourScheme.DarkRed);
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


            // Corrected format string for the main part of the line
            string format = $"{{0,-{idWidth}}}{{1,-{titleWidth}}}{{2,-{categoryWidth}}}{{3,-{locationWidth}}}";
            string headerFormat = $"{{0,-{idWidth}}}{{1,-{titleWidth}}}{{2,-{categoryWidth}}}{{3,-{locationWidth}}}{{4,-{statusWidth}}}\n";

            // Build the output string line by line to apply colors
            redOut.SelectionColor = redOut.ForeColor;
            redOut.AppendText(string.Format(headerFormat, "ID", "Title", "Category", "Location", "Status"));
            int totalWidth = idWidth + titleWidth + categoryWidth + locationWidth + statusWidth;
            redOut.AppendText(new string('=', totalWidth > 0 ? totalWidth - 1 : 0) + "\n");

            // Append Data with colors
            foreach (var request in serviceRequests)
            {
                redOut.SelectionColor = redOut.ForeColor; // Reset to default
                redOut.AppendText(string.Format(format, request.Id, request.Title, request.Category, request.Location));

                // Pad the status manually to align it correctly
                string statusText = request.Status.ToString();
                redOut.AppendText(statusText.PadRight(statusWidth));

                // Now, select and color the status text we just added
                redOut.Select(redOut.Text.Length - statusWidth, statusText.Length);
                redOut.SelectionColor = GetColorForStatus(request.Status);
                redOut.AppendText("\n");
            }

            redOut.DeselectAll();
            redOut.ResumeLayout(); // Resume layout
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            frmMainMenu mainMenuForm = new frmMainMenu();
            this.Hide();
            mainMenuForm.Show();
        }

        private void DisplayDetailsTab(ServiceRequest request)
        {
            _selectedRequest = request; // Keep track of the selected request

            if (request == null)
            {
                redDetails.Clear();
                redDetails.Tag = null;
                return;
            }

            // Use AppendText to allow for coloring
            redDetails.Clear();
            redDetails.SelectionColor = redDetails.ForeColor; // Reset to default color

            redDetails.AppendText($"Title: {request.Title}\n\n");
            redDetails.AppendText("====================\n\n");
            redDetails.AppendText($"ID: {request.Id}\n");
            redDetails.AppendText($"Category: {request.Category}\n");
            redDetails.AppendText($"Location: {request.Location}\n");
            redDetails.AppendText("Status: ");

            // Set color for status and append it
            redDetails.SelectionColor = GetColorForStatus(request.Status);
            redDetails.AppendText(request.Status.ToString());

            // Reset color and set tag
            redDetails.SelectionColor = redDetails.ForeColor;
            redDetails.Tag = request.Id; // Store the ID in the Tag property
        }

        private Color GetColorForStatus(RequestStatus status)
        {
            switch (status)
            {
                case RequestStatus.Completed:
                    return Color.LawnGreen;
                case RequestStatus.InProgress:
                    return Color.Orange;
                case RequestStatus.Pending:
                    return Color.IndianRed;
                default:
                    return redOut.ForeColor; // Default color
            }
        }

        private void HighlightRequestInTableView(ServiceRequest request)
        {
            // Reset previous highlighting
            redOut.SelectAll();
            redOut.SelectionBackColor = ColorTranslator.FromHtml("#" + ColourScheme.DarkerGrey);
            redOut.DeselectAll();

            if (request == null) return;

            // Highlight the found request in the table view
            var serviceRequests = Database.Instance.GetAllServiceRequests().ToList();
            if (!serviceRequests.Any(r => r.Id == request.Id)) return; // Don't highlight if not in list

            int idWidth = Math.Max("ID".Length, serviceRequests.Max(r => r.Id.ToString().Length)) + 2;
            int titleWidth = Math.Max("Title".Length, serviceRequests.Max(r => r.Title.Length)) + 2;
            int categoryWidth = Math.Max("Category".Length, serviceRequests.Max(r => r.Category.Length)) + 2;
            int locationWidth = Math.Max("Location".Length, serviceRequests.Max(r => r.Location.Length)) + 2;
            int statusWidth = 10 + 2;

            string format = $"{{0,-{idWidth}}} {{1,-{titleWidth}}} {{2,-{categoryWidth}}} {{3,-{locationWidth}}} {{4,-{statusWidth}}}";
            string requestLine = string.Format(format, request.Id, request.Title, request.Category, request.Location, request.Status);

            int startIndex = redOut.Text.IndexOf(requestLine);
            if (startIndex != -1)
            {
                redOut.Select(startIndex, requestLine.TrimEnd().Length);
                redOut.SelectionBackColor = Color.Blue;
                // Do not deselect, so the highlight remains visible.
                // redOut.DeselectAll(); 
            }
        }

        private void HighlightRequest(ServiceRequest request)
        {
            DisplayDetailsTab(request);
            HighlightRequestInTableView(request);

            int nodeIndex = -1;
            if (vertexMap != null && request != null)
            {
                foreach (var entry in vertexMap)
                {
                    if (entry.Value.Id == request.Id)
                    {
                        nodeIndex = entry.Key;
                        break;
                    }
                }
            }

            _selectedNodeIndex = nodeIndex;
            // Always invalidate the panel. The paint event will only run if it's visible.
            pnlGraph.Invalidate();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string searchId = edtSearch.Text;
            if (int.TryParse(searchId, out int id))
            {
                var request = Database.Instance.FindServiceRequestById(id);
                if (request != null)
                {
                    HighlightRequest(request);
                }
                else
                {
                    MessageBox.Show("Service request with the specified ID not found.", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    HighlightRequest(null); // Clear selection
                    edtSearch.Clear();
                }
            }
            else
            {
                MessageBox.Show("Please enter a valid numeric ID.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void Btn_MouseEnter(object sender, EventArgs e)
        {
            var btn = sender as Button;
            btn.ForeColor = System.Drawing.Color.FromArgb(0,0,0); 
        }
        private void Btn_MouseLeave(object sender, EventArgs e)
        {
            var btn = sender as Button;
            btn.ForeColor = System.Drawing.Color.FromArgb(227, 226, 236); 
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            // Define statuses to exclude
            var excludedStatuses = new List<RequestStatus> { RequestStatus.Completed, RequestStatus.Cancelled };

            // Get all requests and filter out the excluded ones
            var activeRequests = Database.Instance.GetAllServiceRequests()
                                           .Where(r => !excludedStatuses.Contains(r.Status))
                                           .ToList();

            if (!activeRequests.Any())
            {
                MessageBox.Show("No active service requests available.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                redDetails.Clear();
                redDetails.Tag = null;
                return;
            }

            int currentId = -1;
            if (redDetails.Tag is int tag)
            {
                currentId = tag;
            }

            if (currentId == -1)
            {
                // If nothing is displayed, show the first active request
                DisplayDetailsTab(activeRequests.First());
            }
            else
            {
                // Find the index of the currently displayed request in the active list
                int currentIndex = activeRequests.FindIndex(r => r.Id == currentId);

                if (currentIndex != -1)
                {
                    // Get the next index, wrapping around the active list
                    int nextIndex = (currentIndex + 1) % activeRequests.Count;
                    DisplayDetailsTab(activeRequests[nextIndex]);
                }
                else
                {
                    // If the current ID isn't in the active list (e.g., it was just completed),
                    // show the first active request.
                    DisplayDetailsTab(activeRequests.First());
                }
            }
            updateMap();
            HighlightRequest(_selectedRequest);
        }

        private void btnGenerateRoute_Click(object sender, EventArgs e)
        {
            //redDetails.Clear();
            updateMap();
        }

        private void updateMap()
        {
            pnlGraph.BackgroundImage = Municipality_ST10263992_PROG7312.Properties.Resources.cptImageCrop;
            var (totalWeight, routeEdges) = Database.Instance.GetOptimizedRoute();

            // Store data needed for drawing
            var allRequests = Database.Instance.GetAllServiceRequests().ToList();
            vertexMap = allRequests.Select((req, index) => new { req, index })
                                     .ToDictionary(x => x.index, x => x.req);

            var idToVertex = allRequests.Select((req, index) => new { req, index })
                                        .ToDictionary(x => x.req.Id, x => x.index);

            mstEdges = routeEdges.Select(edge => (idToVertex[edge.from.Id], idToVertex[edge.to.Id], edge.weight)).ToList();

            // If a request was selected before generating the map, find its node index
            if (_selectedRequest != null)
            {
                int nodeIndex = -1;
                foreach (var entry in vertexMap)
                {
                    if (entry.Value.Id == _selectedRequest.Id)
                    {
                        nodeIndex = entry.Key;
                        break;
                    }
                }
                _selectedNodeIndex = nodeIndex;
            }

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
                // Create specific font and brush for the distance text
                using (Font distanceFont = new Font("Arial", 10, FontStyle.Bold))
                using (Brush distanceBrush = new SolidBrush(Color.FromArgb(0,0,0)))
                {
                    foreach (var edge in mstEdges)
                    {
                        Point p1 = nodePositions[edge.u];
                        Point p2 = nodePositions[edge.v];
                        g.DrawLine(mstPen, p1, p2);

                        // Draw edge weight with "km"
                        string distanceText = $"{edge.w} km";
                        Point midPoint = new Point((p1.X + p2.X) / 2, (p1.Y + p2.Y) / 2);
                        g.DrawString(distanceText, distanceFont, distanceBrush, midPoint);
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

            ServiceRequest clickedRequest = null;
            int clickedNodeIndex = -1;

            for (int i = 0; i < nodePositions.Count; i++)
            {
                Point center = nodePositions[i];
                double distance = Math.Sqrt(Math.Pow(e.X - center.X, 2) + Math.Pow(e.Y - center.Y, 2));
                if (distance <= nodeRadius)
                {
                    if (vertexMap.TryGetValue(i, out clickedRequest))
                    {
                        clickedNodeIndex = i;
                        break; 
                    }
                }
            }

            if (clickedRequest != null)
            {
                HighlightRequest(clickedRequest);
            }
        }

        private void btnNextPriority_Click(object sender, EventArgs e)
        {
            var urgentRequest = Database.Instance.GetNextUrgentServiceRequest();

            if (urgentRequest != null)
            {
                // 1. Set the selection state and invalidate the graph.
                HighlightRequest(urgentRequest);

                // 2. Show the message box.
                MessageBox.Show($"Processing next urgent task:\nID: {urgentRequest.Id} - {urgentRequest.Title}", "Next Priority Task", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // 3. After the message box is closed, re-apply the table highlight,
                //    as it may have been cleared when the control lost focus.
                HighlightRequestInTableView(urgentRequest);

                // 4. Now, refresh the main table to remove the processed item.
                TableView();

                // 5. Finally, clear the selection from all views for the next operation.
                HighlightRequest(null);
            }
            else
            {
                MessageBox.Show("No active service requests in the priority queue.", "Queue Empty", MessageBoxButtons.OK, MessageBoxIcon.Information);
                HighlightRequest(null);
            }
        }


    }
}
