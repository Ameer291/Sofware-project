﻿namespace Sofware_project
{
    partial class Profileupdateform
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Profileupdateform));
            profileimage = new PictureBox();
            editprofilebutton = new Button();
            panel1 = new Panel();
            address = new TextBox();
            phonenumber = new TextBox();
            email = new TextBox();
            username = new TextBox();
            gender = new TextBox();
            DOB = new TextBox();
            lastname = new TextBox();
            firstname = new TextBox();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            button1 = new Button();
            changepswdbutton = new Button();
            button3 = new Button();
            ((System.ComponentModel.ISupportInitialize)profileimage).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // profileimage
            // 
            profileimage.BorderStyle = BorderStyle.FixedSingle;
            profileimage.ErrorImage = (Image)resources.GetObject("profileimage.ErrorImage");
            profileimage.Image = Properties.Resources._118174;
            profileimage.Location = new Point(15, 15);
            profileimage.Margin = new Padding(4);
            profileimage.Name = "profileimage";
            profileimage.Size = new Size(136, 117);
            profileimage.SizeMode = PictureBoxSizeMode.StretchImage;
            profileimage.TabIndex = 0;
            profileimage.TabStop = false;
            // 
            // editprofilebutton
            // 
            editprofilebutton.BackColor = Color.FromArgb(192, 192, 255);
            editprofilebutton.FlatAppearance.BorderColor = SystemColors.Window;
            editprofilebutton.FlatAppearance.BorderSize = 0;
            editprofilebutton.FlatStyle = FlatStyle.Flat;
            editprofilebutton.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            editprofilebutton.Location = new Point(15, 151);
            editprofilebutton.Margin = new Padding(4);
            editprofilebutton.Name = "editprofilebutton";
            editprofilebutton.Size = new Size(136, 48);
            editprofilebutton.TabIndex = 1;
            editprofilebutton.Text = "Edit photo";
            editprofilebutton.UseVisualStyleBackColor = false;
            editprofilebutton.Click += editprofilebutton_Click;
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(address);
            panel1.Controls.Add(phonenumber);
            panel1.Controls.Add(email);
            panel1.Controls.Add(username);
            panel1.Controls.Add(gender);
            panel1.Controls.Add(DOB);
            panel1.Controls.Add(lastname);
            panel1.Controls.Add(firstname);
            panel1.Controls.Add(label9);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(195, 15);
            panel1.Margin = new Padding(4);
            panel1.Name = "panel1";
            panel1.Size = new Size(749, 453);
            panel1.TabIndex = 2;
            panel1.Paint += panel1_Paint;
            // 
            // address
            // 
            address.Location = new Point(168, 379);
            address.Margin = new Padding(4);
            address.Name = "address";
            address.Size = new Size(545, 31);
            address.TabIndex = 17;
            address.TextChanged += address_TextChanged;
            // 
            // phonenumber
            // 
            phonenumber.Location = new Point(168, 328);
            phonenumber.Margin = new Padding(4);
            phonenumber.Name = "phonenumber";
            phonenumber.Size = new Size(545, 31);
            phonenumber.TabIndex = 16;
            // 
            // email
            // 
            email.Location = new Point(168, 280);
            email.Margin = new Padding(4);
            email.Name = "email";
            email.Size = new Size(545, 31);
            email.TabIndex = 15;
            email.TextChanged += textBox7_TextChanged;
            // 
            // username
            // 
            username.Location = new Point(168, 224);
            username.Margin = new Padding(4);
            username.Name = "username";
            username.ReadOnly = true;
            username.Size = new Size(545, 31);
            username.TabIndex = 13;
            // 
            // gender
            // 
            gender.Location = new Point(168, 174);
            gender.Margin = new Padding(4);
            gender.Name = "gender";
            gender.Size = new Size(545, 31);
            gender.TabIndex = 12;
            // 
            // DOB
            // 
            DOB.Location = new Point(168, 121);
            DOB.Margin = new Padding(4);
            DOB.Name = "DOB";
            DOB.Size = new Size(545, 31);
            DOB.TabIndex = 11;
            // 
            // lastname
            // 
            lastname.Location = new Point(168, 74);
            lastname.Margin = new Padding(4);
            lastname.Name = "lastname";
            lastname.Size = new Size(545, 31);
            lastname.TabIndex = 10;
            // 
            // firstname
            // 
            firstname.Location = new Point(168, 25);
            firstname.Margin = new Padding(4);
            firstname.Name = "firstname";
            firstname.Size = new Size(545, 31);
            firstname.TabIndex = 9;
            firstname.TextChanged += firstname_TextChanged;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(21, 379);
            label9.Margin = new Padding(4, 0, 4, 0);
            label9.Name = "label9";
            label9.Size = new Size(90, 30);
            label9.TabIndex = 8;
            label9.Text = "Address";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(21, 328);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(73, 30);
            label8.TabIndex = 7;
            label8.Text = "Phone";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(21, 280);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(64, 30);
            label7.TabIndex = 6;
            label7.Text = "Email";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(21, 224);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(109, 30);
            label5.TabIndex = 4;
            label5.Text = "Username";
            label5.Click += label5_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(21, 174);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(83, 30);
            label4.TabIndex = 3;
            label4.Text = "Gender";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(21, 121);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(137, 30);
            label3.TabIndex = 2;
            label3.Text = "Date of birth";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(21, 74);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(110, 30);
            label2.TabIndex = 1;
            label2.Text = "Last name";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(21, 25);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(113, 30);
            label1.TabIndex = 0;
            label1.Text = "First name";
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(192, 192, 255);
            button1.FlatAppearance.BorderColor = SystemColors.Window;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(658, 502);
            button1.Margin = new Padding(4);
            button1.Name = "button1";
            button1.Size = new Size(134, 45);
            button1.TabIndex = 3;
            button1.Text = "Save";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // changepswdbutton
            // 
            changepswdbutton.BackColor = SystemColors.Window;
            changepswdbutton.FlatAppearance.BorderColor = SystemColors.Window;
            changepswdbutton.FlatAppearance.BorderSize = 0;
            changepswdbutton.FlatStyle = FlatStyle.Flat;
            changepswdbutton.Font = new Font("Segoe UI", 10.2F, FontStyle.Underline, GraphicsUnit.Point, 0);
            changepswdbutton.Location = new Point(443, 484);
            changepswdbutton.Margin = new Padding(4);
            changepswdbutton.Name = "changepswdbutton";
            changepswdbutton.Size = new Size(196, 80);
            changepswdbutton.TabIndex = 4;
            changepswdbutton.Text = "Change password";
            changepswdbutton.UseVisualStyleBackColor = false;
            changepswdbutton.Click += changepswdbutton_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(192, 192, 255);
            button3.FlatAppearance.BorderColor = SystemColors.MenuBar;
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.Location = new Point(811, 502);
            button3.Margin = new Padding(4);
            button3.Name = "button3";
            button3.Size = new Size(134, 45);
            button3.TabIndex = 11;
            button3.Text = "Cancel";
            button3.UseVisualStyleBackColor = false;
            // 
            // Profileupdateform
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Window;
            ClientSize = new Size(995, 584);
            Controls.Add(button3);
            Controls.Add(changepswdbutton);
            Controls.Add(button1);
            Controls.Add(panel1);
            Controls.Add(editprofilebutton);
            Controls.Add(profileimage);
            Margin = new Padding(4);
            Name = "Profileupdateform";
            Text = "Profile";
            Load += Profileupdateform_Load;
            ((System.ComponentModel.ISupportInitialize)profileimage).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox profileimage;
        private Button editprofilebutton;
        private Panel panel1;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label label4;
        private Label label5;
        private Label label9;
        private Label label8;
        private Label label7;
        private TextBox firstname;
        private TextBox address;
        private TextBox phonenumber;
        private TextBox email;
        private TextBox username;
        private TextBox gender;
        private TextBox DOB;
        private TextBox lastname;
        private Button button1;
        private Button changepswdbutton;
        private Button button3;
    }
}