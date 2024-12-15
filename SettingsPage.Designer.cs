namespace Sofware_project
{
    partial class SettingsPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingsPage));
            label1 = new Label();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            member_since = new Label();
            member_type = new Label();
            member_name = new Label();
            account_setting = new Label();
            account_info = new Label();
            panel2 = new Panel();
            button1 = new Button();
            label3 = new Label();
            profile_info = new Label();
            label2 = new Label();
            panel3 = new Panel();
            checkBox2 = new CheckBox();
            checkBox1 = new CheckBox();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            panel4 = new Panel();
            button3 = new Button();
            button2 = new Button();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            label12 = new Label();
            label13 = new Label();
            panel5 = new Panel();
            button4 = new Button();
            label15 = new Label();
            label14 = new Label();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(22, 15);
            label1.Name = "label1";
            label1.Size = new Size(0, 30);
            label1.TabIndex = 0;
            label1.Click += label1_Click;
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(member_since);
            panel1.Controls.Add(member_type);
            panel1.Controls.Add(member_name);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(23, 49);
            panel1.Name = "panel1";
            panel1.Size = new Size(772, 90);
            panel1.TabIndex = 1;
            panel1.Paint += panel1_Paint_1;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.FromArgb(192, 192, 255);
            pictureBox1.Location = new Point(20, 24);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(43, 43);
            pictureBox1.TabIndex = 10;
            pictureBox1.TabStop = false;
            // 
            // member_since
            // 
            member_since.AutoSize = true;
            member_since.Location = new Point(72, 58);
            member_since.Name = "member_since";
            member_since.Size = new Size(137, 30);
            member_since.TabIndex = 5;
            member_since.Text = "membersince";
            // 
            // member_type
            // 
            member_type.AutoSize = true;
            member_type.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            member_type.Location = new Point(72, 35);
            member_type.Name = "member_type";
            member_type.Size = new Size(151, 32);
            member_type.TabIndex = 4;
            member_type.Text = "membertype";
            member_type.Click += label3_Click;
            // 
            // member_name
            // 
            member_name.AutoSize = true;
            member_name.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            member_name.Location = new Point(69, 10);
            member_name.Name = "member_name";
            member_name.Size = new Size(83, 36);
            member_name.TabIndex = 3;
            member_name.Text = "name";
            member_name.Click += member_name_Click;
            // 
            // account_setting
            // 
            account_setting.AutoSize = true;
            account_setting.BackColor = SystemColors.Window;
            account_setting.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            account_setting.ForeColor = SystemColors.ControlDarkDark;
            account_setting.Location = new Point(23, 9);
            account_setting.Name = "account_setting";
            account_setting.Size = new Size(449, 30);
            account_setting.TabIndex = 2;
            account_setting.Text = "Manage your account settings and preferences";
            account_setting.Click += label2_Click;
            // 
            // account_info
            // 
            account_info.AutoSize = true;
            account_info.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            account_info.Location = new Point(61, 156);
            account_info.Name = "account_info";
            account_info.Size = new Size(103, 32);
            account_info.TabIndex = 3;
            account_info.Text = "Account";
            account_info.Click += label2_Click_1;
            // 
            // panel2
            // 
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(button1);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(profile_info);
            panel2.Location = new Point(23, 195);
            panel2.Name = "panel2";
            panel2.Size = new Size(772, 63);
            panel2.TabIndex = 4;
            panel2.Paint += panel2_Paint;
            // 
            // button1
            // 
            button1.AutoSize = true;
            button1.FlatAppearance.BorderColor = Color.FromArgb(224, 224, 224);
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.Location = new Point(717, 18);
            button1.Name = "button1";
            button1.Size = new Size(28, 26);
            button1.TabIndex = 4;
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(23, 30);
            label3.Name = "label3";
            label3.Size = new Size(389, 30);
            label3.TabIndex = 1;
            label3.Text = "Update your photos and personal details";
            // 
            // profile_info
            // 
            profile_info.AutoSize = true;
            profile_info.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            profile_info.Location = new Point(23, 10);
            profile_info.Name = "profile_info";
            profile_info.Size = new Size(220, 32);
            profile_info.TabIndex = 0;
            profile_info.Text = "Profile Information";
            profile_info.Click += label2_Click_2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(61, 278);
            label2.Name = "label2";
            label2.Size = new Size(152, 32);
            label2.TabIndex = 5;
            label2.Text = "Notifications";
            // 
            // panel3
            // 
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Controls.Add(checkBox2);
            panel3.Controls.Add(checkBox1);
            panel3.Controls.Add(label5);
            panel3.Controls.Add(label6);
            panel3.Controls.Add(label7);
            panel3.Controls.Add(label8);
            panel3.Location = new Point(23, 307);
            panel3.Name = "panel3";
            panel3.Size = new Size(772, 125);
            panel3.TabIndex = 6;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Location = new Point(727, 76);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(22, 21);
            checkBox2.TabIndex = 5;
            checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(727, 15);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(22, 21);
            checkBox1.TabIndex = 4;
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(23, 91);
            label5.Name = "label5";
            label5.Size = new Size(197, 30);
            label5.TabIndex = 3;
            label5.Text = "Mobile notifications";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(23, 71);
            label6.Name = "label6";
            label6.Size = new Size(211, 32);
            label6.TabIndex = 2;
            label6.Text = "Push Notifications";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(23, 30);
            label7.Name = "label7";
            label7.Size = new Size(206, 30);
            label7.TabIndex = 1;
            label7.Text = "Update about events";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(23, 10);
            label8.Name = "label8";
            label8.Size = new Size(217, 32);
            label8.TabIndex = 0;
            label8.Text = "Email Notifications";
            // 
            // panel4
            // 
            panel4.BorderStyle = BorderStyle.FixedSingle;
            panel4.Controls.Add(button3);
            panel4.Controls.Add(button2);
            panel4.Controls.Add(label9);
            panel4.Controls.Add(label10);
            panel4.Controls.Add(label11);
            panel4.Controls.Add(label12);
            panel4.Location = new Point(23, 476);
            panel4.Name = "panel4";
            panel4.Size = new Size(772, 125);
            panel4.TabIndex = 7;
            panel4.Paint += panel4_Paint;
            // 
            // button3
            // 
            button3.AutoSize = true;
            button3.FlatAppearance.BorderColor = Color.FromArgb(224, 224, 224);
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Image = (Image)resources.GetObject("button3.Image");
            button3.Location = new Point(717, 85);
            button3.Name = "button3";
            button3.Size = new Size(28, 26);
            button3.TabIndex = 6;
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.AutoSize = true;
            button2.FlatAppearance.BorderColor = Color.FromArgb(224, 224, 224);
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Image = (Image)resources.GetObject("button2.Image");
            button2.Location = new Point(717, 24);
            button2.Name = "button2";
            button2.Size = new Size(28, 26);
            button2.TabIndex = 5;
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(23, 91);
            label9.Name = "label9";
            label9.Size = new Size(183, 30);
            label9.TabIndex = 3;
            label9.Text = "Manage your data";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.Location = new Point(23, 71);
            label10.Name = "label10";
            label10.Size = new Size(198, 32);
            label10.TabIndex = 2;
            label10.Text = "Data and Privacy";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(23, 30);
            label11.Name = "label11";
            label11.Size = new Size(292, 30);
            label11.TabIndex = 1;
            label11.Text = "Manage who sees your profile";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label12.Location = new Point(23, 10);
            label12.Name = "label12";
            label12.Size = new Size(181, 32);
            label12.TabIndex = 0;
            label12.Text = "Profile Visibility";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label13.Location = new Point(61, 450);
            label13.Name = "label13";
            label13.Size = new Size(91, 32);
            label13.TabIndex = 8;
            label13.Text = "Privacy";
            // 
            // panel5
            // 
            panel5.BorderStyle = BorderStyle.FixedSingle;
            panel5.Controls.Add(button4);
            panel5.Controls.Add(label15);
            panel5.Controls.Add(label14);
            panel5.ForeColor = SystemColors.ControlDarkDark;
            panel5.Location = new Point(23, 619);
            panel5.Name = "panel5";
            panel5.Size = new Size(772, 65);
            panel5.TabIndex = 9;
            // 
            // button4
            // 
            button4.BackColor = SystemColors.Window;
            button4.FlatAppearance.BorderColor = SystemColors.Window;
            button4.FlatAppearance.BorderSize = 0;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Segoe UI", 10.2F, FontStyle.Underline, GraphicsUnit.Point, 0);
            button4.ForeColor = Color.Red;
            button4.Location = new Point(651, 11);
            button4.Name = "button4";
            button4.Size = new Size(94, 29);
            button4.TabIndex = 2;
            button4.Text = "Delete";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(23, 34);
            label15.Name = "label15";
            label15.Size = new Size(269, 30);
            label15.TabIndex = 1;
            label15.Text = "Delete all data permenantly";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label14.ForeColor = Color.Red;
            label14.Location = new Point(23, 11);
            label14.Name = "label14";
            label14.Size = new Size(178, 32);
            label14.TabIndex = 0;
            label14.Text = "Delete account";
            label14.Click += label14_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.WhatsApp_Image_2024_11_30_at_12_02_01_PM;
            pictureBox2.Location = new Point(23, 156);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(32, 23);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 11;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.FromArgb(192, 192, 255);
            pictureBox3.Image = Properties.Resources.WhatsApp_Image_2024_11_30_at_12_05_31_PM;
            pictureBox3.Location = new Point(23, 278);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(32, 23);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 12;
            pictureBox3.TabStop = false;
            // 
            // SettingsPage
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = SystemColors.Window;
            ClientSize = new Size(832, 744);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(panel5);
            Controls.Add(label13);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(label2);
            Controls.Add(panel2);
            Controls.Add(account_info);
            Controls.Add(account_setting);
            Controls.Add(panel1);
            Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ForeColor = SystemColors.ControlText;
            Name = "SettingsPage";
            Text = "Settings";
            Load += SettingsPage_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Panel panel1;
        private Label account_setting;
        private Label member_since;
        private Label member_type;
        private Label member_name;
        private Label account_info;
        private Panel panel2;
        private Label profile_info;
        private Label label3;
        private Label label2;
        private Panel panel3;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Panel panel4;
        private Label label9;
        private Label label10;
        private Label label11;
        private Label label12;
        private Label label13;
        private Panel panel5;
        private Label label15;
        private Label label14;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private Button button1;
        private Button button2;
        private Button button3;
        private CheckBox checkBox2;
        private CheckBox checkBox1;
        private Button button4;
    }
}