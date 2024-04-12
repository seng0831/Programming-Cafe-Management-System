using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_Trainer_
{
    internal class TrainerFeedback
    {
        private string feedback;
        private string trainerid;
        private string userid;
        public string Feedback
        {
            get { return feedback; }
            set { feedback = value; }
        }
        public string TrainerID
        {
            get { return trainerid; }
            set { trainerid = value; }
        }
        public string UserID
        {
            get { return userid; }
            set { userid = value; }
        }
        public static string constring = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"C:\\Users\\Asus\\OneDrive - Asia Pacific University\\Desktop\\Projects\\IOOP Group Assignment Final Code Compilation\\Assignment\\Assignment.mdf\";Integrated Security=True";

        public TrainerFeedback(string FeedBack, string Trainerid)
        {
            this.feedback = FeedBack;
            this.trainerid = Trainerid;
        }
        public TrainerFeedback(string userID)
        {
            this.userid = userID;
        }

        public int UpdateList()
        {
            int rowsaffected;
            SqlConnection con = new SqlConnection(constring);
            string query = "UPDATE Trainer SET Feedback = '" + feedback + "' WHERE TrainerID = '" + trainerid + "';";

            SqlCommand cmd = new SqlCommand(query, con);
            con.Open();
            rowsaffected = cmd.ExecuteNonQuery();
            return rowsaffected;
        }

        public string GetName()
        {
            string name = string.Empty;
            string query = "Select Trainer From Trainer where TrainerID = '" + userid + "'";
            using (SqlConnection con = new SqlConnection(constring))
            {
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@TrainerID", userid);

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
