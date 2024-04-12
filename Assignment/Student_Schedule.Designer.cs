namespace Assignment_Student_
{
    partial class FrmSchedule
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSchedule));
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.btnHome = new System.Windows.Forms.Button();
            this.btnSch = new System.Windows.Forms.Button();
            this.btnReq = new System.Windows.Forms.Button();
            this.btnPro = new System.Windows.Forms.Button();
            this.btnLog = new System.Windows.Forms.Button();
            this.btnPay = new System.Windows.Forms.Button();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.btnSchReset = new System.Windows.Forms.Button();
            this.lblIntake = new System.Windows.Forms.Label();
            this.lbIntake = new System.Windows.Forms.ListBox();
            this.lblModule = new System.Windows.Forms.Label();
            this.btnSchSearch = new System.Windows.Forms.Button();
            this.lbSchClassL = new System.Windows.Forms.ListBox();
            this.lblSchClassL = new System.Windows.Forms.Label();
            this.gbSch = new System.Windows.Forms.GroupBox();
            this.lvSch = new System.Windows.Forms.ListView();
            this.chModuleID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chModulename = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chIntake = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chCLassL = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chCharges = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chDay = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chDuration = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chTrainer = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lbSchModule = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.gbSch.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(0, 0);
            this.splitter1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(3, 480);
            this.splitter1.TabIndex = 0;
            this.splitter1.TabStop = false;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(3, 0);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.Color.AliceBlue;
            this.splitContainer1.Panel1.Controls.Add(this.btnHome);
            this.splitContainer1.Panel1.Controls.Add(this.btnSch);
            this.splitContainer1.Panel1.Controls.Add(this.btnReq);
            this.splitContainer1.Panel1.Controls.Add(this.btnPro);
            this.splitContainer1.Panel1.Controls.Add(this.btnLog);
            this.splitContainer1.Panel1.Controls.Add(this.btnPay);
            this.splitContainer1.Panel1.Controls.Add(this.picLogo);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackColor = System.Drawing.Color.White;
            this.splitContainer1.Panel2.Controls.Add(this.btnSchReset);
            this.splitContainer1.Panel2.Controls.Add(this.lblIntake);
            this.splitContainer1.Panel2.Controls.Add(this.lbIntake);
            this.splitContainer1.Panel2.Controls.Add(this.lblModule);
            this.splitContainer1.Panel2.Controls.Add(this.btnSchSearch);
            this.splitContainer1.Panel2.Controls.Add(this.lbSchClassL);
            this.splitContainer1.Panel2.Controls.Add(this.lblSchClassL);
            this.splitContainer1.Panel2.Controls.Add(this.gbSch);
            this.splitContainer1.Panel2.Controls.Add(this.lbSchModule);
            this.splitContainer1.Size = new System.Drawing.Size(912, 480);
            this.splitContainer1.SplitterDistance = 204;
            this.splitContainer1.TabIndex = 1;
            this.splitContainer1.SplitterMoved += new System.Windows.Forms.SplitterEventHandler(this.splitContainer1_SplitterMoved);
            // 
            // btnHome
            // 
            this.btnHome.BackColor = System.Drawing.Color.Transparent;
            this.btnHome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnHome.FlatAppearance.BorderSize = 0;
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHome.Font = new System.Drawing.Font("Bahnschrift", 9.75F);
            this.btnHome.ForeColor = System.Drawing.Color.RoyalBlue;
            this.btnHome.Image = ((System.Drawing.Image)(resources.GetObject("btnHome.Image")));
            this.btnHome.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHome.Location = new System.Drawing.Point(3, 80);
            this.btnHome.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(197, 50);
            this.btnHome.TabIndex = 47;
            this.btnHome.Text = "HOME";
            this.btnHome.UseVisualStyleBackColor = false;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // btnSch
            // 
            this.btnSch.BackColor = System.Drawing.Color.Transparent;
            this.btnSch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSch.FlatAppearance.BorderSize = 0;
            this.btnSch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSch.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSch.ForeColor = System.Drawing.Color.RoyalBlue;
            this.btnSch.Image = ((System.Drawing.Image)(resources.GetObject("btnSch.Image")));
            this.btnSch.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSch.Location = new System.Drawing.Point(3, 135);
            this.btnSch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSch.Name = "btnSch";
            this.btnSch.Size = new System.Drawing.Size(197, 50);
            this.btnSch.TabIndex = 41;
            this.btnSch.Text = "SCHEDULE";
            this.btnSch.UseVisualStyleBackColor = false;
            this.btnSch.Click += new System.EventHandler(this.btnSch_Click);
            // 
            // btnReq
            // 
            this.btnReq.BackColor = System.Drawing.Color.Transparent;
            this.btnReq.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnReq.FlatAppearance.BorderSize = 0;
            this.btnReq.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReq.Font = new System.Drawing.Font("Bahnschrift", 9.75F);
            this.btnReq.ForeColor = System.Drawing.Color.RoyalBlue;
            this.btnReq.Image = ((System.Drawing.Image)(resources.GetObject("btnReq.Image")));
            this.btnReq.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReq.Location = new System.Drawing.Point(3, 193);
            this.btnReq.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnReq.Name = "btnReq";
            this.btnReq.Size = new System.Drawing.Size(197, 50);
            this.btnReq.TabIndex = 42;
            this.btnReq.Text = "REQUEST";
            this.btnReq.UseVisualStyleBackColor = false;
            this.btnReq.Click += new System.EventHandler(this.btnReq_Click);
            // 
            // btnPro
            // 
            this.btnPro.BackColor = System.Drawing.Color.Transparent;
            this.btnPro.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnPro.FlatAppearance.BorderSize = 0;
            this.btnPro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPro.Font = new System.Drawing.Font("Bahnschrift", 9.75F);
            this.btnPro.ForeColor = System.Drawing.Color.RoyalBlue;
            this.btnPro.Image = ((System.Drawing.Image)(resources.GetObject("btnPro.Image")));
            this.btnPro.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPro.Location = new System.Drawing.Point(3, 370);
            this.btnPro.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnPro.Name = "btnPro";
            this.btnPro.Size = new System.Drawing.Size(197, 50);
            this.btnPro.TabIndex = 45;
            this.btnPro.Text = "PROFILE";
            this.btnPro.UseVisualStyleBackColor = false;
            this.btnPro.Click += new System.EventHandler(this.btnPro_Click);
            // 
            // btnLog
            // 
            this.btnLog.BackColor = System.Drawing.Color.Transparent;
            this.btnLog.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnLog.FlatAppearance.BorderSize = 0;
            this.btnLog.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLog.Font = new System.Drawing.Font("Bahnschrift", 9.75F);
            this.btnLog.ForeColor = System.Drawing.Color.RoyalBlue;
            this.btnLog.Image = ((System.Drawing.Image)(resources.GetObject("btnLog.Image")));
            this.btnLog.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLog.Location = new System.Drawing.Point(3, 427);
            this.btnLog.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLog.Name = "btnLog";
            this.btnLog.Size = new System.Drawing.Size(197, 50);
            this.btnLog.TabIndex = 44;
            this.btnLog.Text = "LOG OUT";
            this.btnLog.UseVisualStyleBackColor = false;
            this.btnLog.Click += new System.EventHandler(this.btnLog_Click);
            // 
            // btnPay
            // 
            this.btnPay.BackColor = System.Drawing.Color.Transparent;
            this.btnPay.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnPay.FlatAppearance.BorderSize = 0;
            this.btnPay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPay.Font = new System.Drawing.Font("Bahnschrift", 9.75F);
            this.btnPay.ForeColor = System.Drawing.Color.RoyalBlue;
            this.btnPay.Image = ((System.Drawing.Image)(resources.GetObject("btnPay.Image")));
            this.btnPay.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPay.Location = new System.Drawing.Point(3, 250);
            this.btnPay.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnPay.Name = "btnPay";
            this.btnPay.Size = new System.Drawing.Size(197, 50);
            this.btnPay.TabIndex = 43;
            this.btnPay.Text = "PAYMENT";
            this.btnPay.UseVisualStyleBackColor = false;
            this.btnPay.Click += new System.EventHandler(this.btnPay_Click);
            // 
            // picLogo
            // 
            this.picLogo.BackColor = System.Drawing.Color.AliceBlue;
            this.picLogo.Image = ((System.Drawing.Image)(resources.GetObject("picLogo.Image")));
            this.picLogo.Location = new System.Drawing.Point(3, 2);
            this.picLogo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(197, 70);
            this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picLogo.TabIndex = 46;
            this.picLogo.TabStop = false;
            // 
            // btnSchReset
            // 
            this.btnSchReset.BackColor = System.Drawing.Color.Salmon;
            this.btnSchReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSchReset.Font = new System.Drawing.Font("Bahnschrift", 9.75F);
            this.btnSchReset.ForeColor = System.Drawing.Color.Firebrick;
            this.btnSchReset.Location = new System.Drawing.Point(530, 92);
            this.btnSchReset.Name = "btnSchReset";
            this.btnSchReset.Size = new System.Drawing.Size(86, 29);
            this.btnSchReset.TabIndex = 17;
            this.btnSchReset.Text = "Reset";
            this.btnSchReset.UseVisualStyleBackColor = false;
            this.btnSchReset.Click += new System.EventHandler(this.btnSchReset_Click);
            // 
            // lblIntake
            // 
            this.lblIntake.AutoSize = true;
            this.lblIntake.Font = new System.Drawing.Font("Bahnschrift", 11.25F);
            this.lblIntake.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lblIntake.Location = new System.Drawing.Point(26, 29);
            this.lblIntake.Name = "lblIntake";
            this.lblIntake.Size = new System.Drawing.Size(66, 23);
            this.lblIntake.TabIndex = 16;
            this.lblIntake.Text = "Intake:";
            // 
            // lbIntake
            // 
            this.lbIntake.BackColor = System.Drawing.Color.White;
            this.lbIntake.Font = new System.Drawing.Font("Bahnschrift", 12F);
            this.lbIntake.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lbIntake.FormattingEnabled = true;
            this.lbIntake.ItemHeight = 24;
            this.lbIntake.Items.AddRange(new object[] {
            "2023A",
            "2023B"});
            this.lbIntake.Location = new System.Drawing.Point(184, 24);
            this.lbIntake.Name = "lbIntake";
            this.lbIntake.Size = new System.Drawing.Size(233, 28);
            this.lbIntake.TabIndex = 15;
            // 
            // lblModule
            // 
            this.lblModule.AutoSize = true;
            this.lblModule.Font = new System.Drawing.Font("Bahnschrift", 11.25F);
            this.lblModule.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lblModule.Location = new System.Drawing.Point(26, 97);
            this.lblModule.Name = "lblModule";
            this.lblModule.Size = new System.Drawing.Size(76, 23);
            this.lblModule.TabIndex = 13;
            this.lblModule.Text = "Module:";
            // 
            // btnSchSearch
            // 
            this.btnSchSearch.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnSchSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSchSearch.Font = new System.Drawing.Font("Bahnschrift", 9.75F);
            this.btnSchSearch.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.btnSchSearch.Location = new System.Drawing.Point(438, 91);
            this.btnSchSearch.Name = "btnSchSearch";
            this.btnSchSearch.Size = new System.Drawing.Size(86, 29);
            this.btnSchSearch.TabIndex = 12;
            this.btnSchSearch.Text = "Search";
            this.btnSchSearch.UseVisualStyleBackColor = false;
            this.btnSchSearch.Click += new System.EventHandler(this.btnSchSearch_Click);
            // 
            // lbSchClassL
            // 
            this.lbSchClassL.BackColor = System.Drawing.Color.White;
            this.lbSchClassL.Font = new System.Drawing.Font("Bahnschrift", 12F);
            this.lbSchClassL.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lbSchClassL.FormattingEnabled = true;
            this.lbSchClassL.ItemHeight = 24;
            this.lbSchClassL.Items.AddRange(new object[] {
            "Beginner",
            "Intermediate",
            "Advanced"});
            this.lbSchClassL.Location = new System.Drawing.Point(184, 57);
            this.lbSchClassL.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lbSchClassL.Name = "lbSchClassL";
            this.lbSchClassL.Size = new System.Drawing.Size(233, 28);
            this.lbSchClassL.TabIndex = 8;
            // 
            // lblSchClassL
            // 
            this.lblSchClassL.AutoSize = true;
            this.lblSchClassL.Font = new System.Drawing.Font("Bahnschrift", 11.25F);
            this.lblSchClassL.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lblSchClassL.Location = new System.Drawing.Point(26, 62);
            this.lblSchClassL.Name = "lblSchClassL";
            this.lblSchClassL.Size = new System.Drawing.Size(114, 23);
            this.lblSchClassL.TabIndex = 7;
            this.lblSchClassL.Text = "Class Level:";
            // 
            // gbSch
            // 
            this.gbSch.BackColor = System.Drawing.Color.MintCream;
            this.gbSch.Controls.Add(this.lvSch);
            this.gbSch.Font = new System.Drawing.Font("Bahnschrift", 12F);
            this.gbSch.ForeColor = System.Drawing.Color.RoyalBlue;
            this.gbSch.Location = new System.Drawing.Point(21, 135);
            this.gbSch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbSch.Name = "gbSch";
            this.gbSch.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbSch.Size = new System.Drawing.Size(659, 334);
            this.gbSch.TabIndex = 11;
            this.gbSch.TabStop = false;
            this.gbSch.Text = "Schedule";
            // 
            // lvSch
            // 
            this.lvSch.BackColor = System.Drawing.Color.White;
            this.lvSch.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chModuleID,
            this.chModulename,
            this.chIntake,
            this.chCLassL,
            this.chCharges,
            this.chDay,
            this.chDuration,
            this.chTrainer});
            this.lvSch.Font = new System.Drawing.Font("Bahnschrift", 9.75F);
            this.lvSch.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lvSch.FullRowSelect = true;
            this.lvSch.GridLines = true;
            this.lvSch.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lvSch.HideSelection = false;
            this.lvSch.Location = new System.Drawing.Point(9, 29);
            this.lvSch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lvSch.MultiSelect = false;
            this.lvSch.Name = "lvSch";
            this.lvSch.Size = new System.Drawing.Size(644, 301);
            this.lvSch.TabIndex = 1;
            this.lvSch.UseCompatibleStateImageBehavior = false;
            this.lvSch.View = System.Windows.Forms.View.Details;
            // 
            // chModuleID
            // 
            this.chModuleID.Text = "Module ID";
            this.chModuleID.Width = 90;
            // 
            // chModulename
            // 
            this.chModulename.Text = "Module";
            this.chModulename.Width = 150;
            // 
            // chIntake
            // 
            this.chIntake.Text = "Intake";
            this.chIntake.Width = 70;
            // 
            // chCLassL
            // 
            this.chCLassL.Text = "Class Level";
            this.chCLassL.Width = 100;
            // 
            // chCharges
            // 
            this.chCharges.Text = "Charges";
            this.chCharges.Width = 80;
            // 
            // chDay
            // 
            this.chDay.Text = "Day";
            this.chDay.Width = 120;
            // 
            // chDuration
            // 
            this.chDuration.Text = "Duration";
            this.chDuration.Width = 90;
            // 
            // chTrainer
            // 
            this.chTrainer.Text = "Trainer";
            this.chTrainer.Width = 80;
            // 
            // lbSchModule
            // 
            this.lbSchModule.BackColor = System.Drawing.Color.White;
            this.lbSchModule.Font = new System.Drawing.Font("Bahnschrift", 12F);
            this.lbSchModule.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lbSchModule.FormattingEnabled = true;
            this.lbSchModule.ItemHeight = 24;
            this.lbSchModule.Items.AddRange(new object[] {
            "C# Programming ",
            "C Programming",
            "C++ Programming",
            "Python Programming",
            "Java Script Programming",
            "SQL Programming"});
            this.lbSchModule.Location = new System.Drawing.Point(184, 92);
            this.lbSchModule.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lbSchModule.Name = "lbSchModule";
            this.lbSchModule.Size = new System.Drawing.Size(233, 28);
            this.lbSchModule.TabIndex = 10;
            // 
            // FrmSchedule
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(915, 480);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.splitter1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FrmSchedule";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Schedule";
            this.Load += new System.EventHandler(this.FrmSchedule_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.gbSch.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Button btnSch;
        private System.Windows.Forms.Button btnReq;
        private System.Windows.Forms.Button btnPro;
        private System.Windows.Forms.Button btnLog;
        private System.Windows.Forms.Button btnPay;
        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.GroupBox gbSch;
        private System.Windows.Forms.ListView lvSch;
        private System.Windows.Forms.ColumnHeader chModulename;
        private System.Windows.Forms.ColumnHeader chCLassL;
        private System.Windows.Forms.ColumnHeader chCharges;
        private System.Windows.Forms.ColumnHeader chDuration;
        private System.Windows.Forms.ListBox lbSchModule;
        private System.Windows.Forms.ListBox lbSchClassL;
        private System.Windows.Forms.Label lblSchClassL;
        private System.Windows.Forms.Button btnSchSearch;
        private System.Windows.Forms.ColumnHeader chDay;
        private System.Windows.Forms.Label lblModule;
        private System.Windows.Forms.ColumnHeader chModuleID;
        private System.Windows.Forms.ColumnHeader chIntake;
        private System.Windows.Forms.ColumnHeader chTrainer;
        private System.Windows.Forms.Label lblIntake;
        private System.Windows.Forms.ListBox lbIntake;
        private System.Windows.Forms.Button btnSchReset;
    }
}