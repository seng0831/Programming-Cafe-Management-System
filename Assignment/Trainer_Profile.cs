using Assignment_Student_;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Assignment_Trainer_
{
    public partial class Trainer_Profile : Form
    {
        public static string userID;
        public static string username;
        public static string password;
        public static string role;
        public string classlevel;

        SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"C:\\Users\\Asus\\OneDrive - Asia Pacific University\\Desktop\\Projects\\IOOP Group Assignment Final Code Compilation\\Assignment\\Assignment.mdf\";Integrated Security=True");
        public static string constring = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"C:\\Users\\Asus\\OneDrive - Asia Pacific University\\Desktop\\Projects\\IOOP Group Assignment Final Code Compilation\\Assignment\\Assignment.mdf\";Integrated Security=True";
        public Trainer_Profile(string id)
        {
            InitializeComponent();
            userID = id;


        }

        public void RefreshList()
        {

            string query = "SELECT * FROM Login WHERE Username = '" + userID + "'";
            using (SqlCommand cmd = new SqlCommand(query, con))
            {
                cmd.Parameters.AddWithValue("@Username", userID);

                con.Open();

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read() && reader["Username"].ToString() == userID)
                    {
                        string retrievedUsername = reader["Username"].ToString();
                        string role = reader["Role"].ToString();
                        string name = reader["Name"].ToString();
                        string email = reader["Email"].ToString();
                        string contact = reader["Contact"].ToString();
                        string description = reader["Description"].ToString();

                        lblRole.Text = role;
                        lblUsername.Text = retrievedUsername;
                        lblName.Text = name;
                        lblEmail.Text = email;
                        lblContact.Text = contact;
                        txtDes.Text = description;

                        
                        string imagePath = "C:\\Users\\Asus\\OneDrive - Asia Pacific University\\Desktop\\Projects\\IOOP Group Assignment Final Code Compilation\\IOOP Assignment Profile\\trainer.png";
                        pbProPhoto.ImageLocation = imagePath;
                        
                    }
                }

                con.Close();
            }
        }

        public int UpdateDescription()
        {
            string newDes = txtDes.Text;
            int rowsaffected;

            SqlConnection con = new SqlConnection(constring);
            string query = "UPDATE Login SET Description = '" + newDes + "' WHERE Username = '" + userID + "'";

            SqlCommand cmd = new SqlCommand(query, con);
            con.Open();
            rowsaffected = cmd.ExecuteNonQuery();
            return rowsaffected;
        }
        public int ResetPassword()
        {
            string newpass = txtreset.Text;
            int rowsaffected;

            SqlConnection con = new SqlConnection(constring);
            string query = "UPDATE Login SET Password = '" + newpass + "' WHERE Username = '" + userID + "'";

            SqlCommand cmd = new SqlCommand(query, con);
            con.Open();
            rowsaffected = cmd.ExecuteNonQuery();
            return rowsaffected;
        }


        private void Trainer_Profile_Load(object sender, EventArgs e)
        {
            RefreshList();

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

        private void btnLog_Click(object sender, EventArgs e)
        {
            FrmLogin loginform = new FrmLogin();
            loginform.Show();
            this.Hide();
        }

        private void lblRole_Click(object sender, EventArgs e)
        {

        }

        private void btnProReset_Click(object sender, EventArgs e)
        {
            int rowsAffected;
            SqlConnection con = new SqlConnection(constring);

            rowsAffected = ResetPassword();

            if (rowsAffected > 0)
            {
                MessageBox.Show("Sucessfully Reset");
                txtreset.Clear();
            }
            else
            {
                MessageBox.Show("Unsucessfully Reset");
            }

        }


        private void btnfeedback_Click(object sender, EventArgs e)
        {
            Trainer_Feedbacks form4 = new Trainer_Feedbacks(userID);
            form4.Show();
            this.Hide();
        }

        private void btnPro_Click(object sender, EventArgs e)
        {
            Trainer_Profile form5 = new Trainer_Profile(userID);
            form5.Show();
            this.Hide();
        }

        private void btnDesUpdate_Click(object sender, EventArgs e)
        {
            string newDes = txtDes.Text;
            int rowsAffected;
            SqlConnection con = new SqlConnection(constring);

            rowsAffected = UpdateDescription();



            if (rowsAffected > 0)
            {
                MessageBox.Show("Sucessfully Update");
            }
            else
            {
                MessageBox.Show("Unsucessfully Update");
            }
        }
    }
}
