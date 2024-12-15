namespace Sofware_project
{
    partial class Groups
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
            group_description = new TextBox();
            label1 = new Label();
            group_name = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            group_type = new ComboBox();
            group_status = new ComboBox();
            organiser = new TextBox();
            label8 = new Label();
            label5 = new Label();
            addmembers_group = new ComboBox();
            button2 = new Button();
            add_group = new Button();
            SuspendLayout();
            // 
            // group_description
            // 
            group_description.BackColor = SystemColors.Window;
            group_description.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            group_description.Location = new Point(21, 160);
            group_description.Margin = new Padding(3, 2, 3, 2);
            group_description.Multiline = true;
            group_description.Name = "group_description";
            group_description.ReadOnly = true;
            group_description.Size = new Size(675, 96);
            group_description.TabIndex = 8;
            group_description.TextChanged += group_description_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(21, 118);
            label1.Name = "label1";
            label1.Size = new Size(139, 21);
            label1.TabIndex = 7;
            label1.Text = "About this group";
            // 
            // group_name
            // 
            group_name.Font = new Font("Segoe UI Black", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            group_name.Location = new Point(21, 59);
            group_name.Margin = new Padding(3, 2, 3, 2);
            group_name.Name = "group_name";
            group_name.Size = new Size(450, 37);
            group_name.TabIndex = 6;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(21, 22);
            label2.Name = "label2";
            label2.Size = new Size(107, 21);
            label2.TabIndex = 9;
            label2.Text = "Group Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(21, 356);
            label3.Name = "label3";
            label3.Size = new Size(106, 21);
            label3.TabIndex = 12;
            label3.Text = "Group status";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(21, 280);
            label4.Name = "label4";
            label4.Size = new Size(95, 21);
            label4.TabIndex = 11;
            label4.Text = "Group type";
            // 
            // group_type
            // 
            group_type.FormattingEnabled = true;
            group_type.Items.AddRange(new object[] { "Art", "Wellness", "Workshop", "Social" });
            group_type.Location = new Point(21, 312);
            group_type.Margin = new Padding(3, 2, 3, 2);
            group_type.Name = "group_type";
            group_type.Size = new Size(152, 23);
            group_type.TabIndex = 13;
            group_type.SelectedIndexChanged += group_type_SelectedIndexChanged;
            // 
            // group_status
            // 
            group_status.FormattingEnabled = true;
            group_status.Items.AddRange(new object[] { "Active", "Inactive", "Pending" });
            group_status.Location = new Point(21, 395);
            group_status.Margin = new Padding(3, 2, 3, 2);
            group_status.Name = "group_status";
            group_status.Size = new Size(152, 23);
            group_status.TabIndex = 14;
            // 
            // organiser
            // 
            organiser.BackColor = SystemColors.Window;
            organiser.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            organiser.ForeColor = SystemColors.ControlText;
            organiser.Location = new Point(21, 560);
            organiser.Margin = new Padding(3, 2, 3, 2);
            organiser.Name = "organiser";
            organiser.Size = new Size(248, 26);
            organiser.TabIndex = 21;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(21, 519);
            label8.Name = "label8";
            label8.Size = new Size(111, 21);
            label8.TabIndex = 20;
            label8.Text = "Organised by";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(21, 439);
            label5.Name = "label5";
            label5.Size = new Size(116, 21);
            label5.TabIndex = 22;
            label5.Text = "Add members";
            // 
            // addmembers_group
            // 
            addmembers_group.FormattingEnabled = true;
            addmembers_group.Location = new Point(21, 475);
            addmembers_group.Margin = new Padding(3, 2, 3, 2);
            addmembers_group.Name = "addmembers_group";
            addmembers_group.Size = new Size(133, 23);
            addmembers_group.TabIndex = 23;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(192, 192, 255);
            button2.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.Location = new Point(574, 598);
            button2.Margin = new Padding(3, 2, 3, 2);
            button2.Name = "button2";
            button2.Size = new Size(122, 32);
            button2.TabIndex = 25;
            button2.Text = "Cancel";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // add_group
            // 
            add_group.BackColor = Color.FromArgb(192, 192, 255);
            add_group.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            add_group.Location = new Point(441, 598);
            add_group.Margin = new Padding(3, 2, 3, 2);
            add_group.Name = "add_group";
            add_group.Size = new Size(122, 32);
            add_group.TabIndex = 24;
            add_group.Text = "Add";
            add_group.UseVisualStyleBackColor = false;
            add_group.Click += add_group_Click;
            // 
            // Groups
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Window;
            ClientSize = new Size(727, 649);
            Controls.Add(button2);
            Controls.Add(add_group);
            Controls.Add(addmembers_group);
            Controls.Add(label5);
            Controls.Add(organiser);
            Controls.Add(label8);
            Controls.Add(group_status);
            Controls.Add(group_type);
            Controls.Add(label3);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(group_description);
            Controls.Add(label1);
            Controls.Add(group_name);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Groups";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Groups";
            Load += Groups_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox group_description;
        private Label label1;
        private TextBox group_name;
        private Label label2;
        private Label label3;
        private Label label4;
        private ComboBox group_type;
        private ComboBox group_status;
        private TextBox organiser;
        private Label label8;
        private Label label5;
        private ComboBox addmembers_group;
        private Button button2;
        private Button add_group;
    }
}