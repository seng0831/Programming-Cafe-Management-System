using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Assignment_Student_
{
   
    public partial class FrmHomeStudent : Form
    {
        private static string username;
        private static string password;
        public FrmHomeStudent(string userName, string pass)
        {
            username = userName;
            password = pass;
            InitializeComponent();
        }

        private void btnSch_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmSchedule f2 = new FrmSchedule(username, password);
            f2.Show();
        }

        private void btnReq_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmRequest f3 = new FrmRequest(username,password);
            f3.Show();
        }

        private void btnPay_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmPayment f4 = new FrmPayment(username, password);
            f4.Show();
        }

        private void btnPro_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmProfile f5 = new FrmProfile(username, password);
            f5.Show();
        }


        private void btnLog_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmLogin f6 = new FrmLogin();
            f6.Show();
        }

    }
}
