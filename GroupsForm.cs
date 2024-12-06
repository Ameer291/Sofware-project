using System;
using System.Drawing;
using System.Windows.Forms;
using System.Linq;

namespace tcc
{
    public partial class GroupsForm : Form
    {
        private Panel contentPanel;
        private TextBox searchBox;
        private FlowLayoutPanel categoryPanel;
        private FlowLayoutPanel groupsPanel;
        private Panel bottomNav;
        private readonly Color primaryPurple = Color.FromArgb(147, 112, 219);

        public GroupsForm()
        {
            InitializeComponent();
            InitializeUI();
            LoadGroups();
        }

        private void InitializeUI()
        {
            this.MinimumSize = new Size(800, 600);
            this.BackColor = Color.White;

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
                Text = "Groups",
                Font = new Font("Segoe UI", 28, FontStyle.Bold),
                AutoSize = true,
                Margin = new Padding(0, 0, 0, 5)
            };

            Label subtitleLabel = new Label
            {
                Text = "Find your community",
                Font = new Font("Segoe UI", 12),
                AutoSize = true,
                ForeColor = Color.Gray,
                Margin = new Padding(0)
            };

            headerLayout.Controls.Add(titleLabel, 0, 0);
            headerLayout.Controls.Add(subtitleLabel, 0, 1);

            // Search container
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
                BorderStyle = BorderStyle.FixedSingle,
                BackColor = Color.FromArgb(242, 242, 247)  // Light gray background
            };

            searchBox = new TextBox
            {
                Dock = DockStyle.Fill,
                Font = new Font("Segoe UI", 12),
                BorderStyle = BorderStyle.None,
                Text = "Search groups...",
                BackColor = Color.FromArgb(242, 242, 247),
                Padding = new Padding(5)
            };

            searchBox.Enter += (s, e) => { if (searchBox.Text == "Search groups...") searchBox.Text = ""; };
            searchBox.Leave += (s, e) => { if (string.IsNullOrWhiteSpace(searchBox.Text)) searchBox.Text = "Search groups..."; };
            searchBox.TextChanged += SearchBox_TextChanged;

            searchContainer.Controls.Add(searchBox);
            searchLayout.Controls.Add(searchContainer, 0, 0);

            // Categories
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

            string[] categories = { "All Groups", "Art and culture", "Wellness", "Workshops", "Social" };
            foreach (string category in categories)
            {
                Button btn = new Button
                {
                    Text = category,
                    Size = new Size(140, 35),
                    FlatStyle = FlatStyle.Flat,
                    Margin = new Padding(0, 0, 10, 0),
                    Font = new Font("Segoe UI", 10),
                    BackColor = category == "All Groups" ? primaryPurple : Color.FromArgb(242, 242, 247),
                    ForeColor = category == "All Groups" ? Color.White : Color.Black,
                    FlatAppearance = { BorderSize = 0 }
                };
                btn.Click += CategoryButton_Click;
                categoryPanel.Controls.Add(btn);
            }

            categoryLayout.Controls.Add(categoryPanel, 0, 0);

            // Trending Groups Label
            Label trendingLabel = new Label
            {
                Text = "Trending Groups",
                Font = new Font("Segoe UI", 16, FontStyle.Bold),
                Location = new Point(20, categoryLayout.Bottom + 20),
                AutoSize = true
            };

            // Groups panel
            groupsPanel = new FlowLayoutPanel
            {
                Location = new Point(20, trendingLabel.Bottom + 20),
                Width = ClientSize.Width - 40,
                Height = ClientSize.Height - trendingLabel.Bottom - 100,
                AutoScroll = true,
                FlowDirection = FlowDirection.TopDown,
                WrapContents = false,
                Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Bottom
            };

            // Add all controls to the content panel
            contentPanel.Controls.AddRange(new Control[] {
                headerLayout,
                searchLayout,
                categoryLayout,
                trendingLabel,
                groupsPanel
            });

            InitializeNavigation();
            this.Controls.Add(contentPanel);

