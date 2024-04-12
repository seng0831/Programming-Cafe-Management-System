using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Assignment
{
    public partial class frmL_Request : Form
    {
        public frmL_Request()
        {
            InitializeComponent();
        }
        public static string id;
        public frmL_Request(string userid)
        {
            InitializeComponent();
            id = userid;
        }

        public static string constring = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"C:\\Users\\Asus\\OneDrive - Asia Pacific University\\Desktop\\Projects\\IOOP Group Assignment Final Code Compilation\\Assignment\\Assignment.mdf\";Integrated Security=True;MultipleActiveResultSets=true";
        private void LoadRequest()
        {
            lvRequest.Items.Clear();
            SqlConnection con = new SqlConnection(constring);
            string query = "SELECT ID, Name, ClassLevel, ModuleName, StudentID, Intake FROM Requests";

            SqlCommand cmd = new SqlCommand(query, con);
            con.Open();

            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                ListViewItem item = new ListViewItem(reader["ID"].ToString());
                item.SubItems.Add(reader["Name"].ToString());
                item.SubItems.Add(reader["ClassLevel"].ToString());
                item.SubItems.Add(reader["ModuleName"].ToString());
                item.SubItems.Add(reader["StudentID"].ToString());
                item.SubItems.Add(reader["Intake"].ToString());
                lvRequest.Items.Add(item);
            }
            con.Close();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            string form = "home";
            LecturerDashboard obj = new LecturerDashboard(form, id);
            obj.redirect();
            this.Hide();
        }

        private void btnReq_Click(object sender, EventArgs e)
        {
            string form = "request";
            LecturerDashboard obj = new LecturerDashboard(form, id);
            obj.redirect();
            this.Hide();
        }

        private void btnPro_Click(object sender, EventArgs e)
        {
            string form = "profile";
            LecturerDashboard obj = new LecturerDashboard(form, id);
            obj.redirect();
            this.Hide();
        }

        private void btnLog_Click(object sender, EventArgs e)
        {
            string form = "logout";
            LecturerDashboard obj = new LecturerDashboard(form, id);
            obj.redirect();
            this.Hide();
        }

        private void btnEn_Click(object sender, EventArgs e)
        {
            string form = "enroll";
            LecturerDashboard obj = new LecturerDashboard(form, id);
            obj.redirect();
            this.Hide();
        }

        private void btnReject_Click(object sender, EventArgs e)
        {
            if (lvRequest.SelectedItems.Count > 0)
            {
                int id = int.Parse(lvRequest.SelectedItems[0].SubItems[0].Text);
                int return1;
                LecturerRequest obj = new LecturerRequest(id);
                return1 = obj.Reject();
                if (return1 > 0)
                {
                    MessageBox.Show("Request rejected!");
                }
                else
                {
                    MessageBox.Show("Error occured!");
                }
            }
            else
            {
                MessageBox.Show("Please select a row.");
            }
            LoadRequest();
        }

        private void testRequest_Load(object sender, EventArgs e)
        {
            LoadRequest();
        }

        private void btnApprove_Click(object sender, EventArgs e)
        {
            if (lvRequest.SelectedItems.Count > 0)
            {
                int return1;
                int id = Convert.ToInt32(lvRequest.SelectedItems[0].SubItems[0].Text);
                string name = lvRequest.SelectedItems[0].SubItems[1].Text;
                string level = lvRequest.SelectedItems[0].SubItems[2].Text;
                string module = lvRequest.SelectedItems[0].SubItems[3].Text;
                string studentid = lvRequest.SelectedItems[0].SubItems[4].Text;
                string intake = lvRequest.SelectedItems[0].SubItems[5].Text;
                LecturerRequest obj = new LecturerRequest(id, name, level, module, studentid, intake);
                return1 = obj.Approve();
                if (return1 > 0)
                {
                    MessageBox.Show("Request approved!");
                }
                else
                {
                    MessageBox.Show("Error occured!");
                }

            }
            else
            {
                MessageBox.Show("Please select a row.");
            }
            LoadRequest();
        }
    }
}
