namespace Municipality_ST10263992_PROG7312
{
    partial class frmMainMenu
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
            this.button2 = new System.Windows.Forms.Button();
            this.btnEvents = new System.Windows.Forms.Button();
            this.btnReportIssue = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.pnlMainPage.SuspendLayout();
            this.pnlMainMenuInner.SuspendLayout();
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
            this.pnlMainPage.TabIndex = 0;
            // 
            // pnlMainMenuInner
            // 
            this.pnlMainMenuInner.AutoSize = true;
            this.pnlMainMenuInner.Controls.Add(this.btnExit);
            this.pnlMainMenuInner.Controls.Add(this.button2);
            this.pnlMainMenuInner.Controls.Add(this.btnEvents);
            this.pnlMainMenuInner.Controls.Add(this.btnReportIssue);
            this.pnlMainMenuInner.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMainMenuInner.Location = new System.Drawing.Point(24, 24);
            this.pnlMainMenuInner.Margin = new System.Windows.Forms.Padding(0);
            this.pnlMainMenuInner.Name = "pnlMainMenuInner";
            this.pnlMainMenuInner.Size = new System.Drawing.Size(974, 766);
            this.pnlMainMenuInner.TabIndex = 1;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(413, 306);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "Status";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // btnEvents
            // 
            this.btnEvents.Location = new System.Drawing.Point(413, 249);
            this.btnEvents.Name = "btnEvents";
            this.btnEvents.Size = new System.Drawing.Size(75, 23);
            this.btnEvents.TabIndex = 1;
            this.btnEvents.Text = "Events";
            this.btnEvents.UseVisualStyleBackColor = true;
            // 
            // btnReportIssue
            // 
            this.btnReportIssue.Location = new System.Drawing.Point(413, 185);
            this.btnReportIssue.Name = "btnReportIssue";
            this.btnReportIssue.Size = new System.Drawing.Size(75, 23);
            this.btnReportIssue.TabIndex = 0;
            this.btnReportIssue.Text = "Report";
            this.btnReportIssue.UseVisualStyleBackColor = true;
            this.btnReportIssue.Click += new System.EventHandler(this.btnReportIssue_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(18, 16);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // frmMainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1022, 814);
            this.Controls.Add(this.pnlMainPage);
            this.Name = "frmMainMenu";
            this.Text = "Main Menu";
            this.pnlMainPage.ResumeLayout(false);
            this.pnlMainPage.PerformLayout();
            this.pnlMainMenuInner.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlMainPage;
        private System.Windows.Forms.Panel pnlMainMenuInner;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnEvents;
        private System.Windows.Forms.Button btnReportIssue;
        private System.Windows.Forms.Button btnExit;
    }
}

