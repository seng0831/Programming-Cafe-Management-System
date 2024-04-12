using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Assignment_Student_
{
    public partial class FrmSchedule : Form
    {
        public static string username;
        public static string password;
        SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"C:\\Users\\Asus\\OneDrive - Asia Pacific University\\Desktop\\Projects\\IOOP Group Assignment Final Code Compilation\\Assignment\\Assignment.mdf\";Integrated Security=True");
        
        public FrmSchedule()
        {
            InitializeComponent();
        }
        public FrmSchedule(string userName, string pass)
        {
            InitializeComponent();
            username = userName;
            password = pass;
        }
        
        private void splitContainer1_SplitterMoved(object sender, SplitterEventArgs e)
        {

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
            FrmSchedule f2 = new FrmSchedule();
            f2.Show();
        }

        private void btnReq_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmRequest f3 = new FrmRequest(username,password);
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

        private void FrmSchedule_Load(object sender, EventArgs e)
        {
            string query = "SELECT * FROM Schedule";
            SqlCommand cmd = new SqlCommand(query, con);

            con.Open();
            SqlDataReader reader = cmd.ExecuteReader();

            lvSch.Items.Clear();

            while (reader.Read())
            {

                ListViewItem item = new ListViewItem(reader["ModuleID"].ToString());
                item.SubItems.Add(reader["Modulename"].ToString());
                item.SubItems.Add(reader["Intake"].ToString());
                item.SubItems.Add(reader["ClassLevel"].ToString());
                item.SubItems.Add(reader["Charges"].ToString());
                item.SubItems.Add(reader["Day"].ToString());
                item.SubItems.Add(reader["Duration"].ToString());
                item.SubItems.Add(reader["Trainer"].ToString());
                
                lvSch.Items.Add(item);
            }
            con.Close();
        }

        private void btnSchSearch_Click(object sender, EventArgs e)
        {
            string query = "SELECT * FROM Schedule WHERE 1 = 1";
            SqlCommand cmd = new SqlCommand(query, con);

            if (lbIntake.SelectedItem != null)
            {
                query += " AND Intake = @intake";
                cmd.Parameters.AddWithValue("@intake", lbIntake.SelectedItem.ToString());
            }

            if (lbSchClassL.SelectedItem != null)
            {
                query += " AND [ClassLevel] = @classLevel";
                cmd.Parameters.AddWithValue("@classLevel", lbSchClassL.SelectedItem.ToString());
            }

            if (lbSchModule.SelectedItem != null)
            {
                query += " AND Modulename = @module";
                cmd.Parameters.AddWithValue("@module", lbSchModule.SelectedItem.ToString());
            }

            con.Open();
            cmd.CommandText = query;
            SqlDataReader reader = cmd.ExecuteReader();

            lvSch.Items.Clear();

            while (reader.Read())
            {
                ListViewItem item = new ListViewItem(reader["ModuleID"].ToString());
                item.SubItems.Add(reader["Modulename"].ToString());
                item.SubItems.Add(reader["Intake"].ToString());
                item.SubItems.Add(reader["ClassLevel"].ToString());
                item.SubItems.Add(reader["Charges"].ToString());
                item.SubItems.Add(reader["Day"].ToString());
                item.SubItems.Add(reader["Duration"].ToString());
                item.SubItems.Add(reader["Trainer"].ToString());

                lvSch.Items.Add(item);
            }

            con.Close();
        }

        private void btnSchReset_Click(object sender, EventArgs e)
        {
            string query = "SELECT * FROM Schedule";
            SqlCommand cmd = new SqlCommand(query, con);

            con.Open();
            SqlDataReader reader = cmd.ExecuteReader();

            lvSch.Items.Clear();

            while (reader.Read())
            {

                ListViewItem item = new ListViewItem(reader["ModuleID"].ToString());
                item.SubItems.Add(reader["Modulename"].ToString());
                item.SubItems.Add(reader["Intake"].ToString());
                item.SubItems.Add(reader["ClassLevel"].ToString());
                item.SubItems.Add(reader["Charges"].ToString());
                item.SubItems.Add(reader["Day"].ToString());
                item.SubItems.Add(reader["Duration"].ToString());
                item.SubItems.Add(reader["Trainer"].ToString());

                lvSch.Items.Add(item);

            }
            con.Close();
        }
    }
    
}
