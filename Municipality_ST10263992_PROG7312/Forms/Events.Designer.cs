namespace Municipality_ST10263992_PROG7312.Forms
{
    partial class frmEvent
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEvent));
            this.pnlMainPage = new System.Windows.Forms.Panel();
            this.calUpcoming = new System.Windows.Forms.MonthCalendar();
            this.pnlRecomend = new System.Windows.Forms.Panel();
            this.lblSuggested = new System.Windows.Forms.Label();
            this.redRecomend = new System.Windows.Forms.RichTextBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.pnlMainInside = new System.Windows.Forms.Panel();
            this.lblUpcoming = new System.Windows.Forms.Label();
            this.pnlCalender = new System.Windows.Forms.Panel();
            this.pnlMainPageInner = new System.Windows.Forms.Panel();
            this.redOut = new System.Windows.Forms.RichTextBox();
            this.btnReset = new System.Windows.Forms.Button();
            this.cmbCategory = new System.Windows.Forms.ComboBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.dtpSearch = new System.Windows.Forms.DateTimePicker();
            this.edtSearch = new System.Windows.Forms.TextBox();
            this.pnlMainPage.SuspendLayout();
            this.pnlRecomend.SuspendLayout();
            this.pnlMainInside.SuspendLayout();
            this.pnlMainPageInner.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlMainPage
            // 
            this.pnlMainPage.Controls.Add(this.calUpcoming);
            this.pnlMainPage.Controls.Add(this.pnlRecomend);
            this.pnlMainPage.Controls.Add(this.btnExit);
            this.pnlMainPage.Controls.Add(this.pnlMainInside);
            this.pnlMainPage.Location = new System.Drawing.Point(1, 0);
            this.pnlMainPage.Name = "pnlMainPage";
            this.pnlMainPage.Padding = new System.Windows.Forms.Padding(15);
            this.pnlMainPage.Size = new System.Drawing.Size(992, 784);
            this.pnlMainPage.TabIndex = 0;
            // 
            // calUpcoming
            // 
            this.calUpcoming.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Bold);
            this.calUpcoming.Location = new System.Drawing.Point(71, 589);
            this.calUpcoming.Name = "calUpcoming";
            this.calUpcoming.TabIndex = 19;
            // 
            // pnlRecomend
            // 
            this.pnlRecomend.Controls.Add(this.lblSuggested);
            this.pnlRecomend.Controls.Add(this.redRecomend);
            this.pnlRecomend.Location = new System.Drawing.Point(30, 78);
            this.pnlRecomend.Name = "pnlRecomend";
            this.pnlRecomend.Size = new System.Drawing.Size(309, 434);
            this.pnlRecomend.TabIndex = 17;
            // 
            // lblSuggested
            // 
            this.lblSuggested.AutoSize = true;
            this.lblSuggested.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Bold);
            this.lblSuggested.Location = new System.Drawing.Point(98, 18);
            this.lblSuggested.Name = "lblSuggested";
            this.lblSuggested.Size = new System.Drawing.Size(110, 23);
            this.lblSuggested.TabIndex = 0;
            this.lblSuggested.Text = "Suggested";
            // 
            // redRecomend
            // 
            this.redRecomend.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.redRecomend.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.redRecomend.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Bold);
            this.redRecomend.Location = new System.Drawing.Point(15, 70);
            this.redRecomend.Name = "redRecomend";
            this.redRecomend.ReadOnly = true;
            this.redRecomend.Size = new System.Drawing.Size(282, 345);
            this.redRecomend.TabIndex = 0;
            this.redRecomend.Text = "";
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Black;
            this.btnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExit.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Bold);
            this.btnExit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(226)))), ((int)(((byte)(236)))));
            this.btnExit.Location = new System.Drawing.Point(30, 29);
            this.btnExit.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(150, 41);
            this.btnExit.TabIndex = 10;
            this.btnExit.Text = "Back";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // pnlMainInside
            // 
            this.pnlMainInside.Controls.Add(this.lblUpcoming);
            this.pnlMainInside.Controls.Add(this.pnlCalender);
            this.pnlMainInside.Controls.Add(this.pnlMainPageInner);
            this.pnlMainInside.Location = new System.Drawing.Point(11, 12);
            this.pnlMainInside.Name = "pnlMainInside";
            this.pnlMainInside.Size = new System.Drawing.Size(998, 790);
            this.pnlMainInside.TabIndex = 21;
            // 
            // lblUpcoming
            // 
            this.lblUpcoming.AutoSize = true;
            this.lblUpcoming.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Bold);
            this.lblUpcoming.Location = new System.Drawing.Point(117, 545);
            this.lblUpcoming.Name = "lblUpcoming";
            this.lblUpcoming.Size = new System.Drawing.Size(106, 23);
            this.lblUpcoming.TabIndex = 1;
            this.lblUpcoming.Text = "Upcoming";
            // 
            // pnlCalender
            // 
            this.pnlCalender.Location = new System.Drawing.Point(50, 536);
            this.pnlCalender.Name = "pnlCalender";
            this.pnlCalender.Size = new System.Drawing.Size(247, 218);
            this.pnlCalender.TabIndex = 16;
            // 
            // pnlMainPageInner
            // 
            this.pnlMainPageInner.Controls.Add(this.redOut);
            this.pnlMainPageInner.Controls.Add(this.btnReset);
            this.pnlMainPageInner.Controls.Add(this.cmbCategory);
            this.pnlMainPageInner.Controls.Add(this.btnSearch);
            this.pnlMainPageInner.Controls.Add(this.dtpSearch);
            this.pnlMainPageInner.Controls.Add(this.edtSearch);
            this.pnlMainPageInner.Location = new System.Drawing.Point(347, 17);
            this.pnlMainPageInner.Name = "pnlMainPageInner";
            this.pnlMainPageInner.Padding = new System.Windows.Forms.Padding(15);
            this.pnlMainPageInner.Size = new System.Drawing.Size(648, 752);
            this.pnlMainPageInner.TabIndex = 11;
            // 
            // redOut
            // 
            this.redOut.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.redOut.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.redOut.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Bold);
            this.redOut.Location = new System.Drawing.Point(22, 55);
            this.redOut.Name = "redOut";
            this.redOut.ReadOnly = true;
            this.redOut.Size = new System.Drawing.Size(583, 667);
            this.redOut.TabIndex = 0;
            this.redOut.Text = "";
            // 
            // btnReset
            // 
            this.btnReset.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReset.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Bold);
            this.btnReset.Location = new System.Drawing.Point(555, 11);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 31);
            this.btnReset.TabIndex = 16;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // cmbCategory
            // 
            this.cmbCategory.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmbCategory.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Bold);
            this.cmbCategory.FormattingEnabled = true;
            this.cmbCategory.Location = new System.Drawing.Point(9, 11);
            this.cmbCategory.Name = "cmbCategory";
            this.cmbCategory.Size = new System.Drawing.Size(201, 31);
            this.cmbCategory.TabIndex = 14;
            this.cmbCategory.Text = "Categories";
            // 
            // btnSearch
            // 
            this.btnSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearch.Image = global::Municipality_ST10263992_PROG7312.Properties.Resources.search;
            this.btnSearch.Location = new System.Drawing.Point(519, 9);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(30, 32);
            this.btnSearch.TabIndex = 13;
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // dtpSearch
            // 
            this.dtpSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dtpSearch.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Bold);
            this.dtpSearch.Location = new System.Drawing.Point(216, 11);
            this.dtpSearch.Name = "dtpSearch";
            this.dtpSearch.Size = new System.Drawing.Size(123, 30);
            this.dtpSearch.TabIndex = 15;
            this.dtpSearch.Value = new System.DateTime(2025, 10, 13, 16, 42, 15, 0);
            // 
            // edtSearch
            // 
            this.edtSearch.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Bold);
            this.edtSearch.Location = new System.Drawing.Point(345, 10);
            this.edtSearch.Name = "edtSearch";
            this.edtSearch.Size = new System.Drawing.Size(168, 30);
            this.edtSearch.TabIndex = 12;
            this.edtSearch.Text = "Search...";
            this.edtSearch.Click += new System.EventHandler(this.edtSearch_Click);
            // 
            // frmEvent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1022, 814);
            this.Controls.Add(this.pnlMainPage);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmEvent";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Events";
            this.Load += new System.EventHandler(this.Events_Load);
            this.pnlMainPage.ResumeLayout(false);
            this.pnlRecomend.ResumeLayout(false);
            this.pnlRecomend.PerformLayout();
            this.pnlMainInside.ResumeLayout(false);
            this.pnlMainInside.PerformLayout();
            this.pnlMainPageInner.ResumeLayout(false);
            this.pnlMainPageInner.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlMainPage;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Panel pnlMainPageInner;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox edtSearch;
        private System.Windows.Forms.RichTextBox redOut;
        private System.Windows.Forms.ComboBox cmbCategory;
        private System.Windows.Forms.DateTimePicker dtpSearch;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Panel pnlRecomend;
        private System.Windows.Forms.RichTextBox redRecomend;
        private System.Windows.Forms.MonthCalendar calUpcoming;
        private System.Windows.Forms.Panel pnlMainInside;
        private System.Windows.Forms.Label lblUpcoming;
        private System.Windows.Forms.Label lblSuggested;
        private System.Windows.Forms.Panel pnlCalender;
    }
}