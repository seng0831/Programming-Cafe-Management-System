using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Admin
{
    internal class adminRegister
    {
        private static string conString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"C:\\Users\\Asus\\OneDrive - Asia Pacific University\\Desktop\\Projects\\IOOP Group Assignment Final Code Compilation\\Assignment\\Assignment.mdf\";Integrated Security=True";

        private string trainerid;
        private string income;
        private string trainer;
        private string level;

        public string TrainerID
        {
            get { return trainerid; }
            set { trainerid = value; }
        }

        public string Income
        { 
            get { return income; } 
            set { income = value; } 
        }

        public string Trainer
        {
            get { return trainer; }
            set { trainer = value; }
        }  
        
        public string Level
        {
            get { return level; }
            set { level = value; }
        }

        public adminRegister(string trainerid, string income, string trainer, string level)
        {
            this.TrainerID = trainerid;
            this.Income = income;
            this.Trainer = trainer;
            this.Level = level;
        }

        public adminRegister(string trainerid)
        {
            this.TrainerID = trainerid;
        }

        public int register(string trainerid, string income, string trainer, string level)
        {
            using (SqlConnection connection = new SqlConnection(conString))
            {
                string query = "INSERT INTO Trainer (TrainerID, Income, Trainer, Level) VALUES (@TrainerID, @Income, @Trainer, @Level)";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@TrainerID", trainerid);
                    command.Parameters.AddWithValue("@Income", income);
                    command.Parameters.AddWithValue("@Trainer", trainer);
                    command.Parameters.AddWithValue("@Level", level);

                    connection.Open();
                    int rowsAffected = command.ExecuteNonQuery();

                    return rowsAffected;
                }
            }
        }

        public int delete(string trainerid)
        {
            int rowsAffected = 0;

            using (SqlConnection connection = new SqlConnection(conString))
            {
                string query = "DELETE FROM Trainer WHERE TrainerID = @TrainerID";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@TrainerID", trainerid);

                    connection.Open();
                    rowsAffected = command.ExecuteNonQuery();
                    connection.Close();
                }
            }
            return rowsAffected;
        }
        
    }
}
