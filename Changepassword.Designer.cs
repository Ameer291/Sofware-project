﻿namespace Sofware_project
{
    partial class Changepasswordform
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
            panel1 = new Panel();
            newpswderror_label = new Label();
            button2 = new Button();
            label4 = new Label();
            new_pswd_error = new Label();
            old_pswd_error = new Label();
            newpswdconfirm_edit = new TextBox();
            label3 = new Label();
            newpswd_edit = new TextBox();
            label2 = new Label();
            button1 = new Button();
            currentpassword = new TextBox();
            label1 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.MenuBar;
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(newpswderror_label);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(new_pswd_error);
            panel1.Controls.Add(old_pswd_error);
            panel1.Controls.Add(newpswdconfirm_edit);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(newpswd_edit);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(currentpassword);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(113, 57);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(425, 270);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // newpswderror_label
            // 
            newpswderror_label.AutoSize = true;
            newpswderror_label.ForeColor = Color.Red;
            newpswderror_label.Location = new Point(31, 207);
            newpswderror_label.Name = "newpswderror_label";
            newpswderror_label.Size = new Size(132, 15);
            newpswderror_label.TabIndex = 11;
            newpswderror_label.Text = "Password do not match";
            newpswderror_label.Visible = false;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(192, 192, 255);
            button2.FlatAppearance.BorderColor = SystemColors.MenuBar;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Location = new Point(322, 232);
            button2.Margin = new Padding(3, 2, 3, 2);
            button2.Name = "button2";
            button2.Size = new Size(80, 23);
            button2.TabIndex = 10;
            button2.Text = "Cancel";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = Color.Red;
            label4.Location = new Point(31, 205);
            label4.Name = "label4";
            label4.Size = new Size(0, 15);
            label4.TabIndex = 9;
            label4.Visible = false;
            // 
            // new_pswd_error
            // 
            new_pswd_error.AutoSize = true;
            new_pswd_error.ForeColor = Color.Red;
            new_pswd_error.Location = new Point(31, 205);
            new_pswd_error.Name = "new_pswd_error";
            new_pswd_error.Size = new Size(0, 15);
            new_pswd_error.TabIndex = 8;
            new_pswd_error.Click += label4_Click;
            // 
            // old_pswd_error
            // 
            old_pswd_error.AutoSize = true;
            old_pswd_error.ForeColor = Color.Red;
            old_pswd_error.Location = new Point(31, 70);
            old_pswd_error.Name = "old_pswd_error";
            old_pswd_error.Size = new Size(95, 15);
            old_pswd_error.TabIndex = 7;
            old_pswd_error.Text = "Invalid password";
            old_pswd_error.Visible = false;
            old_pswd_error.Click += old_pswd_error_Click;
            // 
            // newpswdconfirm_edit
            // 
            newpswdconfirm_edit.Location = new Point(31, 182);
            newpswdconfirm_edit.Margin = new Padding(3, 2, 3, 2);
            newpswdconfirm_edit.Name = "newpswdconfirm_edit";
            newpswdconfirm_edit.Size = new Size(360, 23);
            newpswdconfirm_edit.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(31, 156);
            label3.Name = "label3";
            label3.Size = new Size(153, 19);
            label3.TabIndex = 5;
            label3.Text = "Confirm new password";
            // 
            // newpswd_edit
            // 
            newpswd_edit.Location = new Point(31, 118);
            newpswd_edit.Margin = new Padding(3, 2, 3, 2);
            newpswd_edit.Name = "newpswd_edit";
            newpswd_edit.Size = new Size(360, 23);
            newpswd_edit.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(31, 85);
            label2.Name = "label2";
            label2.Size = new Size(134, 19);
            label2.TabIndex = 3;
            label2.Text = "Enter new password";
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(192, 192, 255);
            button1.FlatAppearance.BorderColor = SystemColors.MenuBar;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Location = new Point(230, 232);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(80, 23);
            button1.TabIndex = 2;
            button1.Text = "Save";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // currentpassword
            // 
            currentpassword.Location = new Point(31, 45);
            currentpassword.Margin = new Padding(3, 2, 3, 2);
            currentpassword.Name = "currentpassword";
            currentpassword.Size = new Size(360, 23);
            currentpassword.TabIndex = 1;
            currentpassword.TextChanged += currentpassword_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(31, 17);
            label1.Name = "label1";
            label1.Size = new Size(136, 19);
            label1.TabIndex = 0;
            label1.Text = "Enter your password";
            // 
            // Changepasswordform
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Window;
            ClientSize = new Size(659, 385);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
            Name = "Changepasswordform";
            StartPosition = FormStartPosition.CenterScreen;
            Load += Changepasswordform_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private TextBox currentpassword;
        private Label label1;
        private Button button1;
        private TextBox newpswdconfirm_edit;
        private Label label3;
        private TextBox newpswd_edit;
        private Label label2;
        private Label old_pswd_error;
        private Label new_pswd_error;
        private Label label4;
        private Button button2;
        private Label newpswderror_label;
    }
}