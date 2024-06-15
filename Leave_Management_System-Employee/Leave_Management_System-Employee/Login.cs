using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Leave_Management_System_Employee
{
    public partial class Login_page : Form
    {
        Functions Con;
        Encryption Pass;
        public Login_page()
        {
            InitializeComponent();
            Con = new Functions();
            Pass = new Encryption();
        }

        public static int emp_id;
        public static string emp_email = "";
        public static string emp_username = "";
        public static string emp_type = "";
        private void login_btn_Click(object sender, EventArgs e)
        {
            string email = email_txt.Text;
            string password = password_txt.Text;

            if (string.IsNullOrEmpty(email) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please enter both email and password.");
                return;
            }

            string Query = "select * from Employee_tbl where emp_email = '{0}' and emp_status = 1";
            Query = string.Format(Query, email);
            DataTable dt = Con.GetData(Query);

            if (dt.Rows.Count > 0)
            {
                string hashedPasswordFromDatabase = dt.Rows[0]["emp_password"].ToString();

                if (Pass.VerifyPassword(password, hashedPasswordFromDatabase))
                {
                    emp_id = Convert.ToInt32(dt.Rows[0]["emp_id"].ToString());
                    emp_email = dt.Rows[0]["emp_email"].ToString();
                    emp_username = dt.Rows[0]["emp_fname"].ToString() + " " + dt.Rows[0]["emp_lname"].ToString();
                    emp_type = dt.Rows[0]["emp_type"].ToString();
                    Emp_Page emppage = new Emp_Page(emp_id, emp_email, emp_username, emp_type);
                    emppage.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Incorrect email or password. Please try again.");
                }
            }
            else
            {
                MessageBox.Show("Incorrect email or password. Please try again..!");
                email_txt.Text = "";
                password_txt.Text = "";
            }
        }
    }
}
