namespace Assignment_Student_
{
    partial class FrmPayment
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPayment));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.btnHome = new System.Windows.Forms.Button();
            this.btnSch = new System.Windows.Forms.Button();
            this.btnReq = new System.Windows.Forms.Button();
            this.btnPro = new System.Windows.Forms.Button();
            this.btnLog = new System.Windows.Forms.Button();
            this.btnPay = new System.Windows.Forms.Button();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.lblPro = new System.Windows.Forms.Label();
            this.gbInvoice = new System.Windows.Forms.GroupBox();
            this.lvPayment = new System.Windows.Forms.ListView();
            this.chStuID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chCLassL = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chModuleID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chModule = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chCharges = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chStatus = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnPaymentPay = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.gbInvoice.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
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
            this.splitContainer1.Panel2.Controls.Add(this.label6);
            this.splitContainer1.Panel2.Controls.Add(this.lblPro);
            this.splitContainer1.Panel2.Controls.Add(this.gbInvoice);
            this.splitContainer1.Size = new System.Drawing.Size(915, 480);
            this.splitContainer1.SplitterDistance = 201;
            this.splitContainer1.TabIndex = 0;
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
            this.btnSch.Font = new System.Drawing.Font("Bahnschrift", 9.75F);
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
            // label6
            // 
            this.label6.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label6.Font = new System.Drawing.Font("Bahnschrift", 11.25F);
            this.label6.Location = new System.Drawing.Point(1, 71);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(701, 2);
            this.label6.TabIndex = 32;
            // 
            // lblPro
            // 
            this.lblPro.AutoSize = true;
            this.lblPro.BackColor = System.Drawing.Color.White;
            this.lblPro.Font = new System.Drawing.Font("Bahnschrift", 18F, System.Drawing.FontStyle.Bold);
            this.lblPro.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lblPro.Location = new System.Drawing.Point(33, 20);
            this.lblPro.Name = "lblPro";
            this.lblPro.Size = new System.Drawing.Size(132, 36);
            this.lblPro.TabIndex = 33;
            this.lblPro.Text = "Payment";
            // 
            // gbInvoice
            // 
            this.gbInvoice.BackColor = System.Drawing.Color.White;
            this.gbInvoice.Controls.Add(this.lvPayment);
            this.gbInvoice.Controls.Add(this.btnPaymentPay);
            this.gbInvoice.Font = new System.Drawing.Font("Bahnschrift", 12F);
            this.gbInvoice.ForeColor = System.Drawing.Color.RoyalBlue;
            this.gbInvoice.Location = new System.Drawing.Point(25, 91);
            this.gbInvoice.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbInvoice.Name = "gbInvoice";
            this.gbInvoice.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbInvoice.Size = new System.Drawing.Size(653, 378);
            this.gbInvoice.TabIndex = 31;
            this.gbInvoice.TabStop = false;
            this.gbInvoice.Text = "Invoice";
            // 
            // lvPayment
            // 
            this.lvPayment.BackColor = System.Drawing.Color.White;
            this.lvPayment.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chStuID,
            this.chName,
            this.chCLassL,
            this.chModuleID,
            this.chModule,
            this.chCharges,
            this.chStatus});
            this.lvPayment.Font = new System.Drawing.Font("Bahnschrift", 9.75F);
            this.lvPayment.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lvPayment.FullRowSelect = true;
            this.lvPayment.GridLines = true;
            this.lvPayment.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lvPayment.HideSelection = false;
            this.lvPayment.Location = new System.Drawing.Point(14, 29);
            this.lvPayment.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lvPayment.Name = "lvPayment";
            this.lvPayment.Size = new System.Drawing.Size(628, 300);
            this.lvPayment.TabIndex = 29;
            this.lvPayment.UseCompatibleStateImageBehavior = false;
            this.lvPayment.View = System.Windows.Forms.View.Details;
            // 
            // chStuID
            // 
            this.chStuID.Text = "Student ID";
            this.chStuID.Width = 100;
            // 
            // chName
            // 
            this.chName.Text = "Name";
            this.chName.Width = 130;
            // 
            // chCLassL
            // 
            this.chCLassL.Text = "Class Level";
            this.chCLassL.Width = 130;
            // 
            // chModuleID
            // 
            this.chModuleID.Text = "Module ID";
            this.chModuleID.Width = 100;
            // 
            // chModule
            // 
            this.chModule.Text = "Module Name";
            this.chModule.Width = 130;
            // 
            // chCharges
            // 
            this.chCharges.Text = "Charges";
            this.chCharges.Width = 100;
            // 
            // chStatus
            // 
            this.chStatus.Text = "Stutus";
            this.chStatus.Width = 100;
            // 
            // btnPaymentPay
            // 
            this.btnPaymentPay.BackColor = System.Drawing.Color.Honeydew;
            this.btnPaymentPay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPaymentPay.Font = new System.Drawing.Font("Bahnschrift", 9.75F);
            this.btnPaymentPay.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.btnPaymentPay.Location = new System.Drawing.Point(541, 336);
            this.btnPaymentPay.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnPaymentPay.Name = "btnPaymentPay";
            this.btnPaymentPay.Size = new System.Drawing.Size(101, 31);
            this.btnPaymentPay.TabIndex = 28;
            this.btnPaymentPay.Text = "Pay";
            this.btnPaymentPay.UseVisualStyleBackColor = false;
            this.btnPaymentPay.Click += new System.EventHandler(this.brnPayPay_Click);
            // 
            // FrmPayment
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(915, 480);
            this.Controls.Add(this.splitContainer1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FrmPayment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Payment";
            this.Load += new System.EventHandler(this.FrmPayment_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.gbInvoice.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Button btnSch;
        private System.Windows.Forms.Button btnReq;
        private System.Windows.Forms.Button btnPro;
        private System.Windows.Forms.Button btnLog;
        private System.Windows.Forms.Button btnPay;
        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.Label lblPro;
        private System.Windows.Forms.GroupBox gbInvoice;
        private System.Windows.Forms.Button btnPaymentPay;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ListView lvPayment;
        private System.Windows.Forms.ColumnHeader chStuID;
        private System.Windows.Forms.ColumnHeader chCLassL;
        private System.Windows.Forms.ColumnHeader chModule;
        private System.Windows.Forms.ColumnHeader chStatus;
        private System.Windows.Forms.ColumnHeader chName;
        private System.Windows.Forms.ColumnHeader chModuleID;
        private System.Windows.Forms.ColumnHeader chCharges;
    }
}