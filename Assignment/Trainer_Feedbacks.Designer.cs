﻿namespace Assignment_Trainer_
{
    partial class Trainer_Feedbacks
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
            System.Windows.Forms.Label lblsender;
            System.Windows.Forms.Label lblsenderid;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Trainer_Feedbacks));
            this.btnsend = new System.Windows.Forms.Button();
            this.lblfeedbacks = new System.Windows.Forms.Label();
            this.txtfeedbacks = new System.Windows.Forms.RichTextBox();
            this.txtsendername = new System.Windows.Forms.TextBox();
            this.txtsenderid = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnHome = new System.Windows.Forms.Button();
            this.btnSch = new System.Windows.Forms.Button();
            this.btnPro = new System.Windows.Forms.Button();
            this.btnLog = new System.Windows.Forms.Button();
            this.btnPay = new System.Windows.Forms.Button();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.btnfeedback = new System.Windows.Forms.Button();
            lblsender = new System.Windows.Forms.Label();
            lblsenderid = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // lblsender
            // 
            lblsender.AutoSize = true;
            lblsender.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblsender.ForeColor = System.Drawing.Color.RoyalBlue;
            lblsender.Location = new System.Drawing.Point(362, 74);
            lblsender.Name = "lblsender";
            lblsender.Size = new System.Drawing.Size(125, 39);
            lblsender.TabIndex = 8;
            lblsender.Text = "Sender:";
            // 
            // lblsenderid
            // 
            lblsenderid.AutoSize = true;
            lblsenderid.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblsenderid.ForeColor = System.Drawing.Color.RoyalBlue;
            lblsenderid.Location = new System.Drawing.Point(523, 74);
            lblsenderid.Name = "lblsenderid";
            lblsenderid.Size = new System.Drawing.Size(156, 39);
            lblsenderid.TabIndex = 13;
            lblsenderid.Text = "SenderID:";
            // 
            // btnsend
            // 
            this.btnsend.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnsend.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.btnsend.Location = new System.Drawing.Point(890, 615);
            this.btnsend.Name = "btnsend";
            this.btnsend.Size = new System.Drawing.Size(145, 82);
            this.btnsend.TabIndex = 10;
            this.btnsend.Text = "Send";
            this.btnsend.UseVisualStyleBackColor = false;
            this.btnsend.Click += new System.EventHandler(this.btnsend_Click);
            // 
            // lblfeedbacks
            // 
            this.lblfeedbacks.AutoSize = true;
            this.lblfeedbacks.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblfeedbacks.Location = new System.Drawing.Point(362, 218);
            this.lblfeedbacks.Name = "lblfeedbacks";
            this.lblfeedbacks.Size = new System.Drawing.Size(177, 39);
            this.lblfeedbacks.TabIndex = 9;
            this.lblfeedbacks.Text = "Feedbacks:";
            // 
            // txtfeedbacks
            // 
            this.txtfeedbacks.Location = new System.Drawing.Point(367, 306);
            this.txtfeedbacks.Name = "txtfeedbacks";
            this.txtfeedbacks.Size = new System.Drawing.Size(495, 391);
            this.txtfeedbacks.TabIndex = 6;
            this.txtfeedbacks.Text = "Please type your feedbacks here...";
            this.txtfeedbacks.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtfeedbacks_MouseClick);
            // 
            // txtsendername
            // 
            this.txtsendername.Location = new System.Drawing.Point(367, 130);
            this.txtsendername.Name = "txtsendername";
            this.txtsendername.ReadOnly = true;
            this.txtsendername.Size = new System.Drawing.Size(128, 31);
            this.txtsendername.TabIndex = 12;
            // 
            // txtsenderid
            // 
            this.txtsenderid.Location = new System.Drawing.Point(528, 130);
            this.txtsenderid.Name = "txtsenderid";
            this.txtsenderid.ReadOnly = true;
            this.txtsenderid.Size = new System.Drawing.Size(128, 31);
            this.txtsenderid.TabIndex = 14;
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
            this.panel1.Size = new System.Drawing.Size(350, 732);
            this.panel1.TabIndex = 15;
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
            this.btnHome.Location = new System.Drawing.Point(12, 137);
            this.btnHome.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(298, 86);
            this.btnHome.TabIndex = 53;
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
            this.btnSch.Location = new System.Drawing.Point(12, 227);
            this.btnSch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSch.Name = "btnSch";
            this.btnSch.Size = new System.Drawing.Size(298, 86);
            this.btnSch.TabIndex = 48;
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
            this.btnPro.Location = new System.Drawing.Point(15, 525);
            this.btnPro.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnPro.Name = "btnPro";
            this.btnPro.Size = new System.Drawing.Size(298, 86);
            this.btnPro.TabIndex = 52;
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
            this.btnLog.Location = new System.Drawing.Point(15, 615);
            this.btnLog.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLog.Name = "btnLog";
            this.btnLog.Size = new System.Drawing.Size(307, 106);
            this.btnLog.TabIndex = 51;
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
            this.btnPay.Location = new System.Drawing.Point(12, 306);
            this.btnPay.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnPay.Name = "btnPay";
            this.btnPay.Size = new System.Drawing.Size(298, 86);
            this.btnPay.TabIndex = 50;
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
            this.picLogo.Size = new System.Drawing.Size(344, 131);
            this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picLogo.TabIndex = 47;
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
            this.btnfeedback.Location = new System.Drawing.Point(15, 396);
            this.btnfeedback.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnfeedback.Name = "btnfeedback";
            this.btnfeedback.Size = new System.Drawing.Size(299, 99);
            this.btnfeedback.TabIndex = 67;
            this.btnfeedback.Text = "FEEDBACK";
            this.btnfeedback.UseVisualStyleBackColor = false;
            this.btnfeedback.Click += new System.EventHandler(this.btnfeedback_Click);
            // 
            // Trainer_Feedbacks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1066, 732);
            this.Controls.Add(this.txtsenderid);
            this.Controls.Add(lblsenderid);
            this.Controls.Add(this.txtsendername);
            this.Controls.Add(this.btnsend);
            this.Controls.Add(this.lblfeedbacks);
            this.Controls.Add(lblsender);
            this.Controls.Add(this.txtfeedbacks);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.Color.RoyalBlue;
            this.Name = "Trainer_Feedbacks";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Trainer_Feedbacks";
            this.Load += new System.EventHandler(this.Trainer_Feedbacks_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnsend;
        private System.Windows.Forms.Label lblfeedbacks;
        private System.Windows.Forms.RichTextBox txtfeedbacks;
        private System.Windows.Forms.TextBox txtsendername;
        private System.Windows.Forms.TextBox txtsenderid;
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