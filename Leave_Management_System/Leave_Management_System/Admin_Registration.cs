using Microsoft.Reporting.WinForms;
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
            username_lbl.Text = Login.admin_username;
        }

        //Form Load
        private void Admin_Registration_Load(object sender, EventArgs e)
        {
            Show_admin_list();
            Show_emp_list();
            Show_leave_request();
            Show_leave_type_list();
            this.reportViewer1.RefreshReport();
            show_pending_approval_home();

            report_emp_id_txt.Enabled = false;


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

        public void Show_leave_type_list()
        {
            string Query = "select leave_id, leave_type, leave_emp_type, leave_count, (case when leave_status = 1 then 'Active' else 'Inactive' end) as leave_status from Leave_tbl where leave_status = 1";
            leave_type_list_datagridview.DataSource = Con.GetData(Query);
        }

        public void Show_leave_request()
        {
            string Query = "select lh.leave_his_id, (et.emp_fname+' '+et.emp_lname) employee_name, l.leave_type, lh.leave_purpose, lh.leave_his_start_datetime, lh.leave_his_end_datetime, lh.leave_his_count from Leave_his_tbl lh, Employee_tbl et, Leave_tbl l where lh.emp_id = et.emp_id and lh.leave_id = l.leave_id and lh.leave_his_status = '1'";
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

        private void add_leave_btn_Click(object sender, EventArgs e)
        {
            try
            {
                if (leave_type_combox.Text == "" || emp_type_combox.Text == "" || leave_count_txt.Text == "")
                {
                    MessageBox.Show("Missing Data..!");
                }
                else
                {
                    string leave_type = leave_type_combox.Text;
                    string emp_type = emp_type_combox.Text;
                    int leave_count = Convert.ToInt32(leave_count_txt.Text);
                    int admin_id = Convert.ToInt32(admin_id_lbl.Text);

                    string Query = "insert into Leave_tbl(leave_type, leave_emp_type, leave_count, leave_created_by) values('{0}', '{1}', '{2}', '{3}')";
                    Query = string.Format(Query, leave_type, emp_type, leave_count, admin_id);
                    Con.SetData(Query);

                    MessageBox.Show("Leave details added successfully..!");

                    Show_leave_type_list();
                    leave_type_combox.Text = "";
                    emp_type_combox.Text = "";
                    leave_count_txt.Text = "";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void emp_contact_txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void leave_request_refresh_btn_Click(object sender, EventArgs e)
        {
            Show_leave_request();
        }

 

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void leave_type_list_datagridview_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (leave_type_list_datagridview.Columns[e.ColumnIndex].HeaderText == "Update")
            {
                int id, admin_id;
                string leave_type, leave_emp_type, emp_leave_count;

                id = Convert.ToInt32(leave_type_list_datagridview.Rows[e.RowIndex].Cells["leave_id"].Value);
                leave_type = Convert.ToString(leave_type_list_datagridview.Rows[e.RowIndex].Cells["leave_type_name"].Value);
                leave_emp_type = Convert.ToString(leave_type_list_datagridview.Rows[e.RowIndex].Cells["Leave_emp_type"].Value);
                emp_leave_count = Convert.ToString(leave_type_list_datagridview.Rows[e.RowIndex].Cells["emp_leave_count"].Value);
                admin_id = Convert.ToInt32(admin_id_lbl.Text);

                Leave_Type_List_Update_Form leave_Update_Form = new Leave_Type_List_Update_Form(id, leave_type, leave_emp_type, emp_leave_count, admin_id);
                leave_Update_Form.ShowDialog();
            }



            if (leave_type_list_datagridview.Columns[e.ColumnIndex].HeaderText == "Delete")
            {

                DialogResult confirm = MessageBox.Show("Are you sure you want to delete this user", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (confirm == DialogResult.Yes)
                {
                    int id, admin_id;
                    id = Convert.ToInt32(leave_type_list_datagridview.Rows[e.RowIndex].Cells["leave_id"].Value);
                    admin_id = Convert.ToInt32(admin_id_lbl.Text);

                    try
                    {
                        string currentDateTime = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                        string Query = "Update Leave_tbl set leave_status = 0, leave_updated_date = '{0}', leave_updated_by = '{1}' where leave_id = '{2}'";
                        Query = string.Format(Query, currentDateTime, admin_id, id);
                        Con.SetData(Query);

                        MessageBox.Show("Leave delete successfully..!");
                        Show_leave_type_list();

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }

            }
        }

        public void show_pending_approval_home()
        {
            // Anual Leaves
            string anual_leave_count_query = "select count(leave_his_id) leave_count from Leave_his_tbl where leave_his_status = 1 and leave_id in ('1', '4')";
            DataTable anual_leave_count = Con.GetData(anual_leave_count_query);
            var anualleaveCount = anual_leave_count.Rows[0]["leave_count"];

            anual_leave_count_lbl.Text = anualleaveCount.ToString();

            // Casual Leaves
            string casual_leave_count_query = "select count(leave_his_id) leave_count from Leave_his_tbl where leave_his_status = 1 and leave_id in ('2', '5')";
            DataTable casual_leave_count = Con.GetData(casual_leave_count_query);
            var casualleaveCount = casual_leave_count.Rows[0]["leave_count"];

            casual_leave_count_lbl.Text = casualleaveCount.ToString();

            // Short Leaves
            string short_leave_count_query = "select count(leave_his_id) leave_count from Leave_his_tbl where leave_his_status = 1 and leave_id in ('3', '6')";
            DataTable short_leave_count = Con.GetData(short_leave_count_query);
            var shortleaveCount = short_leave_count.Rows[0]["leave_count"];

            short_leave_count_lbl.Text = shortleaveCount.ToString();


        }

        private void leave_refresh_btn_Click(object sender, EventArgs e)
        {
            Show_leave_type_list();
        }

        private void leave_request_gridview_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (leave_request_gridview.Columns[e.ColumnIndex].HeaderText == "Approve")
            {

                DialogResult confirm = MessageBox.Show("Are you sure you want to approve this leave request", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (confirm == DialogResult.Yes)
                {
                    int id, admin_id;
                    id = Convert.ToInt32(leave_request_gridview.Rows[e.RowIndex].Cells["leave_his_id"].Value);
                    admin_id = Convert.ToInt32(admin_id_lbl.Text);

                    try
                    {
                        string currentDateTime = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                        string Query = "Update Leave_his_tbl set leave_his_status = 2, leave_his_updated_date = '{0}', leave_his_approved_by = '{1}' where leave_his_id = '{2}'";
                        Query = string.Format(Query, currentDateTime, admin_id, id);
                        Con.SetData(Query);

                        MessageBox.Show("Leave request approved successfully..!");
                        Show_leave_request();

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }

            }

            if (leave_request_gridview.Columns[e.ColumnIndex].HeaderText == "Reject")
            {

                DialogResult confirm = MessageBox.Show("Are you sure you want to reject this leave request", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (confirm == DialogResult.Yes)
                {
                    int id, admin_id;
                    id = Convert.ToInt32(leave_request_gridview.Rows[e.RowIndex].Cells["leave_his_id"].Value);
                    admin_id = Convert.ToInt32(admin_id_lbl.Text);

                    try
                    {
                        string currentDateTime = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                        string Query = "Update Leave_his_tbl set leave_his_status = 3, leave_his_updated_date = '{0}', leave_his_approved_by = '{1}' where leave_his_id = '{2}'";
                        Query = string.Format(Query, currentDateTime, admin_id, id);
                        Con.SetData(Query);

                        MessageBox.Show("Leave request rejected..!");
                        Show_leave_request();

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }

            }
        }


        private void report_tab_Click(object sender, EventArgs e)
        {

        }

        private void view_report_Click(object sender, EventArgs e)
        {

            string startDate = start_datetime_picker.Value.ToString("yyyy-MM-dd");
            string endDate = end_datetime_picker.Value.ToString("yyyy-MM-dd");

            if (report_type_combo.Text == "")
            {
                MessageBox.Show("Please select report type..!");
            }

            if (report_type_combo.Text == "Full Report")
            {
                try
                {
                    string Query = "SELECT * FROM leave_his_vm where FORMAT(leave_his_start_datetime, 'yyyy-MM-dd') between  '"+startDate+"' and '"+endDate+"'";
                    DataTable data = Con.GetData(Query);
                    if (data == null)
                    {
                        throw new Exception("Data retrieval failed. Data is null.");
                    }

                    ReportDataSource source = new ReportDataSource("DataSet1", data);
                    this.reportViewer1.LocalReport.DataSources.Clear();
                    reportViewer1.LocalReport.DataSources.Add(source);
                    reportViewer1.RefreshReport();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred: {ex.Message}");
                }
            }
            else if (report_type_combo.Text == "Employee Report")
            {

                if (report_emp_id_txt.Text == "")
                {
                    MessageBox.Show("Please enter the employee id..!");
                }

                try
                {
                    string Query = "SELECT * FROM leave_his_vm where emp_id = '"+ report_emp_id_txt .Text+ "' and FORMAT(leave_his_start_datetime, 'yyyy-MM-dd') between  '"+startDate+"' and '"+endDate+"'";
                    DataTable data = Con.GetData(Query);
                    if (data == null)
                    {
                        throw new Exception("Data retrieval failed. Data is null.");
                    }

                    ReportDataSource source = new ReportDataSource("DataSet1", data);
                    this.reportViewer1.LocalReport.DataSources.Clear();
                    reportViewer1.LocalReport.DataSources.Add(source);
                    reportViewer1.RefreshReport();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred: {ex.Message}");
                }
            }




        }

        private void report_type_combo_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void report_type_combo_TextChanged(object sender, EventArgs e)
        {
            if (report_type_combo.Text == "Full Report")
            {
                report_emp_id_txt.Enabled = false;
            }
            else
            {
                report_emp_id_txt.Enabled = true;
            }
        }

        private void report_emp_id_txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void emp_refresh_btn_Click(object sender, EventArgs e)
        {
            Show_emp_list();
        }

    }
}
