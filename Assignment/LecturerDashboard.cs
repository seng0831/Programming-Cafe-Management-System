using Assignment_Student_;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment
{
    internal class LecturerDashboard
    {
        private string form;
        private string username;
        public string Form { get { return form; } set { form = value; } }
        public string Username { get { return username; } set { username = value; } }
        public LecturerDashboard(string Form, string Username)
        {
            this.form = Form;
            this.username = Username;
        }

        public void redirect()
        {
            if (form == "home")
            {
                frmLecturer lecturerform = new frmLecturer(username);
                lecturerform.Show();
            }
            else if (form == "request")
            {
                frmL_Request requestform = new frmL_Request(username);
                requestform.Show();
            }
            else if (form == "enroll")
            {
                frmL_Enroll enrollmentform = new frmL_Enroll(username);
                enrollmentform.Show();
            }
            else if (form == "profile")
            {
                frmL_Profile profileform = new frmL_Profile(username, username);
                profileform.Show();
            }
            else if (form == "logout")
            {
                FrmLogin loginform = new FrmLogin();
                loginform.Show();
            }
            else if (form == "register")
            {
                frmL_AddStudent studentform = new frmL_AddStudent(username);
                studentform.Show();
            }
        }
    }
}
