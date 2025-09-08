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

            cmbCategory.Items.AddRange(new string[] { "Pothole", "Burst Pipe", "Power Outage", "Street Light Fault", "Garbage Collection", "Other" });
        }


        private void btnMedia_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog()) 
            {
                if(openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    attachmentPath = openFileDialog.FileName;
                    lblMediaAttach.Text = "Attachment: " + System.IO.Path.GetFileName(attachmentPath);
                }
            }
        }

        private void frmReportIssues_Deactivate(object sender, EventArgs e)
        {
            //Application.Exit();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
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

            // insert db/store logic here
                Issue newIssue = new Issue
                {
                    Location = txtLocation.Text,
                    Category = cmbCategory.Text,
                    Description = redout.Text,
                    AttachmentPath = attachmentPath,
                    ReportedAt = DateTime.Now
                };
            Database.Instance.AddIssue(newIssue);
            //

            MessageBox.Show("Issue submitted successfully.", "Success");

            txtLocation.Clear();
            cmbCategory.SelectedIndex = -1;
            redout.Clear();
            lblMediaAttach.Text = "No file attached";
            attachmentPath = string.Empty;

          MessageBox.Show(Database.Instance.ToString());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            

        }
    }
}
