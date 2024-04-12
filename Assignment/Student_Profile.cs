using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.AxHost;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Assignment_Student_
{
    public partial class FrmProfile : Form
    {
        public static string username;
        public static string password;
        SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"C:\\Users\\Asus\\OneDrive - Asia Pacific University\\Desktop\\Projects\\IOOP Group Assignment Final Code Compilation\\Assignment\\Assignment.mdf\";Integrated Security=True");
        
        public FrmProfile(string userName, string pass)
        {
            InitializeComponent();
            username = userName;
            password = pass;
        }
        
        private void btnHome_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmHomeStudent f1 = new FrmHomeStudent(username, password);
            f1.Show();
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

        private void FrmProfile_Load(object sender, EventArgs e)
        {
            string query = "SELECT * FROM Login WHERE Username = @Username";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@Username", username);

            con.Open();
            SqlDataReader reader = cmd.ExecuteReader();

            if (reader.Read())
            {
                string retrievedUsername = reader["Username"].ToString();
                if (retrievedUsername == username)
                {
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

                    string imagePath = "C:\\Users\\Asus\\OneDrive - Asia Pacific University\\Desktop\\Projects\\IOOP Group Assignment Final Code Compilation\\IOOP Assignment Profile\\student.png";
                    pbProPhoto.Image = Image.FromFile(imagePath);
                }
             
            }
            reader.Close();
            con.Close();    
        }

        private void btnProReset_Click(object sender, EventArgs e)
        {
            string password= txtreset.Text;
            string uname = username;
            StudentProfile obj = new StudentProfile(password,uname);
            int rowsAffected = obj.ResetPass(password, uname);

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

        private void btnDesUpdate_Click(object sender, EventArgs e)
        {
            string des = txtDes.Text;
            string uname = username;
            StudentProfile obj = new StudentProfile(des, uname);
            int rowsAffected = obj.UpdateDes(des, uname);

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
