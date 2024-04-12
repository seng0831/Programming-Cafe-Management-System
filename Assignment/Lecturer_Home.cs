using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment
{
    public partial class frmLecturer : Form
    {

        public frmLecturer()
        {
            InitializeComponent();  
        }
        public static string id;
        public frmLecturer(string userid)
        {
            InitializeComponent();
            id = userid;
        }
        private void btnLogOut_Click(object sender, EventArgs e)
        {
            string form = "logout";
            LecturerDashboard obj = new LecturerDashboard(form, id);
            obj.redirect();
            this.Hide();
        }

        private void btnRequest_Click(object sender, EventArgs e)
        {
            string form = "request";
            LecturerDashboard obj = new LecturerDashboard(form, id);
            obj.redirect();
            this.Hide();
        }

        private void btnEnroll_Click(object sender, EventArgs e)
        {
            string form = "enroll";
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
    }
}