            this.Resize += (s, e) => {
                searchLayout.Width = ClientSize.Width - 40;
                categoryLayout.Width = ClientSize.Width - 40;
                groupsPanel.Width = ClientSize.Width - 40;
                UpdateGroupCardWidths();
            };
        }

        private void LoadGroups()
        {
            CreateGroupCard("Photography Enthusiasts", "art",
                "Share your photos, learn techniques, and join photo walks around Cambridge",
                "156 members", "Active 2h ago", 3);

            CreateGroupCard("Creative Writing Circle", "workshops",
                "Weekly writing workshops and storytelling sessions",
                "89 members", "Active 4h ago", 2);

            CreateGroupCard("DIY Workshop Group", "workshops",
                "Learn and share DIY skills with fellow enthusiasts",
                "120 members", "Active 1h ago", 4);
        }

        private void CreateGroupCard(string title, string category, string description,
            string members, string activity, int events)
        {
            Panel card = new Panel
            {
                Width = groupsPanel.ClientSize.Width - 20,
                Height = 140,
                BackColor = Color.White,
                BorderStyle = BorderStyle.FixedSingle,
                Padding = new Padding(15),
                Margin = new Padding(0, 0, 0, 15)
            };

            Label titleLabel = new Label
            {
                Text = title,
                Location = new Point(15, 15),
                Font = new Font("Segoe UI", 16, FontStyle.Bold),
                AutoSize = true
            };

            Label categoryLabel = new Label
            {
                Text = category,
                AutoSize = true,
                Location = new Point(card.Width - 100, 15),
                Font = new Font("Segoe UI", 10),
                BackColor = Color.FromArgb(230, 230, 255),
                Padding = new Padding(8, 4, 8, 4),
                Anchor = AnchorStyles.Right
            };

            Label statsLabel = new Label
            {
                Text = $"{members}•{activity}",
                Location = new Point(15, 45),
                Font = new Font("Segoe UI", 10),
                ForeColor = Color.Gray,
                AutoSize = true
            };

            Label descLabel = new Label
            {
                Text = description,
                Location = new Point(15, 70),
                Size = new Size(card.Width - 30, 35),
                Font = new Font("Segoe UI", 10)
            };

            Label eventsLabel = new Label
            {
                Text = $"{events} events",
                Location = new Point(15, 105),
                Font = new Font("Segoe UI", 10),
                AutoSize = true
            };

            Button joinButton = new Button
            {
                Text = "Join Group",
                Location = new Point(card.Width - 110, 95),
                Size = new Size(90, 35),
                FlatStyle = FlatStyle.Flat,
                BackColor = primaryPurple,
                ForeColor = Color.White,
                Font = new Font("Segoe UI", 10),
                Anchor = AnchorStyles.Right
            };
            joinButton.Click += JoinButton_Click;

            card.Controls.AddRange(new Control[] {
                titleLabel,
                categoryLabel,
                statsLabel,
                descLabel,
                eventsLabel,
                joinButton
            });

            groupsPanel.Controls.Add(card);
        }

        private void InitializeNavigation()
        {
            bottomNav = new Panel
            {
                Height = 60,
                Dock = DockStyle.Bottom,
                BackColor = Color.FromArgb(250, 250, 250),
                BorderStyle = BorderStyle.FixedSingle
            };

            TableLayoutPanel navTable = new TableLayoutPanel
            {
                Dock = DockStyle.Fill,
                ColumnCount = 6,
                RowCount = 1
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
                    BackColor = navItems[i] == "Groups" ? Color.LightGray : Color.White,
                    FlatAppearance = { BorderSize = 0 }
                };
                btn.Click += NavButton_Click;
                navTable.Controls.Add(btn, i, 0);
            }

            bottomNav.Controls.Add(navTable);
            this.Controls.Add(bottomNav);
        }

        private void UpdateGroupCardWidths()
        {
            foreach (Control control in groupsPanel.Controls)
            {
                if (control is Panel card)
                {
                    card.Width = groupsPanel.ClientSize.Width - 20;
                    foreach (Control cardControl in card.Controls)
                    {
                        if (cardControl is Label descLabel && !cardControl.AutoSize)
                        {
                            descLabel.Width = card.Width - 30;
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
                    btn.BackColor = isSelected ? primaryPurple : Color.FromArgb(242, 242, 247);
                    btn.ForeColor = isSelected ? Color.White : Color.Black;
                }
            }

            FilterGroups(clickedButton.Text.ToLower(), searchBox.Text);
        }

        private void SearchBox_TextChanged(object sender, EventArgs e)
        {
            string activeCategory = categoryPanel.Controls.Cast<Button>()
                .First(b => b.BackColor == primaryPurple)
                .Text.ToLower();

            FilterGroups(activeCategory, searchBox.Text);
        }

        private void FilterGroups(string category, string searchText)
        {
            searchText = searchText.ToLower();
            if (searchText == "search groups...") searchText = "";

            bool hasVisibleGroups = false;
            foreach (Control card in groupsPanel.Controls)
            {
                if (card is Panel groupCard && !(card.Tag is string tag && tag == "empty-message"))
                {
                    bool categoryMatch = category == "all groups";
                    bool searchMatch = string.IsNullOrEmpty(searchText);

                    foreach (Control control in groupCard.Controls)
                    {
                        if (control is Label label)
                        {
                            string labelText = label.Text.ToLower();

                            if (label.BackColor != Color.Transparent &&
                                labelText == category.Replace(" and culture", ""))
                            {
                                categoryMatch = true;
                            }

                            if (labelText.Contains(searchText))
                            {
                                searchMatch = true;
                            }
                        }
                    }

                    groupCard.Visible = categoryMatch && searchMatch;
                    if (groupCard.Visible)
                    {
                        hasVisibleGroups = true;
                    }
                }
            }

            // Remove existing empty message if it exists
            foreach (Control control in groupsPanel.Controls.Cast<Control>().ToList())
            {
                if (control is Panel p && p.Tag is string tag && tag == "empty-message")
                {
                    groupsPanel.Controls.Remove(control);
                    control.Dispose();
                }
            }

            // Show empty message if no groups are visible
            if (!hasVisibleGroups)
            {
                Panel emptyMessage = new Panel
                {
                    Width = groupsPanel.ClientSize.Width - 20,
                    Height = 100,
                    BackColor = Color.White,
                    BorderStyle = BorderStyle.FixedSingle,
                    Padding = new Padding(15),
                    Margin = new Padding(0, 0, 0, 10),
                    Tag = "empty-message"
                };

                Label messageLabel = new Label
                {
                    Text = $"No groups available in this category",
                    Font = new Font("Segoe UI", 12),
                    ForeColor = Color.Gray,
                    AutoSize = false,
                    TextAlign = ContentAlignment.MiddleCenter,
                    Dock = DockStyle.Fill
                };

                emptyMessage.Controls.Add(messageLabel);
                groupsPanel.Controls.Add(emptyMessage);
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

                if (clickedButton.Text != "Groups")
                {
                    // Here you would integrate with other forms
                    switch (clickedButton.Text)
                    {
                       // case "Home":
                            //var dashboardForm = new Dashboard();
                           // dashboardForm.Show();
                            //this.Hide();
                           // break;
                        case "Events":
                            var eventsForm = new EventsForm();
                            eventsForm.Show();
                            this.Hide();
                            break;
                            // Add other form transitions as needed
                    }
                }
            }
        }

        private void JoinButton_Click(object sender, EventArgs e)
        {
            if (sender is Button button && button.Parent is Panel groupCard)
            {
                string groupTitle = "";
                foreach (Control control in groupCard.Controls)
                {
                    if (control is Label label && label.Font.Bold)
                    {
                        groupTitle = label.Text;
                        break;
                    }
                }
                MessageBox.Show($"Successfully joined group: {groupTitle}");
            }
        }
    }
}