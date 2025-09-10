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
    public partial class frmReportIssues : Form
    {
        private string attachmentPath = string.Empty;
        public frmReportIssues()
        {
            InitializeComponent();
            pnlMainPage.BackColor = ColorTranslator.FromHtml("#" + ColourScheme.DarkWhite);
            pnlMainPageInner.BackColor = ColorTranslator.FromHtml("#" + ColourScheme.DarkerGrey);
            flowLayoutPanel1.BackColor = ColorTranslator.FromHtml("#" + ColourScheme.DarkPurple);
            btnSubmit.BackColor = ColorTranslator.FromHtml("#" + ColourScheme.ButtonColour);
            btnMedia.BackColor = ColorTranslator.FromHtml("#" + ColourScheme.ButtonColour);

            Location.BackColor = ColorTranslator.FromHtml("#" + ColourScheme.LighterPurple);
            Categories.BackColor = ColorTranslator.FromHtml("#" + ColourScheme.LighterPurple);
            Description.BackColor = ColorTranslator.FromHtml("#" + ColourScheme.LighterPurple);
            Media.BackColor = ColorTranslator.FromHtml("#" + ColourScheme.LighterPurple);

            flowLayoutPanel1.AutoSize = false;
            flowLayoutPanel1.Location = new Point { X = pnlMainPageInner.Size.Width / 8, Y = pnlMainPageInner.Size.Height / 8 };


            cmbCategory.Items.AddRange(new string[] { "Pothole", "Burst Pipe", "Power Outage", "Street Light Fault", "Garbage Collection", "Other" });
            cmbCategory.SelectedIndex = 0;
        }


        private void btnMedia_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    attachmentPath = openFileDialog.FileName;
                    lblMediaAttach.Text = "Attachment: " + System.IO.Path.GetFileName(attachmentPath);
                }
            }
        }


        private void btnExit_Click(object sender, EventArgs e)
        {
            frmMainMenu mainMenuForm = new frmMainMenu();
            this.Hide();
            mainMenuForm.Show();
        }


        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtLocation.Text) ||
               string.IsNullOrWhiteSpace(cmbCategory.Text) ||
               string.IsNullOrWhiteSpace(redout.Text))
            {
                MessageBox.Show("Please fill in all fields.", "Error");
                return;
            }

            Issue newIssue = new Issue
            {
                Location = txtLocation.Text,
                Category = cmbCategory.Text,
                Description = redout.Text,
                AttachmentPath = attachmentPath,
                ReportedAt = DateTime.Now
            };
            Database.Instance.AddIssue(newIssue);
            MessageBox.Show("Issue reported successfully!", "Success");
            this.Hide();
            frmMainMenu mainMenuForm = new frmMainMenu();
            mainMenuForm.Show();
        }
    }
}
