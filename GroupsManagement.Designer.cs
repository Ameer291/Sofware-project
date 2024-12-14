namespace Sofware_project
{
    partial class GroupsManagement
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
            panel5 = new Panel();
            panel12 = new Panel();
            grpdelete1 = new Button();
            num_members1 = new Label();
            eventorganiser1 = new Label();
            active_since1 = new Label();
            num_events1 = new Label();
            group_description1 = new TextBox();
            groupname1 = new Label();
            label9 = new Label();
            panel10 = new Panel();
            panel9 = new Panel();
            panel6 = new Panel();
            grpdelete2 = new Button();
            group_description2 = new TextBox();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            groupname2 = new Label();
            panel4 = new Panel();
            group_status = new ComboBox();
            group_categories = new ComboBox();
            panel11 = new Panel();
            groupsearch_admins = new TextBox();
            panel2 = new Panel();
            activenum_members = new Label();
            label2 = new Label();
            panel3 = new Panel();
            monthly_events = new Label();
            label3 = new Label();
            panel1 = new Panel();
            totalnum_groups = new Label();
            label1 = new Label();
            groupname3 = new Label();
            group_description3 = new TextBox();
            panel7 = new Panel();
            grpdelete3 = new Button();
            label8 = new Label();
            label10 = new Label();
            label11 = new Label();
            label12 = new Label();
            button7 = new Button();
            button5 = new Button();
            button4 = new Button();
            button3 = new Button();
            Addgroup = new Button();
            panel12.SuspendLayout();
            panel6.SuspendLayout();
            panel4.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel1.SuspendLayout();
            panel7.SuspendLayout();
            SuspendLayout();
            // 
            // panel5
            // 
            panel5.BackgroundImage = Properties.Resources.Screenshot_2024_12_01_161526;
            panel5.BackgroundImageLayout = ImageLayout.Stretch;
            panel5.Location = new Point(37, 248);
            panel5.Margin = new Padding(3, 2, 3, 2);
            panel5.Name = "panel5";
            panel5.Size = new Size(281, 73);
            panel5.TabIndex = 21;
            // 
            // panel12
            // 
            panel12.BorderStyle = BorderStyle.Fixed3D;
            panel12.Controls.Add(grpdelete1);
            panel12.Controls.Add(num_members1);
            panel12.Controls.Add(eventorganiser1);
            panel12.Controls.Add(active_since1);
            panel12.Controls.Add(num_events1);
            panel12.Controls.Add(group_description1);
            panel12.Controls.Add(groupname1);
            panel12.Controls.Add(label9);
            panel12.Location = new Point(37, 247);
            panel12.Margin = new Padding(3, 2, 3, 2);
            panel12.Name = "panel12";
            panel12.Size = new Size(281, 406);
            panel12.TabIndex = 20;
            // 
            // grpdelete1
            // 
            grpdelete1.BackgroundImage = Properties.Resources.Screenshot_2024_12_01_214121;
            grpdelete1.BackgroundImageLayout = ImageLayout.Stretch;
            grpdelete1.FlatAppearance.BorderColor = SystemColors.Window;
            grpdelete1.FlatAppearance.BorderSize = 0;
            grpdelete1.FlatStyle = FlatStyle.Flat;
            grpdelete1.Location = new Point(229, 362);
            grpdelete1.Margin = new Padding(3, 2, 3, 2);
            grpdelete1.Name = "grpdelete1";
            grpdelete1.Size = new Size(34, 22);
            grpdelete1.TabIndex = 15;
            grpdelete1.UseVisualStyleBackColor = true;
            // 
            // num_members1
            // 
            num_members1.AutoSize = true;
            num_members1.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            num_members1.Location = new Point(8, 188);
            num_members1.Name = "num_members1";
            num_members1.Size = new Size(100, 19);
            num_members1.TabIndex = 14;
            num_members1.Text = "num_members";
            // 
            // eventorganiser1
            // 
            eventorganiser1.AutoSize = true;
            eventorganiser1.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            eventorganiser1.Location = new Point(6, 328);
            eventorganiser1.Name = "eventorganiser1";
            eventorganiser1.Size = new Size(74, 19);
            eventorganiser1.TabIndex = 11;
            eventorganiser1.Text = "organiser1";
            // 
            // active_since1
            // 
            active_since1.AutoSize = true;
            active_since1.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            active_since1.Location = new Point(8, 282);
            active_since1.Name = "active_since1";
            active_since1.Size = new Size(78, 19);
            active_since1.TabIndex = 9;
            active_since1.Text = "active since";
            // 
            // num_events1
            // 
            num_events1.AutoSize = true;
            num_events1.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            num_events1.Location = new Point(8, 233);
            num_events1.Name = "num_events1";
            num_events1.Size = new Size(83, 19);
            num_events1.TabIndex = 6;
            num_events1.Text = "num_events";
            num_events1.Click += eventtime1_Click;
            // 
            // group_description1
            // 
            group_description1.BackColor = SystemColors.Window;
            group_description1.BorderStyle = BorderStyle.None;
            group_description1.Location = new Point(-2, 107);
            group_description1.Margin = new Padding(3, 2, 3, 2);
            group_description1.Multiline = true;
            group_description1.Name = "group_description1";
            group_description1.ReadOnly = true;
            group_description1.Size = new Size(281, 67);
            group_description1.TabIndex = 3;
            group_description1.TextChanged += group_description1_TextChanged;
            // 
            // groupname1
            // 
            groupname1.AutoSize = true;
            groupname1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupname1.Location = new Point(14, 74);
            groupname1.Name = "groupname1";
            groupname1.Size = new Size(69, 21);
            groupname1.TabIndex = 1;
            groupname1.Text = "group 1";
            groupname1.Click += eventname1_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(8, 64);
            label9.Name = "label9";
            label9.Size = new Size(0, 19);
            label9.TabIndex = 0;
            // 
            // panel10
            // 
            panel10.BackgroundImage = Properties.Resources.Screenshot_2024_12_01_161526;
            panel10.BackgroundImageLayout = ImageLayout.Stretch;
            panel10.Location = new Point(382, 247);
            panel10.Margin = new Padding(3, 2, 3, 2);
            panel10.Name = "panel10";
            panel10.Size = new Size(281, 74);
            panel10.TabIndex = 13;
            // 
            // panel9
            // 
            panel9.BackgroundImage = Properties.Resources.Screenshot_2024_12_01_161526;
            panel9.BackgroundImageLayout = ImageLayout.Stretch;
            panel9.Location = new Point(715, 246);
            panel9.Margin = new Padding(3, 2, 3, 2);
            panel9.Name = "panel9";
            panel9.Size = new Size(281, 74);
            panel9.TabIndex = 14;
            // 
            // panel6
            // 
            panel6.BorderStyle = BorderStyle.Fixed3D;
            panel6.Controls.Add(grpdelete2);
            panel6.Controls.Add(group_description2);
            panel6.Controls.Add(label4);
            panel6.Controls.Add(label5);
            panel6.Controls.Add(label6);
            panel6.Controls.Add(label7);
            panel6.Controls.Add(groupname2);
            panel6.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            panel6.Location = new Point(382, 247);
            panel6.Margin = new Padding(3, 2, 3, 2);
            panel6.Name = "panel6";
            panel6.Size = new Size(281, 406);
            panel6.TabIndex = 18;
            panel6.Paint += panel6_Paint;
            // 
            // grpdelete2
            // 
            grpdelete2.BackgroundImage = Properties.Resources.Screenshot_2024_12_01_214121;
            grpdelete2.BackgroundImageLayout = ImageLayout.Stretch;
            grpdelete2.FlatAppearance.BorderColor = SystemColors.Window;
            grpdelete2.FlatAppearance.BorderSize = 0;
            grpdelete2.FlatStyle = FlatStyle.Flat;
            grpdelete2.Location = new Point(222, 361);
            grpdelete2.Margin = new Padding(3, 2, 3, 2);
            grpdelete2.Name = "grpdelete2";
            grpdelete2.Size = new Size(34, 22);
            grpdelete2.TabIndex = 27;
            grpdelete2.UseVisualStyleBackColor = true;
            // 
            // group_description2
            // 
            group_description2.BackColor = SystemColors.Window;
            group_description2.BorderStyle = BorderStyle.None;
            group_description2.Location = new Point(-2, 107);
            group_description2.Margin = new Padding(3, 2, 3, 2);
            group_description2.Multiline = true;
            group_description2.Name = "group_description2";
            group_description2.ReadOnly = true;
            group_description2.Size = new Size(281, 67);
            group_description2.TabIndex = 4;
            group_description2.TextChanged += group_description2_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(12, 188);
            label4.Name = "label4";
            label4.Size = new Size(100, 19);
            label4.TabIndex = 18;
            label4.Text = "num_members";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(12, 328);
            label5.Name = "label5";
            label5.Size = new Size(74, 19);
            label5.TabIndex = 17;
            label5.Text = "organiser1";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(12, 282);
            label6.Name = "label6";
            label6.Size = new Size(78, 19);
            label6.TabIndex = 16;
            label6.Text = "active since";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(12, 233);
            label7.Name = "label7";
            label7.Size = new Size(83, 19);
            label7.TabIndex = 15;
            label7.Text = "num_events";
            // 
            // groupname2
            // 
            groupname2.AutoSize = true;
            groupname2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupname2.Location = new Point(12, 74);
            groupname2.Name = "groupname2";
            groupname2.Size = new Size(69, 21);
            groupname2.TabIndex = 2;
            groupname2.Text = "group 2";
            // 
            // panel4
            // 
            panel4.BorderStyle = BorderStyle.Fixed3D;
            panel4.Controls.Add(group_status);
            panel4.Controls.Add(group_categories);
            panel4.Controls.Add(panel11);
            panel4.Controls.Add(groupsearch_admins);
            panel4.Location = new Point(37, 181);
            panel4.Margin = new Padding(3, 2, 3, 2);
            panel4.Name = "panel4";
            panel4.RightToLeft = RightToLeft.No;
            panel4.Size = new Size(1000, 39);
            panel4.TabIndex = 17;
            panel4.Paint += panel4_Paint;
            // 
            // group_status
            // 
            group_status.BackColor = Color.FromArgb(192, 192, 255);
            group_status.FlatStyle = FlatStyle.Flat;
            group_status.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            group_status.FormattingEnabled = true;
            group_status.Items.AddRange(new object[] { "Active ", "Inactive", "Pending" });
            group_status.Location = new Point(879, 7);
            group_status.Margin = new Padding(3, 2, 3, 2);
            group_status.Name = "group_status";
            group_status.Size = new Size(97, 23);
            group_status.TabIndex = 8;
            group_status.Text = "All Status";
            // 
            // group_categories
            // 
            group_categories.BackColor = Color.FromArgb(192, 192, 255);
            group_categories.FlatStyle = FlatStyle.Flat;
            group_categories.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            group_categories.FormattingEnabled = true;
            group_categories.Items.AddRange(new object[] { "Art", "Wellness", "Workshop", "Social" });
            group_categories.Location = new Point(750, 7);
            group_categories.Margin = new Padding(3, 2, 3, 2);
            group_categories.Name = "group_categories";
            group_categories.Size = new Size(110, 23);
            group_categories.TabIndex = 7;
            group_categories.Text = "All Categories";
            group_categories.SelectedIndexChanged += event_categories_SelectedIndexChanged;
            // 
            // panel11
            // 
            panel11.BackgroundImage = Properties.Resources.Screenshot_2024_12_01_163426;
            panel11.BackgroundImageLayout = ImageLayout.Stretch;
            panel11.Location = new Point(8, 4);
            panel11.Margin = new Padding(3, 2, 3, 2);
            panel11.Name = "panel11";
            panel11.Size = new Size(21, 18);
            panel11.TabIndex = 6;
            panel11.Paint += panel11_Paint;
            // 
            // groupsearch_admins
            // 
            groupsearch_admins.BorderStyle = BorderStyle.None;
            groupsearch_admins.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupsearch_admins.ForeColor = SystemColors.WindowText;
            groupsearch_admins.Location = new Point(34, 4);
            groupsearch_admins.Margin = new Padding(3, 2, 3, 2);
            groupsearch_admins.Name = "groupsearch_admins";
            groupsearch_admins.PlaceholderText = "Search groups";
            groupsearch_admins.Size = new Size(262, 19);
            groupsearch_admins.TabIndex = 3;
            // 
            // panel2
            // 
            panel2.BorderStyle = BorderStyle.Fixed3D;
            panel2.Controls.Add(activenum_members);
            panel2.Controls.Add(label2);
            panel2.Location = new Point(317, 40);
            panel2.Margin = new Padding(3, 2, 3, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(214, 120);
            panel2.TabIndex = 15;
            // 
            // activenum_members
            // 
            activenum_members.AutoSize = true;
            activenum_members.Location = new Point(12, 36);
            activenum_members.Name = "activenum_members";
            activenum_members.Size = new Size(49, 15);
            activenum_members.TabIndex = 5;
            activenum_members.Text = "number";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(12, 16);
            label2.Name = "label2";
            label2.Size = new Size(110, 19);
            label2.TabIndex = 1;
            label2.Text = "Active Members";
            // 
            // panel3
            // 
            panel3.BorderStyle = BorderStyle.Fixed3D;
            panel3.Controls.Add(monthly_events);
            panel3.Controls.Add(label3);
            panel3.Location = new Point(590, 40);
            panel3.Margin = new Padding(3, 2, 3, 2);
            panel3.Name = "panel3";
            panel3.Size = new Size(214, 120);
            panel3.TabIndex = 16;
            // 
            // monthly_events
            // 
            monthly_events.AutoSize = true;
            monthly_events.Location = new Point(18, 36);
            monthly_events.Name = "monthly_events";
            monthly_events.Size = new Size(49, 15);
            monthly_events.TabIndex = 4;
            monthly_events.Text = "number";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(18, 16);
            label3.Name = "label3";
            label3.Size = new Size(106, 19);
            label3.TabIndex = 1;
            label3.Text = "Monthly Events";
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(totalnum_groups);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(37, 40);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(214, 120);
            panel1.TabIndex = 12;
            // 
            // totalnum_groups
            // 
            totalnum_groups.AutoSize = true;
            totalnum_groups.Location = new Point(23, 36);
            totalnum_groups.Name = "totalnum_groups";
            totalnum_groups.Size = new Size(49, 15);
            totalnum_groups.TabIndex = 1;
            totalnum_groups.Text = "number";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(15, 16);
            label1.Name = "label1";
            label1.Size = new Size(89, 19);
            label1.TabIndex = 0;
            label1.Text = "Total Groups";
            // 
            // groupname3
            // 
            groupname3.AutoSize = true;
            groupname3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupname3.Location = new Point(18, 73);
            groupname3.Name = "groupname3";
            groupname3.Size = new Size(69, 21);
            groupname3.TabIndex = 3;
            groupname3.Text = "group 3";
            // 
            // group_description3
            // 
            group_description3.BackColor = SystemColors.Window;
            group_description3.BorderStyle = BorderStyle.None;
            group_description3.Location = new Point(-2, 106);
            group_description3.Margin = new Padding(3, 2, 3, 2);
            group_description3.Multiline = true;
            group_description3.Name = "group_description3";
            group_description3.ReadOnly = true;
            group_description3.Size = new Size(281, 63);
            group_description3.TabIndex = 5;
            // 
            // panel7
            // 
            panel7.BorderStyle = BorderStyle.Fixed3D;
            panel7.Controls.Add(grpdelete3);
            panel7.Controls.Add(label8);
            panel7.Controls.Add(label10);
            panel7.Controls.Add(label11);
            panel7.Controls.Add(label12);
            panel7.Controls.Add(group_description3);
            panel7.Controls.Add(groupname3);
            panel7.Location = new Point(715, 247);
            panel7.Margin = new Padding(3, 2, 3, 2);
            panel7.Name = "panel7";
            panel7.Size = new Size(281, 406);
            panel7.TabIndex = 19;
            panel7.Paint += panel7_Paint;
            // 
            // grpdelete3
            // 
            grpdelete3.BackgroundImage = Properties.Resources.Screenshot_2024_12_01_214121;
            grpdelete3.BackgroundImageLayout = ImageLayout.Stretch;
            grpdelete3.FlatAppearance.BorderColor = SystemColors.Window;
            grpdelete3.FlatAppearance.BorderSize = 0;
            grpdelete3.FlatStyle = FlatStyle.Flat;
            grpdelete3.Location = new Point(228, 360);
            grpdelete3.Margin = new Padding(3, 2, 3, 2);
            grpdelete3.Name = "grpdelete3";
            grpdelete3.Size = new Size(34, 22);
            grpdelete3.TabIndex = 26;
            grpdelete3.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.Location = new Point(18, 187);
            label8.Name = "label8";
            label8.Size = new Size(100, 19);
            label8.TabIndex = 18;
            label8.Text = "num_members";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label10.Location = new Point(18, 327);
            label10.Name = "label10";
            label10.Size = new Size(74, 19);
            label10.TabIndex = 17;
            label10.Text = "organiser1";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label11.Location = new Point(18, 281);
            label11.Name = "label11";
            label11.Size = new Size(78, 19);
            label11.TabIndex = 16;
            label11.Text = "active since";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label12.Location = new Point(18, 232);
            label12.Name = "label12";
            label12.Size = new Size(83, 19);
            label12.TabIndex = 15;
            label12.Text = "num_events";
            // 
            // button7
            // 
            button7.BackColor = Color.FromArgb(192, 192, 255);
            button7.Location = new Point(940, 668);
            button7.Margin = new Padding(3, 2, 3, 2);
            button7.Name = "button7";
            button7.Size = new Size(75, 29);
            button7.TabIndex = 25;
            button7.Text = "Next";
            button7.UseVisualStyleBackColor = false;
            // 
            // button5
            // 
            button5.BackColor = Color.FromArgb(192, 192, 255);
            button5.Location = new Point(827, 668);
            button5.Margin = new Padding(3, 2, 3, 2);
            button5.Name = "button5";
            button5.Size = new Size(46, 29);
            button5.TabIndex = 24;
            button5.Text = "2";
            button5.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            button4.BackColor = Color.FromArgb(192, 192, 255);
            button4.Location = new Point(879, 668);
            button4.Margin = new Padding(3, 2, 3, 2);
            button4.Name = "button4";
            button4.Size = new Size(46, 29);
            button4.TabIndex = 23;
            button4.Text = "3";
            button4.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(192, 192, 255);
            button3.Location = new Point(772, 668);
            button3.Margin = new Padding(3, 2, 3, 2);
            button3.Name = "button3";
            button3.Size = new Size(46, 29);
            button3.TabIndex = 22;
            button3.Text = "1";
            button3.UseVisualStyleBackColor = false;
            // 
            // Addgroup
            // 
            Addgroup.BackColor = Color.FromArgb(192, 192, 255);
            Addgroup.Location = new Point(857, 72);
            Addgroup.Name = "Addgroup";
            Addgroup.Size = new Size(158, 50);
            Addgroup.TabIndex = 26;
            Addgroup.Text = "Add Group";
            Addgroup.UseVisualStyleBackColor = false;
            Addgroup.Click += NewEvent_Click;
            // 
            // GroupsManagement
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Window;
            ClientSize = new Size(1092, 698);
            Controls.Add(Addgroup);
            Controls.Add(button7);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(panel5);
            Controls.Add(panel12);
            Controls.Add(panel10);
            Controls.Add(panel9);
            Controls.Add(panel7);
            Controls.Add(panel6);
            Controls.Add(panel4);
            Controls.Add(panel2);
            Controls.Add(panel3);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
            Name = "GroupsManagement";
            panel12.ResumeLayout(false);
            panel12.PerformLayout();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel5;
        private Panel panel12;
        private Label num_members1;
        private Label eventorganiser1;
        private Label active_since1;
        private Label num_events1;
        private TextBox group_description1;
        private Label groupname1;
        private Label label9;
        private Panel panel10;
        private Panel panel9;
        private Panel panel6;
        private TextBox group_description2;
        private Label groupname2;
        private Panel panel4;
        private Panel panel11;
        private TextBox groupsearch_admins;
        private Panel panel2;
        private Label activenum_members;
        private Label label2;
        private Panel panel3;
        private Label monthly_events;
        private Label label3;
        private Panel panel1;
        private Label totalnum_groups;
        private Label label1;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label groupname3;
        private TextBox group_description3;
        private Panel panel7;
        private Label label8;
        private Label label10;
        private Label label11;
        private Label label12;
        private ComboBox group_categories;
        private Button button7;
        private Button button5;
        private Button button4;
        private Button button3;
        private ComboBox group_status;
        private Button grpdelete1;
        private Button grpdelete2;
        private Button grpdelete3;
        private Button Addgroup;
    }
}