using Assignment_Student_;
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

namespace Assignment_Trainer_
{
    public partial class Trainer_Student_List : Form
    {
        public static string userID;




        SqlCommand cmd;
        DataTable dt;
        SqlDataAdapter da;
        DataSet ds;

        private void RefreshListView()
        {
            lstviewstudentlist.Columns.Clear();
            lstviewstudentlist.Items.Clear();

            lstviewstudentlist.Columns.Add("ID", 70);
            lstviewstudentlist.Columns.Add("Name", 70, HorizontalAlignment.Center);
            lstviewstudentlist.Columns.Add("ClassLevel", 70, HorizontalAlignment.Center);
            lstviewstudentlist.Columns.Add("ModuleName", 70, HorizontalAlignment.Center);
            lstviewstudentlist.Columns.Add("Status", 70, HorizontalAlignment.Center);
            lstviewstudentlist.Columns.Add("StudentID", 70, HorizontalAlignment.Center);
            lstviewstudentlist.Columns.Add("Charges", 70, HorizontalAlignment.Center);
            lstviewstudentlist.Columns.Add("ModuleID", 70, HorizontalAlignment.Center);
            lstviewstudentlist.Columns.Add("TrainerID", 70, HorizontalAlignment.Center);
            lstviewstudentlist.View = View.Details;

            string query = "SELECT * FROM Payment WHERE TrainerID = '" + userID + "'";


            SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"C:\\Users\\Asus\\OneDrive - Asia Pacific University\\Desktop\\Projects\\IOOP Group Assignment Final Code Compilation\\Assignment\\Assignment.mdf\";Integrated Security=True");
            {
                con.Open();
                SqlCommand cmd = new SqlCommand(query, con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds, "testTable");
                con.Close();

                DataTable dt = ds.Tables["testTable"];
                foreach (DataRow row in dt.Rows)
                {
                    ListViewItem item = new ListViewItem(row.ItemArray[0].ToString());
                    item.SubItems.Add(row.ItemArray[1].ToString());
                    item.SubItems.Add(row.ItemArray[2].ToString());
                    item.SubItems.Add(row.ItemArray[3].ToString());
                    item.SubItems.Add(row.ItemArray[4].ToString());
                    item.SubItems.Add(row.ItemArray[5].ToString());
                    item.SubItems.Add(row.ItemArray[6].ToString());
                    item.SubItems.Add(row.ItemArray[7].ToString());
                    item.SubItems.Add(row.ItemArray[8].ToString());
                    lstviewstudentlist.Items.Add(item);
                }
            }
        }
    
        public Trainer_Student_List(string id)
        {
            InitializeComponent();
            userID = id;


        }

        private void btnhomepage_Click(object sender, EventArgs e)
        {
            Trainer_Home form1 = new Trainer_Home(userID);
            form1.Show();
            this.Hide();
        }

        private void Trainer_Student_List_Load(object sender, EventArgs e)
        {
            RefreshListView();
        }

        private void btnrefresh_Click(object sender, EventArgs e)
        {
            RefreshListView();
        }

        private void lstviewstudentlist_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnpaidonly_Click(object sender, EventArgs e)
        {
            RefreshListView();

            List<ListViewItem> itemsToRemove = new List<ListViewItem>();

            foreach (ListViewItem item in lstviewstudentlist.Items)
            {
                if (item.SubItems[4].Text != "PAID")
                {
                    itemsToRemove.Add(item);
                }
            }

            foreach (ListViewItem item in itemsToRemove)
            {
                lstviewstudentlist.Items.Remove(item);
            }
        }

        private void btnunpaidonly_Click(object sender, EventArgs e)
        {
            RefreshListView();

            List<ListViewItem> itemsToRemove = new List<ListViewItem>();

            foreach (ListViewItem item in lstviewstudentlist.Items)
            {
                if (item.SubItems[4].Text != "UNPAID")
                {
                    itemsToRemove.Add(item);
                }
            }

            foreach (ListViewItem item in itemsToRemove)
            {
                lstviewstudentlist.Items.Remove(item);
            }
        }

        private void btnasc_Click(object sender, EventArgs e)
        {
            RefreshListView();

            List<ListViewItem> items = new List<ListViewItem>();
            foreach (ListViewItem item in lstviewstudentlist.Items)
            {
                items.Add(item);
            }

            items.Sort((x, y) => string.Compare(x.SubItems[1].Text, y.SubItems[1].Text));

            lstviewstudentlist.Items.Clear();
            lstviewstudentlist.Items.AddRange(items.ToArray());
        }

        private void btnSch_Click(object sender, EventArgs e)
        {
            Trainer_Update_Information form2 = new Trainer_Update_Information();
            form2.Show();
            this.Hide();
        }

        private void btnLog_Click(object sender, EventArgs e)
        {
            FrmLogin loginform = new FrmLogin();
            loginform.Show();
            this.Hide();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            Trainer_Home form1 = new Trainer_Home(userID);
            form1.Show();
            this.Hide();
        }

        private void btnPay_Click(object sender, EventArgs e)
        {
            Trainer_Student_List form3 = new Trainer_Student_List(userID);
            form3.Show();
            this.Hide();
        }

        private void btnPro_Click(object sender, EventArgs e)
        {
            Trainer_Profile form4 = new Trainer_Profile(userID);
            form4.Show();
            this.Hide();
        }

        private void btnfeedback_Click(object sender, EventArgs e)
        {
            Trainer_Feedbacks form5 = new Trainer_Feedbacks(userID);
            form5.Show();
            this.Hide();
        }
    }
}
