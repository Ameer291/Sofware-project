namespace Sofware_project
{
    partial class Events_info_create
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
            event_name = new TextBox();
            label1 = new Label();
            event_description = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            event_date = new TextBox();
            event_time = new TextBox();
            event_location = new TextBox();
            total_bookings = new TextBox();
            label8 = new Label();
            organiser = new TextBox();
            update_create_eventbtn = new Button();
            button2 = new Button();
            event_type = new ComboBox();
            event_status = new ComboBox();
            SuspendLayout();
            // 
            // event_name
            // 
            event_name.BorderStyle = BorderStyle.None;
            event_name.Font = new Font("Segoe UI Black", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            event_name.Location = new Point(15, 15);
            event_name.Margin = new Padding(4);
            event_name.Name = "event_name";
            event_name.PlaceholderText = "Event name";
            event_name.Size = new Size(642, 44);
            event_name.TabIndex = 0;
            event_name.TextChanged += textBox1_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(15, 81);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(203, 32);
            label1.TabIndex = 1;
            label1.Text = "About this event";
            // 
            // event_description
            // 
            event_description.BackColor = SystemColors.Window;
            event_description.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            event_description.Location = new Point(15, 132);
            event_description.Margin = new Padding(4);
            event_description.Multiline = true;
            event_description.Name = "event_description";
            event_description.Size = new Size(963, 156);
            event_description.TabIndex = 5;
            event_description.TextChanged += event_description_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(15, 306);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(134, 32);
            label2.TabIndex = 7;
            label2.Text = "Event type";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(15, 399);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(152, 32);
            label3.TabIndex = 8;
            label3.Text = "Event status";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(15, 786);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(242, 32);
            label4.TabIndex = 10;
            label4.Text = "Maximum bookings";
            label4.Click += label4_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(15, 691);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(112, 32);
            label5.TabIndex = 11;
            label5.Text = "Location";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(15, 590);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(116, 32);
            label6.TabIndex = 12;
            label6.Text = "Duration";
            label6.Click += label6_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(15, 492);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(256, 32);
            label7.TabIndex = 13;
            label7.Text = "Date (DD/MM/YYYY)";
            // 
            // event_date
            // 
            event_date.BackColor = SystemColors.Window;
            event_date.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            event_date.ForeColor = SystemColors.ControlText;
            event_date.Location = new Point(15, 531);
            event_date.Margin = new Padding(4);
            event_date.Name = "event_date";
            event_date.Size = new Size(353, 35);
            event_date.TabIndex = 14;
            // 
            // event_time
            // 
            event_time.BackColor = SystemColors.Window;
            event_time.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            event_time.ForeColor = SystemColors.ControlText;
            event_time.Location = new Point(15, 629);
            event_time.Margin = new Padding(4);
            event_time.Name = "event_time";
            event_time.Size = new Size(353, 35);
            event_time.TabIndex = 15;
            // 
            // event_location
            // 
            event_location.BackColor = SystemColors.Window;
            event_location.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            event_location.ForeColor = SystemColors.ControlText;
            event_location.Location = new Point(15, 730);
            event_location.Margin = new Padding(4);
            event_location.Name = "event_location";
            event_location.Size = new Size(353, 35);
            event_location.TabIndex = 16;
            // 
            // total_bookings
            // 
            total_bookings.BackColor = SystemColors.Window;
            total_bookings.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            total_bookings.ForeColor = SystemColors.ControlText;
            total_bookings.Location = new Point(15, 825);
            total_bookings.Margin = new Padding(4);
            total_bookings.Name = "total_bookings";
            total_bookings.Size = new Size(353, 35);
            total_bookings.TabIndex = 17;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(15, 879);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(166, 32);
            label8.TabIndex = 18;
            label8.Text = "Organised by";
            // 
            // organiser
            // 
            organiser.BackColor = SystemColors.Window;
            organiser.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            organiser.ForeColor = SystemColors.ControlText;
            organiser.Location = new Point(15, 929);
            organiser.Margin = new Padding(4);
            organiser.Name = "organiser";
            organiser.Size = new Size(353, 35);
            organiser.TabIndex = 19;
            // 
            // update_create_eventbtn
            // 
            update_create_eventbtn.BackColor = Color.FromArgb(192, 192, 255);
            update_create_eventbtn.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            update_create_eventbtn.Location = new Point(625, 970);
            update_create_eventbtn.Margin = new Padding(4);
            update_create_eventbtn.Name = "update_create_eventbtn";
            update_create_eventbtn.Size = new Size(175, 54);
            update_create_eventbtn.TabIndex = 20;
            update_create_eventbtn.Text = "Update/Create";
            update_create_eventbtn.UseVisualStyleBackColor = false;
            update_create_eventbtn.Click += update_create_eventbtn_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(192, 192, 255);
            button2.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.Location = new Point(832, 970);
            button2.Margin = new Padding(4);
            button2.Name = "button2";
            button2.Size = new Size(175, 54);
            button2.TabIndex = 21;
            button2.Text = "Cancel";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // event_type
            // 
            event_type.FormattingEnabled = true;
            event_type.Items.AddRange(new object[] { "Art", "Wellness", "Workshop", "Social" });
            event_type.Location = new Point(16, 350);
            event_type.Name = "event_type";
            event_type.Size = new Size(182, 33);
            event_type.TabIndex = 22;
            // 
            // event_status
            // 
            event_status.FormattingEnabled = true;
            event_status.Items.AddRange(new object[] { "Upcoming", "Active", "Draft", "Completed" });
            event_status.Location = new Point(16, 445);
            event_status.Name = "event_status";
            event_status.Size = new Size(182, 33);
            event_status.TabIndex = 23;
            // 
            // Events_info_create
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = SystemColors.Window;
            ClientSize = new Size(1038, 1039);
            Controls.Add(event_status);
            Controls.Add(event_type);
            Controls.Add(button2);
            Controls.Add(update_create_eventbtn);
            Controls.Add(organiser);
            Controls.Add(label8);
            Controls.Add(total_bookings);
            Controls.Add(event_location);
            Controls.Add(event_time);
            Controls.Add(event_date);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(event_description);
            Controls.Add(label1);
            Controls.Add(event_name);
            Margin = new Padding(4);
            Name = "Events_info_create";
            Text = "Events";
            Load += Events_info_create_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox event_name;
        private Label label1;
        private TextBox event_description;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox event_date;
        private TextBox event_time;
        private TextBox event_location;
        private TextBox total_bookings;
        private Label label8;
        private TextBox organiser;
        private Button update_create_eventbtn;
        private Button button2;
        private ComboBox event_type;
        private ComboBox event_status;
    }
}