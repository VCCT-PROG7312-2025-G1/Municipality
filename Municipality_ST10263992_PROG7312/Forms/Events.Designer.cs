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
            this.pnlMainPage = new System.Windows.Forms.Panel();
            this.btnReset = new System.Windows.Forms.Button();
            this.dtpSearch = new System.Windows.Forms.DateTimePicker();
            this.cmbCategory = new System.Windows.Forms.ComboBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.edtSearch = new System.Windows.Forms.TextBox();
            this.pnlMainPageInner = new System.Windows.Forms.Panel();
            this.redOut = new System.Windows.Forms.RichTextBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.pnlMainPage.SuspendLayout();
            this.pnlMainPageInner.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlMainPage
            // 
            this.pnlMainPage.Controls.Add(this.btnReset);
            this.pnlMainPage.Controls.Add(this.dtpSearch);
            this.pnlMainPage.Controls.Add(this.cmbCategory);
            this.pnlMainPage.Controls.Add(this.btnSearch);
            this.pnlMainPage.Controls.Add(this.edtSearch);
            this.pnlMainPage.Controls.Add(this.pnlMainPageInner);
            this.pnlMainPage.Controls.Add(this.btnExit);
            this.pnlMainPage.Location = new System.Drawing.Point(1, 0);
            this.pnlMainPage.Name = "pnlMainPage";
            this.pnlMainPage.Padding = new System.Windows.Forms.Padding(15);
            this.pnlMainPage.Size = new System.Drawing.Size(1022, 814);
            this.pnlMainPage.TabIndex = 0;
            // 
            // btnReset
            // 
            this.btnReset.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Bold);
            this.btnReset.Location = new System.Drawing.Point(893, 42);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 31);
            this.btnReset.TabIndex = 16;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // dtpSearch
            // 
            this.dtpSearch.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Bold);
            this.dtpSearch.Location = new System.Drawing.Point(413, 43);
            this.dtpSearch.Name = "dtpSearch";
            this.dtpSearch.Size = new System.Drawing.Size(248, 30);
            this.dtpSearch.TabIndex = 15;
            this.dtpSearch.Value = new System.DateTime(2025, 10, 13, 16, 42, 15, 0);
            // 
            // cmbCategory
            // 
            this.cmbCategory.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Bold);
            this.cmbCategory.FormattingEnabled = true;
            this.cmbCategory.Location = new System.Drawing.Point(189, 43);
            this.cmbCategory.Name = "cmbCategory";
            this.cmbCategory.Size = new System.Drawing.Size(201, 31);
            this.cmbCategory.TabIndex = 14;
            this.cmbCategory.Text = "Categories";
            // 
            // btnSearch
            // 
            this.btnSearch.Image = global::Municipality_ST10263992_PROG7312.Properties.Resources.search;
            this.btnSearch.Location = new System.Drawing.Point(855, 42);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(30, 32);
            this.btnSearch.TabIndex = 13;
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // edtSearch
            // 
            this.edtSearch.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Bold);
            this.edtSearch.Location = new System.Drawing.Point(681, 42);
            this.edtSearch.Name = "edtSearch";
            this.edtSearch.Size = new System.Drawing.Size(168, 30);
            this.edtSearch.TabIndex = 12;
            this.edtSearch.Text = "Search...";
            this.edtSearch.Click += new System.EventHandler(this.edtSearch_Click);
            // 
            // pnlMainPageInner
            // 
            this.pnlMainPageInner.Controls.Add(this.redOut);
            this.pnlMainPageInner.Location = new System.Drawing.Point(30, 78);
            this.pnlMainPageInner.Name = "pnlMainPageInner";
            this.pnlMainPageInner.Padding = new System.Windows.Forms.Padding(15);
            this.pnlMainPageInner.Size = new System.Drawing.Size(956, 691);
            this.pnlMainPageInner.TabIndex = 11;
            // 
            // redOut
            // 
            this.redOut.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Bold);
            this.redOut.Location = new System.Drawing.Point(18, 18);
            this.redOut.Name = "redOut";
            this.redOut.Size = new System.Drawing.Size(920, 655);
            this.redOut.TabIndex = 0;
            this.redOut.Text = "";
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
            // frmEvent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1022, 814);
            this.Controls.Add(this.pnlMainPage);
            this.Name = "frmEvent";
            this.Text = "Events";
            this.Load += new System.EventHandler(this.Events_Load);
            this.pnlMainPage.ResumeLayout(false);
            this.pnlMainPage.PerformLayout();
            this.pnlMainPageInner.ResumeLayout(false);
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
    }
}