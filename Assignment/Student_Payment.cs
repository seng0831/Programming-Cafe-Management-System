using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Assignment_Student_
{
    public partial class FrmPayment : Form
    {
        public static string username;
        public static string password; 
        SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"C:\\Users\\Asus\\OneDrive - Asia Pacific University\\Desktop\\Projects\\IOOP Group Assignment Final Code Compilation\\Assignment\\Assignment.mdf\";Integrated Security=True");

        public FrmPayment(string userName, string pass)
        {
            InitializeComponent();
            username = userName;
            password = pass;
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmHomeStudent f1 = new FrmHomeStudent(username, password);
            f1.Show();
        }

        private void btnSch_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmSchedule f2 = new FrmSchedule(username, password);
            f2.Show();
        }

        private void btnReq_Click(object sender, EventArgs e)
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

        private void FrmPayment_Load(object sender, EventArgs e)
        {
            string query = "SELECT * FROM Payment WHERE StudentID=@stuID";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@stuID", username);

            con.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            lvPayment.Items.Clear();

            while (reader.Read())
            {
                string studentID = reader["StudentID"].ToString();
                if (studentID == username)
                {
                    ListViewItem item = new ListViewItem(reader["StudentID"].ToString());
                    item.SubItems.Add(reader["Name"].ToString());
                    item.SubItems.Add(reader["ClassLevel"].ToString());
                    item.SubItems.Add(reader["ModuleID"].ToString());
                    item.SubItems.Add(reader["Modulename"].ToString());
                    item.SubItems.Add(reader["Charges"].ToString());
                    item.SubItems.Add(reader["Status"].ToString());
                    lvPayment.Items.Add(item);
                }
            }
            con.Close();
        }

        private void brnPayPay_Click(object sender, EventArgs e)
        {
            if (lvPayment.SelectedItems.Count > 0)
            {
                ListViewItem selectedPayment = lvPayment.SelectedItems[0];
                string currentStatus = selectedPayment.SubItems[6].Text;

                if (currentStatus == "PAID")
                {
                    MessageBox.Show("Payment is already paid.", "Payment Status", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    string stuid = selectedPayment.SubItems[0].Text;
                    StudentPayment obj = new StudentPayment(stuid);
                    int rowsAffected = obj.Pay(stuid);

                    if (rowsAffected > 0)
                    {
                        selectedPayment.SubItems[6].Text = "PAID";
                        MessageBox.Show("Successfully marked payment as paid.", "Payment Status", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Failed to mark payment as paid.", "Payment Status", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a payment to mark as paid.", "Payment Selection", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
