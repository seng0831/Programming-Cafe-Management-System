using System;
using System.Data.SqlClient;
using System.Drawing;
using System.Reflection.Emit;
using System.Windows.Forms;
using System.Xml.Linq;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;


namespace Assignment_Student_
{
    internal class StudentRequest
    {
        private static string constring = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"C:\\Users\\Asus\\OneDrive - Asia Pacific University\\Desktop\\Projects\\IOOP Group Assignment Final Code Compilation\\Assignment\\Assignment.mdf\";Integrated Security=True";

        private string id;
        private string studentName;
        private string intake;
        private string classLevel;
        private string module;

        public string ID
        {
            get { return id; }
            set { id = value; }
        }

        public string Name
        {
            get { return studentName; }
            set { studentName = value; }
        }

        public string Intake
        {
            get { return intake; }
            set { intake = value; }
        }

        public string ClassLevel
        {
            get { return classLevel; }
            set { classLevel = value; }
        }

        public string Module
        {
            get { return module; }
            set { module = value; }
        }

        public StudentRequest(string id)
        {
            this.id = id;
        }

        public StudentRequest(string name, string intake, string classLevel, string module)
        {
            this.studentName = name;
            this.intake = intake;
            this.classLevel = classLevel;
            this.module = module;
        }

        public int Update(string name, string intake, string classLevel, string module)
        {
            int rowsAffected = 0;
            using (SqlConnection con = new SqlConnection(constring))
            {
                string query = "UPDATE Requests SET [Name] = @Name, [Intake] = @Intake, [ClassLevel] = @ClassLevel, [Modulename] = @Module WHERE [ID] = @ID";
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@ID", ID);
                    cmd.Parameters.AddWithValue("@Name", name);
                    cmd.Parameters.AddWithValue("@Intake", intake);
                    cmd.Parameters.AddWithValue("@ClassLevel", classLevel);
                    cmd.Parameters.AddWithValue("@Module", module);
                    con.Open();
                    rowsAffected = cmd.ExecuteNonQuery();
                }
            }
            return rowsAffected;
        }

        public int Remove(string id)
        {
            int rowAffected = 0;
            using (SqlConnection con = new SqlConnection(constring))
            {
                string query = "DELETE FROM Requests WHERE ID = @id";
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@id", id);
                    con.Open();
                    rowAffected = cmd.ExecuteNonQuery(); 
                }
            }
            return rowAffected;
        }

        public int Submit(string id,string name, string intake, string classLevel, string module)
        {
            int insertedID = 0;
            string query = "INSERT INTO Requests ([Name], [ClassLevel], [Modulename], [StudentID], [Intake]) OUTPUT INSERTED.ID VALUES (@Name, @ClassLevel, @Modulename, @stuID, @Intake)";
            using (SqlConnection con = new SqlConnection(constring))
            {
                SqlCommand cmd = new SqlCommand(query, con);
                con.Open();
                cmd.Parameters.AddWithValue("@stuID", id);
                cmd.Parameters.AddWithValue("@Name", name);
                cmd.Parameters.AddWithValue("@Intake", intake);
                cmd.Parameters.AddWithValue("@ClassLevel", classLevel);
                cmd.Parameters.AddWithValue("@Modulename", module);
                insertedID = (int)cmd.ExecuteScalar();
            }
            return insertedID;
        }
    }
}




