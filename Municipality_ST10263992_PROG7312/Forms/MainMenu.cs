using Municipality_ST10263992_PROG7312.Forms;
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

namespace Municipality_ST10263992_PROG7312
{
    public partial class frmMainMenu : Form
    {
        public frmMainMenu()
        {
            InitializeComponent();
            pnlMainPage.BackColor = ColorTranslator.FromHtml("#" + ColourScheme.DarkWhite);
            pnlMainMenuInner.BackColor = ColorTranslator.FromHtml("#" + ColourScheme.DarkPurple);
            pnlMainMenuInner1.BackColor = ColorTranslator.FromHtml("#" + ColourScheme.DarkPurple);
            pnlMainMenuInner2.BackColor = ColorTranslator.FromHtml("#" + ColourScheme.DarkPurple);


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

            redReportText.BackColor = ColorTranslator.FromHtml("#" + ColourScheme.LighterPurple);

            panel1.BackColor = ColorTranslator.FromHtml("#" + ColourScheme.LighterPurple);
            panel2.BackColor = ColorTranslator.FromHtml("#" + ColourScheme.LighterPurple);
            panel3.BackColor = ColorTranslator.FromHtml("#" + ColourScheme.LighterPurple);

            pnlHead1.BackColor = ColorTranslator.FromHtml("#" + ColourScheme.DarkPurple);
            pnlHead2.BackColor = ColorTranslator.FromHtml("#" + ColourScheme.DarkPurple);
            pnlHead3.BackColor = ColorTranslator.FromHtml("#" + ColourScheme.DarkPurple);

            panel4.BackColor = ColorTranslator.FromHtml("#" + ColourScheme.PrimaryColour);

            panel5.BackColor = ColorTranslator.FromHtml("#" + ColourScheme.DarkerGrey);

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
        }
    }
}
