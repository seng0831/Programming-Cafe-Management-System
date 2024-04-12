using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment
{
    internal class LecturerRequest
    {
        private static string constring = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"C:\\Users\\Asus\\OneDrive - Asia Pacific University\\Desktop\\Projects\\IOOP Group Assignment Final Code Compilation\\Assignment\\Assignment.mdf\";Integrated Security=True;MultipleActiveResultSets=true";
        private int id;
        private string name;
        private string level;
        private string module;
        private string studentid;
        private string intake;
        public int ID
        {
            get { return id; }
            set { id = value; }
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public string Level
        {
            get { return level; }
            set { level = value; }
        }
        public string Module
        {
            get { return module; }
            set { module = value; }
        }
        public string StudentID
        {
            get { return studentid; }
            set { studentid = value; }
        }
        public string Intake
        {
            get { return intake; }
            set { intake = value; }
        }

        public LecturerRequest(int ID)
        {
            this.id = ID;
        }

        public LecturerRequest(int ID, string Name, string Level, string Module, string StudentID, string Intake)
        {
            this.id = ID;
            this.name = Name;
            this.level = Level;
            this.module = Module;
            this.studentid = StudentID;
            this.intake = Intake;
        }
        public int Reject()
        {
            int rows;
            SqlConnection con = new SqlConnection(constring);
            string query = "DELETE FROM Requests WHERE ID = '" + id + "'";
            SqlCommand cmd = new SqlCommand(query, con);
            con.Open();
            rows = cmd.ExecuteNonQuery();
            con.Close();
            return rows;
        }

        public int Approve()
        {
            string moduleid = "", charges = "", trainerid = "", email = "", contact = "", address = "", origin = "";
            int rows;
            SqlConnection con = new SqlConnection(constring);
            string readquery = "SELECT ModuleID, Charges, TrainerID FROM Schedule WHERE ModuleName = '" + module + "' and intake = '" + intake + "'";
            SqlCommand readcmd = new SqlCommand(readquery, con);
            con.Open();
            SqlDataReader reader = readcmd.ExecuteReader();
            while (reader.Read())
            {
                moduleid = (reader["ModuleID"].ToString());
                charges = (reader["Charges"].ToString());
                trainerid = (reader["TrainerID"].ToString());
            }
            string readquery2 = "SELECT Email, Contact, Address, Origin FROM Enroll WHERE StudentID = '" + studentid + "'";
            SqlCommand readcmd2 = new SqlCommand(readquery2, con);
            SqlDataReader reader2 = readcmd2.ExecuteReader();
            while (reader2.Read())
            {
                email = (reader2["Email"].ToString());
                contact = (reader2["Contact"].ToString());
                address = (reader2["Address"].ToString());
                origin = (reader2["Origin"].ToString());
            }
            string query = "INSERT INTO Payment (Name, ClassLevel, ModuleName, Status, StudentID, Charges, ModuleID, TrainerID) VALUES('" + name + "', '" + level + "', '" + module + "', 'UNPAID', '" + studentid + "', '" + charges + "', '" + moduleid + "', '" + trainerid + "');";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.ExecuteNonQuery();

            string query2 = "INSERT INTO Enroll (StudentID, Name, Email, Contact, Address, ClassLevel, Module, Intake, Origin) VALUES('" + studentid + "', '" + name + "', '" + email + "', '" + contact + "', '" + address + "', '" + level + "', '" + module + "', '" + intake + "', '" + origin + "');";
            SqlCommand cmd2 = new SqlCommand(query2, con);
            rows = cmd2.ExecuteNonQuery();
            con.Close();
            Reject();
            return rows;
        }
    }
}
