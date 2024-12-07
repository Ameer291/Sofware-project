namespace Sofware_project
{
    partial class EventsManagement
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
            totalnum_events = new Label();
            label1 = new Label();
            panel2 = new Panel();
            activenum_events = new Label();
            label2 = new Label();
            panel3 = new Panel();
            totalnum_attendees = new Label();
            label3 = new Label();
            panel4 = new Panel();
            panel11 = new Panel();
            button2 = new Button();
            button1 = new Button();
            eventsearch_admins = new TextBox();
            panel6 = new Panel();
            eventdelete2 = new Button();
            eventedit2 = new Button();
            eventorganiser2 = new Label();
            eventlocation2 = new Label();
            eventdate2 = new Label();
            eventstatus2 = new Label();
            eventtype2 = new Label();
            event_description2 = new TextBox();
            eventname2 = new Label();
            Event3Panel = new Panel();
            eventedit3 = new Button();
            eventdelete3 = new Button();
            eventorganiser3 = new Label();
            eventlocation3 = new Label();
            eventdate3 = new Label();
            eventstatus3 = new Label();
            eventtype3 = new Label();
            event_description3 = new TextBox();
            eventname3 = new Label();
            panel9 = new Panel();
            panel10 = new Panel();
            panel12 = new Panel();
            eventdate1 = new Label();
            eventdelete1 = new Button();
            eventedit1 = new Button();
            eventorganiser1 = new Label();
            eventlocation1 = new Label();
            eventstatus1 = new Label();
            event_description1 = new TextBox();
            eventtype1 = new Label();
            eventname1 = new Label();
            label9 = new Label();
            panel5 = new Panel();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            panel6.SuspendLayout();
            Event3Panel.SuspendLayout();
            panel12.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(totalnum_events);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(37, 40);
            panel1.Name = "panel1";
            panel1.Size = new Size(214, 120);
            panel1.TabIndex = 0;
            // 
            // totalnum_events
            // 
            totalnum_events.AutoSize = true;
            totalnum_events.Location = new Point(26, 48);
            totalnum_events.Name = "totalnum_events";
            totalnum_events.Size = new Size(78, 25);
            totalnum_events.TabIndex = 1;
            totalnum_events.Text = "number";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(17, 21);
            label1.Name = "label1";
            label1.Size = new Size(128, 30);
            label1.TabIndex = 0;
            label1.Text = "Total Events";
            label1.Click += label1_Click;
            // 
            // panel2
            // 
            panel2.BorderStyle = BorderStyle.Fixed3D;
            panel2.Controls.Add(activenum_events);
            panel2.Controls.Add(label2);
            panel2.Location = new Point(317, 40);
            panel2.Name = "panel2";
            panel2.Size = new Size(214, 120);
            panel2.TabIndex = 1;
            // 
            // activenum_events
            // 
            activenum_events.AutoSize = true;
            activenum_events.Location = new Point(14, 48);
            activenum_events.Name = "activenum_events";
            activenum_events.Size = new Size(78, 25);
            activenum_events.TabIndex = 5;
            activenum_events.Text = "number";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(14, 21);
            label2.Name = "label2";
            label2.Size = new Size(140, 30);
            label2.TabIndex = 1;
            label2.Text = "Active Events";
            // 
            // panel3
            // 
            panel3.BorderStyle = BorderStyle.Fixed3D;
            panel3.Controls.Add(totalnum_attendees);
            panel3.Controls.Add(label3);
            panel3.Location = new Point(590, 40);
            panel3.Name = "panel3";
            panel3.Size = new Size(214, 120);
            panel3.TabIndex = 1;
            panel3.Paint += panel3_Paint;
            // 
            // totalnum_attendees
            // 
            totalnum_attendees.AutoSize = true;
            totalnum_attendees.Location = new Point(20, 48);
            totalnum_attendees.Name = "totalnum_attendees";
            totalnum_attendees.Size = new Size(78, 25);
            totalnum_attendees.TabIndex = 4;
            totalnum_attendees.Text = "number";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(20, 21);
            label3.Name = "label3";
            label3.Size = new Size(163, 30);
            label3.TabIndex = 1;
            label3.Text = "Total Attendees";
            // 
            // panel4
            // 
            panel4.BorderStyle = BorderStyle.Fixed3D;
            panel4.Controls.Add(panel11);
            panel4.Controls.Add(button2);
            panel4.Controls.Add(button1);
            panel4.Controls.Add(eventsearch_admins);
            panel4.Location = new Point(37, 181);
            panel4.Name = "panel4";
            panel4.RightToLeft = RightToLeft.No;
            panel4.Size = new Size(801, 44);
            panel4.TabIndex = 2;
            // 
            // panel11
            // 
            panel11.BackgroundImage = Properties.Resources.Screenshot_2024_12_01_163426;
            panel11.BackgroundImageLayout = ImageLayout.Stretch;
            panel11.Location = new Point(9, 6);
            panel11.Name = "panel11";
            panel11.Size = new Size(24, 24);
            panel11.TabIndex = 6;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(192, 192, 255);
            button2.Location = new Point(666, 1);
            button2.Name = "button2";
            button2.Size = new Size(127, 35);
            button2.TabIndex = 5;
            button2.Text = "All status";
            button2.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(192, 192, 255);
            button1.FlatAppearance.BorderColor = SystemColors.Window;
            button1.FlatAppearance.BorderSize = 0;
            button1.Location = new Point(525, 1);
            button1.Name = "button1";
            button1.Size = new Size(135, 35);
            button1.TabIndex = 4;
            button1.Text = "All categories";
            button1.UseVisualStyleBackColor = false;
            // 
            // eventsearch_admins
            // 
            eventsearch_admins.BorderStyle = BorderStyle.None;
            eventsearch_admins.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            eventsearch_admins.ForeColor = SystemColors.WindowText;
            eventsearch_admins.Location = new Point(39, 6);
            eventsearch_admins.Name = "eventsearch_admins";
            eventsearch_admins.PlaceholderText = "Search events";
            eventsearch_admins.Size = new Size(299, 28);
            eventsearch_admins.TabIndex = 3;
            eventsearch_admins.TextChanged += textBox3_TextChanged;
            // 
            // panel6
            // 
            panel6.BorderStyle = BorderStyle.Fixed3D;
            panel6.Controls.Add(eventdelete2);
            panel6.Controls.Add(eventedit2);
            panel6.Controls.Add(eventorganiser2);
            panel6.Controls.Add(eventlocation2);
            panel6.Controls.Add(eventdate2);
            panel6.Controls.Add(eventstatus2);
            panel6.Controls.Add(eventtype2);
            panel6.Controls.Add(event_description2);
            panel6.Controls.Add(eventname2);
            panel6.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            panel6.Location = new Point(317, 253);
            panel6.Name = "panel6";
            panel6.Size = new Size(241, 408);
            panel6.TabIndex = 4;
            panel6.Paint += panel6_Paint;
            // 
            // eventdelete2
            // 
            eventdelete2.BackgroundImage = Properties.Resources.Screenshot_2024_12_01_214121;
            eventdelete2.BackgroundImageLayout = ImageLayout.Stretch;
            eventdelete2.FlatAppearance.BorderColor = SystemColors.Window;
            eventdelete2.FlatAppearance.BorderSize = 0;
            eventdelete2.FlatStyle = FlatStyle.Flat;
            eventdelete2.Location = new Point(195, 371);
            eventdelete2.Name = "eventdelete2";
            eventdelete2.Size = new Size(39, 30);
            eventdelete2.TabIndex = 16;
            eventdelete2.UseVisualStyleBackColor = true;
            // 
            // eventedit2
            // 
            eventedit2.BackgroundImage = Properties.Resources.Screenshot_2024_12_01_213651;
            eventedit2.BackgroundImageLayout = ImageLayout.Stretch;
            eventedit2.FlatAppearance.BorderColor = SystemColors.Window;
            eventedit2.FlatAppearance.BorderSize = 0;
            eventedit2.FlatStyle = FlatStyle.Flat;
            eventedit2.Location = new Point(150, 372);
            eventedit2.Name = "eventedit2";
            eventedit2.Size = new Size(39, 30);
            eventedit2.TabIndex = 14;
            eventedit2.UseVisualStyleBackColor = true;
            // 
            // eventorganiser2
            // 
            eventorganiser2.AutoSize = true;
            eventorganiser2.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            eventorganiser2.Location = new Point(3, 336);
            eventorganiser2.Name = "eventorganiser2";
            eventorganiser2.Size = new Size(110, 30);
            eventorganiser2.TabIndex = 13;
            eventorganiser2.Text = "organiser2";
            // 
            // eventlocation2
            // 
            eventlocation2.AutoSize = true;
            eventlocation2.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            eventlocation2.Location = new Point(3, 281);
            eventlocation2.Name = "eventlocation2";
            eventlocation2.Size = new Size(98, 30);
            eventlocation2.TabIndex = 11;
            eventlocation2.Text = "location2";
            // 
            // eventdate2
            // 
            eventdate2.AutoSize = true;
            eventdate2.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            eventdate2.Location = new Point(3, 210);
            eventdate2.Name = "eventdate2";
            eventdate2.Size = new Size(65, 30);
            eventdate2.TabIndex = 7;
            eventdate2.Text = "date2";
            // 
            // eventstatus2
            // 
            eventstatus2.AutoSize = true;
            eventstatus2.BackColor = Color.LemonChiffon;
            eventstatus2.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            eventstatus2.ForeColor = Color.Goldenrod;
            eventstatus2.Location = new Point(3, 251);
            eventstatus2.Name = "eventstatus2";
            eventstatus2.Size = new Size(141, 30);
            eventstatus2.TabIndex = 6;
            eventstatus2.Text = "event status2";
            // 
            // eventtype2
            // 
            eventtype2.AutoSize = true;
            eventtype2.BackColor = SystemColors.GradientInactiveCaption;
            eventtype2.ForeColor = SystemColors.HotTrack;
            eventtype2.Location = new Point(3, 175);
            eventtype2.Name = "eventtype2";
            eventtype2.Size = new Size(133, 30);
            eventtype2.TabIndex = 5;
            eventtype2.Text = "event type 2";
            // 
            // event_description2
            // 
            event_description2.BackColor = SystemColors.Window;
            event_description2.BorderStyle = BorderStyle.None;
            event_description2.Location = new Point(-2, 112);
            event_description2.Multiline = true;
            event_description2.Name = "event_description2";
            event_description2.ReadOnly = true;
            event_description2.Size = new Size(241, 50);
            event_description2.TabIndex = 4;
            event_description2.TextChanged += textBox1_TextChanged;
            // 
            // eventname2
            // 
            eventname2.AutoSize = true;
            eventname2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            eventname2.Location = new Point(14, 74);
            eventname2.Name = "eventname2";
            eventname2.Size = new Size(98, 32);
            eventname2.TabIndex = 2;
            eventname2.Text = "event 2";
            // 
            // Event3Panel
            // 
            Event3Panel.BorderStyle = BorderStyle.Fixed3D;
            Event3Panel.Controls.Add(eventedit3);
            Event3Panel.Controls.Add(eventdelete3);
            Event3Panel.Controls.Add(eventorganiser3);
            Event3Panel.Controls.Add(eventlocation3);
            Event3Panel.Controls.Add(eventdate3);
            Event3Panel.Controls.Add(eventstatus3);
            Event3Panel.Controls.Add(eventtype3);
            Event3Panel.Controls.Add(event_description3);
            Event3Panel.Controls.Add(eventname3);
            Event3Panel.Location = new Point(590, 253);
            Event3Panel.Name = "Event3Panel";
            Event3Panel.Size = new Size(241, 408);
            Event3Panel.TabIndex = 5;
            // 
            // eventedit3
            // 
            eventedit3.BackgroundImage = Properties.Resources.Screenshot_2024_12_01_213651;
            eventedit3.BackgroundImageLayout = ImageLayout.Stretch;
            eventedit3.FlatAppearance.BorderColor = SystemColors.Window;
            eventedit3.FlatAppearance.BorderSize = 0;
            eventedit3.FlatStyle = FlatStyle.Flat;
            eventedit3.Location = new Point(150, 371);
            eventedit3.Name = "eventedit3";
            eventedit3.Size = new Size(39, 30);
            eventedit3.TabIndex = 15;
            eventedit3.UseVisualStyleBackColor = true;
            // 
            // eventdelete3
            // 
            eventdelete3.BackgroundImage = Properties.Resources.Screenshot_2024_12_01_214121;
            eventdelete3.BackgroundImageLayout = ImageLayout.Stretch;
            eventdelete3.FlatAppearance.BorderColor = SystemColors.Window;
            eventdelete3.FlatAppearance.BorderSize = 0;
            eventdelete3.FlatStyle = FlatStyle.Flat;
            eventdelete3.Location = new Point(195, 372);
            eventdelete3.Name = "eventdelete3";
            eventdelete3.Size = new Size(39, 30);
            eventdelete3.TabIndex = 15;
            eventdelete3.UseVisualStyleBackColor = true;
            // 
            // eventorganiser3
            // 
            eventorganiser3.AutoSize = true;
            eventorganiser3.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            eventorganiser3.Location = new Point(6, 338);
            eventorganiser3.Name = "eventorganiser3";
            eventorganiser3.Size = new Size(110, 30);
            eventorganiser3.TabIndex = 12;
            eventorganiser3.Text = "organiser3";
            // 
            // eventlocation3
            // 
            eventlocation3.AutoSize = true;
            eventlocation3.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            eventlocation3.Location = new Point(6, 281);
            eventlocation3.Name = "eventlocation3";
            eventlocation3.Size = new Size(98, 30);
            eventlocation3.TabIndex = 10;
            eventlocation3.Text = "location3";
            // 
            // eventdate3
            // 
            eventdate3.AutoSize = true;
            eventdate3.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            eventdate3.Location = new Point(6, 210);
            eventdate3.Name = "eventdate3";
            eventdate3.Size = new Size(65, 30);
            eventdate3.TabIndex = 8;
            eventdate3.Text = "date3";
            // 
            // eventstatus3
            // 
            eventstatus3.AutoSize = true;
            eventstatus3.BackColor = Color.LemonChiffon;
            eventstatus3.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            eventstatus3.ForeColor = Color.Goldenrod;
            eventstatus3.Location = new Point(6, 251);
            eventstatus3.Name = "eventstatus3";
            eventstatus3.Size = new Size(141, 30);
            eventstatus3.TabIndex = 7;
            eventstatus3.Text = "event status3";
            // 
            // eventtype3
            // 
            eventtype3.AutoSize = true;
            eventtype3.BackColor = SystemColors.GradientInactiveCaption;
            eventtype3.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            eventtype3.ForeColor = SystemColors.HotTrack;
            eventtype3.Location = new Point(6, 175);
            eventtype3.Name = "eventtype3";
            eventtype3.Size = new Size(127, 30);
            eventtype3.TabIndex = 6;
            eventtype3.Text = "event type3";
            // 
            // event_description3
            // 
            event_description3.BackColor = SystemColors.Window;
            event_description3.BorderStyle = BorderStyle.None;
            event_description3.Location = new Point(-2, 112);
            event_description3.Multiline = true;
            event_description3.Name = "event_description3";
            event_description3.ReadOnly = true;
            event_description3.Size = new Size(241, 50);
            event_description3.TabIndex = 5;
            // 
            // eventname3
            // 
            eventname3.AutoSize = true;
            eventname3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            eventname3.Location = new Point(20, 74);
            eventname3.Name = "eventname3";
            eventname3.Size = new Size(98, 32);
            eventname3.TabIndex = 3;
            eventname3.Text = "event 3";
            eventname3.Click += label6_Click;
            // 
            // panel9
            // 
            panel9.BackgroundImage = Properties.Resources.Screenshot_2024_12_01_161526;
            panel9.BackgroundImageLayout = ImageLayout.Stretch;
            panel9.Location = new Point(590, 253);
            panel9.Name = "panel9";
            panel9.Size = new Size(241, 73);
            panel9.TabIndex = 1;
            // 
            // panel10
            // 
            panel10.BackgroundImage = Properties.Resources.Screenshot_2024_12_01_161526;
            panel10.BackgroundImageLayout = ImageLayout.Stretch;
            panel10.Location = new Point(317, 253);
            panel10.Name = "panel10";
            panel10.Size = new Size(241, 73);
            panel10.TabIndex = 1;
            // 
            // panel12
            // 
            panel12.BorderStyle = BorderStyle.Fixed3D;
            panel12.Controls.Add(eventdate1);
            panel12.Controls.Add(eventdelete1);
            panel12.Controls.Add(eventedit1);
            panel12.Controls.Add(eventorganiser1);
            panel12.Controls.Add(eventlocation1);
            panel12.Controls.Add(eventstatus1);
            panel12.Controls.Add(event_description1);
            panel12.Controls.Add(eventtype1);
            panel12.Controls.Add(eventname1);
            panel12.Controls.Add(label9);
            panel12.Location = new Point(37, 253);
            panel12.Name = "panel12";
            panel12.Size = new Size(241, 408);
            panel12.TabIndex = 6;
            panel12.Paint += panel12_Paint;
            // 
            // eventdate1
            // 
            eventdate1.AutoSize = true;
            eventdate1.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            eventdate1.Location = new Point(11, 220);
            eventdate1.Name = "eventdate1";
            eventdate1.Size = new Size(65, 30);
            eventdate1.TabIndex = 14;
            eventdate1.Text = "date1";
            // 
            // eventdelete1
            // 
            eventdelete1.BackgroundImage = Properties.Resources.Screenshot_2024_12_01_214121;
            eventdelete1.BackgroundImageLayout = ImageLayout.Stretch;
            eventdelete1.FlatAppearance.BorderColor = SystemColors.Window;
            eventdelete1.FlatAppearance.BorderSize = 0;
            eventdelete1.FlatStyle = FlatStyle.Flat;
            eventdelete1.Location = new Point(191, 372);
            eventdelete1.Name = "eventdelete1";
            eventdelete1.Size = new Size(39, 30);
            eventdelete1.TabIndex = 13;
            eventdelete1.UseVisualStyleBackColor = true;
            eventdelete1.Click += eventdelete1_Click;
            // 
            // eventedit1
            // 
            eventedit1.BackgroundImage = Properties.Resources.Screenshot_2024_12_01_213651;
            eventedit1.BackgroundImageLayout = ImageLayout.Stretch;
            eventedit1.FlatAppearance.BorderColor = SystemColors.Window;
            eventedit1.FlatAppearance.BorderSize = 0;
            eventedit1.FlatStyle = FlatStyle.Flat;
            eventedit1.Location = new Point(146, 371);
            eventedit1.Name = "eventedit1";
            eventedit1.Size = new Size(39, 30);
            eventedit1.TabIndex = 12;
            eventedit1.UseVisualStyleBackColor = true;
            eventedit1.Click += eventedit1_Click;
            // 
            // eventorganiser1
            // 
            eventorganiser1.AutoSize = true;
            eventorganiser1.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            eventorganiser1.Location = new Point(11, 328);
            eventorganiser1.Name = "eventorganiser1";
            eventorganiser1.Size = new Size(110, 30);
            eventorganiser1.TabIndex = 11;
            eventorganiser1.Text = "organiser1";
            eventorganiser1.Click += label4_Click;
            // 
            // eventlocation1
            // 
            eventlocation1.AutoSize = true;
            eventlocation1.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            eventlocation1.Location = new Point(11, 281);
            eventlocation1.Name = "eventlocation1";
            eventlocation1.Size = new Size(98, 30);
            eventlocation1.TabIndex = 9;
            eventlocation1.Text = "location1";
            // 
            // eventstatus1
            // 
            eventstatus1.AutoSize = true;
            eventstatus1.BackColor = Color.LemonChiffon;
            eventstatus1.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            eventstatus1.ForeColor = Color.Goldenrod;
            eventstatus1.Location = new Point(13, 251);
            eventstatus1.Name = "eventstatus1";
            eventstatus1.Size = new Size(137, 30);
            eventstatus1.TabIndex = 4;
            eventstatus1.Text = "event status1";
            // 
            // event_description1
            // 
            event_description1.BackColor = SystemColors.Window;
            event_description1.BorderStyle = BorderStyle.None;
            event_description1.Location = new Point(-2, 112);
            event_description1.Multiline = true;
            event_description1.Name = "event_description1";
            event_description1.ReadOnly = true;
            event_description1.Size = new Size(241, 50);
            event_description1.TabIndex = 3;
            // 
            // eventtype1
            // 
            eventtype1.AutoSize = true;
            eventtype1.BackColor = SystemColors.GradientInactiveCaption;
            eventtype1.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            eventtype1.ForeColor = SystemColors.HotTrack;
            eventtype1.Location = new Point(9, 175);
            eventtype1.Name = "eventtype1";
            eventtype1.Size = new Size(129, 30);
            eventtype1.TabIndex = 2;
            eventtype1.Text = "event type 1";
            eventtype1.Click += eventtype1_Click;
            // 
            // eventname1
            // 
            eventname1.AutoSize = true;
            eventname1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            eventname1.Location = new Point(17, 74);
            eventname1.Name = "eventname1";
            eventname1.Size = new Size(98, 32);
            eventname1.TabIndex = 1;
            eventname1.Text = "event 1";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(9, 85);
            label9.Name = "label9";
            label9.Size = new Size(0, 30);
            label9.TabIndex = 0;
            // 
            // panel5
            // 
            panel5.BackgroundImage = Properties.Resources.Screenshot_2024_12_01_161526;
            panel5.BackgroundImageLayout = ImageLayout.Stretch;
            panel5.Location = new Point(37, 253);
            panel5.Name = "panel5";
            panel5.Size = new Size(241, 73);
            panel5.TabIndex = 11;
            // 
            // EventsManagement
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = SystemColors.Window;
            ClientSize = new Size(885, 711);
            Controls.Add(panel5);
            Controls.Add(panel12);
            Controls.Add(panel10);
            Controls.Add(panel9);
            Controls.Add(Event3Panel);
            Controls.Add(panel6);
            Controls.Add(panel4);
            Controls.Add(panel2);
            Controls.Add(panel3);
            Controls.Add(panel1);
            Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Name = "EventsManagement";
            Load += EventsManagement_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            Event3Panel.ResumeLayout(false);
            Event3Panel.PerformLayout();
            panel12.ResumeLayout(false);
            panel12.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Label label1;
        private Label label2;
        private Label label3;
        private Panel panel4;
        private TextBox eventsearch_admins;
        private Button button1;
        private Button button2;
        private Panel panel6;
        private Panel Event3Panel;
        private Panel panel8;
        private Panel panel9;
        private Panel panel10;
        private Panel panel11;
        private Label totalnum_events;
        private Label eventname1;
        private Label eventname2;
        private Label eventname3;
        private TextBox event_description1;
        private Label eventtype1;
        private TextBox event_description2;
        private TextBox event_description3;
        private Label eventtype2;
        private Label eventtype3;
        private Label eventstatus1;
        private Label eventstatus2;
        private Label eventstatus3;
        // private Label eventdate1;
        private Panel panel12;
        //private Label eventdate1;
        //private Label eventstatus1;
        private TextBox textBox1;
        private Label activenum_events;
        //private Label eventname1;
        private Label label9;
        private Label eventdate2;
        private Label eventdate3;
        private Label eventlocation1;
        private Label eventlocation2;
        private Label eventlocation3;
        private Panel panel5;
        private Label eventorganiser1;
        private Label eventorganiser2;
        private Label eventorganiser3;
        private Button eventedit1;
        private Button eventdelete2;
        private Button eventedit2;
        private Button eventedit3;
        private Button eventdelete3;
        private Button eventdelete1;
        private Label eventdate1;
        private Label totalnum_attendees;
    }
}