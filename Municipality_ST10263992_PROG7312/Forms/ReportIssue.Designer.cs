namespace Municipality_ST10263992_PROG7312.Forms
{
    partial class frmReportIssues
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnlMainPage = new System.Windows.Forms.Panel();
            this.pnlMainPageInner = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.Location = new System.Windows.Forms.FlowLayoutPanel();
            this.lblLocation = new System.Windows.Forms.Label();
            this.txtLocation = new System.Windows.Forms.TextBox();
            this.Categories = new System.Windows.Forms.FlowLayoutPanel();
            this.lblCategorySelect = new System.Windows.Forms.Label();
            this.cmbCategory = new System.Windows.Forms.ComboBox();
            this.Description = new System.Windows.Forms.FlowLayoutPanel();
            this.lblDescription = new System.Windows.Forms.Label();
            this.redout = new System.Windows.Forms.RichTextBox();
            this.Media = new System.Windows.Forms.FlowLayoutPanel();
            this.lblMediaAttach = new System.Windows.Forms.Label();
            this.btnMedia = new System.Windows.Forms.Button();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.pnlMainPage.SuspendLayout();
            this.pnlMainPageInner.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.Location.SuspendLayout();
            this.Categories.SuspendLayout();
            this.Description.SuspendLayout();
            this.Media.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlMainPage
            // 
            this.pnlMainPage.Controls.Add(this.pnlMainPageInner);
            this.pnlMainPage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMainPage.Location = new System.Drawing.Point(0, 0);
            this.pnlMainPage.Margin = new System.Windows.Forms.Padding(0);
            this.pnlMainPage.Name = "pnlMainPage";
            this.pnlMainPage.Padding = new System.Windows.Forms.Padding(15);
            this.pnlMainPage.Size = new System.Drawing.Size(1022, 814);
            this.pnlMainPage.TabIndex = 1;
            // 
            // pnlMainPageInner
            // 
            this.pnlMainPageInner.AutoSize = true;
            this.pnlMainPageInner.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.pnlMainPageInner.Controls.Add(this.flowLayoutPanel1);
            this.pnlMainPageInner.Controls.Add(this.btnExit);
            this.pnlMainPageInner.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMainPageInner.Location = new System.Drawing.Point(15, 15);
            this.pnlMainPageInner.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.pnlMainPageInner.Name = "pnlMainPageInner";
            this.pnlMainPageInner.Size = new System.Drawing.Size(992, 784);
            this.pnlMainPageInner.TabIndex = 16;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel1.AutoSize = true;
            this.flowLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanel1.Controls.Add(this.Location);
            this.flowLayoutPanel1.Controls.Add(this.Categories);
            this.flowLayoutPanel1.Controls.Add(this.Description);
            this.flowLayoutPanel1.Controls.Add(this.Media);
            this.flowLayoutPanel1.Controls.Add(this.btnSubmit);
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Font = new System.Drawing.Font("Tahoma", 13F, System.Drawing.FontStyle.Bold);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(140, 15);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Padding = new System.Windows.Forms.Padding(40, 35, 40, 35);
            this.flowLayoutPanel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.flowLayoutPanel1.Size = new System.Drawing.Size(692, 693);
            this.flowLayoutPanel1.TabIndex = 15;
            this.flowLayoutPanel1.WrapContents = false;
            // 
            // Location
            // 
            this.Location.AutoSize = true;
            this.Location.BackColor = System.Drawing.Color.White;
            this.Location.Controls.Add(this.lblLocation);
            this.Location.Controls.Add(this.txtLocation);
            this.Location.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Location.Location = new System.Drawing.Point(46, 40);
            this.Location.Margin = new System.Windows.Forms.Padding(6, 5, 6, 30);
            this.Location.MinimumSize = new System.Drawing.Size(600, 0);
            this.Location.Name = "Location";
            this.Location.Padding = new System.Windows.Forms.Padding(12);
            this.Location.Size = new System.Drawing.Size(600, 52);
            this.Location.TabIndex = 24;
            // 
            // lblLocation
            // 
            this.lblLocation.AutoSize = true;
            this.lblLocation.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblLocation.Font = new System.Drawing.Font("Tahoma", 13F, System.Drawing.FontStyle.Bold);
            this.lblLocation.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(226)))), ((int)(((byte)(236)))));
            this.lblLocation.Location = new System.Drawing.Point(18, 12);
            this.lblLocation.Margin = new System.Windows.Forms.Padding(6, 0, 100, 0);
            this.lblLocation.Name = "lblLocation";
            this.lblLocation.Size = new System.Drawing.Size(87, 28);
            this.lblLocation.TabIndex = 16;
            this.lblLocation.Text = "Location";
            this.lblLocation.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtLocation
            // 
            this.txtLocation.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtLocation.Font = new System.Drawing.Font("Tahoma", 11F);
            this.txtLocation.Location = new System.Drawing.Point(315, 17);
            this.txtLocation.Margin = new System.Windows.Forms.Padding(110, 5, 6, 5);
            this.txtLocation.Name = "txtLocation";
            this.txtLocation.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtLocation.Size = new System.Drawing.Size(242, 18);
            this.txtLocation.TabIndex = 15;
            // 
            // Categories
            // 
            this.Categories.AutoSize = true;
            this.Categories.BackColor = System.Drawing.Color.White;
            this.Categories.Controls.Add(this.lblCategorySelect);
            this.Categories.Controls.Add(this.cmbCategory);
            this.Categories.Location = new System.Drawing.Point(46, 127);
            this.Categories.Margin = new System.Windows.Forms.Padding(6, 5, 6, 30);
            this.Categories.MinimumSize = new System.Drawing.Size(600, 0);
            this.Categories.Name = "Categories";
            this.Categories.Padding = new System.Windows.Forms.Padding(12);
            this.Categories.Size = new System.Drawing.Size(600, 60);
            this.Categories.TabIndex = 23;
            // 
            // lblCategorySelect
            // 
            this.lblCategorySelect.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblCategorySelect.Font = new System.Drawing.Font("Tahoma", 13F, System.Drawing.FontStyle.Bold);
            this.lblCategorySelect.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(226)))), ((int)(((byte)(236)))));
            this.lblCategorySelect.Location = new System.Drawing.Point(18, 12);
            this.lblCategorySelect.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblCategorySelect.Name = "lblCategorySelect";
            this.lblCategorySelect.Size = new System.Drawing.Size(192, 36);
            this.lblCategorySelect.TabIndex = 17;
            this.lblCategorySelect.Text = "Category Selection";
            this.lblCategorySelect.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cmbCategory
            // 
            this.cmbCategory.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCategory.FormattingEnabled = true;
            this.cmbCategory.Location = new System.Drawing.Point(316, 17);
            this.cmbCategory.Margin = new System.Windows.Forms.Padding(100, 5, 6, 5);
            this.cmbCategory.Name = "cmbCategory";
            this.cmbCategory.Size = new System.Drawing.Size(238, 26);
            this.cmbCategory.TabIndex = 18;
            // 
            // Description
            // 
            this.Description.AutoSize = true;
            this.Description.BackColor = System.Drawing.Color.White;
            this.Description.Controls.Add(this.lblDescription);
            this.Description.Controls.Add(this.redout);
            this.Description.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Description.Location = new System.Drawing.Point(46, 222);
            this.Description.Margin = new System.Windows.Forms.Padding(6, 5, 6, 30);
            this.Description.MinimumSize = new System.Drawing.Size(600, 0);
            this.Description.Name = "Description";
            this.Description.Padding = new System.Windows.Forms.Padding(12);
            this.Description.Size = new System.Drawing.Size(600, 211);
            this.Description.TabIndex = 25;
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblDescription.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Bold);
            this.lblDescription.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(226)))), ((int)(((byte)(236)))));
            this.lblDescription.Location = new System.Drawing.Point(18, 12);
            this.lblDescription.Margin = new System.Windows.Forms.Padding(6, 0, 80, 0);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(119, 187);
            this.lblDescription.TabIndex = 20;
            this.lblDescription.Text = "Description";
            this.lblDescription.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // redout
            // 
            this.redout.BackColor = System.Drawing.SystemColors.Window;
            this.redout.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.redout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.redout.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.redout.Location = new System.Drawing.Point(317, 17);
            this.redout.Margin = new System.Windows.Forms.Padding(100, 5, 6, 5);
            this.redout.MinimumSize = new System.Drawing.Size(0, 177);
            this.redout.Name = "redout";
            this.redout.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.redout.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedVertical;
            this.redout.Size = new System.Drawing.Size(242, 177);
            this.redout.TabIndex = 19;
            this.redout.Text = "";
            // 
            // Media
            // 
            this.Media.AutoSize = true;
            this.Media.BackColor = System.Drawing.Color.White;
            this.Media.Controls.Add(this.lblMediaAttach);
            this.Media.Controls.Add(this.btnMedia);
            this.Media.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Media.Location = new System.Drawing.Point(46, 468);
            this.Media.Margin = new System.Windows.Forms.Padding(6, 5, 6, 30);
            this.Media.MinimumSize = new System.Drawing.Size(600, 0);
            this.Media.Name = "Media";
            this.Media.Padding = new System.Windows.Forms.Padding(12);
            this.Media.Size = new System.Drawing.Size(600, 92);
            this.Media.TabIndex = 26;
            // 
            // lblMediaAttach
            // 
            this.lblMediaAttach.AutoSize = true;
            this.lblMediaAttach.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblMediaAttach.Font = new System.Drawing.Font("Tahoma", 13F, System.Drawing.FontStyle.Bold);
            this.lblMediaAttach.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(226)))), ((int)(((byte)(236)))));
            this.lblMediaAttach.Location = new System.Drawing.Point(18, 12);
            this.lblMediaAttach.Margin = new System.Windows.Forms.Padding(6, 0, 100, 0);
            this.lblMediaAttach.Name = "lblMediaAttach";
            this.lblMediaAttach.Size = new System.Drawing.Size(128, 68);
            this.lblMediaAttach.TabIndex = 21;
            this.lblMediaAttach.Text = "Attach Media";
            this.lblMediaAttach.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnMedia
            // 
            this.btnMedia.AutoSize = true;
            this.btnMedia.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMedia.Font = new System.Drawing.Font("Tahoma", 13F, System.Drawing.FontStyle.Bold);
            this.btnMedia.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(226)))), ((int)(((byte)(236)))));
            this.btnMedia.Location = new System.Drawing.Point(346, 17);
            this.btnMedia.Margin = new System.Windows.Forms.Padding(100, 5, 6, 5);
            this.btnMedia.Name = "btnMedia";
            this.btnMedia.Size = new System.Drawing.Size(174, 58);
            this.btnMedia.TabIndex = 14;
            this.btnMedia.Text = "Upload";
            this.btnMedia.UseVisualStyleBackColor = true;
            this.btnMedia.Click += new System.EventHandler(this.btnMedia_Click);
            // 
            // btnSubmit
            // 
            this.btnSubmit.AutoSize = true;
            this.btnSubmit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSubmit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(226)))), ((int)(((byte)(236)))));
            this.btnSubmit.Location = new System.Drawing.Point(240, 595);
            this.btnSubmit.Margin = new System.Windows.Forms.Padding(200, 5, 175, 5);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(176, 58);
            this.btnSubmit.TabIndex = 22;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Black;
            this.btnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(226)))), ((int)(((byte)(236)))));
            this.btnExit.Location = new System.Drawing.Point(15, 15);
            this.btnExit.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(150, 41);
            this.btnExit.TabIndex = 9;
            this.btnExit.Text = "Back";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog1";
            // 
            // frmReportIssues
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1022, 814);
            this.Controls.Add(this.pnlMainPage);
            this.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Bold);
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "frmReportIssues";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Report Issues";
            this.pnlMainPage.ResumeLayout(false);
            this.pnlMainPage.PerformLayout();
            this.pnlMainPageInner.ResumeLayout(false);
            this.pnlMainPageInner.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.Location.ResumeLayout(false);
            this.Location.PerformLayout();
            this.Categories.ResumeLayout(false);
            this.Description.ResumeLayout(false);
            this.Description.PerformLayout();
            this.Media.ResumeLayout(false);
            this.Media.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlMainPage;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label lblMediaAttach;
        private System.Windows.Forms.Button btnMedia;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.ComboBox cmbCategory;
        private System.Windows.Forms.Label lblLocation;
        private System.Windows.Forms.Label lblCategorySelect;
        private System.Windows.Forms.TextBox txtLocation;
        private System.Windows.Forms.RichTextBox redout;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.FlowLayoutPanel Categories;
        private System.Windows.Forms.FlowLayoutPanel Location;
        private System.Windows.Forms.FlowLayoutPanel Media;
        private System.Windows.Forms.FlowLayoutPanel Description;
        private System.Windows.Forms.Panel pnlMainPageInner;
    }
}