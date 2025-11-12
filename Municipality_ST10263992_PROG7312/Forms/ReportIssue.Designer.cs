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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmReportIssues));
            this.pnlMainPage = new System.Windows.Forms.Panel();
            this.pnlMainPageInner = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.txtLocation = new System.Windows.Forms.TextBox();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbCategory = new System.Windows.Forms.ComboBox();
            this.flowLayoutPanel4 = new System.Windows.Forms.FlowLayoutPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.redout = new System.Windows.Forms.RichTextBox();
            this.flowLayoutPanel5 = new System.Windows.Forms.FlowLayoutPanel();
            this.lblMediaAttach = new System.Windows.Forms.Label();
            this.btnMedia = new System.Windows.Forms.Button();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.pnlMainPage.SuspendLayout();
            this.pnlMainPageInner.SuspendLayout();
            this.panel1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.flowLayoutPanel3.SuspendLayout();
            this.flowLayoutPanel4.SuspendLayout();
            this.flowLayoutPanel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlMainPage
            // 
            this.pnlMainPage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(137)))), ((int)(((byte)(123)))));
            this.pnlMainPage.Controls.Add(this.pnlMainPageInner);
            this.pnlMainPage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMainPage.Location = new System.Drawing.Point(0, 0);
            this.pnlMainPage.Margin = new System.Windows.Forms.Padding(0);
            this.pnlMainPage.Name = "pnlMainPage";
            this.pnlMainPage.Padding = new System.Windows.Forms.Padding(20);
            this.pnlMainPage.Size = new System.Drawing.Size(1022, 814);
            this.pnlMainPage.TabIndex = 1;
            // 
            // pnlMainPageInner
            // 
            this.pnlMainPageInner.AutoSize = true;
            this.pnlMainPageInner.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.pnlMainPageInner.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(137)))), ((int)(((byte)(123)))));
            this.pnlMainPageInner.Controls.Add(this.panel1);
            this.pnlMainPageInner.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMainPageInner.Location = new System.Drawing.Point(20, 20);
            this.pnlMainPageInner.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.pnlMainPageInner.Name = "pnlMainPageInner";
            this.pnlMainPageInner.Size = new System.Drawing.Size(982, 774);
            this.pnlMainPageInner.TabIndex = 16;
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(137)))), ((int)(((byte)(123)))));
            this.panel1.Controls.Add(this.flowLayoutPanel1);
            this.panel1.Controls.Add(this.btnExit);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(982, 774);
            this.panel1.TabIndex = 17;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel1.AutoSize = true;
            this.flowLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(44)))), ((int)(((byte)(55)))));
            this.flowLayoutPanel1.Controls.Add(this.flowLayoutPanel2);
            this.flowLayoutPanel1.Controls.Add(this.flowLayoutPanel3);
            this.flowLayoutPanel1.Controls.Add(this.flowLayoutPanel4);
            this.flowLayoutPanel1.Controls.Add(this.flowLayoutPanel5);
            this.flowLayoutPanel1.Controls.Add(this.btnSubmit);
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Font = new System.Drawing.Font("Tahoma", 13F, System.Drawing.FontStyle.Bold);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(137, 15);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Padding = new System.Windows.Forms.Padding(50, 40, 50, 40);
            this.flowLayoutPanel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.flowLayoutPanel1.Size = new System.Drawing.Size(712, 713);
            this.flowLayoutPanel1.TabIndex = 15;
            this.flowLayoutPanel1.WrapContents = false;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.AutoSize = true;
            this.flowLayoutPanel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.flowLayoutPanel2.Controls.Add(this.label1);
            this.flowLayoutPanel2.Controls.Add(this.txtLocation);
            this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(56, 45);
            this.flowLayoutPanel2.Margin = new System.Windows.Forms.Padding(6, 5, 6, 25);
            this.flowLayoutPanel2.MinimumSize = new System.Drawing.Size(600, 0);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Padding = new System.Windows.Forms.Padding(15);
            this.flowLayoutPanel2.Size = new System.Drawing.Size(600, 60);
            this.flowLayoutPanel2.TabIndex = 24;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(226)))), ((int)(((byte)(236)))));
            this.label1.Location = new System.Drawing.Point(21, 15);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 100, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 30);
            this.label1.TabIndex = 16;
            this.label1.Text = "Location";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtLocation
            // 
            this.txtLocation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.txtLocation.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtLocation.Font = new System.Drawing.Font("Tahoma", 12F);
            this.txtLocation.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(226)))), ((int)(((byte)(236)))));
            this.txtLocation.Location = new System.Drawing.Point(323, 20);
            this.txtLocation.Margin = new System.Windows.Forms.Padding(110, 5, 6, 5);
            this.txtLocation.Name = "txtLocation";
            this.txtLocation.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtLocation.Size = new System.Drawing.Size(242, 20);
            this.txtLocation.TabIndex = 15;
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.AutoSize = true;
            this.flowLayoutPanel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.flowLayoutPanel3.Controls.Add(this.label2);
            this.flowLayoutPanel3.Controls.Add(this.cmbCategory);
            this.flowLayoutPanel3.Location = new System.Drawing.Point(56, 135);
            this.flowLayoutPanel3.Margin = new System.Windows.Forms.Padding(6, 5, 6, 25);
            this.flowLayoutPanel3.MinimumSize = new System.Drawing.Size(600, 0);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Padding = new System.Windows.Forms.Padding(15);
            this.flowLayoutPanel3.Size = new System.Drawing.Size(600, 67);
            this.flowLayoutPanel3.TabIndex = 23;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(226)))), ((int)(((byte)(236)))));
            this.label2.Location = new System.Drawing.Point(21, 15);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(207, 37);
            this.label2.TabIndex = 17;
            this.label2.Text = "Category";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmbCategory
            // 
            this.cmbCategory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.cmbCategory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbCategory.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCategory.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(226)))), ((int)(((byte)(236)))));
            this.cmbCategory.FormattingEnabled = true;
            this.cmbCategory.Location = new System.Drawing.Point(334, 20);
            this.cmbCategory.Margin = new System.Windows.Forms.Padding(100, 5, 6, 5);
            this.cmbCategory.Name = "cmbCategory";
            this.cmbCategory.Size = new System.Drawing.Size(238, 27);
            this.cmbCategory.TabIndex = 18;
            // 
            // flowLayoutPanel4
            // 
            this.flowLayoutPanel4.AutoSize = true;
            this.flowLayoutPanel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.flowLayoutPanel4.Controls.Add(this.label3);
            this.flowLayoutPanel4.Controls.Add(this.redout);
            this.flowLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel4.Location = new System.Drawing.Point(56, 232);
            this.flowLayoutPanel4.Margin = new System.Windows.Forms.Padding(6, 5, 6, 25);
            this.flowLayoutPanel4.MinimumSize = new System.Drawing.Size(600, 0);
            this.flowLayoutPanel4.Name = "flowLayoutPanel4";
            this.flowLayoutPanel4.Padding = new System.Windows.Forms.Padding(15);
            this.flowLayoutPanel4.Size = new System.Drawing.Size(600, 217);
            this.flowLayoutPanel4.TabIndex = 25;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(226)))), ((int)(((byte)(236)))));
            this.label3.Location = new System.Drawing.Point(21, 15);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 80, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 187);
            this.label3.TabIndex = 20;
            this.label3.Text = "Description";
            // 
            // redout
            // 
            this.redout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.redout.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.redout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.redout.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.redout.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(226)))), ((int)(((byte)(236)))));
            this.redout.Location = new System.Drawing.Point(320, 20);
            this.redout.Margin = new System.Windows.Forms.Padding(100, 5, 6, 5);
            this.redout.MinimumSize = new System.Drawing.Size(0, 177);
            this.redout.Name = "redout";
            this.redout.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.redout.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedVertical;
            this.redout.Size = new System.Drawing.Size(242, 177);
            this.redout.TabIndex = 19;
            this.redout.Text = "";
            // 
            // flowLayoutPanel5
            // 
            this.flowLayoutPanel5.AutoSize = true;
            this.flowLayoutPanel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.flowLayoutPanel5.Controls.Add(this.lblMediaAttach);
            this.flowLayoutPanel5.Controls.Add(this.btnMedia);
            this.flowLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel5.Location = new System.Drawing.Point(56, 479);
            this.flowLayoutPanel5.Margin = new System.Windows.Forms.Padding(6, 5, 6, 25);
            this.flowLayoutPanel5.MinimumSize = new System.Drawing.Size(600, 0);
            this.flowLayoutPanel5.Name = "flowLayoutPanel5";
            this.flowLayoutPanel5.Padding = new System.Windows.Forms.Padding(15);
            this.flowLayoutPanel5.Size = new System.Drawing.Size(600, 101);
            this.flowLayoutPanel5.TabIndex = 26;
            // 
            // lblMediaAttach
            // 
            this.lblMediaAttach.AutoSize = true;
            this.lblMediaAttach.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.lblMediaAttach.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblMediaAttach.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Bold);
            this.lblMediaAttach.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(226)))), ((int)(((byte)(236)))));
            this.lblMediaAttach.Location = new System.Drawing.Point(21, 15);
            this.lblMediaAttach.Margin = new System.Windows.Forms.Padding(6, 0, 100, 0);
            this.lblMediaAttach.Name = "lblMediaAttach";
            this.lblMediaAttach.Size = new System.Drawing.Size(135, 71);
            this.lblMediaAttach.TabIndex = 21;
            this.lblMediaAttach.Text = "Attach Media";
            this.lblMediaAttach.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnMedia
            // 
            this.btnMedia.AutoSize = true;
            this.btnMedia.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(255)))), ((int)(((byte)(250)))));
            this.btnMedia.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMedia.FlatAppearance.BorderSize = 0;
            this.btnMedia.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(44)))), ((int)(((byte)(55)))));
            this.btnMedia.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(44)))), ((int)(((byte)(55)))));
            this.btnMedia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMedia.Font = new System.Drawing.Font("Tahoma", 13F, System.Drawing.FontStyle.Bold);
            this.btnMedia.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(226)))), ((int)(((byte)(236)))));
            this.btnMedia.Location = new System.Drawing.Point(362, 23);
            this.btnMedia.Margin = new System.Windows.Forms.Padding(106, 8, 6, 5);
            this.btnMedia.Name = "btnMedia";
            this.btnMedia.Size = new System.Drawing.Size(190, 58);
            this.btnMedia.TabIndex = 14;
            this.btnMedia.Text = "Upload";
            this.btnMedia.UseVisualStyleBackColor = false;
            this.btnMedia.Click += new System.EventHandler(this.btnMedia_Click);
            this.btnMedia.MouseEnter += new System.EventHandler(this.Btn_MouseEnter);
            this.btnMedia.MouseLeave += new System.EventHandler(this.Btn_MouseLeave);
            // 
            // btnSubmit
            // 
            this.btnSubmit.AutoSize = true;
            this.btnSubmit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.btnSubmit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSubmit.FlatAppearance.BorderSize = 0;
            this.btnSubmit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(44)))), ((int)(((byte)(55)))));
            this.btnSubmit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(255)))), ((int)(((byte)(250)))));
            this.btnSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubmit.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Bold);
            this.btnSubmit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(226)))), ((int)(((byte)(236)))));
            this.btnSubmit.Location = new System.Drawing.Point(250, 610);
            this.btnSubmit.Margin = new System.Windows.Forms.Padding(200, 5, 175, 5);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(200, 58);
            this.btnSubmit.TabIndex = 22;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = false;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            this.btnSubmit.MouseEnter += new System.EventHandler(this.Btn_MouseEnter);
            this.btnSubmit.MouseLeave += new System.EventHandler(this.Btn_MouseLeave);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnExit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold);
            this.btnExit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(226)))), ((int)(((byte)(236)))));
            this.btnExit.Location = new System.Drawing.Point(15, 15);
            this.btnExit.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(100, 41);
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
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "frmReportIssues";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Report Issues";
            this.Load += new System.EventHandler(this.frmReportIssues_Load);
            this.pnlMainPage.ResumeLayout(false);
            this.pnlMainPage.PerformLayout();
            this.pnlMainPageInner.ResumeLayout(false);
            this.pnlMainPageInner.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            this.flowLayoutPanel3.ResumeLayout(false);
            this.flowLayoutPanel4.ResumeLayout(false);
            this.flowLayoutPanel4.PerformLayout();
            this.flowLayoutPanel5.ResumeLayout(false);
            this.flowLayoutPanel5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlMainPage;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.Panel pnlMainPageInner;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtLocation;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbCategory;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox redout;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel5;
        private System.Windows.Forms.Label lblMediaAttach;
        private System.Windows.Forms.Button btnMedia;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Button btnExit;
    }
}