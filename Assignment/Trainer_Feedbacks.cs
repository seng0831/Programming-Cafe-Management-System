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
using System.Xml.Linq;
using System.Data.SqlClient;
using System.Runtime.InteropServices.WindowsRuntime;
using Assignment_Student_;

namespace Assignment_Trainer_
{
    public partial class Trainer_Feedbacks : Form
    {
        public static string userID;

        private void updatelist()
        {
            string feedback = txtfeedbacks.Text;
            string trainerid = userID;
            int return1;

            TrainerFeedback obj = new TrainerFeedback(feedback, trainerid);
            return1 = obj.UpdateList();
            if (return1 >= 1)
            {
                MessageBox.Show("Update Successfully!");
            }
            else
            {
                MessageBox.Show("Update is unsuccessful! Error occurred");
            }

        }

        private void cleartext()
        {
            txtfeedbacks.Text = "";
        }

        public Trainer_Feedbacks(string id)
        {
            InitializeComponent();
            userID = id;
        }

        private void btnhomepage_Click(object sender, EventArgs e)
        {
            Trainer_Home form1 = new Trainer_Home(userID);
            form1.Show();
            this.Hide();
        }

        private void Trainer_Feedbacks_Load(object sender, EventArgs e)
        {
            string name_return;
            txtsenderid.Text = userID.ToString();
            
            TrainerFeedback obj1 = new TrainerFeedback(userID);
            name_return = obj1.GetName();
            txtsendername.Text = name_return.ToString();
        }

        private void btnsend_Click(object sender, EventArgs e)
        {
            updatelist();
            cleartext();
        }

        private void txtfeedbacks_MouseClick(object sender, MouseEventArgs e)
        {
            cleartext();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            Trainer_Home form1 = new Trainer_Home(userID);
            form1.Show();
            this.Hide();
        }

        private void btnSch_Click(object sender, EventArgs e)
        {
            Trainer_Update_Information form2 = new Trainer_Update_Information();
            form2.Show();
            this.Hide();
        }

        private void btnPay_Click(object sender, EventArgs e)
        {
            Trainer_Student_List form3 = new Trainer_Student_List(userID);
            form3.Show();
            this.Hide();
        }

        private void btnPro_Click(object sender, EventArgs e)
        {
            Trainer_Profile form4 = new Trainer_Profile(userID);
            form4.Show();
            this.Hide();
        }

        private void btnLog_Click(object sender, EventArgs e)
        {
            FrmLogin loginform = new FrmLogin();
            loginform.Show();
            this.Hide();
        }

        private void btnfeedback_Click(object sender, EventArgs e)
        {
            Trainer_Feedbacks form4 = new Trainer_Feedbacks(userID);
            form4.Show();
            this.Hide();
        }
    }
}
