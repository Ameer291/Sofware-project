namespace Sofware_project
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
            button2 = new Button();
            label4 = new Label();
            new_pswd_error = new Label();
            old_pswd_error = new Label();
            textBox2 = new TextBox();
            label3 = new Label();
            textBox1 = new TextBox();
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
            panel1.Controls.Add(button2);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(new_pswd_error);
            panel1.Controls.Add(old_pswd_error);
            panel1.Controls.Add(textBox2);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(currentpassword);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(130, 76);
            panel1.Name = "panel1";
            panel1.Size = new Size(485, 359);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(192, 192, 255);
            button2.FlatAppearance.BorderColor = SystemColors.MenuBar;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Location = new Point(368, 309);
            button2.Name = "button2";
            button2.Size = new Size(91, 31);
            button2.TabIndex = 10;
            button2.Text = "Cancel";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = Color.Red;
            label4.Location = new Point(35, 273);
            label4.Name = "label4";
            label4.Size = new Size(0, 20);
            label4.TabIndex = 9;
            label4.Visible = false;
            // 
            // new_pswd_error
            // 
            new_pswd_error.AutoSize = true;
            new_pswd_error.ForeColor = Color.Red;
            new_pswd_error.Location = new Point(35, 273);
            new_pswd_error.Name = "new_pswd_error";
            new_pswd_error.Size = new Size(0, 20);
            new_pswd_error.TabIndex = 8;
            new_pswd_error.Click += label4_Click;
            // 
            // old_pswd_error
            // 
            old_pswd_error.AutoSize = true;
            old_pswd_error.ForeColor = Color.Red;
            old_pswd_error.Location = new Point(35, 90);
            old_pswd_error.Name = "old_pswd_error";
            old_pswd_error.Size = new Size(120, 20);
            old_pswd_error.TabIndex = 7;
            old_pswd_error.Text = "Invalid password";
            old_pswd_error.Visible = false;
            old_pswd_error.Click += old_pswd_error_Click;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(35, 243);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(411, 27);
            textBox2.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(35, 208);
            label3.Name = "label3";
            label3.Size = new Size(186, 23);
            label3.TabIndex = 5;
            label3.Text = "Confirm new password";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(35, 157);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(411, 27);
            textBox1.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(35, 114);
            label2.Name = "label2";
            label2.Size = new Size(164, 23);
            label2.TabIndex = 3;
            label2.Text = "Enter new password";
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(192, 192, 255);
            button1.FlatAppearance.BorderColor = SystemColors.MenuBar;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Location = new Point(262, 309);
            button1.Name = "button1";
            button1.Size = new Size(91, 31);
            button1.TabIndex = 2;
            button1.Text = "Save";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // currentpassword
            // 
            currentpassword.Location = new Point(35, 60);
            currentpassword.Name = "currentpassword";
            currentpassword.Size = new Size(411, 27);
            currentpassword.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(35, 23);
            label1.Name = "label1";
            label1.Size = new Size(167, 23);
            label1.TabIndex = 0;
            label1.Text = "Enter your password";
            // 
            // Changepasswordform
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Window;
            ClientSize = new Size(753, 513);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Changepasswordform";
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
        private TextBox textBox2;
        private Label label3;
        private TextBox textBox1;
        private Label label2;
        private Label old_pswd_error;
        private Label new_pswd_error;
        private Label label4;
        private Button button2;
    }
}