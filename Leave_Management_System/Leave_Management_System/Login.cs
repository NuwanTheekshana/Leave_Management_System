using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Leave_Management_System
{
    public partial class Login : Form
    {
        Functions Con;
        Encryption Pass;
        public Login()
        {
            InitializeComponent();
            Con = new Functions();
            Pass = new Encryption();
        }

        public static int admin_id;
        public static string admin_email = "";
        public static string admin_username = "";
        private void button1_Click(object sender, EventArgs e)
        {
            string email = email_txt.Text;
            string password = password_txt.Text;

            if (string.IsNullOrEmpty(email) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please enter both email and password.");
                return;
            }

            string Query = "select * from Admin_tbl where admin_email = '{0}' and admin_status = 1";
            Query = string.Format(Query, email);
            DataTable dt = Con.GetData(Query);

            if (dt.Rows.Count > 0)
            {
                string hashedPasswordFromDatabase = dt.Rows[0]["admin_password"].ToString();

                if (Pass.VerifyPassword(password, hashedPasswordFromDatabase))
                {
                    admin_id = Convert.ToInt32(dt.Rows[0]["admin_id"].ToString());
                    admin_email = dt.Rows[0]["admin_email"].ToString();
                    admin_username = dt.Rows[0]["admin_fname"].ToString() +" "+dt.Rows[0]["admin_lname"].ToString();
                    Admin_Registration adminReg = new Admin_Registration(admin_id, admin_email, admin_username);
                    adminReg.Show();
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

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
