using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Xml.Linq;

namespace Leave_Management_System_Employee
{
    public partial class Emp_Page : Form
    {
        Functions Con;
        Encryption Pass;
        int empn_id;
        string emp_email, emp_username, emp_type;
        public Emp_Page(int emp_id, string emp_email, string emp_username, string emp_type)
        {
            InitializeComponent();
            Con = new Functions();
            Pass = new Encryption();

            emp_id_lbl.Text = Login_page.emp_id + "";
            emp_email_lbl.Text = Login_page.emp_email;
            emp_username_lbl.Text = Login_page.emp_username;
            username_lbl.Text = Login_page.emp_username;
            emp_type_lbl.Text= Login_page.emp_type;
            
        }

        private void logout_btn_Click(object sender, EventArgs e)
        {
            Login_page login = new Login_page();
            login.Show();
            this.Hide();
        }

        private void request_leave_btn_Click(object sender, EventArgs e)
        {
            int emp_id = Convert.ToInt32(emp_id_lbl.Text);

            
            if (leave_type_box.Text == "Short Leaves")
            {
                TimeSpan result = this.end_datetime_picker.Value - this.start_datetime_picker.Value;
                int minutes = (int)result.TotalMinutes;
                
                if (minutes > 90)
                {
                    MessageBox.Show("The maximum duration for a short leave at once is 1 hour and 30 minutes..!");
                    return;
                }

                TimeSpan currenttime =  this.start_datetime_picker.Value - DateTime.Now;
                int currentminutes = (int)currenttime.TotalMinutes;

                if (currentminutes < 0)
                {
                    MessageBox.Show("Short leave should be applied for upcoming time slots..!");
                    return;
                }
                else
                {
                    int leavecount = 1;
                    DateTime now = DateTime.Now;
                    string monthyear = now.ToString("yyyyMM");
                    string start_datetime = start_datetime_picker.Value.ToString("yyyy-MM-dd HH: mm:ss");
                    string end_datetime = end_datetime_picker.Value.ToString("yyyy-MM-dd HH: mm:ss");
                    string allocated_leave_count_query = "select * from Leave_tbl where leave_status = 1 and leave_emp_type = '" + emp_type_lbl.Text + "' and leave_type = '" + leave_type_box.Text + "'";
                    DataTable allocated_leave_count = Con.GetData(allocated_leave_count_query);
                    var allocatedleaveCount = allocated_leave_count.Rows[0]["leave_count"];
                    var leave_id = allocated_leave_count.Rows[0]["leave_id"];
                    string currentleave_count_query = "select count(leave_his_id) leave_count from Leave_his_tbl where leave_his_status != 4 and emp_id = '" + emp_id_lbl.Text + "' and FORMAT(leave_his_start_datetime, 'yyyyMM') = '" + monthyear + "' and leave_id = 3";
                    DataTable current_leave_count = Con.GetData(currentleave_count_query);
                    var currentleaveCount = current_leave_count.Rows[0]["leave_count"];

                    int nowallleave_count = Convert.ToInt32(leavecount) + Convert.ToInt32(currentleaveCount);

                    if (Convert.ToInt32(nowallleave_count) > Convert.ToInt32(allocatedleaveCount))
                    {
                        MessageBox.Show("The leave count has been exceeded this month..!");
                        return;
                    }

                    //Console.WriteLine("allocated leave count for the month " + allocatedleaveCount);
                    //Console.WriteLine("current leave count for the month " + currentleaveCount);
                    //Console.WriteLine("all leave count " + nowallleave_count);
                    //return;

                    string Query = "insert into Leave_his_tbl(leave_id, emp_id, leave_purpose, leave_his_count, leave_his_start_datetime, leave_his_end_datetime) values('{0}', '{1}', '{2}', '{3}', '{4}', '{5}')";
                    Query = string.Format(Query, leave_id, emp_id_lbl.Text, leave_purpose.Text, leavecount, start_datetime, end_datetime);
                    Con.SetData(Query);
                    MessageBox.Show("Leave Request submited..!");
                    Show_pending_leave_requests();
                    leave_type_box.Text = "";
                    start_datetime_picker.Text = "";
                    end_datetime_picker.Text = "";
                    leave_purpose.Text = "";

                }


            }
            else
            {
                TimeSpan result = this.end_datetime_picker.Value - this.start_datetime_picker.Value;
                int leavecount = (int)result.TotalDays;
                DateTime now = DateTime.Now;
                int year = now.Year;
                string start_datetime = start_datetime_picker.Value.ToString("yyyy-MM-dd HH: mm:ss");
                string end_datetime = end_datetime_picker.Value.ToString("yyyy-MM-dd HH: mm:ss");

                string allocated_leave_count_query = "select * from Leave_tbl where leave_status = 1 and leave_emp_type = '" + emp_type_lbl.Text + "' and leave_type = '" + leave_type_box.Text + "'";
                DataTable allocated_leave_count = Con.GetData(allocated_leave_count_query);
                var allocatedleaveCount = allocated_leave_count.Rows[0]["leave_count"];
                var leave_id = allocated_leave_count.Rows[0]["leave_id"];

                string currentleave_count_query = "select count(leave_his_id) leave_count from Leave_his_tbl where leave_his_status != 4 and emp_id = '" + emp_id_lbl.Text + "' and FORMAT(leave_his_start_datetime, 'yyyy') = '" + year + "' and leave_id = '"+leave_id+"'";
                DataTable current_leave_count = Con.GetData(currentleave_count_query);
                var currentleaveCount = current_leave_count.Rows[0]["leave_count"];

                int nowallleave_count = Convert.ToInt32(leavecount) + Convert.ToInt32(currentleaveCount);

                if (Convert.ToInt32(nowallleave_count) > Convert.ToInt32(allocatedleaveCount))
                {
                    MessageBox.Show("The leave count has been exceeded this month..!");
                    return;
                }

                if (leave_type_box.Text == "Anual Leave")
                {
                    DateTime leaveStartDate = this.start_datetime_picker.Value;
                    DateTime minimumDate = DateTime.Today.AddDays(7);

                    if (leaveStartDate < minimumDate)
                    {
                        MessageBox.Show("Leave application must be submitted at least 7 days in advance.");
                        return; 
                    }

                }

                if (leave_type_box.Text == "Casual Leave")
                {
                    DateTime leaveStartDate = this.start_datetime_picker.Value;
                    DateTime currentdate = DateTime.Today;

                    if (leaveStartDate < currentdate)
                    {
                        MessageBox.Show("Casual leave applications must be submitted before the roster starts..!");
                        return;
                    }

                }



                string Query = "insert into Leave_his_tbl(leave_id, emp_id, leave_purpose, leave_his_count, leave_his_start_datetime, leave_his_end_datetime) values('{0}', '{1}', '{2}', '{3}', '{4}', '{5}')";
                Query = string.Format(Query, leave_id, emp_id_lbl.Text, leave_purpose.Text, leavecount, start_datetime, end_datetime);
                Con.SetData(Query);

                MessageBox.Show("Leave Request submited..!");
                Show_pending_leave_requests();
                leave_type_box.Text = "";
                start_datetime_picker.Text = "";
                end_datetime_picker.Text = "";
                leave_purpose.Text = "";
            }


        }

