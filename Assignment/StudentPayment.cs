using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Assignment_Student_
{
    internal class StudentPayment
    {
        private static string constring = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"C:\\Users\\Asus\\OneDrive - Asia Pacific University\\Desktop\\Projects\\IOOP Group Assignment Final Code Compilation\\Assignment\\Assignment.mdf\";Integrated Security=True";

        private string stuid;
        private string uname;

        public string StudentID
        {
            get { return stuid; }
            set { stuid = value; }
        }

        public string Username
        {
            get { return uname; }
            set { uname = value; }
        }

        public StudentPayment(string stuid)
        {
            this.StudentID = stuid;
        }

        public int Pay(string stuid)
        {
            int rowsAffected = 0;
            using (SqlConnection con = new SqlConnection(constring))
            {
                string query = "UPDATE Payment SET [Status] = 'PAID' WHERE StudentID = @stuID";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@stuID", stuid);
                con.Open();
                rowsAffected = cmd.ExecuteNonQuery();
            }
            return rowsAffected;
        }
    }
}
