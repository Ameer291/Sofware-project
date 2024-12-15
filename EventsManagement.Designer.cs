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
            event_status = new ComboBox();
            event_categories = new ComboBox();
            panel11 = new Panel();
            eventsearch_admins = new TextBox();
            panel6 = new Panel();
            duration2 = new Label();
            eventdelete2 = new Button();
            eventedit2 = new Button();
            eventorganiser2 = new Label();
            booking2 = new Label();
            eventlocation2 = new Label();
            eventdate2 = new Label();
            eventstatus2 = new Label();
            eventtype2 = new Label();
            event_description2 = new TextBox();
            eventname2 = new Label();
            Event3Panel = new Panel();
            duration3 = new Label();
            eventedit3 = new Button();
            eventdelete3 = new Button();
            eventorganiser3 = new Label();
            booking3 = new Label();
            eventlocation3 = new Label();
            eventdate3 = new Label();
            eventstatus3 = new Label();
            eventtype3 = new Label();
            event_description3 = new TextBox();
            eventname3 = new Label();
            panel9 = new Panel();
            panel10 = new Panel();
            panel12 = new Panel();
            duration1 = new Label();
            eventdate1 = new Label();
            eventdelete1 = new Button();
            eventedit1 = new Button();
            booking1 = new Label();
            eventorganiser1 = new Label();
            eventlocation1 = new Label();
            eventstatus1 = new Label();
            event_description1 = new TextBox();
            eventtype1 = new Label();
            eventname1 = new Label();
            label9 = new Label();
            panel5 = new Panel();
            NewEvent = new Button();
            button1 = new Button();
            button2 = new Button();
            button6 = new Button();
            button8 = new Button();
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
            totalnum_events.Size = new Size(49, 15);
            totalnum_events.TabIndex = 1;
            totalnum_events.Text = "number";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(17, 21);
            label1.Name = "label1";
            label1.Size = new Size(84, 19);
            label1.TabIndex = 0;
            label1.Text = "Total Events";
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
            activenum_events.Size = new Size(14, 15);
            activenum_events.TabIndex = 5;
            activenum_events.Text = "4";
            activenum_events.Click += activenum_events_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(14, 21);
            label2.Name = "label2";
            label2.Size = new Size(92, 19);
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
            // 
            // totalnum_attendees
            // 
            totalnum_attendees.AutoSize = true;
            totalnum_attendees.Location = new Point(20, 48);
            totalnum_attendees.Name = "totalnum_attendees";
            totalnum_attendees.Size = new Size(28, 15);
            totalnum_attendees.TabIndex = 4;
            totalnum_attendees.Text = "236";
            totalnum_attendees.Click += totalnum_attendees_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(20, 21);
            label3.Name = "label3";
            label3.Size = new Size(106, 19);
            label3.TabIndex = 1;
            label3.Text = "Total Attendees";
            // 
            // panel4
            // 
            panel4.BorderStyle = BorderStyle.Fixed3D;
            panel4.Controls.Add(event_status);
            panel4.Controls.Add(event_categories);
            panel4.Controls.Add(panel11);
            panel4.Controls.Add(eventsearch_admins);
            panel4.Location = new Point(37, 181);
            panel4.Name = "panel4";
            panel4.RightToLeft = RightToLeft.No;
            panel4.Size = new Size(1000, 39);
            panel4.TabIndex = 2;
            // 
            // event_status
            // 
            event_status.BackColor = Color.FromArgb(192, 192, 255);
            event_status.FlatStyle = FlatStyle.Flat;
            event_status.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            event_status.FormattingEnabled = true;
            event_status.Items.AddRange(new object[] { "Upcoming", "Active", "Completed", "Draft" });
            event_status.Location = new Point(879, 7);
            event_status.Margin = new Padding(3, 2, 3, 2);
            event_status.Name = "event_status";
            event_status.Size = new Size(97, 23);
            event_status.TabIndex = 9;
            event_status.Text = "All Status";
            // 
            // event_categories
            // 
            event_categories.BackColor = Color.FromArgb(192, 192, 255);
            event_categories.FlatStyle = FlatStyle.Flat;
            event_categories.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            event_categories.FormattingEnabled = true;
            event_categories.Items.AddRange(new object[] { "Art", "Wellness", "Workshop", "Social" });
            event_categories.Location = new Point(750, 7);
            event_categories.Margin = new Padding(3, 2, 3, 2);
            event_categories.Name = "event_categories";
            event_categories.Size = new Size(110, 23);
            event_categories.TabIndex = 8;
            event_categories.Text = "All Categories";
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
            // eventsearch_admins
            // 
            eventsearch_admins.BorderStyle = BorderStyle.None;
            eventsearch_admins.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            eventsearch_admins.ForeColor = SystemColors.WindowText;
            eventsearch_admins.Location = new Point(44, 6);
            eventsearch_admins.Name = "eventsearch_admins";
            eventsearch_admins.PlaceholderText = "Search events";
            eventsearch_admins.Size = new Size(299, 19);
            eventsearch_admins.TabIndex = 3;
            // 
            // panel6
            // 
            panel6.BorderStyle = BorderStyle.Fixed3D;
            panel6.Controls.Add(duration2);
            panel6.Controls.Add(eventdelete2);
            panel6.Controls.Add(eventedit2);
            panel6.Controls.Add(eventorganiser2);
            panel6.Controls.Add(booking2);
            panel6.Controls.Add(eventlocation2);
            panel6.Controls.Add(eventdate2);
            panel6.Controls.Add(eventstatus2);
            panel6.Controls.Add(eventtype2);
            panel6.Controls.Add(event_description2);
            panel6.Controls.Add(eventname2);
            panel6.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            panel6.Location = new Point(382, 247);
            panel6.Name = "panel6";
            panel6.Size = new Size(269, 406);
            panel6.TabIndex = 4;
            panel6.Paint += panel6_Paint;
            // 
            // duration2
            // 
            duration2.AutoSize = true;
            duration2.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            duration2.Location = new Point(14, 254);
            duration2.Name = "duration2";
            duration2.Size = new Size(69, 19);
            duration2.TabIndex = 17;
            duration2.Text = "duration2";
            // 
            // eventdelete2
            // 
            eventdelete2.BackgroundImage = Properties.Resources.Screenshot_2024_12_01_214121;
            eventdelete2.BackgroundImageLayout = ImageLayout.Stretch;
            eventdelete2.FlatAppearance.BorderColor = SystemColors.Window;
            eventdelete2.FlatAppearance.BorderSize = 0;
            eventdelete2.FlatStyle = FlatStyle.Flat;
            eventdelete2.Location = new Point(208, 365);
            eventdelete2.Name = "eventdelete2";
            eventdelete2.Size = new Size(39, 30);
            eventdelete2.TabIndex = 16;
            eventdelete2.UseVisualStyleBackColor = true;
            eventdelete2.Click += eventdelete2_Click;
            // 
            // eventedit2
            // 
            eventedit2.BackgroundImage = Properties.Resources.Screenshot_2024_12_01_213651;
            eventedit2.BackgroundImageLayout = ImageLayout.Stretch;
            eventedit2.FlatAppearance.BorderColor = SystemColors.Window;
            eventedit2.FlatAppearance.BorderSize = 0;
            eventedit2.FlatStyle = FlatStyle.Flat;
            eventedit2.Location = new Point(163, 365);
            eventedit2.Name = "eventedit2";
            eventedit2.Size = new Size(39, 30);
            eventedit2.TabIndex = 14;
            eventedit2.UseVisualStyleBackColor = true;
            eventedit2.Click += eventedit2_Click;
            // 
            // eventorganiser2
            // 
            eventorganiser2.AutoSize = true;
            eventorganiser2.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            eventorganiser2.Location = new Point(14, 365);
            eventorganiser2.Name = "eventorganiser2";
            eventorganiser2.Size = new Size(74, 19);
            eventorganiser2.TabIndex = 13;
            eventorganiser2.Text = "organiser2";
            // 
            // booking2
            // 
            booking2.AutoSize = true;
            booking2.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            booking2.Location = new Point(14, 331);
            booking2.Name = "booking2";
            booking2.Size = new Size(67, 19);
            booking2.TabIndex = 11;
            booking2.Text = "Booking2";
            booking2.Click += booking2_Click;
            // 
            // eventlocation2
            // 
            eventlocation2.AutoSize = true;
            eventlocation2.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            eventlocation2.Location = new Point(14, 291);
            eventlocation2.Name = "eventlocation2";
            eventlocation2.Size = new Size(65, 19);
            eventlocation2.TabIndex = 11;
            eventlocation2.Text = "location2";
            // 
            // eventdate2
            // 
            eventdate2.AutoSize = true;
            eventdate2.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            eventdate2.Location = new Point(14, 221);
            eventdate2.Name = "eventdate2";
            eventdate2.Size = new Size(44, 19);
            eventdate2.TabIndex = 7;
            eventdate2.Text = "date2";
            // 
            // eventstatus2
            // 
            eventstatus2.AutoSize = true;
            eventstatus2.BackColor = Color.LemonChiffon;
            eventstatus2.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            eventstatus2.ForeColor = Color.Goldenrod;
            eventstatus2.Location = new Point(143, 175);
            eventstatus2.Name = "eventstatus2";
            eventstatus2.Size = new Size(92, 19);
            eventstatus2.TabIndex = 6;
            eventstatus2.Text = "event status2";
            // 
            // eventtype2
            // 
            eventtype2.AutoSize = true;
            eventtype2.BackColor = SystemColors.GradientInactiveCaption;
            eventtype2.ForeColor = SystemColors.HotTrack;
            eventtype2.Location = new Point(14, 175);
            eventtype2.Name = "eventtype2";
            eventtype2.Size = new Size(86, 19);
            eventtype2.TabIndex = 5;
            eventtype2.Text = "event type 2";
            // 
            // event_description2
            // 
            event_description2.BackColor = SystemColors.Window;
            event_description2.BorderStyle = BorderStyle.None;
            event_description2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            event_description2.Location = new Point(-2, 112);
            event_description2.Multiline = true;
            event_description2.Name = "event_description2";
            event_description2.ReadOnly = true;
            event_description2.Size = new Size(269, 50);
            event_description2.TabIndex = 4;
            event_description2.TextChanged += event_description2_TextChanged;
            // 
            // eventname2
            // 
            eventname2.AutoSize = true;
            eventname2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            eventname2.Location = new Point(5, 74);
            eventname2.Name = "eventname2";
            eventname2.Size = new Size(66, 21);
            eventname2.TabIndex = 2;
            eventname2.Text = "event 2";
            // 
            // Event3Panel
            // 
            Event3Panel.BorderStyle = BorderStyle.Fixed3D;
            Event3Panel.Controls.Add(duration3);
            Event3Panel.Controls.Add(eventedit3);
            Event3Panel.Controls.Add(eventdelete3);
            Event3Panel.Controls.Add(eventorganiser3);
            Event3Panel.Controls.Add(booking3);
            Event3Panel.Controls.Add(eventlocation3);
            Event3Panel.Controls.Add(eventdate3);
            Event3Panel.Controls.Add(eventstatus3);
            Event3Panel.Controls.Add(eventtype3);
            Event3Panel.Controls.Add(event_description3);
            Event3Panel.Controls.Add(eventname3);
            Event3Panel.Location = new Point(715, 247);
            Event3Panel.Name = "Event3Panel";
            Event3Panel.Size = new Size(270, 406);
            Event3Panel.TabIndex = 5;
            // 
            // duration3
            // 
            duration3.AutoSize = true;
            duration3.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            duration3.Location = new Point(13, 254);
            duration3.Name = "duration3";
            duration3.Size = new Size(69, 19);
            duration3.TabIndex = 16;
            duration3.Text = "duration3";
            // 
            // eventedit3
            // 
            eventedit3.BackgroundImage = Properties.Resources.Screenshot_2024_12_01_213651;
            eventedit3.BackgroundImageLayout = ImageLayout.Stretch;
            eventedit3.FlatAppearance.BorderColor = SystemColors.Window;
            eventedit3.FlatAppearance.BorderSize = 0;
            eventedit3.FlatStyle = FlatStyle.Flat;
            eventedit3.Location = new Point(169, 365);
            eventedit3.Name = "eventedit3";
            eventedit3.Size = new Size(39, 30);
            eventedit3.TabIndex = 15;
            eventedit3.UseVisualStyleBackColor = true;
            eventedit3.Click += eventedit3_Click;
            // 
            // eventdelete3
            // 
            eventdelete3.BackgroundImage = Properties.Resources.Screenshot_2024_12_01_214121;
            eventdelete3.BackgroundImageLayout = ImageLayout.Stretch;
            eventdelete3.FlatAppearance.BorderColor = SystemColors.Window;
            eventdelete3.FlatAppearance.BorderSize = 0;
            eventdelete3.FlatStyle = FlatStyle.Flat;
            eventdelete3.Location = new Point(214, 365);
            eventdelete3.Name = "eventdelete3";
            eventdelete3.Size = new Size(39, 30);
            eventdelete3.TabIndex = 15;
            eventdelete3.UseVisualStyleBackColor = true;
            eventdelete3.Click += eventdelete3_Click;
            // 
            // eventorganiser3
            // 
            eventorganiser3.AutoSize = true;
            eventorganiser3.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            eventorganiser3.Location = new Point(13, 365);
            eventorganiser3.Name = "eventorganiser3";
            eventorganiser3.Size = new Size(74, 19);
            eventorganiser3.TabIndex = 12;
            eventorganiser3.Text = "organiser3";
            // 
            // booking3
            // 
            booking3.AutoSize = true;
            booking3.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            booking3.Location = new Point(13, 331);
            booking3.Name = "booking3";
            booking3.Size = new Size(67, 19);
            booking3.TabIndex = 11;
            booking3.Text = "Booking3";
            // 
            // eventlocation3
            // 
            eventlocation3.AutoSize = true;
            eventlocation3.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            eventlocation3.Location = new Point(13, 291);
            eventlocation3.Name = "eventlocation3";
            eventlocation3.Size = new Size(65, 19);
            eventlocation3.TabIndex = 10;
            eventlocation3.Text = "location3";
            // 
            // eventdate3
            // 
            eventdate3.AutoSize = true;
            eventdate3.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            eventdate3.Location = new Point(13, 221);
            eventdate3.Name = "eventdate3";
            eventdate3.Size = new Size(44, 19);
            eventdate3.TabIndex = 8;
            eventdate3.Text = "date3";
            // 
            // eventstatus3
            // 
            eventstatus3.AutoSize = true;
            eventstatus3.BackColor = Color.LemonChiffon;
            eventstatus3.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            eventstatus3.ForeColor = Color.Goldenrod;
            eventstatus3.Location = new Point(146, 175);
            eventstatus3.Name = "eventstatus3";
            eventstatus3.Size = new Size(92, 19);
            eventstatus3.TabIndex = 7;
            eventstatus3.Text = "event status3";
            // 
            // eventtype3
            // 
            eventtype3.AutoSize = true;
            eventtype3.BackColor = SystemColors.GradientInactiveCaption;
            eventtype3.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            eventtype3.ForeColor = SystemColors.HotTrack;
            eventtype3.Location = new Point(13, 175);
            eventtype3.Name = "eventtype3";
            eventtype3.Size = new Size(82, 19);
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
            event_description3.Size = new Size(270, 50);
            event_description3.TabIndex = 5;
            // 
            // eventname3
            // 
            eventname3.AutoSize = true;
            eventname3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            eventname3.Location = new Point(5, 74);
            eventname3.Name = "eventname3";
            eventname3.Size = new Size(66, 21);
            eventname3.TabIndex = 3;
            eventname3.Text = "event 3";
            // 
            // panel9
            // 
            panel9.BackgroundImage = Properties.Resources.Screenshot_2024_12_01_161526;
            panel9.BackgroundImageLayout = ImageLayout.Stretch;
            panel9.Location = new Point(716, 247);
            panel9.Name = "panel9";
            panel9.Size = new Size(269, 73);
            panel9.TabIndex = 1;
            // 
            // panel10
            // 
            panel10.BackgroundImage = Properties.Resources.Screenshot_2024_12_01_161526;
            panel10.BackgroundImageLayout = ImageLayout.Stretch;
            panel10.Location = new Point(382, 247);
            panel10.Name = "panel10";
            panel10.Size = new Size(269, 73);
            panel10.TabIndex = 1;
            // 
            // panel12
            // 
            panel12.BorderStyle = BorderStyle.Fixed3D;
            panel12.Controls.Add(duration1);
            panel12.Controls.Add(eventdate1);
            panel12.Controls.Add(eventdelete1);
            panel12.Controls.Add(eventedit1);
            panel12.Controls.Add(booking1);
            panel12.Controls.Add(eventorganiser1);
            panel12.Controls.Add(eventlocation1);
            panel12.Controls.Add(eventstatus1);
            panel12.Controls.Add(event_description1);
            panel12.Controls.Add(eventtype1);
            panel12.Controls.Add(eventname1);
            panel12.Controls.Add(label9);
            panel12.Location = new Point(37, 247);
            panel12.Name = "panel12";
            panel12.Size = new Size(281, 406);
            panel12.TabIndex = 6;
            // 
            // duration1
            // 
            duration1.AutoSize = true;
            duration1.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            duration1.Location = new Point(9, 254);
            duration1.Name = "duration1";
            duration1.Size = new Size(69, 19);
            duration1.TabIndex = 15;
            duration1.Text = "duration1";
            // 
            // eventdate1
            // 
            eventdate1.AutoSize = true;
            eventdate1.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            eventdate1.Location = new Point(9, 221);
            eventdate1.Name = "eventdate1";
            eventdate1.Size = new Size(44, 19);
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
            eventdelete1.Location = new Point(223, 365);
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
            eventedit1.Location = new Point(178, 365);
            eventedit1.Name = "eventedit1";
            eventedit1.Size = new Size(39, 30);
            eventedit1.TabIndex = 12;
            eventedit1.UseVisualStyleBackColor = true;
            eventedit1.Click += eventedit1_Click;
            // 
            // booking1
            // 
            booking1.AutoSize = true;
            booking1.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            booking1.Location = new Point(9, 331);
            booking1.Name = "booking1";
            booking1.Size = new Size(67, 19);
            booking1.TabIndex = 11;
            booking1.Text = "Booking1";
            // 
            // eventorganiser1
            // 
            eventorganiser1.AutoSize = true;
            eventorganiser1.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            eventorganiser1.Location = new Point(9, 365);
            eventorganiser1.Name = "eventorganiser1";
            eventorganiser1.Size = new Size(74, 19);
            eventorganiser1.TabIndex = 11;
            eventorganiser1.Text = "organiser1";
            // 
            // eventlocation1
            // 
            eventlocation1.AutoSize = true;
            eventlocation1.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            eventlocation1.Location = new Point(9, 291);
            eventlocation1.Name = "eventlocation1";
            eventlocation1.Size = new Size(65, 19);
            eventlocation1.TabIndex = 9;
            eventlocation1.Text = "location1";
            // 
            // eventstatus1
            // 
            eventstatus1.AutoSize = true;
            eventstatus1.BackColor = Color.LemonChiffon;
            eventstatus1.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            eventstatus1.ForeColor = Color.Goldenrod;
            eventstatus1.Location = new Point(155, 175);
            eventstatus1.Name = "eventstatus1";
            eventstatus1.Size = new Size(90, 19);
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
            event_description1.Size = new Size(281, 50);
            event_description1.TabIndex = 3;
            event_description1.TextChanged += event_description1_TextChanged;
            // 
            // eventtype1
            // 
            eventtype1.AutoSize = true;
            eventtype1.BackColor = SystemColors.GradientInactiveCaption;
            eventtype1.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            eventtype1.ForeColor = SystemColors.HotTrack;
            eventtype1.Location = new Point(9, 175);
            eventtype1.Name = "eventtype1";
            eventtype1.Size = new Size(84, 19);
            eventtype1.TabIndex = 2;
            eventtype1.Text = "event type 1";
            // 
            // eventname1
            // 
            eventname1.AutoSize = true;
            eventname1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            eventname1.Location = new Point(5, 74);
            eventname1.Name = "eventname1";
            eventname1.Size = new Size(66, 21);
            eventname1.TabIndex = 1;
            eventname1.Text = "event 1";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(9, 85);
            label9.Name = "label9";
            label9.Size = new Size(0, 19);
            label9.TabIndex = 0;
            // 
            // panel5
            // 
            panel5.BackgroundImage = Properties.Resources.Screenshot_2024_12_01_161526;
            panel5.BackgroundImageLayout = ImageLayout.Stretch;
            panel5.Location = new Point(37, 247);
            panel5.Name = "panel5";
            panel5.Size = new Size(281, 73);
            panel5.TabIndex = 11;
            // 
            // NewEvent
            // 
            NewEvent.BackColor = Color.FromArgb(192, 192, 255);
            NewEvent.Location = new Point(857, 72);
            NewEvent.Name = "NewEvent";
            NewEvent.Size = new Size(158, 50);
            NewEvent.TabIndex = 7;
            NewEvent.Text = "Create Event";
            NewEvent.UseVisualStyleBackColor = false;
            NewEvent.Click += button3_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(192, 192, 255);
            button1.Location = new Point(940, 658);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(75, 29);
            button1.TabIndex = 33;
            button1.Text = "Next";
            button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(192, 192, 255);
            button2.Location = new Point(827, 658);
            button2.Margin = new Padding(3, 2, 3, 2);
            button2.Name = "button2";
            button2.Size = new Size(46, 29);
            button2.TabIndex = 32;
            button2.Text = "2";
            button2.UseVisualStyleBackColor = false;
            // 
            // button6
            // 
            button6.BackColor = Color.FromArgb(192, 192, 255);
            button6.Location = new Point(879, 658);
            button6.Margin = new Padding(3, 2, 3, 2);
            button6.Name = "button6";
            button6.Size = new Size(46, 29);
            button6.TabIndex = 31;
            button6.Text = "3";
            button6.UseVisualStyleBackColor = false;
            // 
            // button8
            // 
            button8.BackColor = Color.FromArgb(192, 192, 255);
            button8.Location = new Point(775, 658);
            button8.Margin = new Padding(3, 2, 3, 2);
            button8.Name = "button8";
            button8.Size = new Size(46, 29);
            button8.TabIndex = 30;
            button8.Text = "1";
            button8.UseVisualStyleBackColor = false;
            // 
            // EventsManagement
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = SystemColors.Window;
            ClientSize = new Size(1092, 698);
            Controls.Add(button1);
            Controls.Add(button2);
            Controls.Add(button6);
            Controls.Add(button8);
            Controls.Add(NewEvent);
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
        private Label booking1;
        private Label booking2;
        private Label booking3;
        private Label duration2;
        private Label duration3;
        private Label duration1;
        private Button NewEvent;
        private ComboBox event_categories;
        private ComboBox event_status;
        private Button button1;
        private Button button2;
        private Button button6;
        private Button button8;
    }
}