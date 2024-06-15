using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Leave_Management_System
{
    public partial class Admin_User_Update_Form : Form
    {
        Functions Con;
        int admin_id;
        string admin_fname, admin_lname, admin_email;

        public Admin_User_Update_Form(int id, string firstName, string lastName, string email)
        {
            InitializeComponent();
            Con = new Functions();
            admin_id = id;
            admin_fname = firstName;
            admin_lname = lastName;
            admin_email = email;
        }

        private void Admin_User_Update_Form_Load(object sender, EventArgs e)
        {
            admin_id_txt.Text = admin_id.ToString();
            fname_txt.Text = admin_fname;
            lname_txt.Text = admin_lname;
            email_txt.Text = admin_email;
        }

        private void admin_add_btn_Click(object sender, EventArgs e)
        {
            int id;
            string fname, lname, email;

            id = Convert.ToInt32(admin_id_txt.Text);
            fname = fname_txt.Text;
            lname = lname_txt.Text;
            email = email_txt.Text;
            DateTime currentDateTime = DateTime.Now;

            try
            {
                
                string Query = "Update Admin_tbl set admin_fname = '{0}', admin_lname = '{1}', admin_email = '{2}', admin_updated_date = '{3}' where admin_id = '{4}'";
                Query = string.Format(Query, fname, lname, email, currentDateTime, id);
                Con.SetData(Query);
                MessageBox.Show("Admin user update successfully..!");
                
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        
    }
}
