namespace Leave_Management_System_Employee
{
    partial class Emp_Page
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.home = new System.Windows.Forms.TabPage();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.short_leave_count_lbl = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.casual_leave_count_lbl = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.anual_leave_count_lbl = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.username_lbl = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.leave_request = new System.Windows.Forms.TabPage();
            this.leave_pending_refresh_btn = new System.Windows.Forms.Button();
            this.label17 = new System.Windows.Forms.Label();
            this.pending_leave_datagrid_view = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.leave_type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emp_leave_purpose = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.leave_his_start_datetime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.leave_his_end_datetime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Delete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.panel4 = new System.Windows.Forms.Panel();
            this.leave_purpose = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.request_leave_btn = new System.Windows.Forms.Button();
            this.end_datetime_picker = new System.Windows.Forms.DateTimePicker();
            this.start_datetime_picker = new System.Windows.Forms.DateTimePicker();
            this.leave_type_box = new System.Windows.Forms.ComboBox();
            this.leavetypeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.leave_management_dbDataSet1 = new Leave_Management_System_Employee.leave_management_dbDataSet1();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.leave_history = new System.Windows.Forms.TabPage();
            this.leave_his_gridview = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.leave_count = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.leave_status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.user_profile = new System.Windows.Forms.TabPage();
            this.panel7 = new System.Windows.Forms.Panel();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.emp_type_lbl = new System.Windows.Forms.Label();
            this.logout_btn = new System.Windows.Forms.Button();
            this.emp_email_lbl = new System.Windows.Forms.Label();
            this.emp_username_lbl = new System.Windows.Forms.Label();
            this.emp_id_lbl = new System.Windows.Forms.Label();
            this.leave_management_dbDataSet = new Leave_Management_System_Employee.leave_management_dbDataSet();
            this.leavetblBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.leave_tblTableAdapter = new Leave_Management_System_Employee.leave_management_dbDataSetTableAdapters.Leave_tblTableAdapter();
            this.leave_typeTableAdapter = new Leave_Management_System_Employee.leave_management_dbDataSet1TableAdapters.leave_typeTableAdapter();
            this.tabControl1.SuspendLayout();
            this.home.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel3.SuspendLayout();
            this.leave_request.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pending_leave_datagrid_view)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.leavetypeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.leave_management_dbDataSet1)).BeginInit();
            this.panel1.SuspendLayout();
            this.leave_history.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.leave_his_gridview)).BeginInit();
            this.panel2.SuspendLayout();
            this.user_profile.SuspendLayout();
            this.panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.leave_management_dbDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.leavetblBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.home);
            this.tabControl1.Controls.Add(this.leave_request);
            this.tabControl1.Controls.Add(this.leave_history);
            this.tabControl1.Controls.Add(this.user_profile);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(899, 545);
            this.tabControl1.TabIndex = 0;
            // 
            // home
            // 
            this.home.Controls.Add(this.panel6);
            this.home.Controls.Add(this.panel5);
            this.home.Controls.Add(this.panel3);
            this.home.Controls.Add(this.label4);
            this.home.Controls.Add(this.username_lbl);
            this.home.Controls.Add(this.label3);
            this.home.Location = new System.Drawing.Point(4, 22);
            this.home.Name = "home";
            this.home.Padding = new System.Windows.Forms.Padding(3);
            this.home.Size = new System.Drawing.Size(891, 519);
            this.home.TabIndex = 0;
            this.home.Text = "Home";
            this.home.UseVisualStyleBackColor = true;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.RosyBrown;
            this.panel6.Controls.Add(this.label8);
            this.panel6.Controls.Add(this.short_leave_count_lbl);
            this.panel6.Location = new System.Drawing.Point(619, 186);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(221, 195);
            this.panel6.TabIndex = 7;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(65, 126);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(90, 20);
            this.label8.TabIndex = 4;
            this.label8.Text = "Short Leaves";
            // 
            // short_leave_count_lbl
            // 
            this.short_leave_count_lbl.AutoSize = true;
            this.short_leave_count_lbl.Font = new System.Drawing.Font("Arial", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.short_leave_count_lbl.Location = new System.Drawing.Point(73, 49);
            this.short_leave_count_lbl.Name = "short_leave_count_lbl";
            this.short_leave_count_lbl.Size = new System.Drawing.Size(78, 56);
            this.short_leave_count_lbl.TabIndex = 0;
            this.short_leave_count_lbl.Text = "00";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.RosyBrown;
            this.panel5.Controls.Add(this.label6);
            this.panel5.Controls.Add(this.casual_leave_count_lbl);
            this.panel5.Location = new System.Drawing.Point(335, 186);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(221, 195);
            this.panel5.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(65, 126);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(98, 20);
            this.label6.TabIndex = 4;
            this.label6.Text = "Casual Leaves";
            // 
            // casual_leave_count_lbl
            // 
            this.casual_leave_count_lbl.AutoSize = true;
            this.casual_leave_count_lbl.Font = new System.Drawing.Font("Arial", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.casual_leave_count_lbl.Location = new System.Drawing.Point(73, 49);
            this.casual_leave_count_lbl.Name = "casual_leave_count_lbl";
            this.casual_leave_count_lbl.Size = new System.Drawing.Size(78, 56);
            this.casual_leave_count_lbl.TabIndex = 0;
            this.casual_leave_count_lbl.Text = "00";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.RosyBrown;
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.anual_leave_count_lbl);
            this.panel3.Location = new System.Drawing.Point(57, 186);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(221, 195);
            this.panel3.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(65, 126);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Anual Leaves";
            // 
            // anual_leave_count_lbl
            // 
            this.anual_leave_count_lbl.AutoSize = true;
            this.anual_leave_count_lbl.Font = new System.Drawing.Font("Arial", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.anual_leave_count_lbl.Location = new System.Drawing.Point(79, 49);
            this.anual_leave_count_lbl.Name = "anual_leave_count_lbl";
            this.anual_leave_count_lbl.Size = new System.Drawing.Size(78, 56);
            this.anual_leave_count_lbl.TabIndex = 0;
            this.anual_leave_count_lbl.Text = "00";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(359, 137);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(165, 22);
            this.label4.TabIndex = 3;
            this.label4.Text = "Available Leaves";
            // 
            // username_lbl
            // 
            this.username_lbl.AutoSize = true;
            this.username_lbl.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.username_lbl.Location = new System.Drawing.Point(398, 66);
            this.username_lbl.Name = "username_lbl";
            this.username_lbl.Size = new System.Drawing.Size(88, 23);
            this.username_lbl.TabIndex = 2;
            this.username_lbl.Text = "UserName";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label3.Location = new System.Drawing.Point(65, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(783, 34);
            this.label3.TabIndex = 1;
            this.label3.Text = "Welcome Leave Management System - Employee Portal";
            // 
            // leave_request
            // 
            this.leave_request.Controls.Add(this.leave_pending_refresh_btn);
            this.leave_request.Controls.Add(this.label17);
            this.leave_request.Controls.Add(this.pending_leave_datagrid_view);
            this.leave_request.Controls.Add(this.panel4);
            this.leave_request.Controls.Add(this.leave_purpose);
            this.leave_request.Controls.Add(this.label15);
            this.leave_request.Controls.Add(this.request_leave_btn);
            this.leave_request.Controls.Add(this.end_datetime_picker);
            this.leave_request.Controls.Add(this.start_datetime_picker);
            this.leave_request.Controls.Add(this.leave_type_box);
            this.leave_request.Controls.Add(this.label11);
            this.leave_request.Controls.Add(this.label10);
            this.leave_request.Controls.Add(this.label9);
            this.leave_request.Controls.Add(this.panel1);
            this.leave_request.Location = new System.Drawing.Point(4, 22);
            this.leave_request.Name = "leave_request";
            this.leave_request.Padding = new System.Windows.Forms.Padding(3);
            this.leave_request.Size = new System.Drawing.Size(891, 519);
            this.leave_request.TabIndex = 1;
            this.leave_request.Text = "Leave Request";
            this.leave_request.UseVisualStyleBackColor = true;
            // 
            // leave_pending_refresh_btn
            // 
            this.leave_pending_refresh_btn.Location = new System.Drawing.Point(795, 270);
            this.leave_pending_refresh_btn.Margin = new System.Windows.Forms.Padding(2);
            this.leave_pending_refresh_btn.Name = "leave_pending_refresh_btn";
            this.leave_pending_refresh_btn.Size = new System.Drawing.Size(56, 19);
            this.leave_pending_refresh_btn.TabIndex = 49;
            this.leave_pending_refresh_btn.Text = "Refresh";
            this.leave_pending_refresh_btn.UseVisualStyleBackColor = true;
            this.leave_pending_refresh_btn.Click += new System.EventHandler(this.leave_pending_refresh_btn_Click);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label17.Location = new System.Drawing.Point(344, 265);
            this.label17.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(243, 24);
            this.label17.TabIndex = 48;
            this.label17.Text = "Pending Leave Requests";
            // 
            // pending_leave_datagrid_view
            // 
            this.pending_leave_datagrid_view.BackgroundColor = System.Drawing.SystemColors.Window;
            this.pending_leave_datagrid_view.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.pending_leave_datagrid_view.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.pending_leave_datagrid_view.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.leave_type,
            this.emp_leave_purpose,
            this.leave_his_start_datetime,
            this.leave_his_end_datetime,
            this.Delete});
            this.pending_leave_datagrid_view.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pending_leave_datagrid_view.Location = new System.Drawing.Point(3, 300);
            this.pending_leave_datagrid_view.Margin = new System.Windows.Forms.Padding(2);
            this.pending_leave_datagrid_view.Name = "pending_leave_datagrid_view";
            this.pending_leave_datagrid_view.RowHeadersWidth = 51;
            this.pending_leave_datagrid_view.RowTemplate.Height = 24;
            this.pending_leave_datagrid_view.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.pending_leave_datagrid_view.Size = new System.Drawing.Size(885, 216);
            this.pending_leave_datagrid_view.TabIndex = 47;
            this.pending_leave_datagrid_view.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.pending_leave_datagrid_view_CellContentClick);
            // 
            // Id
            // 
            this.Id.DataPropertyName = "leave_his_id";
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            // 
            // leave_type
            // 
            this.leave_type.DataPropertyName = "leave_type";
            this.leave_type.HeaderText = "Leave Type";
            this.leave_type.Name = "leave_type";
            // 
            // emp_leave_purpose
            // 
            this.emp_leave_purpose.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.emp_leave_purpose.DataPropertyName = "leave_purpose";
            this.emp_leave_purpose.HeaderText = "Leave Purpose";
            this.emp_leave_purpose.Name = "emp_leave_purpose";
            // 
            // leave_his_start_datetime
            // 
            this.leave_his_start_datetime.DataPropertyName = "leave_his_start_datetime";
            this.leave_his_start_datetime.HeaderText = "Start Date";
            this.leave_his_start_datetime.Name = "leave_his_start_datetime";
            // 
            // leave_his_end_datetime
            // 
            this.leave_his_end_datetime.DataPropertyName = "leave_his_end_datetime";
            this.leave_his_end_datetime.HeaderText = "End Date";
            this.leave_his_end_datetime.Name = "leave_his_end_datetime";
            // 
            // Delete
            // 
            this.Delete.HeaderText = "Delete";
            this.Delete.Name = "Delete";
            this.Delete.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Delete.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Delete.Text = "Delete";
            this.Delete.UseColumnTextForButtonValue = true;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.CornflowerBlue;
            this.panel4.Location = new System.Drawing.Point(-21, 243);
            this.panel4.Margin = new System.Windows.Forms.Padding(2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(932, 10);
            this.panel4.TabIndex = 46;
            // 
            // leave_purpose
            // 
            this.leave_purpose.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.leave_purpose.Location = new System.Drawing.Point(641, 129);
            this.leave_purpose.Margin = new System.Windows.Forms.Padding(2);
            this.leave_purpose.Multiline = true;
            this.leave_purpose.Name = "leave_purpose";
            this.leave_purpose.Size = new System.Drawing.Size(222, 24);
            this.leave_purpose.TabIndex = 45;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(493, 127);
            this.label15.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(128, 20);
            this.label15.TabIndex = 44;
            this.label15.Text = "Leave Purpose";
            // 
            // request_leave_btn
            // 
            this.request_leave_btn.BackColor = System.Drawing.Color.White;
            this.request_leave_btn.FlatAppearance.BorderColor = System.Drawing.Color.CornflowerBlue;
            this.request_leave_btn.FlatAppearance.BorderSize = 3;
            this.request_leave_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.request_leave_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.request_leave_btn.ForeColor = System.Drawing.Color.DarkBlue;
            this.request_leave_btn.Location = new System.Drawing.Point(402, 185);
            this.request_leave_btn.Margin = new System.Windows.Forms.Padding(2);
            this.request_leave_btn.Name = "request_leave_btn";
            this.request_leave_btn.Size = new System.Drawing.Size(147, 36);
            this.request_leave_btn.TabIndex = 43;
            this.request_leave_btn.Text = "Request Leave";
            this.request_leave_btn.UseVisualStyleBackColor = false;
            this.request_leave_btn.Click += new System.EventHandler(this.request_leave_btn_Click);
            // 
            // end_datetime_picker
            // 
            this.end_datetime_picker.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.end_datetime_picker.CustomFormat = "dd-MM-yyyy hh:mm tt";
            this.end_datetime_picker.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.end_datetime_picker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.end_datetime_picker.Location = new System.Drawing.Point(190, 127);
            this.end_datetime_picker.Name = "end_datetime_picker";
            this.end_datetime_picker.Size = new System.Drawing.Size(222, 26);
            this.end_datetime_picker.TabIndex = 41;
            // 
            // start_datetime_picker
            // 
            this.start_datetime_picker.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.start_datetime_picker.CustomFormat = "dd-MM-yyyy hh:mm tt";
            this.start_datetime_picker.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.start_datetime_picker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.start_datetime_picker.Location = new System.Drawing.Point(641, 81);
            this.start_datetime_picker.Name = "start_datetime_picker";
            this.start_datetime_picker.Size = new System.Drawing.Size(222, 26);
            this.start_datetime_picker.TabIndex = 40;
            // 
            // leave_type_box
            // 
            this.leave_type_box.DataSource = this.leavetypeBindingSource;
            this.leave_type_box.DisplayMember = "leave_type";
            this.leave_type_box.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.leave_type_box.FormattingEnabled = true;
            this.leave_type_box.Location = new System.Drawing.Point(190, 79);
            this.leave_type_box.Name = "leave_type_box";
            this.leave_type_box.Size = new System.Drawing.Size(222, 28);
            this.leave_type_box.TabIndex = 38;
            // 
            // leavetypeBindingSource
            // 
            this.leavetypeBindingSource.DataMember = "leave_type";
            this.leavetypeBindingSource.DataSource = this.leave_management_dbDataSet1;
            // 
            // leave_management_dbDataSet1
            // 
            this.leave_management_dbDataSet1.DataSetName = "leave_management_dbDataSet1";
            this.leave_management_dbDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(16, 124);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(123, 20);
            this.label11.TabIndex = 37;
            this.label11.Text = "End DateTime";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(493, 81);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(131, 20);
            this.label10.TabIndex = 35;
            this.label10.Text = "Start DateTime";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(16, 81);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(100, 20);
            this.label9.TabIndex = 33;
            this.label9.Text = "Leave Type";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.CornflowerBlue;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(885, 44);
            this.panel1.TabIndex = 23;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(288, 11);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(249, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Employee Leave Request";
            // 
            // leave_history
            // 
            this.leave_history.Controls.Add(this.leave_his_gridview);
            this.leave_history.Controls.Add(this.panel2);
            this.leave_history.Location = new System.Drawing.Point(4, 22);
            this.leave_history.Name = "leave_history";
            this.leave_history.Size = new System.Drawing.Size(891, 519);
            this.leave_history.TabIndex = 2;
            this.leave_history.Text = "Leave History";
            this.leave_history.UseVisualStyleBackColor = true;
            // 
            // leave_his_gridview
            // 
            this.leave_his_gridview.BackgroundColor = System.Drawing.SystemColors.Window;
            this.leave_his_gridview.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.leave_his_gridview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.leave_his_gridview.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.leave_count,
            this.leave_status});
            this.leave_his_gridview.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.leave_his_gridview.Location = new System.Drawing.Point(0, 48);
            this.leave_his_gridview.Margin = new System.Windows.Forms.Padding(2);
            this.leave_his_gridview.Name = "leave_his_gridview";
            this.leave_his_gridview.RowHeadersWidth = 51;
            this.leave_his_gridview.RowTemplate.Height = 24;
            this.leave_his_gridview.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.leave_his_gridview.Size = new System.Drawing.Size(891, 471);
            this.leave_his_gridview.TabIndex = 48;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "leave_his_id";
            this.dataGridViewTextBoxColumn1.HeaderText = "Id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "leave_type";
            this.dataGridViewTextBoxColumn2.HeaderText = "Leave Type";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn3.DataPropertyName = "leave_purpose";
            this.dataGridViewTextBoxColumn3.HeaderText = "Leave Purpose";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "leave_his_start_datetime";
            this.dataGridViewTextBoxColumn4.HeaderText = "Start Date";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "leave_his_end_datetime";
            this.dataGridViewTextBoxColumn5.HeaderText = "End Date";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // leave_count
            // 
            this.leave_count.DataPropertyName = "leave_his_count";
            this.leave_count.HeaderText = "Leave Count";
            this.leave_count.Name = "leave_count";
            // 
            // leave_status
            // 
            this.leave_status.DataPropertyName = "leave_status";
            this.leave_status.HeaderText = "Leave Status";
            this.leave_status.Name = "leave_status";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.CornflowerBlue;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(891, 44);
            this.panel2.TabIndex = 23;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(369, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Leave History";
            // 
            // user_profile
            // 
            this.user_profile.Controls.Add(this.panel7);
            this.user_profile.Location = new System.Drawing.Point(4, 22);
            this.user_profile.Name = "user_profile";
            this.user_profile.Size = new System.Drawing.Size(891, 519);
            this.user_profile.TabIndex = 3;
            this.user_profile.Text = "User Profile";
            this.user_profile.UseVisualStyleBackColor = true;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.RosyBrown;
            this.panel7.Controls.Add(this.label14);
            this.panel7.Controls.Add(this.label13);
            this.panel7.Controls.Add(this.label12);
            this.panel7.Controls.Add(this.label7);
            this.panel7.Controls.Add(this.emp_type_lbl);
            this.panel7.Controls.Add(this.logout_btn);
            this.panel7.Controls.Add(this.emp_email_lbl);
            this.panel7.Controls.Add(this.emp_username_lbl);
            this.panel7.Controls.Add(this.emp_id_lbl);
            this.panel7.Location = new System.Drawing.Point(284, 104);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(377, 264);
            this.panel7.TabIndex = 43;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(30, 145);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(105, 20);
            this.label14.TabIndex = 42;
            this.label14.Text = "Employee Type";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(30, 99);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(45, 20);
            this.label13.TabIndex = 41;
            this.label13.Text = "Email";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(30, 59);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(76, 20);
            this.label12.TabIndex = 40;
            this.label12.Text = "User Name";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(30, 19);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 20);
            this.label7.TabIndex = 39;
            this.label7.Text = "User Id";
            // 
            // emp_type_lbl
            // 
            this.emp_type_lbl.AutoSize = true;
            this.emp_type_lbl.Location = new System.Drawing.Point(162, 145);
            this.emp_type_lbl.Name = "emp_type_lbl";
            this.emp_type_lbl.Size = new System.Drawing.Size(80, 13);
            this.emp_type_lbl.TabIndex = 38;
            this.emp_type_lbl.Text = "Employee Type";
            // 
            // logout_btn
            // 
            this.logout_btn.BackColor = System.Drawing.Color.White;
            this.logout_btn.FlatAppearance.BorderColor = System.Drawing.Color.CornflowerBlue;
            this.logout_btn.FlatAppearance.BorderSize = 3;
            this.logout_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logout_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logout_btn.ForeColor = System.Drawing.Color.DarkBlue;
            this.logout_btn.Location = new System.Drawing.Point(137, 195);
            this.logout_btn.Margin = new System.Windows.Forms.Padding(2);
            this.logout_btn.Name = "logout_btn";
            this.logout_btn.Size = new System.Drawing.Size(105, 37);
            this.logout_btn.TabIndex = 37;
            this.logout_btn.Text = "Logout";
            this.logout_btn.UseVisualStyleBackColor = false;
            this.logout_btn.Click += new System.EventHandler(this.logout_btn_Click);
            // 
            // emp_email_lbl
            // 
            this.emp_email_lbl.AutoSize = true;
            this.emp_email_lbl.Location = new System.Drawing.Point(162, 99);
            this.emp_email_lbl.Name = "emp_email_lbl";
            this.emp_email_lbl.Size = new System.Drawing.Size(32, 13);
            this.emp_email_lbl.TabIndex = 36;
            this.emp_email_lbl.Text = "Email";
            // 
            // emp_username_lbl
            // 
            this.emp_username_lbl.AutoSize = true;
            this.emp_username_lbl.Location = new System.Drawing.Point(162, 59);
            this.emp_username_lbl.Name = "emp_username_lbl";
            this.emp_username_lbl.Size = new System.Drawing.Size(57, 13);
            this.emp_username_lbl.TabIndex = 35;
            this.emp_username_lbl.Text = "UserName";
            // 
            // emp_id_lbl
            // 
            this.emp_id_lbl.AutoSize = true;
            this.emp_id_lbl.Location = new System.Drawing.Point(162, 19);
            this.emp_id_lbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.emp_id_lbl.Name = "emp_id_lbl";
            this.emp_id_lbl.Size = new System.Drawing.Size(41, 13);
            this.emp_id_lbl.TabIndex = 34;
            this.emp_id_lbl.Text = "User Id";
            // 
            // leave_management_dbDataSet
            // 
            this.leave_management_dbDataSet.DataSetName = "leave_management_dbDataSet";
            this.leave_management_dbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // leavetblBindingSource
            // 
            this.leavetblBindingSource.DataMember = "Leave_tbl";
            this.leavetblBindingSource.DataSource = this.leave_management_dbDataSet;
            // 
            // leave_tblTableAdapter
            // 
            this.leave_tblTableAdapter.ClearBeforeFill = true;
            // 
            // leave_typeTableAdapter
            // 
            this.leave_typeTableAdapter.ClearBeforeFill = true;
            // 
            // Emp_Page
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(899, 545);
            this.Controls.Add(this.tabControl1);
            this.Name = "Emp_Page";
            this.Text = "Emp_Page";
            this.Load += new System.EventHandler(this.Emp_Page_Load);
            this.tabControl1.ResumeLayout(false);
            this.home.ResumeLayout(false);
            this.home.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.leave_request.ResumeLayout(false);
            this.leave_request.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pending_leave_datagrid_view)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.leavetypeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.leave_management_dbDataSet1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.leave_history.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.leave_his_gridview)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.user_profile.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.leave_management_dbDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.leavetblBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage home;
        private System.Windows.Forms.TabPage leave_request;
        private System.Windows.Forms.TabPage leave_history;
        private System.Windows.Forms.TabPage user_profile;
        private System.Windows.Forms.Button logout_btn;
        private System.Windows.Forms.Label emp_email_lbl;
        private System.Windows.Forms.Label emp_username_lbl;
        private System.Windows.Forms.Label emp_id_lbl;
        private System.Windows.Forms.DateTimePicker start_datetime_picker;
        private System.Windows.Forms.ComboBox leave_type_box;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private leave_management_dbDataSet leave_management_dbDataSet;
        private System.Windows.Forms.BindingSource leavetblBindingSource;
        private leave_management_dbDataSetTableAdapters.Leave_tblTableAdapter leave_tblTableAdapter;
        private leave_management_dbDataSet1 leave_management_dbDataSet1;
        private System.Windows.Forms.BindingSource leavetypeBindingSource;
        private leave_management_dbDataSet1TableAdapters.leave_typeTableAdapter leave_typeTableAdapter;
        private System.Windows.Forms.DateTimePicker end_datetime_picker;
        private System.Windows.Forms.TextBox leave_purpose;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button request_leave_btn;
        private System.Windows.Forms.Label emp_type_lbl;
        private System.Windows.Forms.Button leave_pending_refresh_btn;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.DataGridView pending_leave_datagrid_view;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn leave_type;
        private System.Windows.Forms.DataGridViewTextBoxColumn emp_leave_purpose;
        private System.Windows.Forms.DataGridViewTextBoxColumn leave_his_start_datetime;
        private System.Windows.Forms.DataGridViewTextBoxColumn leave_his_end_datetime;
        private System.Windows.Forms.DataGridViewButtonColumn Delete;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView leave_his_gridview;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn leave_count;
        private System.Windows.Forms.DataGridViewTextBoxColumn leave_status;
        private System.Windows.Forms.Label anual_leave_count_lbl;
        private System.Windows.Forms.Label username_lbl;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label short_leave_count_lbl;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label casual_leave_count_lbl;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel7;
    }
}