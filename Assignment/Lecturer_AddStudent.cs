using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment
{
    public partial class frmL_AddStudent : Form
    {
        public frmL_AddStudent()
        {
            InitializeComponent();
        }
        public static string id;
        public frmL_AddStudent(string userid)
        {
            InitializeComponent();
            id = userid;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            string form = "enroll";
            LecturerDashboard obj = new LecturerDashboard(form, id);
            obj.redirect();
            this.Hide();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            string tpnum, name, email, contact, address, level, module, intake, origin;
            Boolean status = false;
            tpnum = txtTPNum.Text;
            name = txtName.Text;
            email = txtEmail.Text;
            contact = txtContact.Text;
            address = txtAddress.Text;
            intake = txtIntake.Text;
            origin = txtOrigin.Text;
            level = lbLevel.SelectedItem.ToString();
            module = lbModule.SelectedItem.ToString();
            LecturerEnroll obj = new LecturerEnroll(tpnum, name, email, contact, address, intake, origin, level, module);
            if (cboxLogin.Checked)
            {
                status = true;
            }
            else
            {
                status = false;
            }
            obj.AddStudent(status);
            this.Hide();
        }
    }
}
