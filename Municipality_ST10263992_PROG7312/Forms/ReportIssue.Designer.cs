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
            this.pnlMainMenuInner = new System.Windows.Forms.Panel();
            this.btnExit = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblEngagment = new System.Windows.Forms.Label();
            this.lblMediaAttach = new System.Windows.Forms.Label();
            this.btnMedia = new System.Windows.Forms.Button();
            this.lblDescription = new System.Windows.Forms.Label();
            this.cmbCategory = new System.Windows.Forms.ComboBox();
            this.lblLocation = new System.Windows.Forms.Label();
            this.lblCategorySelect = new System.Windows.Forms.Label();
            this.txtLocation = new System.Windows.Forms.TextBox();
            this.redout = new System.Windows.Forms.RichTextBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.button1 = new System.Windows.Forms.Button();
            this.pnlMainPage.SuspendLayout();
            this.pnlMainMenuInner.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlMainPage
            // 
            this.pnlMainPage.Controls.Add(this.pnlMainMenuInner);
            this.pnlMainPage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMainPage.Location = new System.Drawing.Point(0, 0);
            this.pnlMainPage.Name = "pnlMainPage";
            this.pnlMainPage.Padding = new System.Windows.Forms.Padding(24);
            this.pnlMainPage.Size = new System.Drawing.Size(1022, 814);
            this.pnlMainPage.TabIndex = 1;
            // 
            // pnlMainMenuInner
            // 
            this.pnlMainMenuInner.AutoSize = true;
            this.pnlMainMenuInner.Controls.Add(this.btnExit);
            this.pnlMainMenuInner.Controls.Add(this.panel2);
            this.pnlMainMenuInner.Controls.Add(this.panel1);
            this.pnlMainMenuInner.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMainMenuInner.Location = new System.Drawing.Point(24, 24);
            this.pnlMainMenuInner.Margin = new System.Windows.Forms.Padding(0);
            this.pnlMainMenuInner.Name = "pnlMainMenuInner";
            this.pnlMainMenuInner.Size = new System.Drawing.Size(974, 766);
            this.pnlMainMenuInner.TabIndex = 1;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(0, 0);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 9;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(32, 30);
            this.panel2.Margin = new System.Windows.Forms.Padding(0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(542, 459);
            this.panel2.TabIndex = 14;
            // 
            // panel1
            // 
            this.panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.lblEngagment);
            this.panel1.Controls.Add(this.lblMediaAttach);
            this.panel1.Controls.Add(this.btnMedia);
            this.panel1.Controls.Add(this.lblDescription);
            this.panel1.Controls.Add(this.cmbCategory);
            this.panel1.Controls.Add(this.lblLocation);
            this.panel1.Controls.Add(this.lblCategorySelect);
            this.panel1.Controls.Add(this.txtLocation);
            this.panel1.Controls.Add(this.redout);
            this.panel1.Controls.Add(this.btnSubmit);
            this.panel1.Location = new System.Drawing.Point(602, 77);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(331, 532);
            this.panel1.TabIndex = 13;
            // 
            // lblEngagment
            // 
            this.lblEngagment.AutoSize = true;
            this.lblEngagment.Location = new System.Drawing.Point(43, 429);
            this.lblEngagment.Name = "lblEngagment";
            this.lblEngagment.Size = new System.Drawing.Size(25, 13);
            this.lblEngagment.TabIndex = 13;
            this.lblEngagment.Text = "Yay";
            // 
            // lblMediaAttach
            // 
            this.lblMediaAttach.AutoSize = true;
            this.lblMediaAttach.Location = new System.Drawing.Point(43, 328);
            this.lblMediaAttach.Name = "lblMediaAttach";
            this.lblMediaAttach.Size = new System.Drawing.Size(70, 13);
            this.lblMediaAttach.TabIndex = 10;
            this.lblMediaAttach.Text = "Attach Media";
            // 
            // btnMedia
            // 
            this.btnMedia.Location = new System.Drawing.Point(148, 323);
            this.btnMedia.Name = "btnMedia";
            this.btnMedia.Size = new System.Drawing.Size(75, 23);
            this.btnMedia.TabIndex = 2;
            this.btnMedia.Text = "Upload";
            this.btnMedia.UseVisualStyleBackColor = true;
            this.btnMedia.Click += new System.EventHandler(this.btnMedia_Click);
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(43, 204);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(60, 13);
            this.lblDescription.TabIndex = 8;
            this.lblDescription.Text = "Description";
            // 
            // cmbCategory
            // 
            this.cmbCategory.FormattingEnabled = true;
            this.cmbCategory.Location = new System.Drawing.Point(148, 142);
            this.cmbCategory.Name = "cmbCategory";
            this.cmbCategory.Size = new System.Drawing.Size(121, 21);
            this.cmbCategory.TabIndex = 6;
            // 
            // lblLocation
            // 
            this.lblLocation.AutoSize = true;
            this.lblLocation.Location = new System.Drawing.Point(43, 89);
            this.lblLocation.Name = "lblLocation";
            this.lblLocation.Size = new System.Drawing.Size(48, 13);
            this.lblLocation.TabIndex = 3;
            this.lblLocation.Text = "Location";
            // 
            // lblCategorySelect
            // 
            this.lblCategorySelect.AutoSize = true;
            this.lblCategorySelect.Location = new System.Drawing.Point(43, 142);
            this.lblCategorySelect.Name = "lblCategorySelect";
            this.lblCategorySelect.Size = new System.Drawing.Size(96, 13);
            this.lblCategorySelect.TabIndex = 5;
            this.lblCategorySelect.Text = "Category Selection";
            // 
            // txtLocation
            // 
            this.txtLocation.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtLocation.Location = new System.Drawing.Point(148, 89);
            this.txtLocation.Name = "txtLocation";
            this.txtLocation.Size = new System.Drawing.Size(121, 13);
            this.txtLocation.TabIndex = 2;
            // 
            // redout
            // 
            this.redout.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.redout.Location = new System.Drawing.Point(148, 204);
            this.redout.Name = "redout";
            this.redout.Size = new System.Drawing.Size(121, 96);
            this.redout.TabIndex = 7;
            this.redout.Text = "";
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(116, 374);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(75, 23);
            this.btnSubmit.TabIndex = 12;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog1";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(116, 468);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 14;
            this.button1.Text = "Submit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmReportIssues
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1022, 814);
            this.Controls.Add(this.pnlMainPage);
            this.Name = "frmReportIssues";
            this.Text = "Report Issues";
            this.Deactivate += new System.EventHandler(this.frmReportIssues_Deactivate);
            this.pnlMainPage.ResumeLayout(false);
            this.pnlMainPage.PerformLayout();
            this.pnlMainMenuInner.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlMainPage;
        private System.Windows.Forms.Panel pnlMainMenuInner;
        private System.Windows.Forms.Label lblLocation;
        private System.Windows.Forms.TextBox txtLocation;
        private System.Windows.Forms.Label lblCategorySelect;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.RichTextBox redout;
        private System.Windows.Forms.ComboBox cmbCategory;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.Button btnMedia;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Label lblMediaAttach;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblEngagment;
        private System.Windows.Forms.Button button1;
    }
}