using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Leave_Management_System
{
    public partial class Admin_Registration : Form
    {
        Functions Con;
        Encryption Pass;
        int admin_id;
        string admin_email, admin_username;
        public Admin_Registration(int admin_id, string admin_email, string admin_username)
        {
            InitializeComponent();
            Con = new Functions();
            Pass = new Encryption();

            admin_id_lbl.Text = Login.admin_id + "";
            admin_email_lbl.Text = Login.admin_email;
            admin_username_lbl.Text = Login.admin_username;
        }

        //Form Load
        private void Admin_Registration_Load(object sender, EventArgs e)
        {
            Show_admin_list();
            Show_emp_list();
            Show_leave_request();
        }
        public void Show_admin_list()
        {
            string Query = "select admin_id, admin_fname, admin_lname, admin_email, (case when admin_status = 1 then 'Active' else 'Inactive' end) as admin_status from Admin_tbl where admin_status = 1";
            AdminListGrid.DataSource = Con.GetData(Query);
        }

        public void Show_emp_list()
        {
            string Query = "select emp_id, emp_fname, emp_lname, emp_email, (case when emp_status = 1 then 'Active' else 'Inactive' end) as emp_status, emp_type, emp_gender, emp_birth_day, emp_contact_no from Employee_tbl where emp_status = 1";
            emp_datagrid_view.DataSource = Con.GetData(Query);
        }

        public void Show_leave_request()
        {
            string Query = "select lh.leave_his_id," +
                            "et.emp_fname+' '+et.emp_lname as employee_name," +
                            "l.leave_type," +
                            "lh.leave_purpose," +
                            "lh.leave_his_start_datetime," +
                            "lh.leave_his_end_datetime," +
                            "lh.leave_his_count" +
                            "from Leave_his_tbl lh, Employee_tbl et, Leave_tbl l" +
                            "where lh.emp_id = et.emp_id" +
                            "and lh.leave_id = l.leave_id" +
                            "and lh.leave_his_status = '1'";
            leave_request_gridview.DataSource = Con.GetData(Query);
        }

        private void admin_add_btn_Click_1(object sender, EventArgs e)
        {
            string emailPattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
            try
            {
                if (fname_txt.Text == "" || lname_txt.Text == "" || email_txt.Text == "" || password_txt.Text == "" || cpassword_txt.Text == "")
                {
                    MessageBox.Show("Missing Data..!");
                }
                else if (!Regex.IsMatch(email_txt.Text, emailPattern))
                {
                    MessageBox.Show("Invalid email format. Please enter a valid email..!");
                }
                else if (password_txt.Text != cpassword_txt.Text)
                {
                    MessageBox.Show("The two password combinations are incorrect..!");
                }
                else
                {
                    string fname = fname_txt.Text;
                    string lname = lname_txt.Text;
                    string email = email_txt.Text;
                    string password = password_txt.Text;

                    string encryptedText = Pass.HashPassword(password);

                    string Query = "insert into Admin_tbl(admin_fname, admin_lname, admin_email, admin_password) values('{0}', '{1}', '{2}', '{3}')";
                    Query = string.Format(Query, fname, lname, email, encryptedText);
                    Con.SetData(Query);

                    MessageBox.Show("Admin details added successfully..!");

                    Show_admin_list();
                    fname_txt.Text = "";
                    lname_txt.Text = "";
                    email_txt.Text = "";
                    password_txt.Text = "";
                    cpassword_txt.Text = "";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }
        private void AdminListGrid_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (AdminListGrid.Columns[e.ColumnIndex].HeaderText == "Update")
            {
                int id;
                string firstName, lastName, email;

                id = Convert.ToInt32(AdminListGrid.Rows[e.RowIndex].Cells["Id"].Value);
                firstName = Convert.ToString(AdminListGrid.Rows[e.RowIndex].Cells["First_Name"].Value);
                lastName = Convert.ToString(AdminListGrid.Rows[e.RowIndex].Cells["Last_Name"].Value);
                email = Convert.ToString(AdminListGrid.Rows[e.RowIndex].Cells["Email"].Value);

                Admin_User_Update_Form user_Update_Form = new Admin_User_Update_Form(id, firstName, lastName, email);
                user_Update_Form.ShowDialog();
            }



            if (AdminListGrid.Columns[e.ColumnIndex].HeaderText == "Delete")
            {

                DialogResult confirm = MessageBox.Show("Are you sure you want to delete this user", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if(confirm == DialogResult.Yes)
                {
                    int id;
                    id = Convert.ToInt32(AdminListGrid.Rows[e.RowIndex].Cells["Id"].Value);

                    try
                    {
                        DateTime currentDateTime = DateTime.Now;
                        string Query = "Update Admin_tbl set admin_status = 0, admin_updated_date = '{0}' where admin_id = '{1}'";
                        Query = string.Format(Query, currentDateTime, id);
                        Con.SetData(Query);

                        MessageBox.Show("Admin user delete successfully..!");
                        Show_admin_list();

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
                
            }
        }


        private void Refresh_Click_1(object sender, EventArgs e)
        {
            Show_admin_list();
        }

        private void logout_btn_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }

        private void add_emp_btn_Click(object sender, EventArgs e)
        {
            
            string emailPattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
            try
            {
                if (emp_fname_txt.Text == "" || emp_lname_txt.Text == "" || gender_box.Text == "" || dob_datepicker.Text == "" || emp_contact_txt.Text == "" || emp_email_txt.Text == "" || emp_type_box.Text == "" || emp_password_txt.Text == "")
                {
                    MessageBox.Show("Missing Data..!");
                }
                else if (!Regex.IsMatch(emp_email_txt.Text, emailPattern))
                {
                    MessageBox.Show("Invalid email format. Please enter a valid email..!");
                }
                else if (admin_id_lbl.Text == "")
                {
                    MessageBox.Show("Invalid Login..!");
                }
                else
                {
                    string fname = emp_fname_txt.Text;
                    string lname = emp_lname_txt.Text;
                    string gender = gender_box.Text;
                    string dob = dob_datepicker.Text;
                    string contact_no = emp_contact_txt.Text;
                    string email = emp_email_txt.Text;
                    string emp_type = emp_type_box.Text;
                    string password = emp_password_txt.Text;
                    string admin_id = admin_id_lbl.Text;

                    string encryptedPassword = Pass.HashPassword(password);

                    string Query = "insert into Employee_tbl(emp_fname, emp_lname, emp_email, emp_password, emp_type, emp_created_by, emp_gender, emp_birth_day, emp_contact_no) values('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}', '{7}', '{8}')";
                    Query = string.Format(Query, fname, lname, email, encryptedPassword, emp_type, admin_id, gender, dob, contact_no);
                    Con.SetData(Query);

                    MessageBox.Show("Employee details added successfully..!");

                    Show_admin_list();
                    emp_fname_txt.Text = "";
                    emp_lname_txt.Text = "";
                    gender_box.Text = "";
                    dob_datepicker.Text = "";
                    emp_contact_txt.Text = "";
                    emp_email_txt.Text = "";
                    emp_type_box.Text = "";
                    emp_password_txt.Text = "";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void emp_datagrid_view_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (emp_datagrid_view.Columns[e.ColumnIndex].HeaderText == "Update")
            {
                int id, Contact_No, admin_id;
                string firstName, lastName, Emp_Type, Email, Gender;
                DateTime DOB;
                

                id = Convert.ToInt32(emp_datagrid_view.Rows[e.RowIndex].Cells["Emp_id"].Value);
                firstName = Convert.ToString(emp_datagrid_view.Rows[e.RowIndex].Cells["Emp_Fname"].Value);
                lastName = Convert.ToString(emp_datagrid_view.Rows[e.RowIndex].Cells["Emp_Lname"].Value);
                Emp_Type = Convert.ToString(emp_datagrid_view.Rows[e.RowIndex].Cells["Emp_Type"].Value);
                Email = Convert.ToString(emp_datagrid_view.Rows[e.RowIndex].Cells["emp_email"].Value);
                Gender = Convert.ToString(emp_datagrid_view.Rows[e.RowIndex].Cells["emp_gender"].Value);
                DOB = Convert.ToDateTime(emp_datagrid_view.Rows[e.RowIndex].Cells["DOB"].Value);
                Contact_No = Convert.ToInt32(emp_datagrid_view.Rows[e.RowIndex].Cells["emp_contact_no"].Value);
                admin_id = Convert.ToInt32(admin_id_lbl.Text);

                Emp_Registration_Update emp_Update_Form = new Emp_Registration_Update(id, firstName, lastName, Emp_Type, Email, Gender, DOB, Contact_No, admin_id);
                emp_Update_Form.ShowDialog();
            }



            if (emp_datagrid_view.Columns[e.ColumnIndex].HeaderText == "Delete")
            {

                DialogResult confirm = MessageBox.Show("Are you sure you want to delete this employee", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (confirm == DialogResult.Yes)
                {
                    int id;
                    id = Convert.ToInt32(emp_datagrid_view.Rows[e.RowIndex].Cells["Emp_id"].Value);

                    try
                    {
                        string currentDateTime = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                        string Query = "Update Employee_tbl set emp_status = 0, emp_updated_date = '{0}' where emp_id = '{1}'";
                        Query = string.Format(Query, currentDateTime, id);
                        Con.SetData(Query);

                        MessageBox.Show("Employee user delete successfully..!");
                        Show_admin_list();

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }

            }
        }

        private void emp_contact_txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void emp_contact_txt_TextChanged(object sender, EventArgs e)
        {

        }

        private void tabPage3_Click(object sender, EventArgs e)
        {

        }

        private void leave_request_refresh_btn_Click(object sender, EventArgs e)
        {
            Show_leave_request();
        }

        private void emp_refresh_btn_Click(object sender, EventArgs e)
        {
            Show_emp_list();
        }

    }
}
