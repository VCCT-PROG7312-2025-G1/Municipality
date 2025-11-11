using Municipality_ST10263992_PROG7312.Forms;
using Municipality_ST10263992_PROG7312.Forms.ReportIssue;
using Municipality_ST10263992_PROG7312.Forms.Events;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Municipality_ST10263992_PROG7312
{
    public partial class frmMainMenu : Form
    {
        public frmMainMenu()
        {
            InitializeComponent();
            pnlMainPage.BackColor = ColorTranslator.FromHtml("#" + ColourScheme.DarkerGrey);
            tableLayoutPanel1.BackColor = ColorTranslator.FromHtml("#" + ColourScheme.DarkerGrey);
            pnlMainMenuInner.BackColor = ColorTranslator.FromHtml("#" + ColourScheme.Maroon);
            pnlMainMenuInner1.BackColor = ColorTranslator.FromHtml("#" + ColourScheme.Maroon);
            pnlMainMenuInner2.BackColor = ColorTranslator.FromHtml("#" + ColourScheme.Maroon);


            btnReportIssue.BackColor = ColorTranslator.FromHtml("#" + ColourScheme.ButtonColour);
            btnReportIssue.ForeColor = ColorTranslator.FromHtml("#" + ColourScheme.Text_Colour);
            btnReportIssue.FlatAppearance.BorderColor = ColorTranslator.FromHtml("#" + ColourScheme.ButtonClickColour);

            btnEvents.BackColor = ColorTranslator.FromHtml("#" + ColourScheme.ButtonColour);
            btnEvents.ForeColor = ColorTranslator.FromHtml("#" + ColourScheme.Text_Colour);
            btnEvents.FlatAppearance.BorderColor = ColorTranslator.FromHtml("#" + ColourScheme.ButtonClickColour);

            btnStatus.BackColor = ColorTranslator.FromHtml("#" + ColourScheme.ButtonColour);
            btnStatus.ForeColor = ColorTranslator.FromHtml("#" + ColourScheme.Text_Colour);
            btnStatus.FlatAppearance.BorderColor = ColorTranslator.FromHtml("#" + ColourScheme.ButtonClickColour);


            btnExit.BackColor = ColorTranslator.FromHtml("#" + ColourScheme.ErrorColour);
            btnExit.FlatAppearance.BorderColor = ColorTranslator.FromHtml("#" + ColourScheme.ButtonClickColour);

            redReportText.BackColor = ColorTranslator.FromHtml("#" + ColourScheme.DarkRed);
            redOutEvents.BackColor = ColorTranslator.FromHtml("#" + ColourScheme.DarkRed);
            redServices.BackColor = ColorTranslator.FromHtml("#" + ColourScheme.DarkRed);

            panel1.BackColor = ColorTranslator.FromHtml("#" + ColourScheme.DarkRed);
            panel2.BackColor = ColorTranslator.FromHtml("#" + ColourScheme.DarkRed);
            panel3.BackColor = ColorTranslator.FromHtml("#" + ColourScheme.DarkRed);

            pnlHead1.BackColor = ColorTranslator.FromHtml("#" + ColourScheme.Maroon);
            pnlHead2.BackColor = ColorTranslator.FromHtml("#" + ColourScheme.Maroon);
            pnlHead3.BackColor = ColorTranslator.FromHtml("#" + ColourScheme.Maroon);

            //panel4.BackColor = ColorTranslator.FromHtml("#" + ColourScheme.OffWhite);

            panel5.BackColor = ColorTranslator.FromHtml("#" + ColourScheme.DarkerGrey);

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

        private void btnReportIssue_Click(object sender, EventArgs e)
        {
            frmReportIssues reportIssueForm = new frmReportIssues();
            this.Hide();
            reportIssueForm.Show();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void frmMainMenu_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void frmMainMenu_Shown(object sender, EventArgs e)
        {
            redReportText.Text = Database.Instance.PrintRecentIssues();
            redOutEvents.Text = Database.Instance.PrintUpcomingEvents(7);
            redServices.Text = Database.Instance.PrintServiceRequestSummary();
        }

        private void btnStatus_Click(object sender, EventArgs e)
        {
            frmService serviceForm = new frmService();
            this.Hide();
            serviceForm.Show();
        }

        private void btnEvents_Click(object sender, EventArgs e)
        {
            Forms.frmEvent eventsForm = new Forms.frmEvent();
            this.Hide();
            eventsForm.Show();
        }

        private void frmMainMenu_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
