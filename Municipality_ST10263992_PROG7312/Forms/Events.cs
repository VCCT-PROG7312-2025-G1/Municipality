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
            pnlMainPage.BackColor = ColorTranslator.FromHtml("#" + ColourScheme.DarkGrey);
            pnlMainInside.BackColor = ColorTranslator.FromHtml("#" + ColourScheme.DarkerGrey);
            panel1.BackColor = ColorTranslator.FromHtml("#" + ColourScheme.Maroon);
            //pnlMainPageInner.BackColor = ColorTranslator.FromHtml("#" + ColourScheme.Maroon);
            pnlRecomend.BackColor = ColorTranslator.FromHtml("#" + ColourScheme.DarkRed);
            pnlCalender.BackColor = ColorTranslator.FromHtml("#" + ColourScheme.DarkRed);
            panel2.BackColor = ColorTranslator.FromHtml("#" + ColourScheme.DarkRed);
            panel3.BackColor = ColorTranslator.FromHtml("#" + ColourScheme.DarkRed);
            redRecomend.BackColor = ColorTranslator.FromHtml("#" + ColourScheme.DarkerGrey);

            redOut.BackColor = ColorTranslator.FromHtml("#" + ColourScheme.DarkerGrey);
            redOut.Text = GetEventLayout();
          
            btnSearch.BackColor = ColorTranslator.FromHtml("#" + ColourScheme.ButtonColour);
            btnSearch.ForeColor = ColorTranslator.FromHtml("#" + ColourScheme.Text_Colour);
            btnSearch.FlatAppearance.BorderColor = ColorTranslator.FromHtml("#" + ColourScheme.ButtonClickColour);

            cmbCategory.DataSource = Enum.GetValues(typeof(EventCategory));
            cmbCategory.SelectedIndex = 0;

            redOut.Text= Database.Instance.PrintEvents();

            btnReset.BackColor = ColorTranslator.FromHtml("#" + ColourScheme.ErrorColour);

            //lblSuggested.BackColor = ColorTranslator.FromHtml("#" + ColourScheme.DarkGrey);
            //lblSuggested.ForeColor = ColorTranslator.FromHtml("#" + ColourScheme.Tan);

            //lblUpcoming.BackColor = ColorTranslator.FromHtml("#" + ColourScheme.DarkGrey);
            //lblUpcoming.ForeColor = ColorTranslator.FromHtml("#" + ColourScheme.Tan);

            //add event enum to combo box
            
            
            //string imagePath = ""; fix image load

            // Add event handler for DateTimePicker
            dtpSearch.ValueChanged += DtpSearch_ValueChanged;

            // Add event handler for Calendar date selection
            calUpcoming.DateSelected += calUpcoming_DateSelected;
            DisplayUpcomingEvents();
            StyleCalendar();
        }
        private void Btn_MouseEnter(object sender, EventArgs e)
        {
            var btn = sender as Button;
            btn.ForeColor = System.Drawing.Color.FromArgb(0, 0, 0);
        }
        private void Btn_MouseLeave(object sender, EventArgs e)
        {
            var btn = sender as Button;
            btn.ForeColor = System.Drawing.Color.FromArgb(227, 226, 236);
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
            EventCategory category = (EventCategory)cmbCategory.SelectedItem;
       
            DateTime? searchDate = null;
            if (datePickerModified)
            {
                searchDate = dtpSearch.Value.Date;
            }

            var searchResults = Database.Instance.SearchEvents(userSearch, category, searchDate);

            // Build the display text
            StringBuilder displayText = new StringBuilder();
            displayText.Append(GetEventLayout());
            displayText.Append("You searched for: ");

            if (userSearch != "" && userSearch != "Search...")
            {
                displayText.Append(userSearch);
            }
            else
            {
                displayText.AppendLine("All Events");
            }

            if (cmbCategory.SelectedItem != null)
            {
                displayText.AppendLine("\nIn category: " + cmbCategory.SelectedItem.ToString());
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
                recommendationText.AppendLine("No recommendations available");
            }
            else
            {
                recommendationText.AppendLine("You might like:\n");
                var recCurrent = recommendations.First;
                while (recCurrent != null)
                {
                    var eventItem = recCurrent.Value;
                    recommendationText.AppendLine($"Title: {eventItem.Title}");
                    recommendationText.AppendLine($"Date: {eventItem.EventDate:dd/MM/yyyy}\n");
                    recCurrent = recCurrent.Next;
                }
            }

            redRecomend.Text = recommendationText.ToString();
            //MessageBox.Show(recommendationText.ToString(), "Recommendations", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            layout.AppendLine("===================================");
            layout.AppendLine("              UPCOMING EVENTS & ANNOUNCEMENTS");
            layout.AppendLine("===================================\n");
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
        private void DisplayUpcomingEvents()
        {
            // Get upcoming events for the next 90 days
            var upcomingEvents = Database.Instance.GetUpcomingEvents(90);
            var eventDates = new List<DateTime>();

            var current = upcomingEvents.First;
            while (current != null)
            {
                eventDates.Add(current.Value.EventDate.Date);
                current = current.Next;
            }

            calUpcoming.BoldedDates = eventDates.ToArray();
            calUpcoming.UpdateBoldedDates();
        }
        private void StyleCalendar()
        {
            calUpcoming.BackColor = ColorTranslator.FromHtml("#" + ColourScheme.DarkRed);
            calUpcoming.TitleBackColor = ColorTranslator.FromHtml("#" + ColourScheme.DarkerGrey);
            calUpcoming.TitleForeColor = ColorTranslator.FromHtml("#" + ColourScheme.Text_Colour);
            calUpcoming.TrailingForeColor = Color.Gray;
        }
        private void calUpcoming_DateSelected(object sender, DateRangeEventArgs e)
        {
            DateTime selectedDate = e.Start.Date;

            // Search for events on the selected date
            var eventsOnDate = Database.Instance.SearchEvents(null, EventCategory.None, selectedDate);

            StringBuilder displayText = new StringBuilder();
            displayText.AppendLine(GetEventLayout());
            displayText.AppendLine($"Events for {selectedDate:dd MMMM yyyy}:\n");

            if (eventsOnDate.First != null)
            {
                var current = eventsOnDate.First;
                while (current != null)
                {
                    var eventItem = current.Value;
                    displayText.AppendLine("---------------------------------------------------");
                    displayText.AppendLine($"Title: {eventItem.Title}");
                    displayText.AppendLine($"Category: {eventItem.Category}");
                    displayText.AppendLine($"Description: {eventItem.Description}\n");
                    current = current.Next;
                }
            }
            else
            {
                displayText.AppendLine("No events scheduled for this date.");
            }

            // Display the events for the selected date in the main text area
            redOut.Text = displayText.ToString();
        }
    }
}
