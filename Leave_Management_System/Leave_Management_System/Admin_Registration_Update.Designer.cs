﻿namespace Leave_Management_System
{
    partial class Admin_User_Update_Form
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
            this.fname_txt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lname_txt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.email_txt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.admin_add_btn = new System.Windows.Forms.Button();
            this.admin_id_txt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // fname_txt
            // 
            this.fname_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fname_txt.Location = new System.Drawing.Point(203, 78);
            this.fname_txt.Name = "fname_txt";
            this.fname_txt.Size = new System.Drawing.Size(294, 30);
            this.fname_txt.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "First Name";
            // 
            // lname_txt
            // 
            this.lname_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lname_txt.Location = new System.Drawing.Point(203, 141);
            this.lname_txt.Name = "lname_txt";
            this.lname_txt.Size = new System.Drawing.Size(294, 30);
            this.lname_txt.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 141);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 25);
            this.label1.TabIndex = 7;
            this.label1.Text = "Last Name";
            // 
            // email_txt
            // 
            this.email_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.email_txt.Location = new System.Drawing.Point(203, 205);
            this.email_txt.Name = "email_txt";
            this.email_txt.Size = new System.Drawing.Size(294, 30);
            this.email_txt.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 205);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 25);
            this.label2.TabIndex = 9;
            this.label2.Text = "Email";
            // 
            // admin_add_btn
            // 
            this.admin_add_btn.BackColor = System.Drawing.Color.White;
            this.admin_add_btn.FlatAppearance.BorderColor = System.Drawing.Color.CornflowerBlue;
            this.admin_add_btn.FlatAppearance.BorderSize = 3;
            this.admin_add_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.admin_add_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.admin_add_btn.ForeColor = System.Drawing.Color.DarkBlue;
            this.admin_add_btn.Location = new System.Drawing.Point(203, 262);
            this.admin_add_btn.Name = "admin_add_btn";
            this.admin_add_btn.Size = new System.Drawing.Size(186, 44);
            this.admin_add_btn.TabIndex = 15;
            this.admin_add_btn.Text = "Update User";
            this.admin_add_btn.UseVisualStyleBackColor = false;
            this.admin_add_btn.Click += new System.EventHandler(this.admin_add_btn_Click);
            // 
            // admin_id_txt
            // 
            this.admin_id_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.admin_id_txt.Location = new System.Drawing.Point(203, 26);
            this.admin_id_txt.Name = "admin_id_txt";
            this.admin_id_txt.ReadOnly = true;
            this.admin_id_txt.Size = new System.Drawing.Size(294, 30);
            this.admin_id_txt.TabIndex = 17;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 25);
            this.label4.TabIndex = 16;
            this.label4.Text = "Id";
            // 
            // Admin_User_Update_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(527, 318);
            this.Controls.Add(this.admin_id_txt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.admin_add_btn);
            this.Controls.Add(this.email_txt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lname_txt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.fname_txt);
            this.Controls.Add(this.label3);
            this.Name = "Admin_User_Update_Form";
            this.Text = "Admin User Update";
            this.Load += new System.EventHandler(this.Admin_User_Update_Form_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox fname_txt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox lname_txt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox email_txt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button admin_add_btn;
        private System.Windows.Forms.TextBox admin_id_txt;
        private System.Windows.Forms.Label label4;
    }
}