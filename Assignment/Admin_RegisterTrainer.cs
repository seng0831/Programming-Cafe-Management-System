using Assignment;
using Assignment_Student_;
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

namespace Admin
{
    public partial class frmRegisterTrainer : Form
    {
        private string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"C:\\Users\\Asus\\OneDrive - Asia Pacific University\\Desktop\\Projects\\IOOP Group Assignment Final Code Compilation\\Assignment\\Assignment.mdf\";Integrated Security=True";
        private string userid, password;

        public frmRegisterTrainer(string Userid, string Pass)
        {
            InitializeComponent();
            this.userid = Userid;
            this.password = Pass;
        }


        private void Admin_Load(object sender, EventArgs e)
        {
            LoadTrainerData();
        }

        private void LoadTrainerData()
        {
            string query = "SELECT * FROM Trainer";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);

                connection.Open();

                SqlDataReader reader = command.ExecuteReader();
                lvAdmin.Items.Clear();

                while (reader.Read())
                {
                    string trainerID = reader["TrainerID"].ToString();
                    string income = reader["Income"].ToString();
                    string trainer = reader["Trainer"].ToString();
                    string feedback = reader["Feedback"].ToString();
                    string level = reader["Level"].ToString();

                    TrainerData trainerData = new TrainerData(trainerID, income, trainer, feedback, level);
                    ListViewItem item = trainerData.ToListViewItem();
                    lvAdmin.Items.Add(item);
                }

                reader.Close();
            }
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            string trainerid = txtTrainerID.Text;
            string income = txtIncome.Text;
            string trainer = txtTrainer.Text;
            string level = cbLevel.Text;

            if (string.IsNullOrWhiteSpace(trainerid) || string.IsNullOrWhiteSpace(income) ||
                string.IsNullOrWhiteSpace(trainer) || string.IsNullOrWhiteSpace(level))
            {
                MessageBox.Show("Please fill in all the fields.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            adminRegister obj = new adminRegister(trainerid, income, trainer, level);
            int result = obj.register(trainerid, income, trainer, level);

            if (result > 0)
            {
                TrainerData trainerData = new TrainerData(trainerid, income, trainer, "", level);
                ListViewItem item = trainerData.ToListViewItem();
                lvAdmin.Items.Add(item);

                txtTrainerID.Text = string.Empty;
                txtIncome.Text = string.Empty;
                txtTrainer.Text = string.Empty;
                cbLevel.Text = string.Empty;
            }
            else
            {
                MessageBox.Show("Registration failed.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (lvAdmin.SelectedItems.Count > 0)
            {
                DialogResult result = MessageBox.Show("Are you sure you want to delete this data?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    ListViewItem selectedItem = lvAdmin.SelectedItems[0];
                    string trainerid = selectedItem.SubItems[0].Text;

                    adminRegister obj = new adminRegister(trainerid);
                    int rowsAffected = obj.delete(trainerid);


                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Data deleted successfully.");
                        lvAdmin.Items.Remove(selectedItem);
                    }
                    else
                    {
                        MessageBox.Show("Unable to delete data.");
                    }
                    
                }
            }
            else
            {
                MessageBox.Show("Please select an item to delete.");
            }
        }


        private void btnView_Click(object sender, EventArgs e)
        {
            if (lvAdmin.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = lvAdmin.SelectedItems[0];
                string feedback = selectedItem.SubItems[3].Text;

                if (!string.IsNullOrEmpty(feedback))
                {
                    MessageBox.Show(feedback, "Feedback");
                }
                else
                {
                    MessageBox.Show("Feedback unavailable.", "Feedback");
                }
            }
            else
            {
                MessageBox.Show("Please select an item to show feedback.", "Feedback");
            }
        }

        private void btnTrainer_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Show();
        }

        private void btnLog_Click(object sender, EventArgs e)
        {
            FrmLogin loginform = new FrmLogin();
            loginform.Show();
            this.Hide();
        }

        private void btnPro_Click(object sender, EventArgs e)
        {
            frmAdminProfile adminprofile = new frmAdminProfile(userid, password);
            adminprofile.Show();
            this.Hide();
        }

    }

    public class TrainerData
    {
        public string TrainerID { get; set; }
        public string Income { get; set; }
        public string Trainer { get; set; }
        public string Feedback { get; set; }
        public string Level { get; set; }

        public TrainerData(string trainerID, string income, string trainer, string feedback, string level)
        {
            TrainerID = trainerID;
            Income = income;
            Trainer = trainer;
            Feedback = feedback;
            Level = level;
        }

        public ListViewItem ToListViewItem()
        {
            ListViewItem item = new ListViewItem(TrainerID);
            item.SubItems.Add(Income);
            item.SubItems.Add(Trainer);
            item.SubItems.Add(Feedback);
            item.SubItems.Add(Level);

            return item;
        }
    }
}
