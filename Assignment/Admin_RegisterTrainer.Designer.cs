namespace Admin
{
    partial class frmRegisterTrainer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRegisterTrainer));
            this.lvAdmin = new System.Windows.Forms.ListView();
            this.chTrainerID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chIncome = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chTrainer = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chFeedback = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chLevel = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnRegister = new System.Windows.Forms.Button();
            this.txtTrainerID = new System.Windows.Forms.TextBox();
            this.txtIncome = new System.Windows.Forms.TextBox();
            this.txtTrainer = new System.Windows.Forms.TextBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnView = new System.Windows.Forms.Button();
            this.cbLevel = new System.Windows.Forms.ComboBox();
            this.lblReqName = new System.Windows.Forms.Label();
            this.gbRegister = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblReqModule = new System.Windows.Forms.Label();
            this.lblClassL = new System.Windows.Forms.Label();
            this.gbTrainerInfo = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnTrainer = new System.Windows.Forms.Button();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.btnLog = new System.Windows.Forms.Button();
            this.btnPro = new System.Windows.Forms.Button();
            this.gbRegister.SuspendLayout();
            this.gbTrainerInfo.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // lvAdmin
            // 
            this.lvAdmin.BackColor = System.Drawing.Color.White;
            this.lvAdmin.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chTrainerID,
            this.chIncome,
            this.chTrainer,
            this.chFeedback,
            this.chLevel});
            this.lvAdmin.Font = new System.Drawing.Font("Bahnschrift", 9.75F);
            this.lvAdmin.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lvAdmin.FullRowSelect = true;
            this.lvAdmin.GridLines = true;
            this.lvAdmin.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lvAdmin.HideSelection = false;
            this.lvAdmin.Location = new System.Drawing.Point(6, 33);
            this.lvAdmin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lvAdmin.Name = "lvAdmin";
            this.lvAdmin.Size = new System.Drawing.Size(750, 228);
            this.lvAdmin.TabIndex = 12;
            this.lvAdmin.UseCompatibleStateImageBehavior = false;
            this.lvAdmin.View = System.Windows.Forms.View.Details;
            // 
            // chTrainerID
            // 
            this.chTrainerID.Text = "TrainerID";
            this.chTrainerID.Width = 85;
            // 
            // chIncome
            // 
            this.chIncome.Text = "Income";
            this.chIncome.Width = 68;
            // 
            // chTrainer
            // 
            this.chTrainer.Text = "Trainer";
            this.chTrainer.Width = 75;
            // 
            // chFeedback
            // 
            this.chFeedback.Text = "Feedback";
            this.chFeedback.Width = 118;
            // 
            // chLevel
            // 
            this.chLevel.Text = "Level";
            this.chLevel.Width = 184;
            // 
            // btnRegister
            // 
            this.btnRegister.Font = new System.Drawing.Font("Bahnschrift", 9.75F);
            this.btnRegister.Location = new System.Drawing.Point(607, 30);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(117, 29);
            this.btnRegister.TabIndex = 1;
            this.btnRegister.Text = "Register";
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // txtTrainerID
            // 
            this.txtTrainerID.Location = new System.Drawing.Point(22, 66);
            this.txtTrainerID.Name = "txtTrainerID";
            this.txtTrainerID.Size = new System.Drawing.Size(265, 32);
            this.txtTrainerID.TabIndex = 2;
            // 
            // txtIncome
            // 
            this.txtIncome.Location = new System.Drawing.Point(300, 65);
            this.txtIncome.Name = "txtIncome";
            this.txtIncome.Size = new System.Drawing.Size(265, 32);
            this.txtIncome.TabIndex = 2;
            // 
            // txtTrainer
            // 
            this.txtTrainer.Location = new System.Drawing.Point(22, 127);
            this.txtTrainer.Name = "txtTrainer";
            this.txtTrainer.Size = new System.Drawing.Size(265, 32);
            this.txtTrainer.TabIndex = 2;
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Salmon;
            this.btnDelete.Font = new System.Drawing.Font("Bahnschrift", 9.75F);
            this.btnDelete.ForeColor = System.Drawing.Color.Firebrick;
            this.btnDelete.Location = new System.Drawing.Point(607, 68);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(117, 29);
            this.btnDelete.TabIndex = 1;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnView
            // 
            this.btnView.Font = new System.Drawing.Font("Bahnschrift", 9.75F);
            this.btnView.Location = new System.Drawing.Point(586, 127);
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(157, 31);
            this.btnView.TabIndex = 4;
            this.btnView.Text = "View Feedback";
            this.btnView.UseVisualStyleBackColor = true;
            this.btnView.Click += new System.EventHandler(this.btnView_Click);
            // 
            // cbLevel
            // 
            this.cbLevel.FormattingEnabled = true;
            this.cbLevel.Items.AddRange(new object[] {
            "Beginner",
            "Intermediate",
            "Advance"});
            this.cbLevel.Location = new System.Drawing.Point(300, 126);
            this.cbLevel.Name = "cbLevel";
            this.cbLevel.Size = new System.Drawing.Size(265, 32);
            this.cbLevel.TabIndex = 5;
            // 
            // lblReqName
            // 
            this.lblReqName.AutoSize = true;
            this.lblReqName.Font = new System.Drawing.Font("Bahnschrift", 11.25F);
            this.lblReqName.Location = new System.Drawing.Point(18, 37);
            this.lblReqName.Name = "lblReqName";
            this.lblReqName.Size = new System.Drawing.Size(87, 23);
            this.lblReqName.TabIndex = 13;
            this.lblReqName.Text = "TrainerID";
            // 
            // gbRegister
            // 
            this.gbRegister.BackColor = System.Drawing.Color.MintCream;
            this.gbRegister.Controls.Add(this.label1);
            this.gbRegister.Controls.Add(this.btnView);
            this.gbRegister.Controls.Add(this.cbLevel);
            this.gbRegister.Controls.Add(this.btnDelete);
            this.gbRegister.Controls.Add(this.lblReqName);
            this.gbRegister.Controls.Add(this.lblReqModule);
            this.gbRegister.Controls.Add(this.btnRegister);
            this.gbRegister.Controls.Add(this.lblClassL);
            this.gbRegister.Controls.Add(this.txtTrainerID);
            this.gbRegister.Controls.Add(this.txtTrainer);
            this.gbRegister.Controls.Add(this.txtIncome);
            this.gbRegister.Font = new System.Drawing.Font("Bahnschrift", 12F);
            this.gbRegister.ForeColor = System.Drawing.Color.RoyalBlue;
            this.gbRegister.Location = new System.Drawing.Point(232, 9);
            this.gbRegister.Name = "gbRegister";
            this.gbRegister.Size = new System.Drawing.Size(762, 182);
            this.gbRegister.TabIndex = 14;
            this.gbRegister.TabStop = false;
            this.gbRegister.Text = "Register trainer";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift", 11.25F);
            this.label1.Location = new System.Drawing.Point(296, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 23);
            this.label1.TabIndex = 14;
            this.label1.Text = "Income";
            // 
            // lblReqModule
            // 
            this.lblReqModule.AutoSize = true;
            this.lblReqModule.Font = new System.Drawing.Font("Bahnschrift", 11.25F);
            this.lblReqModule.Location = new System.Drawing.Point(296, 101);
            this.lblReqModule.Name = "lblReqModule";
            this.lblReqModule.Size = new System.Drawing.Size(57, 23);
            this.lblReqModule.TabIndex = 5;
            this.lblReqModule.Text = "Level";
            // 
            // lblClassL
            // 
            this.lblClassL.AutoSize = true;
            this.lblClassL.Font = new System.Drawing.Font("Bahnschrift", 11.25F);
            this.lblClassL.Location = new System.Drawing.Point(18, 101);
            this.lblClassL.Name = "lblClassL";
            this.lblClassL.Size = new System.Drawing.Size(70, 23);
            this.lblClassL.TabIndex = 2;
            this.lblClassL.Text = "Trainer";
            // 
            // gbTrainerInfo
            // 
            this.gbTrainerInfo.BackColor = System.Drawing.Color.MintCream;
            this.gbTrainerInfo.Controls.Add(this.lvAdmin);
            this.gbTrainerInfo.Font = new System.Drawing.Font("Bahnschrift", 12F);
            this.gbTrainerInfo.ForeColor = System.Drawing.Color.RoyalBlue;
            this.gbTrainerInfo.Location = new System.Drawing.Point(232, 197);
            this.gbTrainerInfo.Name = "gbTrainerInfo";
            this.gbTrainerInfo.Size = new System.Drawing.Size(762, 266);
            this.gbTrainerInfo.TabIndex = 15;
            this.gbTrainerInfo.TabStop = false;
            this.gbTrainerInfo.Text = "Trainer information";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.AliceBlue;
            this.panel1.Controls.Add(this.btnTrainer);
            this.panel1.Controls.Add(this.picLogo);
            this.panel1.Controls.Add(this.btnLog);
            this.panel1.Controls.Add(this.btnPro);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(215, 475);
            this.panel1.TabIndex = 56;
            // 
            // btnTrainer
            // 
            this.btnTrainer.BackColor = System.Drawing.Color.Transparent;
            this.btnTrainer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnTrainer.FlatAppearance.BorderSize = 0;
            this.btnTrainer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTrainer.Font = new System.Drawing.Font("Bahnschrift", 9.75F);
            this.btnTrainer.ForeColor = System.Drawing.Color.RoyalBlue;
            this.btnTrainer.Image = ((System.Drawing.Image)(resources.GetObject("btnTrainer.Image")));
            this.btnTrainer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTrainer.Location = new System.Drawing.Point(12, 83);
            this.btnTrainer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnTrainer.Name = "btnTrainer";
            this.btnTrainer.Size = new System.Drawing.Size(197, 50);
            this.btnTrainer.TabIndex = 60;
            this.btnTrainer.Text = "Trainer List";
            this.btnTrainer.UseVisualStyleBackColor = false;
            this.btnTrainer.Click += new System.EventHandler(this.btnTrainer_Click);
            // 
            // picLogo
            // 
            this.picLogo.BackColor = System.Drawing.Color.AliceBlue;
            this.picLogo.Image = ((System.Drawing.Image)(resources.GetObject("picLogo.Image")));
            this.picLogo.Location = new System.Drawing.Point(12, 9);
            this.picLogo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(197, 70);
            this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picLogo.TabIndex = 56;
            this.picLogo.TabStop = false;
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
            this.btnLog.Location = new System.Drawing.Point(12, 414);
            this.btnLog.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLog.Name = "btnLog";
            this.btnLog.Size = new System.Drawing.Size(197, 50);
            this.btnLog.TabIndex = 55;
            this.btnLog.Text = "LOG OUT";
            this.btnLog.UseVisualStyleBackColor = false;
            this.btnLog.Click += new System.EventHandler(this.btnLog_Click);
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
            this.btnPro.Location = new System.Drawing.Point(12, 360);
            this.btnPro.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnPro.Name = "btnPro";
            this.btnPro.Size = new System.Drawing.Size(197, 50);
            this.btnPro.TabIndex = 54;
            this.btnPro.Text = "PROFILE";
            this.btnPro.UseVisualStyleBackColor = false;
            this.btnPro.Click += new System.EventHandler(this.btnPro_Click);
            // 
            // frmRegisterTrainer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1002, 475);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.gbTrainerInfo);
            this.Controls.Add(this.gbRegister);
            this.Name = "frmRegisterTrainer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin Trainer List";
            this.Load += new System.EventHandler(this.Admin_Load);
            this.gbRegister.ResumeLayout(false);
            this.gbRegister.PerformLayout();
            this.gbTrainerInfo.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lvAdmin;
        private System.Windows.Forms.ColumnHeader chTrainerID;
        private System.Windows.Forms.ColumnHeader chIncome;
        private System.Windows.Forms.ColumnHeader chTrainer;
        private System.Windows.Forms.ColumnHeader chFeedback;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.TextBox txtTrainerID;
        private System.Windows.Forms.TextBox txtIncome;
        private System.Windows.Forms.TextBox txtTrainer;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnView;
        private System.Windows.Forms.ColumnHeader chLevel;
        private System.Windows.Forms.ComboBox cbLevel;
        private System.Windows.Forms.Label lblReqName;
        private System.Windows.Forms.GroupBox gbRegister;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblReqModule;
        private System.Windows.Forms.Label lblClassL;
        private System.Windows.Forms.GroupBox gbTrainerInfo;
        private System.Windows.Forms.Button btnPro;
        private System.Windows.Forms.Button btnLog;
        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnTrainer;
    }
}

