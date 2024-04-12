using Admin;
using Assignment_Student_;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Assignment
{
    public partial class frmAdminProfile : Form
    {
        public static string username;
        public static string password;
        SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"C:\\Users\\Asus\\OneDrive - Asia Pacific University\\Desktop\\Projects\\IOOP Group Assignment Final Code Compilation\\Assignment\\Assignment.mdf\";Integrated Security=True");

        public frmAdminProfile(string userName, string pass)
        {
            InitializeComponent();
            username = userName;
            password = pass;
        }

        private void btnDesUpdate_Click(object sender, EventArgs e)
        {
            string newDes = txtDes.Text;

            string query = "UPDATE Login SET [Description] = @des WHERE [Username]=@user";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@des", newDes);
            cmd.Parameters.AddWithValue("@user", username);

            con.Open();
            int rowsAffected = cmd.ExecuteNonQuery();
            con.Close();

            if (rowsAffected > 0)
            {
                MessageBox.Show("Sucessfully Update");
            }
            else
            {
                MessageBox.Show("Unsucessfully Update");
            }

        }

        private void frmAdminProfile_Load(object sender, EventArgs e)
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


                    string imagePath = "C:\\Users\\Asus\\OneDrive - Asia Pacific University\\Desktop\\Projects\\IOOP Group Assignment Final Code Compilation\\IOOP Assignment Profile\\admin.png";
                    pbProPhoto.Image = Image.FromFile(imagePath);
                }
            }
            reader.Close();
            con.Close();

        }

        private void btnProReset_Click(object sender, EventArgs e)
        {
            string newpass = txtreset.Text;

            string query = "UPDATE Login SET [Password] = @pass WHERE [Username]=@user";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@pass", newpass);
            cmd.Parameters.AddWithValue("@user", username);

            con.Open();
            int rowsAffected = cmd.ExecuteNonQuery();
            con.Close();

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

        private void btnPro_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Show();
        }

        private void btnLog_Click(object sender, EventArgs e)
        {
            FrmLogin loginform = new FrmLogin();
            loginform.Show();
            this.Hide();
        }

        private void btnTrainer_Click(object sender, EventArgs e)
        {
            frmRegisterTrainer registerform = new frmRegisterTrainer(username, password);
            registerform.Show();
            this.Hide();
        }
    }
}
