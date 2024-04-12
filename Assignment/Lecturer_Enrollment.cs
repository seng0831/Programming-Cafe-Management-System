using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Reflection.Emit;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Xml.Linq;

namespace Assignment
{
    public partial class frmL_Enroll : Form
    {
        public frmL_Enroll()
        {
            InitializeComponent();
        }
        public static string id;
        public frmL_Enroll(string userid)
        {
            InitializeComponent();
            id = userid;
        }
        public static string constring = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"C:\\Users\\Asus\\OneDrive - Asia Pacific University\\Desktop\\Projects\\IOOP Group Assignment Final Code Compilation\\Assignment\\Assignment.mdf\";Integrated Security=True;MultipleActiveResultSets=true";
        private void LoadEnrollment()
        {
            lvEnrollment.Items.Clear();
            SqlConnection con = new SqlConnection(constring);
            string query = "SELECT * FROM Enroll";
            SqlCommand cmd = new SqlCommand(query, con);
            con.Open();
            SqlDataReader reader = cmd.ExecuteReader();        
            while (reader.Read())
            {
                ListViewItem item = new ListViewItem(reader["ID"].ToString());
                item.SubItems.Add(reader["StudentID"].ToString());
                item.SubItems.Add(reader["Name"].ToString());
                item.SubItems.Add(reader["Email"].ToString());
                item.SubItems.Add(reader["Contact"].ToString());
                item.SubItems.Add(reader["Address"].ToString());
                item.SubItems.Add(reader["ClassLevel"].ToString());
                item.SubItems.Add(reader["Module"].ToString());
                item.SubItems.Add(reader["Intake"].ToString());
                item.SubItems.Add(reader["Origin"].ToString());
                lvEnrollment.Items.Add(item);
            }
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

        private void btnLog_Click(object sender, EventArgs e)
        {
            string form = "logout";
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

        private void btnEn_Click(object sender, EventArgs e)
        {
            string form = "enroll";
            LecturerDashboard obj = new LecturerDashboard(form, id);
            obj.redirect();
            this.Hide();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            string form = "register";
            LecturerDashboard obj = new LecturerDashboard(form, id);
            obj.redirect();
            this.Hide();
        }

        private void testenrollment_Load(object sender, EventArgs e)
        {
            LecturerEnroll obj = new LecturerEnroll();
            string num = obj.DistinctStudent();
            string num2 = obj.TotalEnrollment();
            LoadEnrollment();
            lblNumRegistered.Text = num;
            lblNumEnrollment.Text = num2;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (lvEnrollment.SelectedItems.Count > 0)
            {
                int id = int.Parse(lvEnrollment.SelectedItems[0].SubItems[0].Text);
                string studentid = lvEnrollment.SelectedItems[0].SubItems[1].Text;
                string level = lvEnrollment.SelectedItems[0].SubItems[6].Text;
                string module = lvEnrollment.SelectedItems[0].SubItems[7].Text;
                LecturerEnroll obj = new LecturerEnroll(id, studentid, level, module);
                int return1, return2;
                return1 = obj.DeletePayment();
                return2 = obj.DeleteEnrollment();
                if(return1>0 && return2 >0)
                {
                    MessageBox.Show("Enrollment Deleted!");
                }
                else
                {
                    MessageBox.Show("Error occured!");
                }
                LoadEnrollment();
            }
            else
            {
                MessageBox.Show("Please select a row.");
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (lvEnrollment.SelectedItems.Count > 0)
            {
                if (txtNewIntake.Text != "")
                {
                    string newIntake, newLevel, newModule;
                    newIntake = txtNewIntake.Text;
                    newLevel = lbNewLevel.SelectedItem.ToString();
                    newModule = lbNewModule.SelectedItem.ToString();
                    int id = int.Parse(lvEnrollment.SelectedItems[0].SubItems[0].Text);
                    string studentid = lvEnrollment.SelectedItems[0].SubItems[1].Text;
                    string orilevel = lvEnrollment.SelectedItems[0].SubItems[6].Text;
                    string orimodule = lvEnrollment.SelectedItems[0].SubItems[7].Text;
                    string oriintake = lvEnrollment.SelectedItems[0].SubItems[8].Text;
                    LecturerEnroll obj = new LecturerEnroll(id, newIntake, newLevel, newModule);
                    int return1, return2;
                    return1 = obj.UpdateEnroll();
                    return2 = obj.UpdatePayment(studentid, orilevel, orimodule);
                    if (return1 > 0 && return2 > 0)
                    {
                        MessageBox.Show("Enrollment Updated!");
                    }
                    else
                    {
                        MessageBox.Show("Error occured!");
                    }
                    LoadEnrollment();
                }
                else
                {
                    MessageBox.Show("Plese enter an intake code");
                }
                
            }
            else
            {
                MessageBox.Show("Please select a row.");
            }

        }

    }
}
