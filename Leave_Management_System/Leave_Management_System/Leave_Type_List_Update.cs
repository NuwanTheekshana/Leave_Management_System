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
    public partial class Leave_Type_List_Update_Form : Form
    {
        Functions Con;
        int leave_id, auth_id;
        string leave_type_name, emp_type, leave_count;

        public Leave_Type_List_Update_Form(int id, string leave_type, string leave_emp_type, string emp_leave_count, int admin_id)
        {
            InitializeComponent();
            Con = new Functions();
            leave_id = id;
            leave_type_name = leave_type;
            emp_type = leave_emp_type;
            leave_count = emp_leave_count;
            auth_id = admin_id;
        }
        private void Leave_Type_List_Update_Form_Load(object sender, EventArgs e)
        {
            leave_id_txt.Text = leave_id.ToString();
            leave_type_combox.Text = leave_type_name;
            emp_type_combox.Text = emp_type;
            leave_count_txt.Text = leave_count;
            admin_auth_id.Text = auth_id.ToString();
        }

        private void update_leave_type_btn_Click(object sender, EventArgs e)
        {
            int id, auth_id;
            string leave_type_name, emp_type, leave_count;

            id = Convert.ToInt32(leave_id_txt.Text);
            leave_type_name = leave_type_combox.Text;
            emp_type = emp_type_combox.Text;
            leave_count = leave_count_txt.Text;
            auth_id = Convert.ToInt32(admin_auth_id.Text);
            string currentDateTime = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");

            try
            {

                string Query = "Update Leave_tbl set leave_type = '{0}', leave_emp_type = '{1}', leave_count = '{2}', leave_updated_date = '{3}', leave_updated_by = '{4}' where leave_id = '{5}'";
                Query = string.Format(Query, leave_type_name, emp_type, leave_count, currentDateTime, auth_id, id);
                Con.SetData(Query);

                MessageBox.Show("Leave update successfully..!");

                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void leave_count_txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
}
