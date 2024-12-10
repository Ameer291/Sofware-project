using System;
using System.Drawing;
using System.Windows.Forms;
using System.Linq;

namespace Software_project
{
    public partial class EventsForm : Form
    {
        private Panel contentPanel;
        private TextBox searchBox;
        private FlowLayoutPanel categoryPanel;
        private FlowLayoutPanel eventsPanel;
        private Panel bottomNav;
        private readonly Color primaryPurple = Color.FromArgb(147, 112, 219);

        public EventsForm()
        {
            InitializeComponent();
            InitializeUI();
            LoadEvents();
        }

        private void InitializeUI()
        {
            this.MinimumSize = new Size(800, 600);
            this.BackColor = Color.White;

            // Main container with proper padding
            contentPanel = new Panel
            {
                Dock = DockStyle.Fill,
                Padding = new Padding(20),
                AutoScroll = true
            };

            // Header layout
            TableLayoutPanel headerLayout = new TableLayoutPanel
            {
                Location = new Point(20, 20),
                AutoSize = true,
                Width = ClientSize.Width - 40,
                ColumnCount = 1,
                RowCount = 2,
                Margin = new Padding(0)
            };

            headerLayout.RowStyles.Add(new RowStyle(SizeType.AutoSize));
            headerLayout.RowStyles.Add(new RowStyle(SizeType.AutoSize));

            Label titleLabel = new Label
            {
                Text = "Events",
                Font = new Font("Segoe UI", 28, FontStyle.Bold),
                AutoSize = true,
                Margin = new Padding(0, 0, 0, 5)
            };

            Label subtitleLabel = new Label
            {
                Text = "Discover and join community activities",
                Font = new Font("Segoe UI", 12),
                AutoSize = true,
                ForeColor = Color.Gray,
                Margin = new Padding(0)
            };

            headerLayout.Controls.Add(titleLabel, 0, 0);
            headerLayout.Controls.Add(subtitleLabel, 0, 1);

            // Search container with proper width constraints
            TableLayoutPanel searchLayout = new TableLayoutPanel
            {
                ColumnCount = 1,
                RowCount = 1,
                Dock = DockStyle.None,
                AutoSize = false,
                Width = ClientSize.Width - 40,
                Height = 40,
                Location = new Point(20, headerLayout.Bottom + 20),
                Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right
            };

            Panel searchContainer = new Panel
            {
                Dock = DockStyle.Fill,
                Height = 32,
                BorderStyle = BorderStyle.FixedSingle
            };

            searchBox = new TextBox
            {
                Dock = DockStyle.Fill,
                Font = new Font("Segoe UI", 12),
                BorderStyle = BorderStyle.None,
                Text = "Search events...",
                Padding = new Padding(5)
            };

            searchBox.Enter += (s, e) => { if (searchBox.Text == "Search events...") searchBox.Text = ""; };
            searchBox.Leave += (s, e) => { if (string.IsNullOrWhiteSpace(searchBox.Text)) searchBox.Text = "Search events..."; };
            searchBox.TextChanged += SearchBox_TextChanged;

            searchContainer.Controls.Add(searchBox);
            searchLayout.Controls.Add(searchContainer, 0, 0);

            // Categories with proper width constraints
            TableLayoutPanel categoryLayout = new TableLayoutPanel
            {
                ColumnCount = 1,
                RowCount = 1,
                Dock = DockStyle.None,
                AutoSize = false,
                Width = ClientSize.Width - 40,
                Location = new Point(20, searchLayout.Bottom + 20),
                Height = 45,
                Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right
            };

            categoryPanel = new FlowLayoutPanel
            {
                Dock = DockStyle.Fill,
                AutoSize = true,
                WrapContents = true
            };

            string[] categories = { "All Events", "Art and culture", "Wellness", "Workshops", "Social" };
            foreach (string category in categories)
            {
                Button btn = new Button
                {
                    Text = category,
                    Size = new Size(140, 35),
                    FlatStyle = FlatStyle.Flat,
                    Margin = new Padding(0, 0, 10, 0),
                    Font = new Font("Segoe UI", 10),
                    BackColor = category == "All Events" ? primaryPurple : Color.White,
                    ForeColor = category == "All Events" ? Color.White : Color.Black,
                    FlatAppearance = { BorderColor = Color.Black, BorderSize = 1 }
                };
                btn.Click += CategoryButton_Click;
                categoryPanel.Controls.Add(btn);
            }

            categoryLayout.Controls.Add(categoryPanel, 0, 0);

            // Events panel with proper width constraints
            TableLayoutPanel eventsLayout = new TableLayoutPanel
            {
                ColumnCount = 1,
                RowCount = 1,
                Dock = DockStyle.None,
                AutoSize = false,
                Width = ClientSize.Width - 40,
                Location = new Point(20, categoryLayout.Bottom + 20),
                Height = ClientSize.Height - categoryLayout.Bottom - 100,
                Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Bottom
            };

            eventsPanel = new FlowLayoutPanel
            {
                Dock = DockStyle.Fill,
                AutoScroll = true,
                FlowDirection = FlowDirection.TopDown,
                WrapContents = false,
                Padding = new Padding(0)
            };

            eventsLayout.Controls.Add(eventsPanel, 0, 0);

            // Add all controls to the content panel
            contentPanel.Controls.AddRange(new Control[] {
                headerLayout,
                searchLayout,
                categoryLayout,
                eventsLayout
            });

            InitializeNavigation();
            this.Controls.Add(contentPanel);

            // Handle resize events
            this.Resize += (s, e) => {
                searchLayout.Width = ClientSize.Width - 40;
                categoryLayout.Width = ClientSize.Width - 40;
                eventsLayout.Width = ClientSize.Width - 40;
                UpdateEventCardWidths();
            };
        }

