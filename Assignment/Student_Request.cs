using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Assignment_Student_
{
    public partial class FrmRequest : Form
    {
        private static string username;
        private static string password;
        SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"C:\\Users\\Asus\\OneDrive - Asia Pacific University\\Desktop\\Projects\\IOOP Group Assignment Final Code Compilation\\Assignment\\Assignment.mdf\";Integrated Security=True");
        
        
        public FrmRequest(string userName, string pass)
        {
            username = userName;
            password = pass;
            InitializeComponent();
        }

        private void btnReqSubmit_Click(object sender, EventArgs e)
        {
            string classLevel = lbReqClassL.SelectedItem?.ToString();
            string module = lbReqModule.SelectedItem?.ToString();
            string intake = lbReqIntake.SelectedItem?.ToString();
            int insertedID;

            if (string.IsNullOrEmpty(classLevel) || string.IsNullOrEmpty(module) || string.IsNullOrEmpty(intake))
            {
                MessageBox.Show("Please select from all the boxes.");
            }
            else
            {
                string id = username;
                string name=txtReqName.Text;
                StudentRequest obj = new StudentRequest(id);
                insertedID = obj.Submit(id, name, intake, classLevel, module);

                ListViewItem value = new ListViewItem(new string[] {insertedID.ToString(), txtReqName.Text, intake, classLevel, module });
                lvPenReq.Items.Add(value);

                con.Close();
                MessageBox.Show("Successfully Saved");
            }
        }
        

            private void btnHome_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmHomeStudent f1 = new FrmHomeStudent(username,password);
            f1.Show();
        }

        private void btnSch_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmSchedule f2 = new FrmSchedule(username, password);
            f2.Show();
        }

        private void btnReq_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            FrmRequest f3 = new FrmRequest(username, password);
            f3.Show();
        }

        private void btnPay_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmPayment f4 = new FrmPayment(username, password);
            f4.Show();
        }

        private void btnPro_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmProfile f5 = new FrmProfile(username, password);
            f5.Show();
        }

        private void btnLog_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmLogin f6 = new FrmLogin();
            f6.Show();
        }

        private void FrmRequest_Load(object sender, EventArgs e)
        {
            string query = "SELECT * FROM Requests WHERE StudentID=@stuID";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@stuID", username);

            con.Open();

            SqlDataReader reader = cmd.ExecuteReader();
            lvPenReq.Items.Clear();

            while (reader.Read())
            {
                
                string studentID = reader["StudentID"].ToString();

                if (studentID == username)
                {
                    ListViewItem item = new ListViewItem(reader["ID"].ToString());
                    item.SubItems.Add(reader["Name"].ToString());
                    item.SubItems.Add(reader["Intake"].ToString());
                    item.SubItems.Add(reader["ClassLevel"].ToString());
                    item.SubItems.Add(reader["Modulename"].ToString());

                    lvPenReq.Items.Add(item);

                }
            }
            con.Close();
        }

        private void btnReqUpdate_Click(object sender, EventArgs e)
        {
            if (lvPenReq.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = lvPenReq.SelectedItems[0];
                string id = selectedItem.SubItems[0].Text;
                string name = txtReqName.Text;
                string intake = lbReqIntake.Text;
                string classLevel = lbReqClassL.Text;
                string module = lbReqModule.Text;

                if (string.IsNullOrEmpty(intake) || string.IsNullOrEmpty(classLevel) || string.IsNullOrEmpty(module))
                {
                    MessageBox.Show("Please select all the boxes.");
                }
                else
                {
                    StudentRequest obj = new StudentRequest(id);
                    int rowsAffected = obj.Update(name, intake, classLevel, module);

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Successfully Updated");
                        selectedItem.SubItems[0].Text = id;
                        selectedItem.SubItems[1].Text = name;
                        selectedItem.SubItems[2].Text = intake;
                        selectedItem.SubItems[3].Text = classLevel;
                        selectedItem.SubItems[4].Text = module;
                    }
                    else
                    {
                        MessageBox.Show("Update Failed");
                    }
                }
            }
        }

        private void btnReqRemove_Click(object sender, EventArgs e)
        {
            if (lvPenReq.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = lvPenReq.SelectedItems[0];
                string id = selectedItem.SubItems[0].Text;

                StudentRequest obj = new StudentRequest(id);
                int rowsAffected = obj.Remove(id);

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Successfully Removed");
                    lvPenReq.Items.Remove(selectedItem);
                }
                else
                {
                    MessageBox.Show("Removal Failed");
                }
            }
            con.Close();
        }

        private void lvPenReq_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvPenReq.SelectedItems.Count > 0)
            {
                txtReqName.Text = lvPenReq.SelectedItems[0].SubItems[1].Text;
                lbReqIntake.Text = lvPenReq.SelectedItems[0].SubItems[2].Text;
                lbReqClassL.Text = lvPenReq.SelectedItems[0].SubItems[3].Text;
                lbReqModule.Text = lvPenReq.SelectedItems[0].SubItems[4].Text;
            }
        }
    }
}
