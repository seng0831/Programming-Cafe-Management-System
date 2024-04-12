using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment_Trainer_
{
    internal class TrainerUpdateInformation
    {
        private string userid;
        private string classlevel;
        private string trainername;

        private string userID
        {
            get { return userid; }
            set { userid = value; }
        }
        private string ClassLevel
        {
            get { return classlevel; }
            set { classlevel = value; }
        }
        private string TrainerName
        {
            get { return trainername; }
            set { trainername = value; }
        }

        public static string constring = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"C:\\Users\\Asus\\OneDrive - Asia Pacific University\\Desktop\\Projects\\IOOP Group Assignment Final Code Compilation\\Assignment\\Assignment.mdf\";Integrated Security=True";

        public TrainerUpdateInformation(string userID, string classlevel)
        {
            this.userid = userID;   
            this.classlevel = ClassLevel;
        }
        public TrainerUpdateInformation(string trainername)
        {
            this.trainername = TrainerName;
        }
        public string GetClassLevel()
        {
            string classlevel = string.Empty;
            string query = "Select Level From Trainer where TrainerID = '" + userid + "'";
            using (SqlConnection con = new SqlConnection(constring))
            {
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    con.Open();
                    SqlDataReader reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {
                        classlevel = reader["Level"].ToString();
                    }

                    reader.Close();
                }
            }

            return classlevel;
        }

        public string GetName()
        {
            string name = string.Empty;
            string query = "Select Trainer From Trainer where TrainerID = '" + userid + "'";
            using (SqlConnection con = new SqlConnection(constring))
            {
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    con.Open();
                    SqlDataReader reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {
                        name = reader["Trainer"].ToString();
                    }

                    reader.Close();
                }
            }

            return name;
        }

    }
    
}
