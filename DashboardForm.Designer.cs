using System.Drawing;
using System.Windows.Forms;

namespace Software_project
{
    partial class DashboardForm
    {
        private System.ComponentModel.IContainer components = null;
        private Panel mainContainer;
        private Label greetingLabel;
        private TextBox searchBox;
        private Panel searchResultsPanel;

        // Stats panels
        private Panel statsContainer;
        private Panel activeMembersPanel;
        private Panel eventsThisWeekPanel;
        private Panel yourGroupsPanel;
        private Label activeMembersCount;
        private Label eventsThisWeek;
        private Label groupCount;

        // Featured groups
        private Label featuredGroupsTitle;
        private Panel[] featuredGroupsPanels;
        private FlowLayoutPanel featuredGroupsContainer;

        // Upcoming events
        private Label upcomingEventsTitle;
        private Panel upcomingEventsPanel;

        // Navigation
        private Panel navigationPanel;
        private Button homeButton;
        private Button eventsButton;
        private Button groupsButton;
        private Button membershipButton;
        private Button settingsButton;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();

            // Form settings
            this.Size = new Size(1000, 800);
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.None;
            this.BackColor = Color.White;

            // Main container
            mainContainer = new Panel
            {
                Dock = DockStyle.Fill,
                Padding = new Padding(20)
            };

            // Greeting
            greetingLabel = new Label
            {
                Font = new Font("Segoe UI", 24, FontStyle.Bold),
                Location = new Point(20, 20),
                Size = new Size(600, 80),
                Text = "Hey [User] 👋\nExplore what's happening in your community"
            };

            // Search box
            searchBox = new TextBox
            {
                Size = new Size(960, 40),
                Location = new Point(20, 110),
                Font = new Font("Segoe UI", 12),
                //PlaceholderText = "Search For Events, Groups or more!",
                BorderStyle = BorderStyle.FixedSingle
            };

            // Search results panel (initially hidden)
            searchResultsPanel = new Panel
            {
                Size = new Size(960, 300),
                Location = new Point(20, 150),
                BorderStyle = BorderStyle.FixedSingle,
                BackColor = Color.WhiteSmoke,
                Visible = false
            };

            // Stats container
            statsContainer = new Panel
            {
                Size = new Size(960, 100),
                Location = new Point(20, 170)
            };

            // Stats panels
            activeMembersPanel = CreateStatsPanel("Active Members", 0);
            eventsThisWeekPanel = CreateStatsPanel("Events This Week", 320);
            yourGroupsPanel = CreateStatsPanel("Your Groups", 640);

            statsContainer.Controls.AddRange(new Control[] {
            activeMembersPanel,
            eventsThisWeekPanel,
            yourGroupsPanel
        });

            // Featured Groups section
            featuredGroupsTitle = new Label
            {
                Text = "Featured Groups",
                Font = new Font("Segoe UI", 16, FontStyle.Bold),
                Location = new Point(20, 290),
                Size = new Size(200, 30)
            };

            featuredGroupsContainer = new FlowLayoutPanel
            {
                Size = new Size(960, 150),
                Location = new Point(20, 330),
                AutoScroll = false
            };

            // Create 4 group panels
            featuredGroupsPanels = new Panel[4];
            for (int i = 0; i < 4; i++)
            {
                featuredGroupsPanels[i] = new Panel
                {
                    Size = new Size(230, 140),
                    Margin = new Padding(5),
                    BackColor = Color.WhiteSmoke,
                    BorderStyle = BorderStyle.FixedSingle
                };
                featuredGroupsContainer.Controls.Add(featuredGroupsPanels[i]);
            }

            // Upcoming Events section
            upcomingEventsTitle = new Label
            {
                Text = "Upcoming Events",
                Font = new Font("Segoe UI", 16, FontStyle.Bold),
                Location = new Point(20, 500),
                Size = new Size(200, 30)
            };

            upcomingEventsPanel = new Panel
            {
                Size = new Size(960, 180),
                Location = new Point(20, 540),
                BackColor = Color.WhiteSmoke,
                BorderStyle = BorderStyle.FixedSingle,
                AutoScroll = true
            };

            // Navigation panel
            navigationPanel = new Panel
            {
                Size = new Size(960, 60),
                Location = new Point(20, 740),
                BackColor = Color.White
            };

            // Navigation buttons
            homeButton = CreateNavButton("Home", 0);
            eventsButton = CreateNavButton("Events", 192);
            groupsButton = CreateNavButton("Groups", 384);
            membershipButton = CreateNavButton("Membership", 576);
            settingsButton = CreateNavButton("Settings", 768);

            navigationPanel.Controls.AddRange(new Control[] {
            homeButton, eventsButton, groupsButton,
            membershipButton, settingsButton
        });

            // Add all controls to main container
            mainContainer.Controls.AddRange(new Control[] {
            greetingLabel,
            searchBox,
            searchResultsPanel,
            statsContainer,
            featuredGroupsTitle,
            featuredGroupsContainer,
            upcomingEventsTitle,
            upcomingEventsPanel,
            navigationPanel
        });

            // Add main container to form
            this.Controls.Add(mainContainer);

            // Add close button
            Button btnClose = new Button
            {
                Text = "×",
                Size = new Size(30, 30),
                Location = new Point(this.Width - 40, 10),
                FlatStyle = FlatStyle.Flat,
                ForeColor = Color.Black,
                Font = new Font("Arial", 15, FontStyle.Bold),
                Cursor = Cursors.Hand
            };
            btnClose.FlatAppearance.BorderSize = 0;
            btnClose.Click += (s, e) => Application.Exit();
            this.Controls.Add(btnClose);
        }

        private Panel CreateStatsPanel(string title, int x)
        {
            Panel panel = new Panel
            {
                Size = new Size(300, 100),
                Location = new Point(x, 0),
                BackColor = title == "Active Members" ? Color.Purple :
                           title == "Events This Week" ? Color.Blue :
                           Color.DarkRed
            };

            Label titleLabel = new Label
            {
                Text = title,
                ForeColor = Color.White,
                Font = new Font("Segoe UI", 12),
                Location = new Point(20, 20),
                AutoSize = true
            };

            Label countLabel = new Label
            {
                Text = "0",
                ForeColor = Color.White,
                Font = new Font("Segoe UI", 24, FontStyle.Bold),
                Location = new Point(20, 45),
                AutoSize = true
            };

            switch (title)
            {
                case "Active Members": activeMembersCount = countLabel; break;
                case "Events This Week": eventsThisWeek = countLabel; break;
                case "Your Groups": groupCount = countLabel; break;
            }

            panel.Controls.AddRange(new Control[] { titleLabel, countLabel });
            return panel;
        }

        private Button CreateNavButton(string text, int x)
        {
            return new Button
            {
                Text = text,
                Size = new Size(192, 60),
                Location = new Point(x, 0),
                FlatStyle = FlatStyle.Flat,
                BackColor = Color.White,
                Font = new Font("Segoe UI", 10)
            };
        }
    }
}