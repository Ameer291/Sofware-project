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
            group_description.Location = new Point(12, 160);
            group_description.Multiline = true;
            group_description.Name = "group_description";
            group_description.ReadOnly = true;
            group_description.Size = new Size(771, 126);
            group_description.TabIndex = 8;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 119);
            label1.Name = "label1";
            label1.Size = new Size(173, 28);
            label1.TabIndex = 7;
            label1.Text = "About this group";
            // 
            // group_name
            // 
            group_name.Font = new Font("Segoe UI Black", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            group_name.Location = new Point(12, 66);
            group_name.Name = "group_name";
            group_name.Size = new Size(514, 44);
            group_name.TabIndex = 6;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(12, 22);
            label2.Name = "label2";
            label2.Size = new Size(132, 28);
            label2.TabIndex = 9;
            label2.Text = "Group Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(12, 375);
            label3.Name = "label3";
            label3.Size = new Size(133, 28);
            label3.TabIndex = 12;
            label3.Text = "Group status";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(12, 301);
            label4.Name = "label4";
            label4.Size = new Size(118, 28);
            label4.TabIndex = 11;
            label4.Text = "Group type";
            // 
            // group_type
            // 
            group_type.FormattingEnabled = true;
            group_type.Items.AddRange(new object[] { "Art", "Wellness", "Workshop", "Social" });
            group_type.Location = new Point(12, 332);
            group_type.Name = "group_type";
            group_type.Size = new Size(173, 28);
            group_type.TabIndex = 13;
            group_type.SelectedIndexChanged += group_type_SelectedIndexChanged;
            // 
            // group_status
            // 
            group_status.FormattingEnabled = true;
            group_status.Items.AddRange(new object[] { "Active", "Inactive", "Pending" });
            group_status.Location = new Point(12, 406);
            group_status.Name = "group_status";
            group_status.Size = new Size(173, 28);
            group_status.TabIndex = 14;
            // 
            // organiser
            // 
            organiser.BackColor = SystemColors.Window;
            organiser.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            organiser.ForeColor = SystemColors.ControlText;
            organiser.Location = new Point(12, 564);
            organiser.Name = "organiser";
            organiser.Size = new Size(283, 30);
            organiser.TabIndex = 21;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(12, 533);
            label8.Name = "label8";
            label8.Size = new Size(137, 28);
            label8.TabIndex = 20;
            label8.Text = "Organised by";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(12, 454);
            label5.Name = "label5";
            label5.Size = new Size(143, 28);
            label5.TabIndex = 22;
            label5.Text = "Add members";
            // 
            // addmembers_group
            // 
            addmembers_group.FormattingEnabled = true;
            addmembers_group.Location = new Point(12, 485);
            addmembers_group.Name = "addmembers_group";
            addmembers_group.Size = new Size(151, 28);
            addmembers_group.TabIndex = 23;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(192, 192, 255);
            button2.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.Location = new Point(643, 615);
            button2.Name = "button2";
            button2.Size = new Size(140, 43);
            button2.TabIndex = 25;
            button2.Text = "Cancel";
            button2.UseVisualStyleBackColor = false;
            // 
            // add_group
            // 
            add_group.BackColor = Color.FromArgb(192, 192, 255);
            add_group.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            add_group.Location = new Point(491, 615);
            add_group.Name = "add_group";
            add_group.Size = new Size(140, 43);
            add_group.TabIndex = 24;
            add_group.Text = "Add";
            add_group.UseVisualStyleBackColor = false;
            // 
            // Groups
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Window;
            ClientSize = new Size(796, 668);
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
            Name = "Groups";
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