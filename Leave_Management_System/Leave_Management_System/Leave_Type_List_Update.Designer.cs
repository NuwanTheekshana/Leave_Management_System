namespace Leave_Management_System
{
    partial class Leave_Type_List_Update_Form
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
            this.leave_id_txt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.update_leave_type_btn = new System.Windows.Forms.Button();
            this.leave_type_combox = new System.Windows.Forms.ComboBox();
            this.label20 = new System.Windows.Forms.Label();
            this.emp_type_combox = new System.Windows.Forms.ComboBox();
            this.label21 = new System.Windows.Forms.Label();
            this.leave_count_txt = new System.Windows.Forms.TextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.admin_auth_id = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // leave_id_txt
            // 
            this.leave_id_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.leave_id_txt.Location = new System.Drawing.Point(158, 15);
            this.leave_id_txt.Margin = new System.Windows.Forms.Padding(2);
            this.leave_id_txt.Name = "leave_id_txt";
            this.leave_id_txt.ReadOnly = true;
            this.leave_id_txt.Size = new System.Drawing.Size(222, 26);
            this.leave_id_txt.TabIndex = 26;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(15, 15);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(25, 20);
            this.label4.TabIndex = 25;
            this.label4.Text = "Id";
            // 
            // update_leave_type_btn
            // 
            this.update_leave_type_btn.BackColor = System.Drawing.Color.White;
            this.update_leave_type_btn.FlatAppearance.BorderColor = System.Drawing.Color.CornflowerBlue;
            this.update_leave_type_btn.FlatAppearance.BorderSize = 3;
            this.update_leave_type_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.update_leave_type_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.update_leave_type_btn.ForeColor = System.Drawing.Color.DarkBlue;
            this.update_leave_type_btn.Location = new System.Drawing.Point(158, 207);
            this.update_leave_type_btn.Margin = new System.Windows.Forms.Padding(2);
            this.update_leave_type_btn.Name = "update_leave_type_btn";
            this.update_leave_type_btn.Size = new System.Drawing.Size(140, 36);
            this.update_leave_type_btn.TabIndex = 24;
            this.update_leave_type_btn.Text = "Update Leave Type";
            this.update_leave_type_btn.UseVisualStyleBackColor = false;
            this.update_leave_type_btn.Click += new System.EventHandler(this.update_leave_type_btn_Click);
            // 
            // leave_type_combox
            // 
            this.leave_type_combox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.leave_type_combox.FormattingEnabled = true;
            this.leave_type_combox.Items.AddRange(new object[] {
            "Anual Leave",
            "Casual Leave",
            "Short Leaves"});
            this.leave_type_combox.Location = new System.Drawing.Point(158, 57);
            this.leave_type_combox.Name = "leave_type_combox";
            this.leave_type_combox.Size = new System.Drawing.Size(222, 28);
            this.leave_type_combox.TabIndex = 40;
            this.leave_type_combox.Text = "Select Leave Type";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(15, 60);
            this.label20.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(100, 20);
            this.label20.TabIndex = 41;
            this.label20.Text = "Leave Type";
            // 
            // emp_type_combox
            // 
            this.emp_type_combox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.emp_type_combox.FormattingEnabled = true;
            this.emp_type_combox.Items.AddRange(new object[] {
            "Permanent",
            "Non Permanent"});
            this.emp_type_combox.Location = new System.Drawing.Point(158, 109);
            this.emp_type_combox.Name = "emp_type_combox";
            this.emp_type_combox.Size = new System.Drawing.Size(222, 28);
            this.emp_type_combox.TabIndex = 42;
            this.emp_type_combox.Text = "Select Employee Type";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(15, 112);
            this.label21.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(130, 20);
            this.label21.TabIndex = 43;
            this.label21.Text = "Employee Type";
            // 
            // leave_count_txt
            // 
            this.leave_count_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.leave_count_txt.Location = new System.Drawing.Point(158, 158);
            this.leave_count_txt.Margin = new System.Windows.Forms.Padding(2);
            this.leave_count_txt.Name = "leave_count_txt";
            this.leave_count_txt.Size = new System.Drawing.Size(222, 26);
            this.leave_count_txt.TabIndex = 44;
            this.leave_count_txt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.leave_count_txt_KeyPress);
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.Location = new System.Drawing.Point(15, 161);
            this.label22.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label22.Name = "label22";
            this.label22.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label22.Size = new System.Drawing.Size(110, 20);
            this.label22.TabIndex = 45;
            this.label22.Text = "Leave Count";
            // 
            // admin_auth_id
            // 
            this.admin_auth_id.AutoSize = true;
            this.admin_auth_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.admin_auth_id.Location = new System.Drawing.Point(308, 229);
            this.admin_auth_id.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.admin_auth_id.Name = "admin_auth_id";
            this.admin_auth_id.Size = new System.Drawing.Size(76, 20);
            this.admin_auth_id.TabIndex = 47;
            this.admin_auth_id.Text = "admin id";
            this.admin_auth_id.Visible = false;
            // 
            // Leave_Type_List_Update_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(395, 258);
            this.Controls.Add(this.admin_auth_id);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.leave_count_txt);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.emp_type_combox);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.leave_type_combox);
            this.Controls.Add(this.leave_id_txt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.update_leave_type_btn);
            this.Name = "Leave_Type_List_Update_Form";
            this.Text = "Leave_Type_List_Update";
            this.Load += new System.EventHandler(this.Leave_Type_List_Update_Form_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox leave_id_txt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button update_leave_type_btn;
        private System.Windows.Forms.ComboBox leave_type_combox;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.ComboBox emp_type_combox;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.TextBox leave_count_txt;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label admin_auth_id;
    }
}