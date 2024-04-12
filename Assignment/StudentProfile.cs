using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Assignment_Student_
{
    internal class StudentProfile
    {
        private static string constring = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"C:\\Users\\Asus\\OneDrive - Asia Pacific University\\Desktop\\Projects\\IOOP Group Assignment Final Code Compilation\\Assignment\\Assignment.mdf\";Integrated Security=True";

        private string password;
        private string uname;
        private string description;

        public string Password
        {
            get { return password; }
            set { password = value; }
        }

        public string Username
        {
            get { return uname; }
            set { uname = value; }
        }

        public string des
        {
            get { return description; }
            set { description = value; }
        }

        public StudentProfile(string password, string uname)
        {
            this.Password = password;
            this.uname = uname;
        }

        public StudentProfile(string description)
        {
            this.des=description;
        }

        public int ResetPass(string password, string uname)
        {
            int rowsAffected = 0;
            using (SqlConnection con= new SqlConnection(constring))
            {
                string query = "UPDATE Login SET [Password] = @pass WHERE [Username]=@user";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@pass", password);
                cmd.Parameters.AddWithValue("@user", uname);
                con.Open();
                rowsAffected = cmd.ExecuteNonQuery();
                con.Close();
            }
            return rowsAffected;
        }

        public int UpdateDes(string des, string uname)
        {
            int rowsAffected = 0;
            using (SqlConnection con = new SqlConnection(constring))
            {
                string query = "UPDATE Login SET [Description] = @des WHERE [Username]=@user";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@des", des);
                cmd.Parameters.AddWithValue("@user", uname);

                con.Open();
                rowsAffected = cmd.ExecuteNonQuery();
                con.Close();
            }
            return rowsAffected;
        }
    }
}
