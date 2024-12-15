using Software_project;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskBand;
using System.Drawing;
using System.Windows.Forms;
using System;
using Microsoft.Data.SqlClient;
using Sofware_project;
namespace Software_project
{
    public partial class DashboardForm : Form
    {
        private User currentUser;

        public DashboardForm()
        {
            InitializeComponent();
            currentUser = LoginUser.GetInstance.GetCurrentUser();
            SetupEventHandlers();
            LoadDashboardData();
        }

        private void SetupEventHandlers()
        {
            // Navigation events
            homeButton.Click += (s, e) => { /* Already on dashboard */ };
            eventsButton.Click += (s, e) =>
            {

                EventsForm p = new EventsForm();
                p.Owner = this;
                p.StartPosition = FormStartPosition.Manual;
                p.Location = new Point(this.Left, this.Top);
                p.Size = new Size(ClientSize.Width, ClientSize.Height);
                p.ShowDialog();
                //MessageBox.Show("Events feature coming soon!", "Under Development",
                //    MessageBoxButtons.OK, MessageBoxIcon.Information);
            };
            groupsButton.Click += (s, e) =>
            {
                GroupsForm p = new GroupsForm();
                p.Owner = this;
                p.StartPosition = FormStartPosition.Manual;
                p.Location = new Point(this.Left, this.Top );
                p.Size = new Size(ClientSize.Width, ClientSize.Height);
                p.ShowDialog();
                //MessageBox.Show("Groups feature coming soon!", "Under Development",
                //    MessageBoxButtons.OK, MessageBoxIcon.Information);
            };
            membershipButton.Click += (s, e) =>
            {
                MessageBox.Show("Membership feature coming soon!", "Under Development",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            };
            settingsButton.Click += (s, e) =>
            {
                SettingsPage p = new SettingsPage();
                p.ShowDialog();
            };

            // Search events
            searchBox.Enter += SearchBox_Enter;
            searchBox.Leave += SearchBox_Leave;
            searchBox.TextChanged += SearchBox_TextChanged;
        }

        private void LoadDashboardData()
        {
            User currentUser = LoginUser.GetInstance.GetCurrentUser();
            DBConnection DBcon = new DBConnection();
            if (currentUser == null) return;

            greetingLabel.Text = $"Hey {currentUser.GetFirstName()} 👋\nExplore what's happening in your community";

            try
            {
                using (SqlConnection conn = DBcon.ConnectDB())
                {
                    LoadStatistics(conn);
                    LoadFeaturedGroups(conn);
                    LoadUpcomingEvents(conn);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading dashboard: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadStatistics(SqlConnection conn)
        {
            // Active Members
            //string queryMembers = "SELECT COUNT(*) FROM Users WHERE IsActive = 1";
            //using (var cmd = new SqlCommand(queryMembers, conn))
            //{
            //    activeMembersCount.Text = cmd.ExecuteScalar().ToString();
            //}

            //// Events this week
            //string queryEvents = @"SELECT COUNT(*) FROM Events 
            //                WHERE EventDate BETWEEN @Start AND @End";
            //using (var cmd = new SqlCommand(queryEvents, conn))
            //{
            //    DateTime startOfWeek = DateTime.Today;
            //    DateTime endOfWeek = startOfWeek.AddDays(7);
            //    cmd.Parameters.AddWithValue("@Start", startOfWeek);
            //    cmd.Parameters.AddWithValue("@End", endOfWeek);
            //    eventsThisWeek.Text = cmd.ExecuteScalar().ToString();
            //}

            // Your groups
            //string queryGroups = @"SELECT COUNT(*) FROM GroupMembers 
            //               WHERE UserID = @UserID";
            //using (var cmd = new SqlCommand(queryGroups, conn))
            //{
            //    cmd.Parameters.AddWithValue("@UserID", currentUser.GetUserID());
            //    groupCount.Text = cmd.ExecuteScalar().ToString();
            //}
        }

        private void LoadFeaturedGroups(SqlConnection conn)
        {
            //string query = @"SELECT TOP 4 g.Name, g.Description, COUNT(gm.UserID) as MemberCount
            //           FROM Groups g
            //           LEFT JOIN GroupMembers gm ON g.GroupID = gm.GroupID
            //           GROUP BY g.GroupID, g.Name, g.Description
            //           ORDER BY COUNT(gm.UserID) DESC";

            //using (var cmd = new SqlCommand(query, conn))
            //using (var reader = cmd.ExecuteReader())
            //{
            //    int panelIndex = 0;
            //    while (reader.Read() && panelIndex < 4)
            //    {
            //        var groupPanel = featuredGroupsPanels[panelIndex];
            //        groupPanel.Controls.Clear();

            //        Label nameLabel = new Label
            //        {
            //            Text = reader["Name"].ToString(),
            //            Font = new Font("Segoe UI", 10, FontStyle.Bold),
            //            Location = new Point(10, 10),
            //            AutoSize = true
            //        };

            //        Label membersLabel = new Label
            //        {
            //            Text = $"{reader["MemberCount"]} members",
            //            Location = new Point(10, 35),
            //            AutoSize = true
            //        };

            //        groupPanel.Controls.AddRange(new Control[] {
            //        nameLabel, membersLabel
            //    });
            //        panelIndex++;
            //    }
            //}
        }

        private void LoadUpcomingEvents(SqlConnection conn)
        {
            //string query = @"SELECT TOP 3 Title, Description, EventDate, StartTime
            //           FROM Events
            //           WHERE EventDate >= @Today
            //           ORDER BY EventDate, StartTime";

            //using (var cmd = new SqlCommand(query, conn))
            //{
            //    cmd.Parameters.AddWithValue("@Today", DateTime.Today);
            //    using (var reader = cmd.ExecuteReader())
            //    {
            //        upcomingEventsPanel.Controls.Clear();
            //        int yPosition = 10;

            //        while (reader.Read())
            //        {
            //            AddEventToPanel(reader, ref yPosition);
            //        }

            //        if (upcomingEventsPanel.Controls.Count == 0)
            //        {
            //            Label noEventsLabel = new Label
            //            {
            //                Text = "No upcoming events",
            //                Font = new Font("Segoe UI", 10),
            //                Location = new Point(10, 10),
            //                AutoSize = true
            //            };
            //            upcomingEventsPanel.Controls.Add(noEventsLabel);
            //        }
            //    }
            //}
        }

        private void AddEventToPanel(SqlDataReader reader, ref int yPosition)
        {
            Panel eventPanel = new Panel
            {
                Width = upcomingEventsPanel.Width - 20,
                Height = 80,
                Location = new Point(10, yPosition),
                BackColor = Color.White,
                BorderStyle = BorderStyle.FixedSingle
            };

            Label titleLabel = new Label
            {
                Text = reader["Title"].ToString(),
                Font = new Font("Segoe UI", 12, FontStyle.Bold),
                Location = new Point(10, 10),
                AutoSize = true
            };

            Label dateLabel = new Label
            {
                Text = $"📅 {((DateTime)reader["EventDate"]).ToShortDateString()} • " +
                      $"🕒 {((TimeSpan)reader["StartTime"]).ToString(@"hh\:mm tt")}",
                Location = new Point(10, 40),
                AutoSize = true
            };

            eventPanel.Controls.AddRange(new Control[] {
            titleLabel, dateLabel
        });
            upcomingEventsPanel.Controls.Add(eventPanel);
            yPosition += 90;
        }

        private void SearchBox_TextChanged(object sender, EventArgs e)
        {
            string searchText = searchBox.Text.Trim().ToLower();
            if (string.IsNullOrEmpty(searchText) ||
                searchText == "search for events, groups or more!".ToLower())
            {
                searchResultsPanel.Visible = false;
                return;
            }

            PerformSearch(searchText);
        }

        private void PerformSearch(string searchText)
        {
            DBConnection con = new DBConnection();
            try
            {
                using (SqlConnection conn = con.ConnectDB())
                {
                    string query = @"
                    SELECT 'Event' as Type, Title as Name, Description 
                    FROM Events 
                    WHERE LOWER(Title) LIKE @Search 
                    OR LOWER(Description) LIKE @Search
                    UNION
                    SELECT 'Group' as Type, Name, Description 
                    FROM Groups
                    WHERE LOWER(Name) LIKE @Search 
                    OR LOWER(Description) LIKE @Search";

                    using (var cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Search", $"%{searchText}%");
                        using (var reader = cmd.ExecuteReader())
                        {
                            DisplaySearchResults(reader);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error searching: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DisplaySearchResults(SqlDataReader reader)
        {
            searchResultsPanel.Controls.Clear();
            searchResultsPanel.Visible = true;
            int yPosition = 10;

            bool hasResults = false;
            while (reader.Read())
            {
                hasResults = true;
                AddSearchResult(reader, ref yPosition);
            }

            if (!hasResults)
            {
                Label noResults = new Label
                {
                    Text = "No results found",
                    AutoSize = true,
                    Location = new Point(10, 10)
                };
                searchResultsPanel.Controls.Add(noResults);
            }

            AddCloseButton();
        }

        private void AddSearchResult(SqlDataReader reader, ref int yPosition)
        {
            Panel resultPanel = new Panel
            {
                Width = searchResultsPanel.Width - 25,
                Height = 80,
                Location = new Point(5, yPosition),
                BackColor = Color.White,
                BorderStyle = BorderStyle.FixedSingle
            };

            string type = reader["Type"].ToString();

            Label typeLabel = new Label
            {
                Text = type,
                AutoSize = true,
                Location = new Point(10, 10),
                ForeColor = type == "Event" ? Color.Blue : Color.Green,
                BackColor = type == "Event" ? Color.LightBlue : Color.LightGreen,
                Padding = new Padding(3)
            };

            Label nameLabel = new Label
            {
                Text = reader["Name"].ToString(),
                AutoSize = true,
                Location = new Point(10, 35),
                Font = new Font("Segoe UI", 10, FontStyle.Bold)
            };

            resultPanel.Controls.AddRange(new Control[] {
            typeLabel, nameLabel
        });

            searchResultsPanel.Controls.Add(resultPanel);
            yPosition += 85;
        }

        private void AddCloseButton()
        {
            Button closeButton = new Button
            {
                Text = "×",
                Size = new Size(25, 25),
                Location = new Point(searchResultsPanel.Width - 30, 5),
                FlatStyle = FlatStyle.Flat,
                ForeColor = Color.Gray
            };
            closeButton.Click += (s, e) => searchResultsPanel.Visible = false;
            searchResultsPanel.Controls.Add(closeButton);
        }

        private void SearchBox_Enter(object sender, EventArgs e)
        {
            if (searchBox.Text == "Search For Events, Groups or more!")
            {
                searchBox.Text = "";
                searchBox.ForeColor = Color.Black;
            }
        }

        private void SearchBox_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(searchBox.Text))
            {
                searchBox.Text = "Search For Events, Groups or more!";
                searchBox.ForeColor = Color.Gray;
            }
        }
    }
}