using Assignment;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Assignment_Student_
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void btnProUpdate_Click(object sender, EventArgs e)
        {
            string stat;
            users obj1 = new users(txtuser.Text, txtpass.Text);
            stat = obj1.login(txtuser.Text);
            if (stat == "Incorrect username/password")
            {
                MessageBox.Show(stat);
            }
            else
            {
                this.Hide();
            }
            txtuser.Text = String.Empty;
            txtpass.Text = String.Empty;
        }


        private void btnHide_Click(object sender, EventArgs e)
        {
            if (txtpass.UseSystemPasswordChar)
            {
                txtpass.UseSystemPasswordChar = false;
            }
            else
            {
                txtpass.UseSystemPasswordChar = true;
            }
        }
    }
}
