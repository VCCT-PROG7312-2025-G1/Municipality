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
            cmbCategory.Items.AddRange(new string[] {"Community Service",
            "Public Meeting",
            "Maintenance",
            "Recreation",
            "Emergency",
            "Other" });
            //string imagePath = ""; fix image load
        }

        private void Events_Load(object sender, EventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string userSearch = edtSearch.Text;
            if (userSearch != "" && userSearch != "Search...")
            {
                userSearch = "For: " + userSearch;
            }
            else
            {
                userSearch = "For: All Events";
            }
            if (cmbCategory.SelectedItem != null)
            {
                userSearch += "\nIn category: " + cmbCategory.SelectedItem.ToString();
            }
            redOut.Text = GetEventLayout()+ "\nYou searched for: " + userSearch + "\n";
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
            layout.AppendLine("==========================================");
            layout.AppendLine("                        UPCOMING EVENTS & ANNOUNCEMENTS");
            layout.AppendLine("==========================================\n");
            return layout.ToString();
        }
    }
}
