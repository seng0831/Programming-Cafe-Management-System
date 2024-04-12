using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Assignment
{
    internal class LecturerEnroll
    {
        private int id;
        private string level;
        private string module;
        private string intake;
        private string origin;
        private string contact;
        private string address;
        private string tpnum;
        private string name;
        private string email;

        public int ID
        {
            get { return id; }
            set { id = value; }
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

        public string Intake
        {
            get { return intake; }
            set { intake = value; }
        }

        public string Origin
        {
            get { return origin; }
            set { origin = value; }
        }
        public string Contact
        {
            get { return contact; }
            set { contact = value; }
        }

        public string Address
        {
            get { return address; }
            set { address = value; }
        }

        public string TPNum
        {
            get { return tpnum; }
            set { tpnum = value; }
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        public LecturerEnroll()
        {

        }

        public LecturerEnroll(string TPNum, string Name, string Email, string Contact, string Address, string Intake, string Origin, string Level, string Module)
        {
            this.tpnum = TPNum;
            this.name = Name;
            this.email = Email;
            this.contact = Contact;
            this.address = Address;
            this.intake = Intake;
            this.origin = Origin;
            this.level = Level;
            this.module = Module;
        }

        private static string constring = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"C:\\Users\\Asus\\OneDrive - Asia Pacific University\\Desktop\\Projects\\IOOP Group Assignment Final Code Compilation\\Assignment\\Assignment.mdf\";Integrated Security=True;MultipleActiveResultSets=true";
        public LecturerEnroll(int newid, string newintake, string newlevel, string newmodule)
        {
            this.id = newid;
            this.intake = newintake;
            this.level = newlevel;
            this.module = newmodule;
        }

        public void AddStudentWithLogin()
        {
            SqlConnection con = new SqlConnection(constring);
            string query = "INSERT INTO Login (Username, Name, Password, Role, Email, Contact, Description) VALUES('"+ tpnum +"', '"+ name +"', '12345', 'student', '"+ tpnum +"@apu.edu.my', '"+ contact +"', 'This student has not add a description yet, how boring!')";
            con.Open();
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.ExecuteNonQuery();
        }

        public void AddStudent(Boolean status)
        {
            SqlConnection con = new SqlConnection(constring);
            string query = "INSERT INTO Enroll (StudentID, Name, Email, Contact, Address, ClassLevel, Module, Intake, Origin) VALUES('"+ tpnum +"', '"+ name +"', '"+ email +"', '"+ contact +"', '"+ address +"', '"+ level +"', '"+ module +"', '"+ intake +"', '"+ origin +"')";
            con.Open();
            SqlCommand cmd = new SqlCommand(query, con);
            string charges = "", moduleid = "", trainerid = "";
            string readquery = "SELECT Charges, ModuleID, TrainerID FROM Schedule WHERE ModuleName = '" + module + "' and ClassLevel = '" + level + "' and Intake = '" + intake + "'";
            SqlCommand readcmd = new SqlCommand(readquery, con);
            SqlDataReader reader = readcmd.ExecuteReader();
            while (reader.Read())
            {
                charges = (reader["Charges"].ToString());
                moduleid = (reader["ModuleID"].ToString());
                trainerid = (reader["ModuleID"].ToString());
            }
            string query2 = "INSERT INTO Payment (Name, ClassLevel, ModuleName, Status, StudentID, Charges, ModuleID, TrainerID) VALUES('"+ name +"', '"+ level +"', '"+ module + "', 'UNPAID', '"+ tpnum +"', '"+ charges +"', '"+ moduleid +"', '"+ trainerid +"')";
            SqlCommand cmd2 = new SqlCommand(query2, con);

            cmd.ExecuteNonQuery();
            cmd2.ExecuteNonQuery();
            if (status == true)
            {
                AddStudentWithLogin();
                MessageBox.Show("Student has been successfully registered! Default password is 12345");
            }
            else
            {
                MessageBox.Show("Student has been successfully enrolled!");
            }
            con.Close();
            frmL_Enroll enrollmentform = new frmL_Enroll();
            enrollmentform.Show();
        }
        public int UpdateEnroll()
        {
            int rows;
            SqlConnection con = new SqlConnection(constring);
            string query = "UPDATE Enroll SET Intake = '"+ intake +"', Module ='" + module + "', ClassLevel = '" + level + "' WHERE id = '"+ id +"';";
            con.Open();
            SqlCommand cmd = new SqlCommand(query, con);
            rows = cmd.ExecuteNonQuery();
            con.Close();
            return rows;
        }
        public int UpdatePayment(string studentid, string orilevel, string orimodule)
        {
            int rows;
            SqlConnection con = new SqlConnection(constring);
            string charges = "", moduleid = "", trainerid = "";
            string readquery = "SELECT Charges, ModuleID, TrainerID FROM Schedule WHERE ModuleName = '" + module + "' and ClassLevel = '" + level + "' and Intake = '" + intake + "'";
            SqlCommand readcmd = new SqlCommand(readquery, con);
            con.Open();
            SqlDataReader reader = readcmd.ExecuteReader();
            while (reader.Read())
            {
                charges = (reader["Charges"].ToString());
                moduleid = (reader["ModuleID"].ToString());
                trainerid = (reader["ModuleID"].ToString());
            }
            string query = "UPDATE Payment SET ClassLevel = '" + level + "', ModuleName ='" + module + "', Charges = '" + charges + "', ModuleID = '" + moduleid + "', TrainerID = '"+ trainerid +"' WHERE StudentID = '" + studentid + "' and ModuleName = '"+ orimodule +"' and ClassLevel = '"+ orilevel +"'";
            SqlCommand cmd = new SqlCommand(query, con);
            
            rows = cmd.ExecuteNonQuery();
            con.Close();
            return rows;
        }
        public string DistinctStudent()
        {
            string num = "";
            SqlConnection con = new SqlConnection(constring);
            string readquery = "SELECT Count(Distinct StudentID) As Count FROM Enroll;";
            con.Open();
            SqlCommand readcmd = new SqlCommand(readquery, con);
            SqlDataReader reader = readcmd.ExecuteReader();
            while (reader.Read())
            {
                num = (reader["Count"].ToString());
            }
            con.Close();
            return num;
        }
        public string TotalEnrollment()
        {
            string num = "";
            SqlConnection con = new SqlConnection(constring);
            string readquery = "SELECT Count(StudentID) As Count FROM Enroll;";
            con.Open();
            SqlCommand readcmd = new SqlCommand(readquery, con);
            SqlDataReader reader = readcmd.ExecuteReader();
            while (reader.Read())
            {
                num = (reader["Count"].ToString());
            }
            con.Close();
            return num;

        }
        public int DeleteEnrollment()
        {
            int thisid = id, rows;
            SqlConnection con = new SqlConnection(constring);
            string query = "DELETE FROM Enroll WHERE ID = '" + thisid + "'";
            SqlCommand cmd = new SqlCommand(query, con);
            con.Open();
            rows = cmd.ExecuteNonQuery();
            con.Close();
            return rows;
        }
        public int DeletePayment()
        {
            string studentid, Level, Module;
            int rows;
            studentid = intake;
            Level = level;
            Module = module;
            SqlConnection con = new SqlConnection(constring);
            string query = "DELETE FROM Payment WHERE StudentID = '" + studentid + "' and ClassLevel = '" + Level + "' and ModuleName = '" + Module + "'";
            SqlCommand cmd = new SqlCommand(query, con);
            con.Open();
            rows = cmd.ExecuteNonQuery();
            con.Close();
            return rows;
        }


    }
}
