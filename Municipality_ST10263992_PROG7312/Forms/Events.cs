using Municipality_ST10263992_PROG7312.Forms.Events;
using Municipality_ST10263992_PROG7312.Forms.ReportIssue;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Municipality_ST10263992_PROG7312.Forms
{
    public partial class frmEvent : Form
    {
        private bool datePickerModified = false;

        public frmEvent()
        {
            InitializeComponent();
            pnlMainPage.BackColor = ColorTranslator.FromHtml("#" + ColourScheme.DarkWhite);
            pnlMainPageInner.BackColor = ColorTranslator.FromHtml("#" + ColourScheme.DarkerGrey);
            redOut.BackColor = ColorTranslator.FromHtml("#" + ColourScheme.LighterPurple);
            redOut.Text = GetEventLayout();
            btnSearch.BackColor = ColorTranslator.FromHtml("#" + ColourScheme.ButtonColour);
            btnSearch.ForeColor = ColorTranslator.FromHtml("#" + ColourScheme.Text_Colour);
            redOut.Text= Database.Instance.PrintEvents();
            //add event enum to combo box
            cmbCategory.DataSource = Enum.GetValues(typeof(EventCategory));
            cmbCategory.SelectedIndex = 0;
            
            //string imagePath = ""; fix image load

            // Add event handler for DateTimePicker
            dtpSearch.ValueChanged += DtpSearch_ValueChanged;
        }

        private void Events_Load(object sender, EventArgs e)
        {

        }

        private void DtpSearch_ValueChanged(object sender, EventArgs e)
        {
            datePickerModified = true;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string userSearch = edtSearch.Text;
            if (userSearch == "Search...")
            {
                userSearch = "";
            }
            EventCategory category = (EventCategory)cmbCategory.SelectedIndex;
       
            DateTime? searchDate = null;
            if (datePickerModified)
            {
                searchDate = dtpSearch.Value.Date;
            }

            var searchResults = Database.Instance.SearchEvents(userSearch, category, searchDate);

            // Build the display text
            StringBuilder displayText = new StringBuilder();
            displayText.Append(GetEventLayout());
            displayText.AppendLine("You searched for: ");

            if (userSearch != "" && userSearch != "Search...")
            {
                displayText.AppendLine(userSearch);
            }
            else
            {
                displayText.AppendLine("All Events");
            }

            if (cmbCategory.SelectedItem != null)
            {
                displayText.AppendLine("In category: " + cmbCategory.SelectedItem.ToString());
            }

            if (datePickerModified)
            {
                displayText.AppendLine($"On date: {searchDate.Value:dd/MM/yyyy}");
            }

            // Format each search result
            var current = searchResults.First;
            while (current != null)
            {
                var eventItem = current.Value;
                displayText.AppendLine("\n---------------------------------------------------");
                displayText.AppendLine($"Title: {eventItem.Title}");
                displayText.AppendLine($"Category: {eventItem.Category}");
                displayText.AppendLine($"Description: {eventItem.Description}");
                displayText.AppendLine($"Event Date: {eventItem.EventDate:dd/MM/yyyy}");
                current = current.Next;
            }

            if (searchResults.First == null)
            {
                displayText.AppendLine("\nNo events found matching your search criteria.");
            }

            redOut.Text = displayText.ToString();
            // Get and format recommendations for the MessageBox
            var recommendations = Database.Instance.GetRecommendations();
            StringBuilder recommendationText = new StringBuilder();

            if (recommendations.First == null)
            {
                recommendationText.AppendLine("No recommendations available based on your search history.");
            }
            else
            {
                recommendationText.AppendLine("Based on your search history, you might like:\n");
                var recCurrent = recommendations.First;
                while (recCurrent != null)
                {
                    var eventItem = recCurrent.Value;
                    recommendationText.AppendLine($"Title: {eventItem.Title}");
                    recommendationText.AppendLine($"Date: {eventItem.EventDate:dd/MM/yyyy}");
                    recommendationText.AppendLine("--------------------");
                    recCurrent = recCurrent.Next;
                }
            }

            MessageBox.Show(recommendationText.ToString(), "Recommendations", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void edtSearch_Click(object sender, EventArgs e)
        {
            edtSearch.Text = "";
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            frmMainMenu mainMenuForm = new frmMainMenu();
            this.Hide();
            mainMenuForm.Show();
        }

        private string GetEventLayout()
        {
            StringBuilder layout = new StringBuilder();
            layout.AppendLine("========================================================");
            layout.AppendLine("                                         UPCOMING EVENTS & ANNOUNCEMENTS");
            layout.AppendLine("========================================================\n");
            return layout.ToString();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            edtSearch.Text = "Search...";
            redOut.Text = Database.Instance.PrintEvents();
            //add event enum to combo box
            cmbCategory.DataSource = Enum.GetValues(typeof(EventCategory));
            cmbCategory.SelectedIndex = 0;
            datePickerModified = false;
        }
    }
}
