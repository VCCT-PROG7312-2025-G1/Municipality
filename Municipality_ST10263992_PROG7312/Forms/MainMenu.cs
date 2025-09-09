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
            pnlMainPage.BackColor = ColorTranslator.FromHtml("#" + ColourScheme.SecondaryColour);
            pnlMainMenuInner.BackColor = ColorTranslator.FromHtml("#" + ColourScheme.OtherColour);
            pnlMainMenuInner1.BackColor = ColorTranslator.FromHtml("#" + ColourScheme.OtherColour);
            pnlMainMenuInner2.BackColor = ColorTranslator.FromHtml("#" + ColourScheme.OtherColour);


            btnReportIssue.BackColor = ColorTranslator.FromHtml("#" + ColourScheme.ButtonColour);
            btnReportIssue.ForeColor = ColorTranslator.FromHtml("#" + ColourScheme.Text_Colour);
            btnReportIssue.FlatAppearance.BorderColor = ColorTranslator.FromHtml("#" + ColourScheme.ButtonClickColour);
            //btnReportIssue.Click += (s, e) => { btnReportIssue.BackColor = ColorTranslator.FromHtml("#" + ColourScheme.ButtonClickColour); };

            btnEvents.BackColor = ColorTranslator.FromHtml("#" + ColourScheme.ButtonColour);
            btnEvents.ForeColor = ColorTranslator.FromHtml("#" + ColourScheme.Text_Colour);
            btnEvents.FlatAppearance.BorderColor = ColorTranslator.FromHtml("#" + ColourScheme.ButtonClickColour);
            //btnEvents.Click += (s, e) => { btnEvents.BackColor = ColorTranslator.FromHtml("#" + ColourScheme.ButtonClickColour); };

            btnStatus.BackColor = ColorTranslator.FromHtml("#" + ColourScheme.ButtonColour);
            btnStatus.ForeColor = ColorTranslator.FromHtml("#" + ColourScheme.Text_Colour);
            btnStatus.FlatAppearance.BorderColor = ColorTranslator.FromHtml("#" + ColourScheme.ButtonClickColour);
            //btnStatus.Click += (s, e) => { btnStatus.BackColor = ColorTranslator.FromHtml("#" + ColourScheme.ButtonClickColour); };

            btnExit.BackColor = ColorTranslator.FromHtml("#" + ColourScheme.ErrorColour);
            btnExit.FlatAppearance.BorderColor = ColorTranslator.FromHtml("#" + ColourScheme.ButtonClickColour);


            panel1.BackColor = ColorTranslator.FromHtml("#" + ColourScheme.AccentColour);
            panel2.BackColor = ColorTranslator.FromHtml("#" + ColourScheme.AccentColour);
            panel3.BackColor = ColorTranslator.FromHtml("#" + ColourScheme.AccentColour);

            pnlHead1.BackColor = ColorTranslator.FromHtml("#" + ColourScheme.AccentColour);
            pnlHead2.BackColor = ColorTranslator.FromHtml("#" + ColourScheme.AccentColour);
            pnlHead3.BackColor = ColorTranslator.FromHtml("#" + ColourScheme.AccentColour);

            panel4.BackColor = ColorTranslator.FromHtml("#" + ColourScheme.PrimaryColour);

            
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

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void frmMainMenu_Load(object sender, EventArgs e)
        {
            //lblReportText.Text = Database.Instance.printRecentIssues();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void frmMainMenu_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void frmMainMenu_Shown(object sender, EventArgs e)
        {
            lblReportText.Text = Database.Instance.PrintRecentIssues();
        }
    }
}