        private void LoadEvents()
        {
            CreateEventCard("Art gathering", "art",
                "Join us for a meeting of creative expression and community art.",
                "Today", "11:00 - 13:00", "Cambridge Community Center", 12);

            CreateEventCard("Meditation Session", "wellness",
                "Guided meditation for all experience levels",
                "Thu, Nov 9", "10:00 - 12:00", "Cambridge Gardens", 20);

            CreateEventCard("Morning Yoga", "wellness",
                "Energizing morning yoga flow for all levels.",
                "Fri, Nov 10", "8:00 - 09:00", "Mind and Body Studio", 27);
        }

        private void CreateEventCard(string title, string category, string description,
            string date, string time, string location, int attendees)
        {
            Panel card = new Panel
            {
                Width = eventsPanel.ClientSize.Width - 20,
                Height = 130,
                BackColor = Color.White,
                BorderStyle = BorderStyle.FixedSingle,
                Padding = new Padding(15),
                Margin = new Padding(0, 0, 0, 10)
            };

            Label categoryLabel = new Label
            {
                Text = category,
                AutoSize = true,
                Location = new Point(15, 15),
                Font = new Font("Segoe UI", 10),
                BackColor = category == "wellness" ? Color.FromArgb(220, 255, 220) : Color.FromArgb(230, 220, 255),
                Padding = new Padding(8, 4, 8, 4)
            };

            Label attendeesLabel = new Label
            {
                Text = $"👥 {attendees}",
                Location = new Point(card.Width - 60, 15),
                AutoSize = true,
                Font = new Font("Segoe UI", 12),
                Margin = new Padding(0, 0, 15, 0),
                Anchor = AnchorStyles.Right
            };

            Label titleLabel = new Label
            {
                Text = title,
                Location = new Point(15, 45),
                Font = new Font("Segoe UI", 14, FontStyle.Bold),
                AutoSize = true
            };

            Label descLabel = new Label
            {
                Text = description,
                Location = new Point(15, 70),
                Size = new Size(card.Width - 150, 20),
                Font = new Font("Segoe UI", 10)
            };

            Label dateTimeLabel = new Label
            {
                Text = $"📅 {date} • 🕒 {time} • 📍 {location}",
                Location = new Point(15, 95),
                AutoSize = true,
                Font = new Font("Segoe UI", 10),
                ForeColor = Color.Gray
            };

            Button joinButton = new Button
            {
                Text = "Join Event",
                Location = new Point(card.Width - 110, 85),
                Size = new Size(90, 30),
                FlatStyle = FlatStyle.Flat,
                BackColor = primaryPurple,
                ForeColor = Color.White,
                Font = new Font("Segoe UI", 10),
                Anchor = AnchorStyles.Right
            };
            joinButton.Click += JoinButton_Click;

            card.Controls.AddRange(new Control[] {
                categoryLabel,
                titleLabel,
                descLabel,
                dateTimeLabel,
                attendeesLabel,
                joinButton
            });

            eventsPanel.Controls.Add(card);
        }

        private void InitializeNavigation()
        {
            bottomNav = new Panel
            {
                Height = 60,
                Dock = DockStyle.Bottom,
                BackColor = Color.White,
                BorderStyle = BorderStyle.FixedSingle
            };

            TableLayoutPanel navTable = new TableLayoutPanel
            {
                Dock = DockStyle.Fill,
                ColumnCount = 6,
                RowCount = 1,
                BackColor = Color.White
            };

            for (int i = 0; i < 6; i++)
            {
                navTable.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100f / 6));
            }

            string[] navItems = { "Home", "Events", "Groups", "Chat", "Membership", "Settings" };
            for (int i = 0; i < navItems.Length; i++)
            {
                Button btn = new Button
                {
                    Text = navItems[i],
                    Dock = DockStyle.Fill,
                    FlatStyle = FlatStyle.Flat,
                    Font = new Font("Segoe UI", 10),
                    BackColor = navItems[i] == "Events" ? Color.LightGray : Color.White,
                    FlatAppearance = { BorderSize = 0 }
                };
                btn.Click += NavButton_Click;
                navTable.Controls.Add(btn, i, 0);
            }

