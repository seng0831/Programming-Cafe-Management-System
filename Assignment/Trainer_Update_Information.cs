using Assignment_Student_;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Assignment_Trainer_.Trainer_Update_Information;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Assignment_Trainer_
{


    public partial class Trainer_Update_Information : Form
    {
        public static string userID;
        public string trainername;
        public string classlevel;

        SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"C:\\Users\\Asus\\OneDrive - Asia Pacific University\\Desktop\\Projects\\IOOP Group Assignment Final Code Compilation\\Assignment\\Assignment.mdf\";Integrated Security=True");

        public Trainer_Update_Information(string id)
        {
            InitializeComponent();
            userID = id;
        }


        private void updatelist()
        {

            string moduleid = txtmoduleid.Text;
            string modulename = lstboxcoachingclass.Text;
            string classlevel = txtclasslevel.Text;
            int charges = Convert.ToInt32(txtcharges.Text);
            string day = lstday.Text;
            string duration = txtduration.Text;
            string intake = txtintake.Text;
            string trainer = txttrainername.Text;
            string trainerid = userID;


            string query = "INSERT INTO Schedule VALUES ('" + moduleid + "', '" + modulename + "', '" + classlevel + "', '" + charges + "', '" + day + "', '" + duration + "', '" + intake + "', '" + trainer + "', '" + trainerid + "')";

            SqlCommand cmd = new SqlCommand(query, con);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Update Successfully!");

            RefreshListView();

        }


        private void RefreshListView()
        {
            listviewcoachingclass.Columns.Clear();
            listviewcoachingclass.Items.Clear();

            listviewcoachingclass.Columns.Add("ModuleID", 70);
            listviewcoachingclass.Columns.Add("Modulename", 70, HorizontalAlignment.Center);
            listviewcoachingclass.Columns.Add("ClassLevel", 70, HorizontalAlignment.Center);
            listviewcoachingclass.Columns.Add("Charges", 70, HorizontalAlignment.Center);
            listviewcoachingclass.Columns.Add("Day", 70, HorizontalAlignment.Center);
            listviewcoachingclass.Columns.Add("Duration", 70, HorizontalAlignment.Center);
            listviewcoachingclass.Columns.Add("Intake", 70, HorizontalAlignment.Center);
            listviewcoachingclass.Columns.Add("Trainer", 70, HorizontalAlignment.Center);
            listviewcoachingclass.Columns.Add("TrainerID", 70, HorizontalAlignment.Center);

            listviewcoachingclass.View = View.Details;

            {
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM Schedule", con);
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
                    listviewcoachingclass.Items.Add(item);
                }
            }
        }

        private void DeleteList(string moduleID)
        {
            SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"C:\\Users\\Asus\\OneDrive - Asia Pacific University\\Desktop\\Projects\\IOOP Group Assignment Final Code Compilation\\Assignment\\Assignment.mdf\";Integrated Security=True");
            string query = "DELETE FROM Schedule WHERE ModuleID = '" + moduleID + "'";
            SqlCommand cmd = new SqlCommand(query, con);
            con.Open();
            cmd.ExecuteNonQuery();
        }

        public Trainer_Update_Information()
        {
            InitializeComponent();
        }

        private void btnhomepage_Click(object sender, EventArgs e)
        {
            Trainer_Home form1 = new Trainer_Home(userID);
            form1.Show();
            this.Hide();
        }



        private void Trainer_Update_Information_Load(object sender, EventArgs e)
        {
            RefreshListView();

            string classlevel = string.Empty;
            string userid = userID;
            string classlevel_return;
            string name_return;
            TrainerUpdateInformation obj1 = new TrainerUpdateInformation(userid, classlevel);
            classlevel_return = obj1.GetClassLevel();
            txtclasslevel.Text = classlevel_return.ToString(); //for testing

            TrainerUpdateInformation obj2 = new TrainerUpdateInformation(userid,trainername);
            name_return =obj2.GetName();
            txttrainername.Text = name_return.ToString();
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            RefreshListView();
            updatelist();
        }


        private void btndelete_Click(object sender, EventArgs e)
        {

            string moduleID = listviewcoachingclass.SelectedItems[0].SubItems[0].Text;
            DeleteList(moduleID);
            MessageBox.Show("Deleted Successfully!");

            
            RefreshListView();
        }

        private void btnLog_Click(object sender, EventArgs e)
        {
            FrmLogin loginform = new FrmLogin();
            loginform.Show();
            this.Hide();
        }


        private void btnSch_Click(object sender, EventArgs e)
        {
            Trainer_Update_Information form2 = new Trainer_Update_Information(userID);
            form2.Show();
            this.Hide();
        }

        private void btnPay_Click(object sender, EventArgs e)
        {
            Trainer_Student_List form3 = new Trainer_Student_List(userID);
            form3.Show();
            this.Hide();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            Trainer_Home form1 = new Trainer_Home(userID);
            form1.Show();
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
