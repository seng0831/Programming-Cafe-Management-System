namespace Assignment_Trainer_
{
    partial class Trainer_Update_Information
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
            System.Windows.Forms.ListViewGroup listViewGroup1 = new System.Windows.Forms.ListViewGroup("ModuleID", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup2 = new System.Windows.Forms.ListViewGroup("Modulename", System.Windows.Forms.HorizontalAlignment.Left);
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Trainer_Update_Information));
            this.listviewcoachingclass = new System.Windows.Forms.ListView();
            this.ModuleID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Modulename = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ClassLevel = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Charges = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Day = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Duration = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Intake = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Trainer = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TrainerID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnupdate = new System.Windows.Forms.Button();
            this.lstboxcoachingclass = new System.Windows.Forms.ListBox();
            this.txtmoduleid = new System.Windows.Forms.TextBox();
            this.txtcharges = new System.Windows.Forms.TextBox();
            this.lblid = new System.Windows.Forms.Label();
            this.txtduration = new System.Windows.Forms.TextBox();
            this.txtintake = new System.Windows.Forms.TextBox();
            this.btndelete = new System.Windows.Forms.Button();
            this.txtclasslevel = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnfeedback = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            this.btnSch = new System.Windows.Forms.Button();
            this.btnPro = new System.Windows.Forms.Button();
            this.btnLog = new System.Windows.Forms.Button();
            this.btnPay = new System.Windows.Forms.Button();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.lblcharges = new System.Windows.Forms.Label();
            this.lblday = new System.Windows.Forms.Label();
            this.lblduration = new System.Windows.Forms.Label();
            this.lblintake = new System.Windows.Forms.Label();
            this.lstday = new System.Windows.Forms.ListBox();
            this.lblcoachingclass = new System.Windows.Forms.Label();
            this.txttrainername = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // listviewcoachingclass
            // 
            this.listviewcoachingclass.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ModuleID,
            this.Modulename,
            this.ClassLevel,
            this.Charges,
            this.Day,
            this.Duration,
            this.Intake,
            this.Trainer,
            this.TrainerID});
            this.listviewcoachingclass.FullRowSelect = true;
            listViewGroup1.Header = "ModuleID";
            listViewGroup1.Name = "ModuleID";
            listViewGroup2.Header = "Modulename";
            listViewGroup2.Name = "Modulename";
            this.listviewcoachingclass.Groups.AddRange(new System.Windows.Forms.ListViewGroup[] {
            listViewGroup1,
            listViewGroup2});
            this.listviewcoachingclass.HideSelection = false;
            this.listviewcoachingclass.Location = new System.Drawing.Point(332, 158);
            this.listviewcoachingclass.Name = "listviewcoachingclass";
            this.listviewcoachingclass.Size = new System.Drawing.Size(1118, 671);
            this.listviewcoachingclass.TabIndex = 2;
            this.listviewcoachingclass.UseCompatibleStateImageBehavior = false;
            // 
            // ModuleID
            // 
            this.ModuleID.Text = "ModuleID";
            // 
            // Modulename
            // 
            this.Modulename.Text = "Modulename";
            // 
            // ClassLevel
            // 
            this.ClassLevel.Text = "Class Level";
            // 
            // Charges
            // 
            this.Charges.Text = "Charges";
            // 
            // Day
            // 
            this.Day.Text = "Day";
            // 
            // Duration
            // 
            this.Duration.Text = "Duration";
            // 
            // Trainer
            // 
            this.Trainer.Text = "Trainer";
            // 
            // TrainerID
            // 
            this.TrainerID.Text = "TrainerID";
            // 
            // btnupdate
            // 
            this.btnupdate.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnupdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnupdate.Font = new System.Drawing.Font("Bahnschrift", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnupdate.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.btnupdate.Location = new System.Drawing.Point(1504, 465);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.Size = new System.Drawing.Size(139, 49);
            this.btnupdate.TabIndex = 3;
            this.btnupdate.Text = "Update";
            this.btnupdate.UseVisualStyleBackColor = false;
            this.btnupdate.Click += new System.EventHandler(this.btnupdate_Click);
            // 
            // lstboxcoachingclass
            // 
            this.lstboxcoachingclass.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstboxcoachingclass.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lstboxcoachingclass.FormattingEnabled = true;
            this.lstboxcoachingclass.ItemHeight = 39;
            this.lstboxcoachingclass.Items.AddRange(new object[] {
            "C# Programming ",
            "C Programming",
            "C++ Programming",
            "Python Programming",
            "Java Script Programming",
            "SQL Programming"});
            this.lstboxcoachingclass.Location = new System.Drawing.Point(1473, 209);
            this.lstboxcoachingclass.Name = "lstboxcoachingclass";
            this.lstboxcoachingclass.Size = new System.Drawing.Size(320, 43);
            this.lstboxcoachingclass.TabIndex = 5;
            // 
            // txtmoduleid
            // 
            this.txtmoduleid.Location = new System.Drawing.Point(352, 77);
            this.txtmoduleid.Name = "txtmoduleid";
            this.txtmoduleid.Size = new System.Drawing.Size(143, 31);
            this.txtmoduleid.TabIndex = 6;
            // 
            // txtcharges
            // 
            this.txtcharges.Location = new System.Drawing.Point(560, 77);
            this.txtcharges.Name = "txtcharges";
            this.txtcharges.Size = new System.Drawing.Size(130, 31);
            this.txtcharges.TabIndex = 7;
            // 
            // lblid
            // 
            this.lblid.AutoSize = true;
            this.lblid.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblid.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lblid.Location = new System.Drawing.Point(345, 22);
            this.lblid.Name = "lblid";
            this.lblid.Size = new System.Drawing.Size(150, 39);
            this.lblid.TabIndex = 9;
            this.lblid.Text = "ModuleID";
            // 
            // txtduration
            // 
            this.txtduration.Location = new System.Drawing.Point(762, 79);
            this.txtduration.Name = "txtduration";
            this.txtduration.Size = new System.Drawing.Size(133, 31);
            this.txtduration.TabIndex = 11;
            // 
            // txtintake
            // 
            this.txtintake.Location = new System.Drawing.Point(985, 80);
            this.txtintake.Name = "txtintake";
            this.txtintake.Size = new System.Drawing.Size(131, 31);
            this.txtintake.TabIndex = 12;
            // 
            // btndelete
            // 
            this.btndelete.BackColor = System.Drawing.Color.Salmon;
            this.btndelete.Font = new System.Drawing.Font("Bahnschrift", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndelete.ForeColor = System.Drawing.Color.Firebrick;
            this.btndelete.Location = new System.Drawing.Point(1504, 575);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(139, 49);
            this.btndelete.TabIndex = 18;
            this.btndelete.Text = "Delete";
            this.btndelete.UseVisualStyleBackColor = false;
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
            // 
            // txtclasslevel
            // 
            this.txtclasslevel.Location = new System.Drawing.Point(1504, 377);
            this.txtclasslevel.Name = "txtclasslevel";
            this.txtclasslevel.ReadOnly = true;
            this.txtclasslevel.Size = new System.Drawing.Size(139, 31);
            this.txtclasslevel.TabIndex = 19;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.AliceBlue;
            this.panel1.Controls.Add(this.btnfeedback);
            this.panel1.Controls.Add(this.btnHome);
            this.panel1.Controls.Add(this.btnSch);
            this.panel1.Controls.Add(this.btnPro);
            this.panel1.Controls.Add(this.btnLog);
            this.panel1.Controls.Add(this.btnPay);
            this.panel1.Controls.Add(this.picLogo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(315, 833);
            this.panel1.TabIndex = 20;
            // 
            // btnfeedback
            // 
            this.btnfeedback.BackColor = System.Drawing.Color.Transparent;
            this.btnfeedback.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnfeedback.FlatAppearance.BorderSize = 0;
            this.btnfeedback.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnfeedback.Font = new System.Drawing.Font("Bahnschrift", 9.75F);
            this.btnfeedback.ForeColor = System.Drawing.Color.RoyalBlue;
            this.btnfeedback.Image = ((System.Drawing.Image)(resources.GetObject("btnfeedback.Image")));
            this.btnfeedback.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnfeedback.Location = new System.Drawing.Point(3, 432);
            this.btnfeedback.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnfeedback.Name = "btnfeedback";
            this.btnfeedback.Size = new System.Drawing.Size(299, 99);
            this.btnfeedback.TabIndex = 66;
            this.btnfeedback.Text = "FEEDBACK";
            this.btnfeedback.UseVisualStyleBackColor = false;
            this.btnfeedback.Click += new System.EventHandler(this.btnfeedback_Click);
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
            this.btnHome.Location = new System.Drawing.Point(3, 139);
            this.btnHome.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(299, 99);
            this.btnHome.TabIndex = 65;
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
            this.btnSch.Location = new System.Drawing.Point(4, 242);
            this.btnSch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSch.Name = "btnSch";
            this.btnSch.Size = new System.Drawing.Size(299, 99);
            this.btnSch.TabIndex = 61;
            this.btnSch.Text = "SCHEDULE";
            this.btnSch.UseVisualStyleBackColor = false;
            this.btnSch.Click += new System.EventHandler(this.btnSch_Click);
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
            this.btnPro.Location = new System.Drawing.Point(3, 609);
            this.btnPro.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnPro.Name = "btnPro";
            this.btnPro.Size = new System.Drawing.Size(299, 99);
            this.btnPro.TabIndex = 64;
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
            this.btnLog.Location = new System.Drawing.Point(4, 703);
            this.btnLog.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLog.Name = "btnLog";
            this.btnLog.Size = new System.Drawing.Size(308, 119);
            this.btnLog.TabIndex = 63;
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
            this.btnPay.Location = new System.Drawing.Point(3, 329);
            this.btnPay.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnPay.Name = "btnPay";
            this.btnPay.Size = new System.Drawing.Size(299, 99);
            this.btnPay.TabIndex = 62;
            this.btnPay.Text = "PAYMENT";
            this.btnPay.UseVisualStyleBackColor = false;
            this.btnPay.Click += new System.EventHandler(this.btnPay_Click);
            // 
            // picLogo
            // 
            this.picLogo.BackColor = System.Drawing.Color.AliceBlue;
            this.picLogo.Image = ((System.Drawing.Image)(resources.GetObject("picLogo.Image")));
            this.picLogo.Location = new System.Drawing.Point(0, -2);
            this.picLogo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(315, 125);
            this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picLogo.TabIndex = 60;
            this.picLogo.TabStop = false;
            // 
            // lblcharges
            // 
            this.lblcharges.AutoSize = true;
            this.lblcharges.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcharges.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lblcharges.Location = new System.Drawing.Point(553, 24);
            this.lblcharges.Name = "lblcharges";
            this.lblcharges.Size = new System.Drawing.Size(137, 39);
            this.lblcharges.TabIndex = 21;
            this.lblcharges.Text = "Charges";
            // 
            // lblday
            // 
            this.lblday.AutoSize = true;
            this.lblday.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblday.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lblday.Location = new System.Drawing.Point(1463, 48);
            this.lblday.Name = "lblday";
            this.lblday.Size = new System.Drawing.Size(70, 39);
            this.lblday.TabIndex = 22;
            this.lblday.Text = "Day";
            // 
            // lblduration
            // 
            this.lblduration.AutoSize = true;
            this.lblduration.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblduration.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lblduration.Location = new System.Drawing.Point(755, 24);
            this.lblduration.Name = "lblduration";
            this.lblduration.Size = new System.Drawing.Size(140, 39);
            this.lblduration.TabIndex = 23;
            this.lblduration.Text = "Duration";
            // 
            // lblintake
            // 
            this.lblintake.AutoSize = true;
            this.lblintake.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblintake.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lblintake.Location = new System.Drawing.Point(980, 24);
            this.lblintake.Name = "lblintake";
            this.lblintake.Size = new System.Drawing.Size(105, 39);
            this.lblintake.TabIndex = 24;
            this.lblintake.Text = "Intake";
            // 
            // lstday
            // 
            this.lstday.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstday.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lstday.FormattingEnabled = true;
            this.lstday.ItemHeight = 39;
            this.lstday.Items.AddRange(new object[] {
            "Monday",
            "Tuesday",
            "Wednesday",
            "Thursday",
            "Friday"});
            this.lstday.Location = new System.Drawing.Point(1470, 90);
            this.lstday.Name = "lstday";
            this.lstday.Size = new System.Drawing.Size(320, 43);
            this.lstday.TabIndex = 25;
            // 
            // lblcoachingclass
            // 
            this.lblcoachingclass.AutoSize = true;
            this.lblcoachingclass.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcoachingclass.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lblcoachingclass.Location = new System.Drawing.Point(1463, 167);
            this.lblcoachingclass.Name = "lblcoachingclass";
            this.lblcoachingclass.Size = new System.Drawing.Size(120, 39);
            this.lblcoachingclass.TabIndex = 26;
            this.lblcoachingclass.Text = "Module";
            // 
            // txttrainername
            // 
            this.txttrainername.Location = new System.Drawing.Point(1504, 310);
            this.txttrainername.Name = "txttrainername";
            this.txttrainername.ReadOnly = true;
            this.txttrainername.Size = new System.Drawing.Size(139, 31);
            this.txttrainername.TabIndex = 27;
            // 
            // Trainer_Update_Information
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1805, 833);
            this.Controls.Add(this.txttrainername);
            this.Controls.Add(this.lblcoachingclass);
            this.Controls.Add(this.lstday);
            this.Controls.Add(this.lblintake);
            this.Controls.Add(this.lblduration);
            this.Controls.Add(this.lblday);
            this.Controls.Add(this.lblcharges);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtclasslevel);
            this.Controls.Add(this.btndelete);
            this.Controls.Add(this.txtintake);
            this.Controls.Add(this.txtduration);
            this.Controls.Add(this.lblid);
            this.Controls.Add(this.txtcharges);
            this.Controls.Add(this.txtmoduleid);
            this.Controls.Add(this.lstboxcoachingclass);
            this.Controls.Add(this.btnupdate);
            this.Controls.Add(this.listviewcoachingclass);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1831, 904);
            this.Name = "Trainer_Update_Information";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Update Coaching Class";
            this.Load += new System.EventHandler(this.Trainer_Update_Information_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListView listviewcoachingclass;
        private System.Windows.Forms.Button btnupdate;
        private System.Windows.Forms.ListBox lstboxcoachingclass;
        private System.Windows.Forms.TextBox txtmoduleid;
        private System.Windows.Forms.TextBox txtcharges;
        private System.Windows.Forms.ColumnHeader ModuleID;
        private System.Windows.Forms.ColumnHeader Modulename;
        private System.Windows.Forms.ColumnHeader ClassLevel;
        private System.Windows.Forms.ColumnHeader Charges;
        private System.Windows.Forms.ColumnHeader Day;
        private System.Windows.Forms.ColumnHeader Duration;
        private System.Windows.Forms.ColumnHeader Trainer;
        private System.Windows.Forms.ColumnHeader TrainerID;
        private System.Windows.Forms.ColumnHeader Intake;
        private System.Windows.Forms.Label lblid;
        private System.Windows.Forms.TextBox txtduration;
        private System.Windows.Forms.TextBox txtintake;
        private System.Windows.Forms.Button btndelete;
        private System.Windows.Forms.TextBox txtclasslevel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Button btnSch;
        private System.Windows.Forms.Button btnPro;
        private System.Windows.Forms.Button btnLog;
        private System.Windows.Forms.Button btnPay;
        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.Label lblcharges;
        private System.Windows.Forms.Label lblday;
        private System.Windows.Forms.Label lblduration;
        private System.Windows.Forms.Label lblintake;
        private System.Windows.Forms.ListBox lstday;
        private System.Windows.Forms.Label lblcoachingclass;
        private System.Windows.Forms.Button btnfeedback;
        private System.Windows.Forms.TextBox txttrainername;
    }
}