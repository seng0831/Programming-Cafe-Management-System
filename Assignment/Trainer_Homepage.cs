using Assignment_Student_;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment_Trainer_
{

    public partial class Trainer_Home : Form
    {

        public static string userID;



        public Trainer_Home(string id)
        {
            InitializeComponent();
            userID = id;
        }
        private void Trainer_Home_Load(object sender, EventArgs e)
        {

        }

        private void btnupdateinformation_Click(object sender, EventArgs e)
        {
            Trainer_Update_Information form1 = new Trainer_Update_Information(userID);
            form1.Show();
            this.Hide();
        }

        private void btnstudentlist_Click(object sender, EventArgs e)
        {
            Trainer_Student_List form2 = new Trainer_Student_List(userID);
            form2.Show();
            this.Hide();
        }

        private void btnfeedbacks_Click(object sender, EventArgs e)
        {
            Trainer_Feedbacks form3 = new Trainer_Feedbacks(userID);
            form3.Show();
            this.Hide();
        }

        private void btnprofile_Click(object sender, EventArgs e)
        {
            Trainer_Profile form4 = new Trainer_Profile(userID);
            form4.Show();
            this.Hide();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            FrmLogin loginform = new FrmLogin();
            loginform.Show();
            this.Hide();
        }
    }
}
