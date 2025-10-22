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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
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
            this.flowLayoutPanel1.SuspendLayout();
            this.pnlMainInside.SuspendLayout();
            this.pnlInner.SuspendLayout();
            this.pnlOutService.SuspendLayout();
            this.pnlDisplaySearch.SuspendLayout();
            this.pnlSearch.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlMainPage
            // 
            this.pnlMainPage.Controls.Add(this.flowLayoutPanel1);
            this.pnlMainPage.Location = new System.Drawing.Point(0, 0);
            this.pnlMainPage.Name = "pnlMainPage";
            this.pnlMainPage.Size = new System.Drawing.Size(1022, 814);
            this.pnlMainPage.TabIndex = 0;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.pnlMainInside);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(15, 9);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(992, 784);
            this.flowLayoutPanel1.TabIndex = 7;
            // 
            // pnlMainInside
            // 
            this.pnlMainInside.Controls.Add(this.btnExit);
            this.pnlMainInside.Controls.Add(this.pnlInner);
            this.pnlMainInside.Location = new System.Drawing.Point(3, 3);
            this.pnlMainInside.Name = "pnlMainInside";
            this.pnlMainInside.Size = new System.Drawing.Size(992, 784);
            this.pnlMainInside.TabIndex = 0;
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
            this.btnExit.TabIndex = 11;
            this.btnExit.Text = "Back";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // pnlInner
            // 
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
            this.pnlOutService.Controls.Add(this.pnlGraph);
            this.pnlOutService.Controls.Add(this.redOut);
            this.pnlOutService.Location = new System.Drawing.Point(235, 59);
            this.pnlOutService.Name = "pnlOutService";
            this.pnlOutService.Size = new System.Drawing.Size(721, 670);
            this.pnlOutService.TabIndex = 9;
            // 
            // pnlGraph
            // 
            this.pnlGraph.Location = new System.Drawing.Point(10, 292);
            this.pnlGraph.Name = "pnlGraph";
            this.pnlGraph.Size = new System.Drawing.Size(700, 359);
            this.pnlGraph.TabIndex = 1;
            this.pnlGraph.Paint += new System.Windows.Forms.PaintEventHandler(this.PnlGraph_Paint);
            this.pnlGraph.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pnlGraph_MouseClick);
            // 
            // redOut
            // 
            this.redOut.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.redOut.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.redOut.Location = new System.Drawing.Point(10, 22);
            this.redOut.Name = "redOut";
            this.redOut.ReadOnly = true;
            this.redOut.Size = new System.Drawing.Size(700, 252);
            this.redOut.TabIndex = 0;
            this.redOut.Text = "";
            // 
            // pnlDisplaySearch
            // 
            this.pnlDisplaySearch.Controls.Add(this.redDetails);
            this.pnlDisplaySearch.Controls.Add(this.label2);
            this.pnlDisplaySearch.Location = new System.Drawing.Point(12, 351);
            this.pnlDisplaySearch.Name = "pnlDisplaySearch";
            this.pnlDisplaySearch.Size = new System.Drawing.Size(217, 378);
            this.pnlDisplaySearch.TabIndex = 8;
            // 
            // redDetails
            // 
            this.redDetails.BorderStyle = System.Windows.Forms.BorderStyle.None;
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
            this.label2.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(10, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 23);
            this.label2.TabIndex = 6;
            this.label2.Text = "Details:";
            // 
            // pnlSearch
            // 
            this.pnlSearch.Controls.Add(this.btnGenerateRoute);
            this.pnlSearch.Controls.Add(this.btnSearch);
            this.pnlSearch.Controls.Add(this.edtSearch);
            this.pnlSearch.Controls.Add(this.label1);
            this.pnlSearch.Controls.Add(this.btnNext);
            this.pnlSearch.Location = new System.Drawing.Point(12, 59);
            this.pnlSearch.Name = "pnlSearch";
            this.pnlSearch.Size = new System.Drawing.Size(217, 286);
            this.pnlSearch.TabIndex = 7;
            // 
            // btnGenerateRoute
            // 
            this.btnGenerateRoute.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.btnGenerateRoute.Location = new System.Drawing.Point(36, 197);
            this.btnGenerateRoute.Name = "btnGenerateRoute";
            this.btnGenerateRoute.Size = new System.Drawing.Size(145, 29);
            this.btnGenerateRoute.TabIndex = 3;
            this.btnGenerateRoute.Text = "Show on Map";
            this.btnGenerateRoute.UseVisualStyleBackColor = true;
            this.btnGenerateRoute.Click += new System.EventHandler(this.btnGenerateRoute_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(36, 127);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(145, 29);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // edtSearch
            // 
            this.edtSearch.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Bold);
            this.edtSearch.Location = new System.Drawing.Point(14, 65);
            this.edtSearch.Name = "edtSearch";
            this.edtSearch.Size = new System.Drawing.Size(176, 30);
            this.edtSearch.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(10, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Search by ID:";
            // 
            // btnNext
            // 
            this.btnNext.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.btnNext.Location = new System.Drawing.Point(36, 162);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(145, 29);
            this.btnNext.TabIndex = 3;
            this.btnNext.Text = "Next Priority";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
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
            this.flowLayoutPanel1.ResumeLayout(false);
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
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox edtSearch;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel pnlOutService;
        private System.Windows.Forms.Panel pnlDisplaySearch;
        private System.Windows.Forms.Panel pnlSearch;
        private System.Windows.Forms.RichTextBox redOut;
        private System.Windows.Forms.RichTextBox redDetails;
        private System.Windows.Forms.Panel pnlGraph;
        private System.Windows.Forms.Button btnGenerateRoute;
    }
}