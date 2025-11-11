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
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.panel1 = new System.Windows.Forms.Panel();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.flowLayoutPanel4 = new System.Windows.Forms.FlowLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.flowLayoutPanel5 = new System.Windows.Forms.FlowLayoutPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.flowLayoutPanel6 = new System.Windows.Forms.FlowLayoutPanel();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.pnlMainPage.SuspendLayout();
            this.pnlMainPageInner.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.Location.SuspendLayout();
            this.Categories.SuspendLayout();
            this.Description.SuspendLayout();
            this.Media.SuspendLayout();
            this.panel1.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.flowLayoutPanel3.SuspendLayout();
            this.flowLayoutPanel4.SuspendLayout();
            this.flowLayoutPanel5.SuspendLayout();
            this.flowLayoutPanel6.SuspendLayout();
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
            this.pnlMainPageInner.Controls.Add(this.flowLayoutPanel1);
            this.pnlMainPageInner.Controls.Add(this.btnExit);
            this.pnlMainPageInner.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMainPageInner.Location = new System.Drawing.Point(20, 20);
            this.pnlMainPageInner.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.pnlMainPageInner.Name = "pnlMainPageInner";
            this.pnlMainPageInner.Size = new System.Drawing.Size(982, 774);
            this.pnlMainPageInner.TabIndex = 16;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel1.AutoSize = true;
            this.flowLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(44)))), ((int)(((byte)(55)))));
            this.flowLayoutPanel1.Controls.Add(this.Location);
            this.flowLayoutPanel1.Controls.Add(this.Categories);
            this.flowLayoutPanel1.Controls.Add(this.Description);
            this.flowLayoutPanel1.Controls.Add(this.Media);
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
            // Location
            // 
            this.Location.AutoSize = true;
            this.Location.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.Location.Controls.Add(this.lblLocation);
            this.Location.Controls.Add(this.txtLocation);
            this.Location.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Location.Location = new System.Drawing.Point(56, 45);
            this.Location.Margin = new System.Windows.Forms.Padding(6, 5, 6, 25);
            this.Location.MinimumSize = new System.Drawing.Size(600, 0);
            this.Location.Name = "Location";
            this.Location.Padding = new System.Windows.Forms.Padding(15);
            this.Location.Size = new System.Drawing.Size(600, 60);
            this.Location.TabIndex = 24;
            // 
            // lblLocation
            // 
            this.lblLocation.AutoSize = true;
            this.lblLocation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.lblLocation.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblLocation.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Bold);
            this.lblLocation.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(226)))), ((int)(((byte)(236)))));
            this.lblLocation.Location = new System.Drawing.Point(21, 15);
            this.lblLocation.Margin = new System.Windows.Forms.Padding(6, 0, 100, 0);
            this.lblLocation.Name = "lblLocation";
            this.lblLocation.Size = new System.Drawing.Size(92, 30);
            this.lblLocation.TabIndex = 16;
            this.lblLocation.Text = "Location";
            this.lblLocation.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
            // Categories
            // 
            this.Categories.AutoSize = true;
            this.Categories.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.Categories.Controls.Add(this.lblCategorySelect);
            this.Categories.Controls.Add(this.cmbCategory);
            this.Categories.Location = new System.Drawing.Point(56, 135);
            this.Categories.Margin = new System.Windows.Forms.Padding(6, 5, 6, 25);
            this.Categories.MinimumSize = new System.Drawing.Size(600, 0);
            this.Categories.Name = "Categories";
            this.Categories.Padding = new System.Windows.Forms.Padding(15);
            this.Categories.Size = new System.Drawing.Size(600, 67);
            this.Categories.TabIndex = 23;
            // 
            // lblCategorySelect
            // 
            this.lblCategorySelect.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.lblCategorySelect.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblCategorySelect.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Bold);
            this.lblCategorySelect.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(226)))), ((int)(((byte)(236)))));
            this.lblCategorySelect.Location = new System.Drawing.Point(21, 15);
            this.lblCategorySelect.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblCategorySelect.Name = "lblCategorySelect";
            this.lblCategorySelect.Size = new System.Drawing.Size(207, 37);
            this.lblCategorySelect.TabIndex = 17;
            this.lblCategorySelect.Text = "Category";
            this.lblCategorySelect.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
            // Description
            // 
            this.Description.AutoSize = true;
            this.Description.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.Description.Controls.Add(this.lblDescription);
            this.Description.Controls.Add(this.redout);
            this.Description.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Description.Location = new System.Drawing.Point(56, 232);
            this.Description.Margin = new System.Windows.Forms.Padding(6, 5, 6, 25);
            this.Description.MinimumSize = new System.Drawing.Size(600, 0);
            this.Description.Name = "Description";
            this.Description.Padding = new System.Windows.Forms.Padding(15);
            this.Description.Size = new System.Drawing.Size(600, 217);
            this.Description.TabIndex = 25;
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.lblDescription.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblDescription.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Bold);
            this.lblDescription.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(226)))), ((int)(((byte)(236)))));
            this.lblDescription.Location = new System.Drawing.Point(21, 15);
            this.lblDescription.Margin = new System.Windows.Forms.Padding(6, 0, 80, 0);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(119, 187);
            this.lblDescription.TabIndex = 20;
            this.lblDescription.Text = "Description";
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
            // Media
            // 
            this.Media.AutoSize = true;
            this.Media.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.Media.Controls.Add(this.lblMediaAttach);
            this.Media.Controls.Add(this.btnMedia);
            this.Media.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Media.Location = new System.Drawing.Point(56, 479);
            this.Media.Margin = new System.Windows.Forms.Padding(6, 5, 6, 25);
            this.Media.MinimumSize = new System.Drawing.Size(600, 0);
            this.Media.Name = "Media";
            this.Media.Padding = new System.Windows.Forms.Padding(15);
            this.Media.Size = new System.Drawing.Size(600, 101);
            this.Media.TabIndex = 26;
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
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(137)))), ((int)(((byte)(123)))));
            this.panel1.Controls.Add(this.flowLayoutPanel2);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(982, 774);
            this.panel1.TabIndex = 17;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel2.AutoSize = true;
            this.flowLayoutPanel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(44)))), ((int)(((byte)(55)))));
            this.flowLayoutPanel2.Controls.Add(this.flowLayoutPanel3);
            this.flowLayoutPanel2.Controls.Add(this.flowLayoutPanel4);
            this.flowLayoutPanel2.Controls.Add(this.flowLayoutPanel5);
            this.flowLayoutPanel2.Controls.Add(this.flowLayoutPanel6);
            this.flowLayoutPanel2.Controls.Add(this.button2);
            this.flowLayoutPanel2.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel2.Font = new System.Drawing.Font("Tahoma", 13F, System.Drawing.FontStyle.Bold);
            this.flowLayoutPanel2.Location = new System.Drawing.Point(137, 15);
            this.flowLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Padding = new System.Windows.Forms.Padding(50, 40, 50, 40);
            this.flowLayoutPanel2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.flowLayoutPanel2.Size = new System.Drawing.Size(712, 713);
            this.flowLayoutPanel2.TabIndex = 15;
            this.flowLayoutPanel2.WrapContents = false;
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.AutoSize = true;
            this.flowLayoutPanel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.flowLayoutPanel3.Controls.Add(this.label1);
            this.flowLayoutPanel3.Controls.Add(this.textBox1);
            this.flowLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel3.Location = new System.Drawing.Point(56, 45);
            this.flowLayoutPanel3.Margin = new System.Windows.Forms.Padding(6, 5, 6, 25);
            this.flowLayoutPanel3.MinimumSize = new System.Drawing.Size(600, 0);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Padding = new System.Windows.Forms.Padding(15);
            this.flowLayoutPanel3.Size = new System.Drawing.Size(600, 60);
            this.flowLayoutPanel3.TabIndex = 24;
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
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Tahoma", 12F);
            this.textBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(226)))), ((int)(((byte)(236)))));
            this.textBox1.Location = new System.Drawing.Point(323, 20);
            this.textBox1.Margin = new System.Windows.Forms.Padding(110, 5, 6, 5);
            this.textBox1.Name = "textBox1";
            this.textBox1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.textBox1.Size = new System.Drawing.Size(242, 20);
            this.textBox1.TabIndex = 15;
            // 
            // flowLayoutPanel4
            // 
            this.flowLayoutPanel4.AutoSize = true;
            this.flowLayoutPanel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.flowLayoutPanel4.Controls.Add(this.label2);
            this.flowLayoutPanel4.Controls.Add(this.comboBox1);
            this.flowLayoutPanel4.Location = new System.Drawing.Point(56, 135);
            this.flowLayoutPanel4.Margin = new System.Windows.Forms.Padding(6, 5, 6, 25);
            this.flowLayoutPanel4.MinimumSize = new System.Drawing.Size(600, 0);
            this.flowLayoutPanel4.Name = "flowLayoutPanel4";
            this.flowLayoutPanel4.Padding = new System.Windows.Forms.Padding(15);
            this.flowLayoutPanel4.Size = new System.Drawing.Size(600, 67);
            this.flowLayoutPanel4.TabIndex = 23;
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
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.comboBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(226)))), ((int)(((byte)(236)))));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(334, 20);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(100, 5, 6, 5);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(238, 27);
            this.comboBox1.TabIndex = 18;
            // 
            // flowLayoutPanel5
            // 
            this.flowLayoutPanel5.AutoSize = true;
            this.flowLayoutPanel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.flowLayoutPanel5.Controls.Add(this.label3);
            this.flowLayoutPanel5.Controls.Add(this.richTextBox1);
            this.flowLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel5.Location = new System.Drawing.Point(56, 232);
            this.flowLayoutPanel5.Margin = new System.Windows.Forms.Padding(6, 5, 6, 25);
            this.flowLayoutPanel5.MinimumSize = new System.Drawing.Size(600, 0);
            this.flowLayoutPanel5.Name = "flowLayoutPanel5";
            this.flowLayoutPanel5.Padding = new System.Windows.Forms.Padding(15);
            this.flowLayoutPanel5.Size = new System.Drawing.Size(600, 217);
            this.flowLayoutPanel5.TabIndex = 25;
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
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBox1.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(226)))), ((int)(((byte)(236)))));
            this.richTextBox1.Location = new System.Drawing.Point(320, 20);
            this.richTextBox1.Margin = new System.Windows.Forms.Padding(100, 5, 6, 5);
            this.richTextBox1.MinimumSize = new System.Drawing.Size(0, 177);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.richTextBox1.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedVertical;
            this.richTextBox1.Size = new System.Drawing.Size(242, 177);
            this.richTextBox1.TabIndex = 19;
            this.richTextBox1.Text = "";
            // 
            // flowLayoutPanel6
            // 
            this.flowLayoutPanel6.AutoSize = true;
            this.flowLayoutPanel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.flowLayoutPanel6.Controls.Add(this.label4);
            this.flowLayoutPanel6.Controls.Add(this.button1);
            this.flowLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel6.Location = new System.Drawing.Point(56, 479);
            this.flowLayoutPanel6.Margin = new System.Windows.Forms.Padding(6, 5, 6, 25);
            this.flowLayoutPanel6.MinimumSize = new System.Drawing.Size(600, 0);
            this.flowLayoutPanel6.Name = "flowLayoutPanel6";
            this.flowLayoutPanel6.Padding = new System.Windows.Forms.Padding(15);
            this.flowLayoutPanel6.Size = new System.Drawing.Size(600, 101);
            this.flowLayoutPanel6.TabIndex = 26;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(226)))), ((int)(((byte)(236)))));
            this.label4.Location = new System.Drawing.Point(21, 15);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 100, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(135, 71);
            this.label4.TabIndex = 21;
            this.label4.Text = "Attach Media";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // button1
            // 
            this.button1.AutoSize = true;
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(255)))), ((int)(((byte)(250)))));
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(44)))), ((int)(((byte)(55)))));
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(44)))), ((int)(((byte)(55)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Tahoma", 13F, System.Drawing.FontStyle.Bold);
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(226)))), ((int)(((byte)(236)))));
            this.button1.Location = new System.Drawing.Point(362, 23);
            this.button1.Margin = new System.Windows.Forms.Padding(106, 8, 6, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(190, 58);
            this.button1.TabIndex = 14;
            this.button1.Text = "Upload";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.AutoSize = true;
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(44)))), ((int)(((byte)(55)))));
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(255)))), ((int)(((byte)(250)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Bold);
            this.button2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(226)))), ((int)(((byte)(236)))));
            this.button2.Location = new System.Drawing.Point(250, 610);
            this.button2.Margin = new System.Windows.Forms.Padding(200, 5, 175, 5);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(200, 58);
            this.button2.TabIndex = 22;
            this.button2.Text = "Submit";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold);
            this.button3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(226)))), ((int)(((byte)(236)))));
            this.button3.Location = new System.Drawing.Point(15, 15);
            this.button3.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(100, 41);
            this.button3.TabIndex = 9;
            this.button3.Text = "Back";
            this.button3.UseVisualStyleBackColor = false;
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
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.Location.ResumeLayout(false);
            this.Location.PerformLayout();
            this.Categories.ResumeLayout(false);
            this.Description.ResumeLayout(false);
            this.Description.PerformLayout();
            this.Media.ResumeLayout(false);
            this.Media.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            this.flowLayoutPanel3.ResumeLayout(false);
            this.flowLayoutPanel3.PerformLayout();
            this.flowLayoutPanel4.ResumeLayout(false);
            this.flowLayoutPanel5.ResumeLayout(false);
            this.flowLayoutPanel5.PerformLayout();
            this.flowLayoutPanel6.ResumeLayout(false);
            this.flowLayoutPanel6.PerformLayout();
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
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}