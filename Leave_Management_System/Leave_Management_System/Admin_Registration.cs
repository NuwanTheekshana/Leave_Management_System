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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        public void Show_admin_list()
        {
            string Query = "select admin_id, admin_fname, admin_lname, admin_email, (case when admin_status = 1 then 'Active' else 'Inactive' end) as admin_status from Admin_tbl where admin_status = 1";
            AdminListGrid.DataSource = Con.GetData(Query);
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

        int Key = 0;
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


        private void Admin_Registration_Load(object sender, EventArgs e)
        {
            Show_admin_list();
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

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