            bottomNav.Controls.Add(navTable);
            this.Controls.Add(bottomNav);
        }

        private void UpdateEventCardWidths()
        {
            foreach (Control control in eventsPanel.Controls)
            {
                if (control is Panel card)
                {
                    card.Width = eventsPanel.ClientSize.Width - 20;
                    foreach (Control cardControl in card.Controls)
                    {
                        if (cardControl is Label descLabel && !cardControl.AutoSize)
                        {
                            descLabel.Width = card.Width - 150;
                        }
                    }
                }
            }
        }

        private void CategoryButton_Click(object sender, EventArgs e)
        {
            Button clickedButton = (Button)sender;
            foreach (Control control in categoryPanel.Controls)
            {
                if (control is Button btn)
                {
                    bool isSelected = btn == clickedButton;
                    btn.BackColor = isSelected ? primaryPurple : Color.White;
                    btn.ForeColor = isSelected ? Color.White : Color.Black;
                }
            }

            string category = clickedButton.Text.ToLower().Replace(" and culture", "");
            FilterEvents(category, searchBox.Text);
        }

        private void SearchBox_TextChanged(object sender, EventArgs e)
        {
            string activeCategory = categoryPanel.Controls.Cast<Button>()
                .First(b => b.BackColor == primaryPurple)
                .Text.ToLower().Replace(" and culture", "");

            FilterEvents(activeCategory, searchBox.Text);
        }

        private void FilterEvents(string category, string searchText)
        {
            searchText = searchText.ToLower();
            if (searchText == "search events...") searchText = "";

            bool hasVisibleEvents = false;
            foreach (Control card in eventsPanel.Controls)
            {
                if (card is Panel eventCard && !(card.Tag is string tag && tag == "empty-message"))
                {
                    bool categoryMatch = category == "all events";
                    bool searchMatch = string.IsNullOrEmpty(searchText);

                    foreach (Control control in eventCard.Controls)
                    {
                        if (control is Label label)
                        {
                            // Check category
                            if (label.BackColor != Color.Transparent &&
                                label.Text.ToLower() == category)
                            {
                                categoryMatch = true;
                            }

                            // Check search text
                            if (label.Text.ToLower().Contains(searchText))
                            {
                                searchMatch = true;
                            }
                        }
                    }

                    eventCard.Visible = categoryMatch && searchMatch;
                    if (eventCard.Visible)
                    {
                        hasVisibleEvents = true;
                    }
                }
            }

            // Remove existing empty message if it exists
            foreach (Control control in eventsPanel.Controls)
            {
                if (control is Panel p && p.Tag is string tag && tag == "empty-message")
                {
                    eventsPanel.Controls.Remove(control);
                    break;
                }
            }

            // Show empty message if no events are visible
            if (!hasVisibleEvents)
            {
                Panel emptyMessage = new Panel
                {
                    Width = eventsPanel.ClientSize.Width - 20,
                    Height = 100,
                    BackColor = Color.White,
                    BorderStyle = BorderStyle.FixedSingle,
                    Padding = new Padding(15),
                    Margin = new Padding(0, 0, 0, 10),
                    Tag = "empty-message"
                };

                Label messageLabel = new Label
                {
                    Text = $"No events available in this category",
                    Font = new Font("Segoe UI", 12),
                    ForeColor = Color.Gray,
                    AutoSize = false,
                    TextAlign = ContentAlignment.MiddleCenter,
                    Dock = DockStyle.Fill
                };

                emptyMessage.Controls.Add(messageLabel);
                eventsPanel.Controls.Add(emptyMessage);
            }
        }

        private void NavButton_Click(object sender, EventArgs e)
        {
            if (sender is Button clickedButton)
            {
                foreach (Control control in clickedButton.Parent.Controls)
                {
                    if (control is Button btn)
                    {
                        btn.BackColor = btn == clickedButton ? Color.LightGray : Color.White;
                    }
                }

                if (clickedButton.Text != "Events")
                {
                    switch (clickedButton.Text)
                    {
                        case "Groups":    // Add this case
                            var groupsForm = new GroupsForm();
                            groupsForm.Show();
                            this.Hide();
                            break;
                        //case "Home":
                          //  var dashboardForm = new Dashboard();
                            //dashboardForm.Show();
                            //this.Hide();
                            //break;
                            // ... other cases ...
                    }
                }
            }
        }

        private void JoinButton_Click(object sender, EventArgs e)
        {
            if (sender is Button button && button.Parent is Panel eventCard)
            {
                string eventTitle = "";
                foreach (Control control in eventCard.Controls)
                {
                    if (control is Label label && label.Font.Bold)
                    {
                        eventTitle = label.Text;
                        break;
                    }
                }
                MessageBox.Show($"Successfully joined event: {eventTitle}");
            }
        }
    }
}