        private void leave_pending_refresh_btn_Click(object sender, EventArgs e)
        {
            Show_pending_leave_requests();
        }

        private void pending_leave_datagrid_view_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (pending_leave_datagrid_view.Columns[e.ColumnIndex].HeaderText == "Delete")
            {

                DialogResult confirm = MessageBox.Show("Are you sure you want to delete this leave request", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (confirm == DialogResult.Yes)
                {
                    int id;
                    id = Convert.ToInt32(pending_leave_datagrid_view.Rows[e.RowIndex].Cells["Id"].Value);

                    try
                    {
                        string currentDateTime = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                        string Query = "Update Leave_his_tbl set leave_his_status = 4, leave_his_updated_date = '{0}' where leave_his_id = '{1}'";
                        Query = string.Format(Query, currentDateTime, id);
                        Con.SetData(Query);

                        MessageBox.Show("Leave request delete successfully..!");
                        Show_pending_leave_requests();

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }

            }
        }

        public void Show_pending_leave_requests()
        {
            string Query = "select lh.leave_his_id, l.leave_type, lh.leave_purpose, lh.leave_his_start_datetime, lh.leave_his_end_datetime from Leave_his_tbl lh, Leave_tbl l where lh.leave_id = l.leave_id and leave_his_status = 1 and emp_id = '" + emp_id_lbl.Text + "'";
            pending_leave_datagrid_view.DataSource = Con.GetData(Query);
        }

        public void Show_leave_history()
        {
            string Query = "select lh.leave_his_id, l.leave_type, lh.leave_purpose, lh.leave_his_start_datetime, lh.leave_his_end_datetime, (case when leave_his_status = '1' then 'Pending' when leave_his_status = '2' then 'Approved' when leave_his_status = '3' then 'Reject' when leave_his_status = '4' then 'Delete' end) leave_status, leave_his_count  from Leave_his_tbl lh, Leave_tbl l where lh.leave_id = l.leave_id and leave_his_status != 4 and emp_id = '" + emp_id_lbl.Text + "'";
            leave_his_gridview.DataSource = Con.GetData(Query);
        }

        public void Show_employee_home()
        {
            DateTime now = DateTime.Now;
            int year = now.Year;
            string monthyear = now.ToString("yyyyMM");
            // Anual Leaves
            string allocated_anual_leave_count_query = "select * from Leave_tbl where leave_status = 1 and leave_emp_type = '" + emp_type_lbl.Text + "' and leave_type = 'Anual Leave'";
            DataTable allocated_anual_leave_count = Con.GetData(allocated_anual_leave_count_query);
            var allocatedanualleaveCount = allocated_anual_leave_count.Rows[0]["leave_count"];
            var leave_id = allocated_anual_leave_count.Rows[0]["leave_id"];

            string currentleave_count_query = "select count(leave_his_id) leave_count from Leave_his_tbl where leave_his_status != 4 and emp_id = '" + emp_id_lbl.Text + "' and FORMAT(leave_his_start_datetime, 'yyyy') = '" + year + "' and leave_id = '" + leave_id + "'";
            DataTable current_leave_count = Con.GetData(currentleave_count_query);
            var currentleaveCount = current_leave_count.Rows[0]["leave_count"];

            int availble_leave_count = Convert.ToInt32(allocatedanualleaveCount) - Convert.ToInt32(currentleaveCount);
            anual_leave_count_lbl.Text = availble_leave_count.ToString();

            // Casual Leaves
            string allocated_casual_leave_count_query = "select * from Leave_tbl where leave_status = 1 and leave_emp_type = '" + emp_type_lbl.Text + "' and leave_type = 'Casual Leave'";
            DataTable allocated_casual_leave_count = Con.GetData(allocated_casual_leave_count_query);
            var allocatedcasualleaveCount = allocated_casual_leave_count.Rows[0]["leave_count"];
            var casual_leave_id = allocated_casual_leave_count.Rows[0]["leave_id"];

            string currentcasualleave_count_query = "select count(leave_his_id) leave_count from Leave_his_tbl where leave_his_status != 4 and emp_id = '" + emp_id_lbl.Text + "' and FORMAT(leave_his_start_datetime, 'yyyy') = '" + year + "' and leave_id = '" + casual_leave_id + "'";
            DataTable current_casual_leave_count = Con.GetData(currentcasualleave_count_query);
            var currentcasualleaveCount = current_casual_leave_count.Rows[0]["leave_count"];

            int availble_casual_leave_count = Convert.ToInt32(allocatedcasualleaveCount) - Convert.ToInt32(currentcasualleaveCount);
            casual_leave_count_lbl.Text = availble_casual_leave_count.ToString();

            // Short Leaves
            string allocated_short_leave_count_query = "select * from Leave_tbl where leave_status = 1 and leave_emp_type = '" + emp_type_lbl.Text + "' and leave_type = 'Short Leaves'";
            DataTable allocated_short_leave_count = Con.GetData(allocated_short_leave_count_query);
            var allocatedshortleaveCount = allocated_short_leave_count.Rows[0]["leave_count"];
            var short_leave_id = allocated_short_leave_count.Rows[0]["leave_id"];

            string currentshortleave_count_query = "select count(leave_his_id) leave_count from Leave_his_tbl where leave_his_status != 4 and emp_id = '" + emp_id_lbl.Text + "' and FORMAT(leave_his_start_datetime, 'yyyyMM') = '" + monthyear + "' and leave_id = '" + short_leave_id + "'";
            DataTable current_short_leave_count = Con.GetData(currentshortleave_count_query);
            var currentshortleaveCount = current_short_leave_count.Rows[0]["leave_count"];

            int availble_short_leave_count = Convert.ToInt32(allocatedshortleaveCount) - Convert.ToInt32(currentshortleaveCount);
            short_leave_count_lbl.Text = availble_short_leave_count.ToString();


        }

        private void Emp_Page_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'leave_management_dbDataSet1.leave_type' table. You can move, or remove it, as needed.
            this.leave_typeTableAdapter.Fill(this.leave_management_dbDataSet1.leave_type);
            Show_pending_leave_requests();
            Show_leave_history();
            Show_employee_home();
        }
    }
}
