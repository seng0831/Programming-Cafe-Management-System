using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using Assignment_Student_;
using Assignment_Trainer_;
using Admin;

namespace Assignment
{
    internal class users
    {
        private string username;
        private string password;

        public string Username
        {
            get { return username; }
            set { username = value; }
        }

        public string Password
        {
            get { return password; }
            set { password = value; }
        }

        public users(string name, string password)
        {
            this.username = name;
            this.password = password;
        }

        public string login(string un)
        {
            string status = null;
            string constring = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"C:\\Users\\Asus\\OneDrive - Asia Pacific University\\Desktop\\Projects\\IOOP Group Assignment Final Code Compilation\\Assignment\\Assignment.mdf\";Integrated Security=True";
            SqlConnection con = new SqlConnection(constring);
            con.Open();
            string sqlstring;

            sqlstring = "select count(*) from Login where Username='" + username + "' and Password='" + password + "'";

            // SqlCommand cmd = new SqlCommand("select count(*) from users where username='" + username + "' + and password='" + password + "'", con);
            SqlCommand cmd = new SqlCommand(sqlstring, con);

            int count = Convert.ToInt32(cmd.ExecuteScalar());
            status = username;
            if (count > 0)
            {
                SqlCommand cmd2 = new SqlCommand("select Role from Login where username='" + username + "' and password='" + password + "'", con);
                string role = cmd2.ExecuteScalar().ToString();

                if (role == "admin")
                {
                    frmRegisterTrainer adminform = new frmRegisterTrainer(status, password);
                    adminform.Show();
                }
                else if (role == "student")
                {
                    FrmHomeStudent studentform = new FrmHomeStudent(status, password);
                    studentform.Show();
                }
                else if(role == "lecturer")
                {
                    frmLecturer lecturerform = new frmLecturer(status);
                    lecturerform.Show();
                }
                else if(role == "trainer")
                {
                    Trainer_Home trainerform = new Trainer_Home(status);
                    trainerform.Show();
                }
            }
            else status = "Incorrect username/password";

            con.Close();
            return status;
        }
    }

}
