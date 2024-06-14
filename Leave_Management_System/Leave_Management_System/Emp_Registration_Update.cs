using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Leave_Management_System
{
    
    public partial class Emp_Registration_Update : Form
    {
        Functions Con;
        int emp_id, emp_contactno, auth_id;
        string emp_fname, emp_lname, emp_type, emp_email, emp_gender;
        DateTime emp_dob;
        public Emp_Registration_Update(int id, string firstName, string lastName, string Emp_Type, string Email, string Gender, DateTime DOB, int Contact_No, int admin_id)
        {
            InitializeComponent();
            Con = new Functions();
            emp_id = id;
            emp_fname = firstName;
            emp_lname = lastName;
            emp_type = Emp_Type;
            emp_email = Email;
            emp_gender = Gender;
            emp_dob = DOB;
            emp_contactno = Contact_No;
            auth_id = admin_id;
        }

        private void Emp_Registration_Update_Load(object sender, EventArgs e)
        {
            emp_id_txt.Text = emp_id.ToString();
            fname_txt.Text = emp_fname;
            lname_txt.Text = emp_lname;
            emp_type_box.Text = emp_type;
            email_txt.Text = emp_email;
            gender_box.Text = emp_gender;
            dob_datepicker.Text = emp_dob.ToString();
            Contact_No.Text = emp_contactno.ToString();
            admin_auth_id.Text = auth_id.ToString();
        }

        private void Contact_No_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void update_emp_btn_Click(object sender, EventArgs e)
        {
            int emp_id, emp_contactno, auth_id;
            string emp_fname, emp_lname, emp_type, emp_email, emp_gender;
            DateTime emp_dob;

            emp_id = Convert.ToInt32(emp_id_txt.Text);
            emp_fname = fname_txt.Text;
            emp_lname = lname_txt.Text;
            emp_type = emp_type_box.Text;
            emp_email = email_txt.Text;
            emp_gender = gender_box.Text;
            emp_dob = Convert.ToDateTime(dob_datepicker.Text).Date;
            emp_contactno = Convert.ToInt32(Contact_No.Text);
            string currentDateTime = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            auth_id = Convert.ToInt32(admin_auth_id.Text);

            try
            {
                string Query = "Update Employee_tbl set emp_fname = '{0}', emp_lname = '{1}', emp_type = '{2}', emp_email = '{3}', emp_gender = '{4}', emp_birth_day = '{5}', emp_contact_no = '{6}', emp_updated_date = '{7}', emp_updated_by = '{8}' where emp_id = '{9}'";
                Query = string.Format(Query, emp_fname, emp_lname, emp_type, emp_email, emp_gender, emp_dob, emp_contactno, currentDateTime, auth_id, emp_id);
                Con.SetData(Query);

                MessageBox.Show("Employee details update successfully..!");

                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
