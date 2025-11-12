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
            pnlMainPage.BackColor = ColorTranslator.FromHtml("#" + ColourScheme.DarkGrey);
            pnlMainPageInner.BackColor = ColorTranslator.FromHtml("#" + ColourScheme.DarkerGrey);
            panel1.BackColor = ColorTranslator.FromHtml("#" + ColourScheme.Maroon);
            flowLayoutPanel1.BackColor = ColorTranslator.FromHtml("#" + ColourScheme.Maroon);
            btnSubmit.BackColor = ColorTranslator.FromHtml("#" + ColourScheme.ButtonColour);
            btnMedia.BackColor = ColorTranslator.FromHtml("#" + ColourScheme.ButtonColour);

            flowLayoutPanel2.BackColor = ColorTranslator.FromHtml("#" + ColourScheme.DarkRed);
            flowLayoutPanel3.BackColor = ColorTranslator.FromHtml("#" + ColourScheme.DarkRed);
            flowLayoutPanel4.BackColor = ColorTranslator.FromHtml("#" + ColourScheme.DarkRed);
            flowLayoutPanel5.BackColor = ColorTranslator.FromHtml("#" + ColourScheme.DarkRed);

            flowLayoutPanel1.AutoSize = false;
            pnlMainPageInner.Resize += (sender, e) =>
            {
                flowLayoutPanel1.Location = new Point(
                    (pnlMainPageInner.Width - flowLayoutPanel1.Width) / 2,
                    (pnlMainPageInner.Height - flowLayoutPanel1.Height) / 2);
            };


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

        private void frmReportIssues_Load(object sender, EventArgs e)
        {

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
    }
}
