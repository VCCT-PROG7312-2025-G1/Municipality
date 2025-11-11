namespace Municipality_ST10263992_PROG7312.Forms
{
    partial class frmService
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmService));
            this.pnlMainPage = new System.Windows.Forms.Panel();
            this.pnlMainInside = new System.Windows.Forms.Panel();
            this.btnExit = new System.Windows.Forms.Button();
            this.pnlInner = new System.Windows.Forms.Panel();
            this.pnlOutService = new System.Windows.Forms.Panel();
            this.pnlGraph = new System.Windows.Forms.Panel();
            this.redOut = new System.Windows.Forms.RichTextBox();
            this.pnlDisplaySearch = new System.Windows.Forms.Panel();
            this.redDetails = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pnlSearch = new System.Windows.Forms.Panel();
            this.btnGenerateRoute = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.edtSearch = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnNext = new System.Windows.Forms.Button();
            this.pnlMainPage.SuspendLayout();
            this.pnlMainInside.SuspendLayout();
            this.pnlInner.SuspendLayout();
            this.pnlOutService.SuspendLayout();
            this.pnlDisplaySearch.SuspendLayout();
            this.pnlSearch.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlMainPage
            // 
            this.pnlMainPage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(137)))), ((int)(((byte)(123)))));
            this.pnlMainPage.Controls.Add(this.pnlMainInside);
            this.pnlMainPage.Location = new System.Drawing.Point(0, 0);
            this.pnlMainPage.Name = "pnlMainPage";
            this.pnlMainPage.Padding = new System.Windows.Forms.Padding(20);
            this.pnlMainPage.Size = new System.Drawing.Size(1022, 814);
            this.pnlMainPage.TabIndex = 0;
            // 
            // pnlMainInside
            // 
            this.pnlMainInside.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(137)))), ((int)(((byte)(123)))));
            this.pnlMainInside.Controls.Add(this.btnExit);
            this.pnlMainInside.Controls.Add(this.pnlInner);
            this.pnlMainInside.Location = new System.Drawing.Point(15, 15);
            this.pnlMainInside.Name = "pnlMainInside";
            this.pnlMainInside.Size = new System.Drawing.Size(992, 784);
            this.pnlMainInside.TabIndex = 1;
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
            this.btnExit.Location = new System.Drawing.Point(30, 29);
            this.btnExit.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(100, 41);
            this.btnExit.TabIndex = 11;
            this.btnExit.Text = "Back";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // pnlInner
            // 
            this.pnlInner.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(137)))), ((int)(((byte)(123)))));
            this.pnlInner.Controls.Add(this.pnlOutService);
            this.pnlInner.Controls.Add(this.pnlDisplaySearch);
            this.pnlInner.Controls.Add(this.pnlSearch);
            this.pnlInner.Location = new System.Drawing.Point(18, 16);
            this.pnlInner.Name = "pnlInner";
            this.pnlInner.Size = new System.Drawing.Size(959, 748);
            this.pnlInner.TabIndex = 22;
            // 
            // pnlOutService
            // 
            this.pnlOutService.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(44)))), ((int)(((byte)(55)))));
            this.pnlOutService.Controls.Add(this.pnlGraph);
            this.pnlOutService.Controls.Add(this.redOut);
            this.pnlOutService.Location = new System.Drawing.Point(235, 59);
            this.pnlOutService.Name = "pnlOutService";
            this.pnlOutService.Padding = new System.Windows.Forms.Padding(10);
            this.pnlOutService.Size = new System.Drawing.Size(721, 670);
            this.pnlOutService.TabIndex = 9;
            // 
            // pnlGraph
            // 
            this.pnlGraph.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.pnlGraph.Location = new System.Drawing.Point(10, 292);
            this.pnlGraph.Name = "pnlGraph";
            this.pnlGraph.Size = new System.Drawing.Size(700, 359);
            this.pnlGraph.TabIndex = 1;
            // 
            // redOut
            // 
            this.redOut.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.redOut.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.redOut.Cursor = System.Windows.Forms.Cursors.Default;
            this.redOut.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.redOut.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(226)))), ((int)(((byte)(236)))));
            this.redOut.Location = new System.Drawing.Point(10, 22);
            this.redOut.Name = "redOut";
            this.redOut.ReadOnly = true;
            this.redOut.Size = new System.Drawing.Size(700, 264);
            this.redOut.TabIndex = 0;
            this.redOut.Text = "";
            // 
            // pnlDisplaySearch
            // 
            this.pnlDisplaySearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(44)))), ((int)(((byte)(55)))));
            this.pnlDisplaySearch.Controls.Add(this.redDetails);
            this.pnlDisplaySearch.Controls.Add(this.label2);
            this.pnlDisplaySearch.Location = new System.Drawing.Point(12, 351);
            this.pnlDisplaySearch.Name = "pnlDisplaySearch";
            this.pnlDisplaySearch.Padding = new System.Windows.Forms.Padding(10);
            this.pnlDisplaySearch.Size = new System.Drawing.Size(217, 378);
            this.pnlDisplaySearch.TabIndex = 8;
            // 
            // redDetails
            // 
            this.redDetails.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.redDetails.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.redDetails.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.redDetails.Font = new System.Drawing.Font("Tahoma", 10F);
            this.redDetails.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(226)))), ((int)(((byte)(236)))));
            this.redDetails.Location = new System.Drawing.Point(14, 61);
            this.redDetails.Name = "redDetails";
            this.redDetails.ReadOnly = true;
            this.redDetails.Size = new System.Drawing.Size(190, 298);
            this.redDetails.TabIndex = 7;
            this.redDetails.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(44)))), ((int)(((byte)(55)))));
            this.label2.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(226)))), ((int)(((byte)(236)))));
            this.label2.Location = new System.Drawing.Point(10, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 23);
            this.label2.TabIndex = 6;
            this.label2.Text = "Details:";
            // 
            // pnlSearch
            // 
            this.pnlSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(44)))), ((int)(((byte)(55)))));
            this.pnlSearch.Controls.Add(this.btnGenerateRoute);
            this.pnlSearch.Controls.Add(this.btnSearch);
            this.pnlSearch.Controls.Add(this.edtSearch);
            this.pnlSearch.Controls.Add(this.label1);
            this.pnlSearch.Controls.Add(this.btnNext);
            this.pnlSearch.Location = new System.Drawing.Point(12, 59);
            this.pnlSearch.Name = "pnlSearch";
            this.pnlSearch.Padding = new System.Windows.Forms.Padding(10);
            this.pnlSearch.Size = new System.Drawing.Size(217, 286);
            this.pnlSearch.TabIndex = 7;
            // 
            // btnGenerateRoute
            // 
            this.btnGenerateRoute.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.btnGenerateRoute.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGenerateRoute.FlatAppearance.BorderSize = 0;
            this.btnGenerateRoute.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(44)))), ((int)(((byte)(55)))));
            this.btnGenerateRoute.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(255)))), ((int)(((byte)(250)))));
            this.btnGenerateRoute.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGenerateRoute.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold);
            this.btnGenerateRoute.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(226)))), ((int)(((byte)(236)))));
            this.btnGenerateRoute.Location = new System.Drawing.Point(36, 197);
            this.btnGenerateRoute.Name = "btnGenerateRoute";
            this.btnGenerateRoute.Size = new System.Drawing.Size(145, 40);
            this.btnGenerateRoute.TabIndex = 3;
            this.btnGenerateRoute.Text = "Show on Map";
            this.btnGenerateRoute.UseVisualStyleBackColor = false;
            this.btnGenerateRoute.Click += new System.EventHandler(this.btnGenerateRoute_Click);
            this.btnGenerateRoute.MouseEnter += new System.EventHandler(this.Btn_MouseEnter);
            this.btnGenerateRoute.MouseLeave += new System.EventHandler(this.Btn_MouseLeave);
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.btnSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(44)))), ((int)(((byte)(55)))));
            this.btnSearch.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(255)))), ((int)(((byte)(250)))));
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(226)))), ((int)(((byte)(236)))));
            this.btnSearch.Location = new System.Drawing.Point(36, 113);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(145, 40);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            this.btnSearch.MouseEnter += new System.EventHandler(this.Btn_MouseEnter);
            this.btnSearch.MouseLeave += new System.EventHandler(this.Btn_MouseLeave);
            // 
            // edtSearch
            // 
            this.edtSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.edtSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.edtSearch.Font = new System.Drawing.Font("Tahoma", 12F);
            this.edtSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(226)))), ((int)(((byte)(236)))));
            this.edtSearch.Location = new System.Drawing.Point(14, 65);
            this.edtSearch.Name = "edtSearch";
            this.edtSearch.Size = new System.Drawing.Size(190, 27);
            this.edtSearch.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(44)))), ((int)(((byte)(55)))));
            this.label1.Font = new System.Drawing.Font("Tahoma", 13F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(226)))), ((int)(((byte)(236)))));
            this.label1.Location = new System.Drawing.Point(10, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 22);
            this.label1.TabIndex = 1;
            this.label1.Text = "Search by ID:";
            // 
            // btnNext
            // 
            this.btnNext.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.btnNext.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNext.FlatAppearance.BorderSize = 0;
            this.btnNext.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(44)))), ((int)(((byte)(55)))));
            this.btnNext.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(255)))), ((int)(((byte)(250)))));
            this.btnNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNext.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold);
            this.btnNext.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(226)))), ((int)(((byte)(236)))));
            this.btnNext.Location = new System.Drawing.Point(36, 155);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(145, 40);
            this.btnNext.TabIndex = 3;
            this.btnNext.Text = "Next Priority";
            this.btnNext.UseVisualStyleBackColor = false;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            this.btnNext.MouseEnter += new System.EventHandler(this.Btn_MouseEnter);
            this.btnNext.MouseLeave += new System.EventHandler(this.Btn_MouseLeave);
            // 
            // frmService
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1022, 814);
            this.Controls.Add(this.pnlMainPage);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmService";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Service";
            this.Load += new System.EventHandler(this.Service_Load);
            this.pnlMainPage.ResumeLayout(false);
            this.pnlMainInside.ResumeLayout(false);
            this.pnlInner.ResumeLayout(false);
            this.pnlOutService.ResumeLayout(false);
            this.pnlDisplaySearch.ResumeLayout(false);
            this.pnlDisplaySearch.PerformLayout();
            this.pnlSearch.ResumeLayout(false);
            this.pnlSearch.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlMainPage;
        private System.Windows.Forms.Panel pnlMainInside;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Panel pnlInner;
        private System.Windows.Forms.Panel pnlOutService;
        private System.Windows.Forms.Panel pnlGraph;
        private System.Windows.Forms.RichTextBox redOut;
        private System.Windows.Forms.Panel pnlDisplaySearch;
        private System.Windows.Forms.RichTextBox redDetails;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel pnlSearch;
        private System.Windows.Forms.Button btnGenerateRoute;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox edtSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnNext;
    }
}