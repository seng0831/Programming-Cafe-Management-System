namespace Assignment_Trainer_
{
    partial class Trainer_Student_List
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Trainer_Student_List));
            this.lstviewstudentlist = new System.Windows.Forms.ListView();
            this.btnasc = new System.Windows.Forms.Button();
            this.btnpaidonly = new System.Windows.Forms.Button();
            this.btnunpaidonly = new System.Windows.Forms.Button();
            this.btnrefresh = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnHome = new System.Windows.Forms.Button();
            this.btnSch = new System.Windows.Forms.Button();
            this.btnPro = new System.Windows.Forms.Button();
            this.btnLog = new System.Windows.Forms.Button();
            this.btnPay = new System.Windows.Forms.Button();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.btnfeedback = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // lstviewstudentlist
            // 
            this.lstviewstudentlist.HideSelection = false;
            this.lstviewstudentlist.Location = new System.Drawing.Point(317, 45);
            this.lstviewstudentlist.Name = "lstviewstudentlist";
            this.lstviewstudentlist.Size = new System.Drawing.Size(845, 724);
            this.lstviewstudentlist.TabIndex = 0;
            this.lstviewstudentlist.UseCompatibleStateImageBehavior = false;
            this.lstviewstudentlist.SelectedIndexChanged += new System.EventHandler(this.lstviewstudentlist_SelectedIndexChanged);
            // 
            // btnasc
            // 
            this.btnasc.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnasc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnasc.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.btnasc.Location = new System.Drawing.Point(1191, 133);
            this.btnasc.Name = "btnasc";
            this.btnasc.Size = new System.Drawing.Size(168, 50);
            this.btnasc.TabIndex = 4;
            this.btnasc.Text = "A-Z";
            this.btnasc.UseVisualStyleBackColor = false;
            this.btnasc.Click += new System.EventHandler(this.btnasc_Click);
            // 
            // btnpaidonly
            // 
            this.btnpaidonly.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnpaidonly.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnpaidonly.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.btnpaidonly.Location = new System.Drawing.Point(1191, 629);
            this.btnpaidonly.Name = "btnpaidonly";
            this.btnpaidonly.Size = new System.Drawing.Size(168, 52);
            this.btnpaidonly.TabIndex = 13;
            this.btnpaidonly.Text = "PAID ONLY";
            this.btnpaidonly.UseVisualStyleBackColor = false;
            this.btnpaidonly.Click += new System.EventHandler(this.btnpaidonly_Click);
            // 
            // btnunpaidonly
            // 
            this.btnunpaidonly.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnunpaidonly.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnunpaidonly.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.btnunpaidonly.Location = new System.Drawing.Point(1191, 718);
            this.btnunpaidonly.Name = "btnunpaidonly";
            this.btnunpaidonly.Size = new System.Drawing.Size(168, 52);
            this.btnunpaidonly.TabIndex = 14;
            this.btnunpaidonly.Text = "UNPAID ONLY";
            this.btnunpaidonly.UseVisualStyleBackColor = false;
            this.btnunpaidonly.Click += new System.EventHandler(this.btnunpaidonly_Click);
            // 
            // btnrefresh
            // 
            this.btnrefresh.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnrefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnrefresh.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.btnrefresh.Location = new System.Drawing.Point(1191, 45);
            this.btnrefresh.Name = "btnrefresh";
            this.btnrefresh.Size = new System.Drawing.Size(168, 50);
            this.btnrefresh.TabIndex = 15;
            this.btnrefresh.Text = "Refresh";
            this.btnrefresh.UseVisualStyleBackColor = false;
            this.btnrefresh.Click += new System.EventHandler(this.btnrefresh_Click);
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
            this.panel1.Size = new System.Drawing.Size(298, 794);
            this.panel1.TabIndex = 16;
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
            this.btnHome.Location = new System.Drawing.Point(3, 141);
            this.btnHome.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(308, 83);
            this.btnHome.TabIndex = 71;
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
            this.btnSch.Location = new System.Drawing.Point(3, 228);
            this.btnSch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSch.Name = "btnSch";
            this.btnSch.Size = new System.Drawing.Size(306, 76);
            this.btnSch.TabIndex = 67;
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
            this.btnPro.Location = new System.Drawing.Point(4, 596);
            this.btnPro.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnPro.Name = "btnPro";
            this.btnPro.Size = new System.Drawing.Size(305, 78);
            this.btnPro.TabIndex = 70;
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
            this.btnLog.Location = new System.Drawing.Point(4, 691);
            this.btnLog.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLog.Name = "btnLog";
            this.btnLog.Size = new System.Drawing.Size(306, 78);
            this.btnLog.TabIndex = 69;
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
            this.btnPay.Location = new System.Drawing.Point(3, 308);
            this.btnPay.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnPay.Name = "btnPay";
            this.btnPay.Size = new System.Drawing.Size(306, 86);
            this.btnPay.TabIndex = 68;
            this.btnPay.Text = "PAYMENT";
            this.btnPay.UseVisualStyleBackColor = false;
            this.btnPay.Click += new System.EventHandler(this.btnPay_Click);
            // 
            // picLogo
            // 
            this.picLogo.BackColor = System.Drawing.Color.AliceBlue;
            this.picLogo.Image = ((System.Drawing.Image)(resources.GetObject("picLogo.Image")));
            this.picLogo.Location = new System.Drawing.Point(0, 2);
            this.picLogo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(309, 116);
            this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picLogo.TabIndex = 66;
            this.picLogo.TabStop = false;
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
            this.btnfeedback.Location = new System.Drawing.Point(4, 385);
            this.btnfeedback.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnfeedback.Name = "btnfeedback";
            this.btnfeedback.Size = new System.Drawing.Size(299, 99);
            this.btnfeedback.TabIndex = 67;
            this.btnfeedback.Text = "FEEDBACK";
            this.btnfeedback.UseVisualStyleBackColor = false;
            this.btnfeedback.Click += new System.EventHandler(this.btnfeedback_Click);
            // 
            // Trainer_Student_List
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1455, 794);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnrefresh);
            this.Controls.Add(this.btnunpaidonly);
            this.Controls.Add(this.btnpaidonly);
            this.Controls.Add(this.btnasc);
            this.Controls.Add(this.lstviewstudentlist);
            this.Name = "Trainer_Student_List";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Trainer_Student_List";
            this.Load += new System.EventHandler(this.Trainer_Student_List_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lstviewstudentlist;
        private System.Windows.Forms.Button btnasc;
        private System.Windows.Forms.Button btnpaidonly;
        private System.Windows.Forms.Button btnunpaidonly;
        private System.Windows.Forms.Button btnrefresh;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Button btnSch;
        private System.Windows.Forms.Button btnPro;
        private System.Windows.Forms.Button btnLog;
        private System.Windows.Forms.Button btnPay;
        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.Button btnfeedback;
    }
}