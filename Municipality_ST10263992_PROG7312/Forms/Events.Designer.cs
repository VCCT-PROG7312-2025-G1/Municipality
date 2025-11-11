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
            this.pnlRecomend = new System.Windows.Forms.Panel();
            this.lblSuggested = new System.Windows.Forms.Label();
            this.redRecomend = new System.Windows.Forms.RichTextBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.pnlMainInside = new System.Windows.Forms.Panel();
            this.pnlCalender = new System.Windows.Forms.Panel();
            this.lblUpcoming = new System.Windows.Forms.Label();
            this.calUpcoming = new System.Windows.Forms.MonthCalendar();
            this.pnlMainPageInner = new System.Windows.Forms.Panel();
            this.redOut = new System.Windows.Forms.RichTextBox();
            this.btnReset = new System.Windows.Forms.Button();
            this.cmbCategory = new System.Windows.Forms.ComboBox();
            this.dtpSearch = new System.Windows.Forms.DateTimePicker();
            this.edtSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.panel3 = new System.Windows.Forms.Panel();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.pnlMainPage.SuspendLayout();
            this.pnlRecomend.SuspendLayout();
            this.pnlMainInside.SuspendLayout();
            this.pnlCalender.SuspendLayout();
            this.pnlMainPageInner.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlMainPage
            // 
            this.pnlMainPage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(137)))), ((int)(((byte)(123)))));
            this.pnlMainPage.Controls.Add(this.pnlRecomend);
            this.pnlMainPage.Controls.Add(this.btnExit);
            this.pnlMainPage.Controls.Add(this.pnlMainInside);
            this.pnlMainPage.Location = new System.Drawing.Point(1, 0);
            this.pnlMainPage.Name = "pnlMainPage";
            this.pnlMainPage.Padding = new System.Windows.Forms.Padding(20);
            this.pnlMainPage.Size = new System.Drawing.Size(1020, 814);
            this.pnlMainPage.TabIndex = 0;
            // 
            // pnlRecomend
            // 
            this.pnlRecomend.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(44)))), ((int)(((byte)(55)))));
            this.pnlRecomend.Controls.Add(this.lblSuggested);
            this.pnlRecomend.Controls.Add(this.redRecomend);
            this.pnlRecomend.Location = new System.Drawing.Point(30, 78);
            this.pnlRecomend.Name = "pnlRecomend";
            this.pnlRecomend.Padding = new System.Windows.Forms.Padding(10);
            this.pnlRecomend.Size = new System.Drawing.Size(309, 460);
            this.pnlRecomend.TabIndex = 17;
            // 
            // lblSuggested
            // 
            this.lblSuggested.AutoSize = true;
            this.lblSuggested.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(44)))), ((int)(((byte)(55)))));
            this.lblSuggested.Font = new System.Drawing.Font("Tahoma", 16F, System.Drawing.FontStyle.Bold);
            this.lblSuggested.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(226)))), ((int)(((byte)(236)))));
            this.lblSuggested.Location = new System.Drawing.Point(85, 15);
            this.lblSuggested.Name = "lblSuggested";
            this.lblSuggested.Size = new System.Drawing.Size(128, 27);
            this.lblSuggested.TabIndex = 0;
            this.lblSuggested.Text = "Suggested";
            // 
            // redRecomend
            // 
            this.redRecomend.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.redRecomend.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.redRecomend.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.redRecomend.Font = new System.Drawing.Font("Tahoma", 12F);
            this.redRecomend.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(226)))), ((int)(((byte)(236)))));
            this.redRecomend.Location = new System.Drawing.Point(13, 60);
            this.redRecomend.Name = "redRecomend";
            this.redRecomend.ReadOnly = true;
            this.redRecomend.Size = new System.Drawing.Size(282, 387);
            this.redRecomend.TabIndex = 0;
            this.redRecomend.Text = "";
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
            this.btnExit.TabIndex = 10;
            this.btnExit.Text = "Back";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // pnlMainInside
            // 
            this.pnlMainInside.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(137)))), ((int)(((byte)(123)))));
            this.pnlMainInside.Controls.Add(this.panel1);
            this.pnlMainInside.Controls.Add(this.pnlCalender);
            this.pnlMainInside.Controls.Add(this.pnlMainPageInner);
            this.pnlMainInside.Location = new System.Drawing.Point(11, 12);
            this.pnlMainInside.Name = "pnlMainInside";
            this.pnlMainInside.Size = new System.Drawing.Size(998, 790);
            this.pnlMainInside.TabIndex = 21;
            // 
            // pnlCalender
            // 
            this.pnlCalender.Controls.Add(this.lblUpcoming);
            this.pnlCalender.Controls.Add(this.calUpcoming);
            this.pnlCalender.Location = new System.Drawing.Point(19, 532);
            this.pnlCalender.Name = "pnlCalender";
            this.pnlCalender.Size = new System.Drawing.Size(309, 218);
            this.pnlCalender.TabIndex = 16;
            // 
            // lblUpcoming
            // 
            this.lblUpcoming.AutoSize = true;
            this.lblUpcoming.BackColor = System.Drawing.Color.Transparent;
            this.lblUpcoming.Font = new System.Drawing.Font("Tahoma", 16F, System.Drawing.FontStyle.Bold);
            this.lblUpcoming.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(226)))), ((int)(((byte)(236)))));
            this.lblUpcoming.Location = new System.Drawing.Point(89, 11);
            this.lblUpcoming.Name = "lblUpcoming";
            this.lblUpcoming.Size = new System.Drawing.Size(124, 27);
            this.lblUpcoming.TabIndex = 1;
            this.lblUpcoming.Text = "Upcoming";
            // 
            // calUpcoming
            // 
            this.calUpcoming.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.calUpcoming.Font = new System.Drawing.Font("Tahoma", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calUpcoming.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(226)))), ((int)(((byte)(236)))));
            this.calUpcoming.Location = new System.Drawing.Point(39, 47);
            this.calUpcoming.Name = "calUpcoming";
            this.calUpcoming.TabIndex = 19;
            this.calUpcoming.TitleBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(44)))), ((int)(((byte)(55)))));
            this.calUpcoming.TitleForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(226)))), ((int)(((byte)(236)))));
            this.calUpcoming.TrailingForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(81)))), ((int)(((byte)(81)))));
            // 
            // pnlMainPageInner
            // 
            this.pnlMainPageInner.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(44)))), ((int)(((byte)(55)))));
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
            this.redOut.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.redOut.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.redOut.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.redOut.Font = new System.Drawing.Font("Tahoma", 12F);
            this.redOut.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(226)))), ((int)(((byte)(236)))));
            this.redOut.Location = new System.Drawing.Point(22, 55);
            this.redOut.Name = "redOut";
            this.redOut.ReadOnly = true;
            this.redOut.Size = new System.Drawing.Size(603, 670);
            this.redOut.TabIndex = 0;
            this.redOut.Text = "";
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.btnReset.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReset.FlatAppearance.BorderSize = 0;
            this.btnReset.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(44)))), ((int)(((byte)(55)))));
            this.btnReset.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(255)))), ((int)(((byte)(250)))));
            this.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReset.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.btnReset.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(226)))), ((int)(((byte)(236)))));
            this.btnReset.Location = new System.Drawing.Point(550, 11);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 31);
            this.btnReset.TabIndex = 16;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // cmbCategory
            // 
            this.cmbCategory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.cmbCategory.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmbCategory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbCategory.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.cmbCategory.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(226)))), ((int)(((byte)(236)))));
            this.cmbCategory.FormattingEnabled = true;
            this.cmbCategory.Location = new System.Drawing.Point(9, 11);
            this.cmbCategory.Name = "cmbCategory";
            this.cmbCategory.Size = new System.Drawing.Size(201, 27);
            this.cmbCategory.TabIndex = 14;
            this.cmbCategory.Text = "Categories";
            // 
            // dtpSearch
            // 
            this.dtpSearch.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.dtpSearch.CalendarTitleBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(44)))), ((int)(((byte)(55)))));
            this.dtpSearch.CalendarTitleForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(226)))), ((int)(((byte)(236)))));
            this.dtpSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dtpSearch.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold);
            this.dtpSearch.Location = new System.Drawing.Point(216, 13);
            this.dtpSearch.Name = "dtpSearch";
            this.dtpSearch.Size = new System.Drawing.Size(123, 25);
            this.dtpSearch.TabIndex = 15;
            this.dtpSearch.Value = new System.DateTime(2025, 10, 13, 16, 42, 15, 0);
            // 
            // edtSearch
            // 
            this.edtSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.edtSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.edtSearch.Font = new System.Drawing.Font("Tahoma", 12F);
            this.edtSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(226)))), ((int)(((byte)(236)))));
            this.edtSearch.Location = new System.Drawing.Point(345, 12);
            this.edtSearch.Name = "edtSearch";
            this.edtSearch.Size = new System.Drawing.Size(163, 27);
            this.edtSearch.TabIndex = 12;
            this.edtSearch.Text = "Search...";
            this.edtSearch.Click += new System.EventHandler(this.edtSearch_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.btnSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnSearch.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Image = global::Municipality_ST10263992_PROG7312.Properties.Resources.search_resized;
            this.btnSearch.Location = new System.Drawing.Point(514, 9);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(30, 32);
            this.btnSearch.TabIndex = 13;
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(137)))), ((int)(((byte)(123)))));
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Location = new System.Drawing.Point(8, 8);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(998, 790);
            this.panel1.TabIndex = 22;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.monthCalendar1);
            this.panel2.Location = new System.Drawing.Point(19, 532);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(309, 218);
            this.panel2.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Tahoma", 16F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(226)))), ((int)(((byte)(236)))));
            this.label1.Location = new System.Drawing.Point(89, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 27);
            this.label1.TabIndex = 1;
            this.label1.Text = "Upcoming";
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.monthCalendar1.Font = new System.Drawing.Font("Tahoma", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.monthCalendar1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(226)))), ((int)(((byte)(236)))));
            this.monthCalendar1.Location = new System.Drawing.Point(39, 47);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 19;
            this.monthCalendar1.TitleBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(44)))), ((int)(((byte)(55)))));
            this.monthCalendar1.TitleForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(226)))), ((int)(((byte)(236)))));
            this.monthCalendar1.TrailingForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(81)))), ((int)(((byte)(81)))));
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(44)))), ((int)(((byte)(55)))));
            this.panel3.Controls.Add(this.richTextBox1);
            this.panel3.Controls.Add(this.button1);
            this.panel3.Controls.Add(this.comboBox1);
            this.panel3.Controls.Add(this.button2);
            this.panel3.Controls.Add(this.dateTimePicker1);
            this.panel3.Controls.Add(this.textBox1);
            this.panel3.Location = new System.Drawing.Point(347, 17);
            this.panel3.Name = "panel3";
            this.panel3.Padding = new System.Windows.Forms.Padding(15);
            this.panel3.Size = new System.Drawing.Size(648, 752);
            this.panel3.TabIndex = 11;
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.richTextBox1.Font = new System.Drawing.Font("Tahoma", 12F);
            this.richTextBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(226)))), ((int)(((byte)(236)))));
            this.richTextBox1.Location = new System.Drawing.Point(22, 55);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(603, 670);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(44)))), ((int)(((byte)(55)))));
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(255)))), ((int)(((byte)(250)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(226)))), ((int)(((byte)(236)))));
            this.button1.Location = new System.Drawing.Point(550, 11);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 31);
            this.button1.TabIndex = 16;
            this.button1.Text = "Reset";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.comboBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.comboBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(226)))), ((int)(((byte)(236)))));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(9, 11);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(201, 27);
            this.comboBox1.TabIndex = 14;
            this.comboBox1.Text = "Categories";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Image = global::Municipality_ST10263992_PROG7312.Properties.Resources.search_resized;
            this.button2.Location = new System.Drawing.Point(514, 9);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(30, 32);
            this.button2.TabIndex = 13;
            this.button2.UseVisualStyleBackColor = false;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.dateTimePicker1.CalendarTitleBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(44)))), ((int)(((byte)(55)))));
            this.dateTimePicker1.CalendarTitleForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(226)))), ((int)(((byte)(236)))));
            this.dateTimePicker1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dateTimePicker1.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold);
            this.dateTimePicker1.Location = new System.Drawing.Point(216, 13);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(123, 25);
            this.dateTimePicker1.TabIndex = 15;
            this.dateTimePicker1.Value = new System.DateTime(2025, 10, 13, 16, 42, 15, 0);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Font = new System.Drawing.Font("Tahoma", 12F);
            this.textBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(226)))), ((int)(((byte)(236)))));
            this.textBox1.Location = new System.Drawing.Point(345, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(163, 27);
            this.textBox1.TabIndex = 12;
            this.textBox1.Text = "Search...";
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
            this.pnlCalender.ResumeLayout(false);
            this.pnlCalender.PerformLayout();
            this.pnlMainPageInner.ResumeLayout(false);
            this.pnlMainPageInner.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
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
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox textBox1;
    }
}