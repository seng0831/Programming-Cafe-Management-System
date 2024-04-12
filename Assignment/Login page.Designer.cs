namespace Assignment_Student_
{
    partial class FrmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLogin));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.btnHide = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.lblLog = new System.Windows.Forms.Label();
            this.btnLogin = new System.Windows.Forms.Button();
            this.txtpass = new System.Windows.Forms.TextBox();
            this.lblPass = new System.Windows.Forms.Label();
            this.txtuser = new System.Windows.Forms.TextBox();
            this.lblUsername = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(4);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.Color.AliceBlue;
            this.splitContainer1.Panel1.Controls.Add(this.picLogo);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackColor = System.Drawing.Color.MintCream;
            this.splitContainer1.Panel2.Controls.Add(this.btnHide);
            this.splitContainer1.Panel2.Controls.Add(this.label6);
            this.splitContainer1.Panel2.Controls.Add(this.lblLog);
            this.splitContainer1.Panel2.Controls.Add(this.btnLogin);
            this.splitContainer1.Panel2.Controls.Add(this.txtpass);
            this.splitContainer1.Panel2.Controls.Add(this.lblPass);
            this.splitContainer1.Panel2.Controls.Add(this.txtuser);
            this.splitContainer1.Panel2.Controls.Add(this.lblUsername);
            this.splitContainer1.Size = new System.Drawing.Size(915, 480);
            this.splitContainer1.SplitterDistance = 334;
            this.splitContainer1.SplitterWidth = 5;
            this.splitContainer1.TabIndex = 0;
            // 
            // picLogo
            // 
            this.picLogo.BackColor = System.Drawing.Color.Transparent;
            this.picLogo.Image = ((System.Drawing.Image)(resources.GetObject("picLogo.Image")));
            this.picLogo.Location = new System.Drawing.Point(4, 177);
            this.picLogo.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(326, 105);
            this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picLogo.TabIndex = 40;
            this.picLogo.TabStop = false;
            // 
            // btnHide
            // 
            this.btnHide.AutoSize = true;
            this.btnHide.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnHide.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnHide.BackgroundImage")));
            this.btnHide.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnHide.FlatAppearance.BorderSize = 0;
            this.btnHide.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHide.Location = new System.Drawing.Point(473, 251);
            this.btnHide.Name = "btnHide";
            this.btnHide.Size = new System.Drawing.Size(31, 31);
            this.btnHide.TabIndex = 66;
            this.btnHide.UseVisualStyleBackColor = false;
            this.btnHide.Click += new System.EventHandler(this.btnHide_Click);
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label6.Font = new System.Drawing.Font("Bahnschrift", 11.25F);
            this.label6.Location = new System.Drawing.Point(26, 125);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(514, 2);
            this.label6.TabIndex = 65;
            // 
            // lblLog
            // 
            this.lblLog.AutoSize = true;
            this.lblLog.BackColor = System.Drawing.Color.White;
            this.lblLog.Font = new System.Drawing.Font("Bahnschrift", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLog.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lblLog.Location = new System.Drawing.Point(54, 68);
            this.lblLog.Name = "lblLog";
            this.lblLog.Size = new System.Drawing.Size(123, 45);
            this.lblLog.TabIndex = 64;
            this.lblLog.Text = "LOGIN";
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.Font = new System.Drawing.Font("Bahnschrift", 9.75F);
            this.btnLogin.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.btnLogin.Location = new System.Drawing.Point(392, 302);
            this.btnLogin.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(113, 37);
            this.btnLogin.TabIndex = 63;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnProUpdate_Click);
            // 
            // txtpass
            // 
            this.txtpass.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtpass.Font = new System.Drawing.Font("Bahnschrift", 12F);
            this.txtpass.Location = new System.Drawing.Point(216, 250);
            this.txtpass.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.txtpass.Name = "txtpass";
            this.txtpass.Size = new System.Drawing.Size(288, 32);
            this.txtpass.TabIndex = 62;
            this.txtpass.UseSystemPasswordChar = true;
            // 
            // lblPass
            // 
            this.lblPass.AutoSize = true;
            this.lblPass.Font = new System.Drawing.Font("Bahnschrift", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPass.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lblPass.Location = new System.Drawing.Point(56, 250);
            this.lblPass.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPass.Name = "lblPass";
            this.lblPass.Size = new System.Drawing.Size(142, 33);
            this.lblPass.TabIndex = 61;
            this.lblPass.Text = "Password:";
            // 
            // txtuser
            // 
            this.txtuser.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtuser.Font = new System.Drawing.Font("Bahnschrift", 12F);
            this.txtuser.Location = new System.Drawing.Point(216, 182);
            this.txtuser.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.txtuser.Name = "txtuser";
            this.txtuser.Size = new System.Drawing.Size(288, 32);
            this.txtuser.TabIndex = 60;
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Font = new System.Drawing.Font("Bahnschrift", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsername.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lblUsername.Location = new System.Drawing.Point(56, 180);
            this.lblUsername.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(144, 33);
            this.lblUsername.TabIndex = 50;
            this.lblUsername.Text = "Username:";
            // 
            // FrmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(915, 480);
            this.Controls.Add(this.splitContainer1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login_page";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.TextBox txtuser;
        private System.Windows.Forms.TextBox txtpass;
        private System.Windows.Forms.Label lblPass;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Label lblLog;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnHide;
    }
}