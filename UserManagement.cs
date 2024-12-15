using System;
using System.Drawing;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel;
using Sofware_project;

namespace Software_project
{
    public partial class UserManagementForm : Form
    {
        private DataGridView userGrid;
        private TextBox searchBox;
        private ComboBox roleFilter, statusFilter;
        private Panel mainPanel;
        private Label showingLabel;
        private Panel sidebar;
        private Form childForm;
        private EventsManagement EMobj;
        private GroupsManagement GroupManagementobj;
        private ReportManaegement ReportManagementobj;
        public UserManagementForm()
        {
            InitializeComponent();
            userGrid = new DataGridView();
            searchBox = new TextBox();
            roleFilter = new ComboBox();
            statusFilter = new ComboBox();
            mainPanel = new Panel();

            this.Size = new Size(1400, 800);
            this.BackColor = Color.FromArgb(250, 245, 255);
            InitializeUI();
            EMobj = new EventsManagement();
            GroupManagementobj = new GroupsManagement();
            ReportManagementobj = new ReportManaegement();
        }

        private void InitializeUI()
        {
            mainPanel = new Panel
            {
                Dock = DockStyle.Fill,
                BackColor = Color.White
            };

            AddLeftSidebar();

            Panel contentPanel = new Panel
            {
                Location = new Point(250, 0),
                Size = new Size(ClientSize.Width - 250, ClientSize.Height),
                BackColor = Color.White,
                Padding = new Padding(20)
            };

            Label titleLabel = new Label
            {
                Text = "Users Management",
                Font = new Font("Segoe UI", 24, FontStyle.Bold),
                Location = new Point(20, 20),
                AutoSize = true
            };

            Label subtitleLabel = new Label
            {
                Text = "Manage and monitor user accounts",
                Font = new Font("Segoe UI", 10),
                Location = new Point(20, 60),
                ForeColor = Color.Gray,
                AutoSize = true
            };

            Panel statsPanel = new Panel
            {
                Location = new Point(20, 80),
                Size = new Size(contentPanel.Width - 40, 120)
            };

            AddStatsCards(statsPanel);

            // Add Export and Add User buttons
            Panel buttonPanel = new Panel
            {
                Location = new Point(contentPanel.Width - 360, 220),
                Size = new Size(340, 50)
            };

            Button exportButton = new Button
            {
                Text = "⭳ Export Data",
                Location = new Point(0, 0),
                Size = new Size(150, 35),
                FlatStyle = FlatStyle.Flat,
                BackColor = Color.FromArgb(245, 245, 245),
                Font = new Font("Segoe UI", 10),
                Cursor = Cursors.Hand
            };

            Button addUserButton = new Button
            {
                Text = "+ Add User",
                Location = new Point(170, 0),
                Size = new Size(150, 35),
                FlatStyle = FlatStyle.Flat,
                BackColor = Color.FromArgb(147, 51, 234),
                ForeColor = Color.White,
                Font = new Font("Segoe UI", 10),
                Cursor = Cursors.Hand
            };

            buttonPanel.Controls.AddRange(new Control[] { exportButton, addUserButton });

            Panel filtersPanel = new Panel
            {
                Location = new Point(20, 220),
                Size = new Size(contentPanel.Width - 400, 50)  // Adjusted width to make room for buttons
            };

            searchBox = new TextBox
            {
                Location = new Point(0, 0),
                Size = new Size(300, 35),
                Font = new Font("Segoe UI", 10),
                BorderStyle = BorderStyle.FixedSingle,
                ForeColor = Color.Gray,
                Text = "Search users by name, email..."
            };

            searchBox.GotFocus += (s, e) =>
            {
                if (searchBox.Text == "Search users by name, email...")
                {
                    searchBox.Text = "";
                    searchBox.ForeColor = Color.Black;
                }
            };

            searchBox.LostFocus += (s, e) =>
            {
                if (string.IsNullOrWhiteSpace(searchBox.Text))
                {
                    searchBox.Text = "Search users by name, email...";
                    searchBox.ForeColor = Color.Gray;
                }
            };

            roleFilter = new ComboBox
            {
                Location = new Point(320, 0),
                Size = new Size(150, 35),
                Font = new Font("Segoe UI", 10),
                DropDownStyle = ComboBoxStyle.DropDownList
            };
            roleFilter.Items.AddRange(new string[] { "All roles", "Premium", "Basic" });
            roleFilter.SelectedIndex = 0;

            statusFilter = new ComboBox
            {
                Location = new Point(490, 0),
                Size = new Size(150, 35),
                Font = new Font("Segoe UI", 10),
                DropDownStyle = ComboBoxStyle.DropDownList
            };
            statusFilter.Items.AddRange(new string[] { "All status", "active", "inactive", "pending", "banned" });
            statusFilter.SelectedIndex = 0;

            filtersPanel.Controls.AddRange(new Control[] { searchBox, roleFilter, statusFilter });

            CreateUsersGrid();

            userGrid.Location = new Point(20, 290);
            userGrid.Size = new Size(contentPanel.Width - 40, contentPanel.Height - 350);

            // Add pagination panel
            Panel paginationPanel = new Panel
            {
                Location = new Point(20, contentPanel.Height - 50),
                Size = new Size(contentPanel.Width - 40, 40)
            };

            showingLabel = new Label
            {
                Text = "Showing 1 to 5 of 1,246 users",
                Location = new Point(0, 10),
                AutoSize = true,
                Font = new Font("Segoe UI", 9)
            };

            Button prevButton = new Button
            {
                Text = "Previous",
                Location = new Point(250, 5),
                Size = new Size(80, 30),
                FlatStyle = FlatStyle.Flat,
                BackColor = Color.FromArgb(245, 245, 245),
                Font = new Font("Segoe UI", 9)
            };

            Button page1 = new Button
            {
                Text = "1",
                Location = new Point(340, 5),
                Size = new Size(30, 30),
                FlatStyle = FlatStyle.Flat,
                BackColor = Color.FromArgb(147, 51, 234),
                ForeColor = Color.White,
                Font = new Font("Segoe UI", 9)
            };

            Button page2 = new Button
            {
                Text = "2",
                Location = new Point(380, 5),
                Size = new Size(30, 30),
                FlatStyle = FlatStyle.Flat,
                BackColor = Color.FromArgb(245, 245, 245),
                Font = new Font("Segoe UI", 9)
            };

            Button page3 = new Button
            {
                Text = "3",
                Location = new Point(420, 5),
                Size = new Size(30, 30),
                FlatStyle = FlatStyle.Flat,
                BackColor = Color.FromArgb(245, 245, 245),
                Font = new Font("Segoe UI", 9)
            };

            Button nextButton = new Button
            {
                Text = "Next",
                Location = new Point(460, 5),
                Size = new Size(80, 30),
                FlatStyle = FlatStyle.Flat,
                BackColor = Color.FromArgb(245, 245, 245),
                Font = new Font("Segoe UI", 9)
            };

            paginationPanel.Controls.AddRange(new Control[] { showingLabel, prevButton, page1, page2, page3, nextButton });

            searchBox.TextChanged += (s, e) => FilterGrid();
            roleFilter.SelectedIndexChanged += (s, e) => FilterGrid();
            statusFilter.SelectedIndexChanged += (s, e) => FilterGrid();

            // Add event handlers for Export and Add User buttons
            // In InitializeUI method, replace the existing button click handlers with these:

            exportButton.Click += (s, e) =>
            {
                Form exportForm = new Form
                {
                    Text = "Export Data",
                    Size = new Size(400, 300),
                    StartPosition = FormStartPosition.CenterParent,
                    FormBorderStyle = FormBorderStyle.FixedDialog,
                    MaximizeBox = false,
                    MinimizeBox = false
                };

                Label titleLabel = new Label
                {
                    Text = "Export Users Data",
                    Font = new Font("Segoe UI", 16, FontStyle.Bold),
                    Location = new Point(20, 20),
                    AutoSize = true
                };

                GroupBox formatGroupBox = new GroupBox
                {
                    Text = "Export Format",
                    Location = new Point(20, 70),
                    Size = new Size(340, 100)
                };

                RadioButton csvRadio = new RadioButton
                {
                    Text = "CSV",
                    Location = new Point(20, 30),
                    Checked = true
                };

                RadioButton excelRadio = new RadioButton
                {
                    Text = "Excel",
                    Location = new Point(20, 60)
                };

                formatGroupBox.Controls.AddRange(new Control[] { csvRadio, excelRadio });

                Button exportBtn = new Button
                {
                    Text = "Export",
                    Location = new Point(20, 190),
                    Size = new Size(340, 40),
                    BackColor = Color.FromArgb(147, 51, 234),
                    ForeColor = Color.White,
                    FlatStyle = FlatStyle.Flat
                };

                exportBtn.Click += (se, ev) =>
                {
                    MessageBox.Show("Data exported successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    exportForm.Close();
                };

                exportForm.Controls.AddRange(new Control[] { titleLabel, formatGroupBox, exportBtn });
                exportForm.ShowDialog();
            };

            addUserButton.Click += (s, e) =>
            {
                Form addUserForm = new Form
                {
                    Text = "Add New User",
                    Size = new Size(400, 500),
                    StartPosition = FormStartPosition.CenterParent,
                    FormBorderStyle = FormBorderStyle.FixedDialog,
                    MaximizeBox = false,
                    MinimizeBox = false
                };

                int yPos = 20;

                Label titleLabel = new Label
                {
                    Text = "Add New User",
                    Font = new Font("Segoe UI", 16, FontStyle.Bold),
                    Location = new Point(20, yPos),
                    AutoSize = true
                };
                addUserForm.Controls.Add(titleLabel);

                yPos += 50;
                addUserForm.Controls.Add(new Label
                {
                    Text = "Name:",
                    Location = new Point(20, yPos),
                    AutoSize = true
                });

                TextBox nameBox = new TextBox
                {
                    Location = new Point(20, yPos + 20),
                    Width = 340
                };
                addUserForm.Controls.Add(nameBox);

                yPos += 60;
                addUserForm.Controls.Add(new Label
                {
                    Text = "Email:",
                    Location = new Point(20, yPos),
                    AutoSize = true
                });

                TextBox emailBox = new TextBox
                {
                    Location = new Point(20, yPos + 20),
                    Width = 340
                };
                addUserForm.Controls.Add(emailBox);

                yPos += 60;
                addUserForm.Controls.Add(new Label
                {
                    Text = "Role:",
                    Location = new Point(20, yPos),
                    AutoSize = true
                });

                ComboBox roleBox = new ComboBox
                {
                    Location = new Point(20, yPos + 20),
                    Width = 340,
                    DropDownStyle = ComboBoxStyle.DropDownList
                };
                roleBox.Items.AddRange(new string[] { "Premium", "Basic" });
                roleBox.SelectedIndex = 0;
                addUserForm.Controls.Add(roleBox);

                yPos += 60;
                addUserForm.Controls.Add(new Label
                {
                    Text = "Status:",
                    Location = new Point(20, yPos),
                    AutoSize = true
                });

                ComboBox statusBox = new ComboBox
                {
                    Location = new Point(20, yPos + 20),
                    Width = 340,
                    DropDownStyle = ComboBoxStyle.DropDownList
                };
                statusBox.Items.AddRange(new string[] { "active", "inactive", "pending" });
                statusBox.SelectedIndex = 0;
                addUserForm.Controls.Add(statusBox);

                yPos += 60;
                addUserForm.Controls.Add(new Label
                {
                    Text = "Groups:",
                    Location = new Point(20, yPos),
                    AutoSize = true
                });

                TextBox groupsBox = new TextBox
                {
                    Location = new Point(20, yPos + 20),
                    Width = 340
                };
                addUserForm.Controls.Add(groupsBox);

                Button saveButton = new Button
                {
                    Text = "Add User",
                    Location = new Point(20, yPos + 80),
                    Width = 340,
                    Height = 40,
                    BackColor = Color.FromArgb(147, 51, 234),
                    ForeColor = Color.White,
                    FlatStyle = FlatStyle.Flat
                };

                saveButton.Click += (se, ev) =>
                {
                    if (string.IsNullOrWhiteSpace(nameBox.Text) || string.IsNullOrWhiteSpace(emailBox.Text))
                    {
                        MessageBox.Show("Name and Email are required!", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    userGrid.Rows.Add(
                        $"{nameBox.Text}\n{emailBox.Text}",
                        roleBox.SelectedItem,
                        statusBox.SelectedItem,
                        DateTime.Now.ToString("MMM dd, yyyy"),
                        "Just now",
                        groupsBox.Text,
                        "✎"
                    );

                    addUserForm.Close();
                    MessageBox.Show("User added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    FilterGrid(); // Update the showing label
                };

                addUserForm.Controls.Add(saveButton);
                addUserForm.ShowDialog();
            };

            contentPanel.Controls.AddRange(new Control[] {
                titleLabel,
                subtitleLabel,
                statsPanel,
                buttonPanel,
                filtersPanel,
                userGrid,
                paginationPanel
            });

            mainPanel.Controls.Add(contentPanel);
            this.Controls.Add(mainPanel);
        }
        private void AddLeftSidebar()
        {
            sidebar = new Panel
            {
                Width = 250,
                Dock = DockStyle.Left,
                BackColor = Color.FromArgb(250, 245, 255),
                Padding = new Padding(20)
            };

            string[] menuItems = {
                "Dashboard",
                "Users Management",
                "Events Management",
                "Groups Management",
                "Reports Management",
                "Settings"
            };

            int yPos = 20;
            foreach (string item in menuItems)
            {
                Button btn = new Button
                {
                    Text = item,
                    Location = new Point(0, yPos),
                    Size = new Size(210, 40),
                    FlatStyle = FlatStyle.Flat,
                    BackColor = item == "Users Management" ? Color.White : Color.Transparent,
                    Font = new Font("Segoe UI", 10),
                    TextAlign = ContentAlignment.MiddleLeft,
                    Padding = new Padding(10, 0, 0, 0),
                    FlatAppearance = { BorderSize = 0 }
                };
                btn.Click += btn_Click;
                sidebar.Controls.Add(btn);
                yPos += 45;
            }

            Panel adminProfile = new Panel
            {
                Height = 80,
                Dock = DockStyle.Bottom,
                Padding = new Padding(10)
            };

            Label adminLabel = new Label
            {
                Text = "Admin User",
                Font = new Font("Segoe UI", 10, FontStyle.Bold),
                Location = new Point(10, 10),
                AutoSize = true
            };

            Label emailLabel = new Label
            {
                Text = "admin@together.com",
                ForeColor = Color.Gray,
                Location = new Point(10, 30),
                AutoSize = true
            };

            Button logoutBtn = new Button
            {
                Text = "Logout",
                ForeColor = Color.Red,
                Location = new Point(10, 50),
                FlatStyle = FlatStyle.Flat,
                FlatAppearance = { BorderSize = 0 }
            };

            logoutBtn.Click += (s, e) =>
            {
                if (MessageBox.Show("Are you sure you want to logout?", "Confirm Logout",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    Application.Exit();
                }
            };

            adminProfile.Controls.AddRange(new Control[] { adminLabel, emailLabel, logoutBtn });
            sidebar.Controls.Add(adminProfile);

            mainPanel.Controls.Add(sidebar);
        }

        private void CreateUsersGrid()
        {
            userGrid = new DataGridView
            {
                BackgroundColor = Color.White,
                BorderStyle = BorderStyle.None,
                AllowUserToAddRows = false,
                ReadOnly = true,
                AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells,
                RowHeadersVisible = false,
                SelectionMode = DataGridViewSelectionMode.FullRowSelect,
                MultiSelect = false,
                CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal,
                GridColor = Color.FromArgb(240, 240, 240),
                Font = new Font("Segoe UI", 10),
                RowTemplate = { Height = 60 }
            };

            userGrid.EnableHeadersVisualStyles = false;
            userGrid.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(0, 120, 212);
            userGrid.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            userGrid.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10);
            userGrid.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            userGrid.ColumnHeadersHeight = 40;

            userGrid.Columns.AddRange(new DataGridViewColumn[]
            {
                new DataGridViewTextBoxColumn {
                    HeaderText = "User",
                    Width = 250,
                    DefaultCellStyle = new DataGridViewCellStyle {
                        Padding = new Padding(5),
                        WrapMode = DataGridViewTriState.True
                    }
                },
                new DataGridViewTextBoxColumn { HeaderText = "Role", Width = 100 },
                new DataGridViewTextBoxColumn { HeaderText = "Status", Width = 100 },
                new DataGridViewTextBoxColumn { HeaderText = "Join Date", Width = 120 },
                new DataGridViewTextBoxColumn { HeaderText = "Last Active", Width = 120 },
                new DataGridViewTextBoxColumn { HeaderText = "Groups", Width = 200 },
                new DataGridViewButtonColumn {
                    HeaderText = "Actions",
                    Width = 80,
                    Text = "✎",
                    FlatStyle = FlatStyle.Flat,
                    DefaultCellStyle = new DataGridViewCellStyle {
                        Padding = new Padding(5),
                        BackColor = Color.White,
                        SelectionBackColor = Color.FromArgb(245, 245, 245)
                    },
                    UseColumnTextForButtonValue = true
                }
            });

            userGrid.CellFormatting += (s, e) =>
            {
                if (e.ColumnIndex == 0 && e.RowIndex >= 0 && e.Value != null)
                {
                    string[] parts = e.Value.ToString().Split('\n');
                    if (parts.Length == 2)
                    {
                        e.CellStyle.Font = new Font(userGrid.Font, FontStyle.Bold);
                    }
                }
            };

            userGrid.CellClick += UserGrid_CellClick;
            AddSampleData();
        }
        private void AddSampleData()
        {
            var users = new[]
            {
                new { Name = "Sarah Kulsum", Email = "sarah.k@example.com", Role = "Premium", Status = "active",
                      JoinDate = "Oct 15, 2023", LastActive = "2 hours ago", Groups = "Photography, Art, Creative Writing" },
                new { Name = "John Smith", Email = "john.s@example.com", Role = "Basic", Status = "inactive",
                      JoinDate = "Sep 20, 2023", LastActive = "5 days ago", Groups = "Mindfulness" },
                new { Name = "Emma Wilson", Email = "emma.w@example.com", Role = "Premium", Status = "active",
                      JoinDate = "Nov 1, 2023", LastActive = "1 hour ago", Groups = "Photography, Mindfulness" },
                new { Name = "Michael Chang", Email = "michael.c@example.com", Role = "Basic", Status = "pending",
                      JoinDate = "Nov 5, 2023", LastActive = "Just now", Groups = "Art" },
                new { Name = "Lisa Johnson", Email = "lisa.j@example.com", Role = "Premium", Status = "banned",
                      JoinDate = "Aug 15, 2023", LastActive = "1 month ago", Groups = "" }
            };

            foreach (var user in users)
            {
                userGrid.Rows.Add(
                    $"{user.Name}\n{user.Email}",
                    user.Role,
                    user.Status,
                    user.JoinDate,
                    user.LastActive,
                    user.Groups,
                    "✎"
                );
            }
        }

        private void AddStatsCards(Panel container)
        {
            var stats = new[]
            {
                new { Title = "Total Users", Value = "1,246", Change = "+12%" },
                new { Title = "Active Today", Value = "889", Change = "+7%" },
                new { Title = "Premium Users", Value = "678", Change = "+37%" }
            };

            int cardWidth = (container.Width - 40) / 3;

            for (int i = 0; i < stats.Length; i++)
            {
                Panel card = new Panel
                {
                    Width = cardWidth,
                    Height = 100,
                    Location = new Point(i * (cardWidth + 10), 0),
                    BorderStyle = BorderStyle.FixedSingle,
                    BackColor = Color.White
                };

                Label titleLabel = new Label
                {
                    Text = stats[i].Title,
                    Font = new Font("Segoe UI", 12),
                    Location = new Point(15, 15),
                    AutoSize = true
                };

                Label valueLabel = new Label
                {
                    Text = stats[i].Value,
                    Font = new Font("Segoe UI", 24, FontStyle.Bold),
                    Location = new Point(15, 40),
                    AutoSize = true
                };

                Label changeLabel = new Label
                {
                    Text = stats[i].Change,
                    ForeColor = Color.Green,
                    Location = new Point(valueLabel.Right + 10, valueLabel.Top + 10),
                    AutoSize = true
                };

                card.Controls.AddRange(new Control[] { titleLabel, valueLabel, changeLabel });
                container.Controls.Add(card);
            }
        }

        private void FilterGrid()
        {
            if (userGrid == null || searchBox == null) return;

            string searchText = searchBox.Text.ToLower();
            if (searchText == "search users by name, email...") searchText = "";

            string selectedRole = roleFilter?.SelectedItem?.ToString() ?? "All roles";
            string selectedStatus = statusFilter?.SelectedItem?.ToString() ?? "All status";

            int visibleCount = 0;
            foreach (DataGridViewRow row in userGrid.Rows)
            {
                if (row?.Cells == null) continue;
                bool showRow = true;

                if (!string.IsNullOrEmpty(searchText))
                {
                    showRow = row.Cells[0].Value?.ToString()?.ToLower()?.Contains(searchText) ?? false;
                }

                if (showRow && selectedRole != "All roles")
                {
                    showRow = row.Cells[1].Value?.ToString() == selectedRole;
                }

                if (showRow && selectedStatus != "All status")
                {
                    showRow = row.Cells[2].Value?.ToString() == selectedStatus;
                }

                row.Visible = showRow;
                if (showRow) visibleCount++;
            }

            showingLabel.Text = $"Showing 1 to {visibleCount} of 1,246 users";
        }

        private void UserGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || userGrid?.Rows == null || e.RowIndex >= userGrid.Rows.Count) return;

            if (e.ColumnIndex == userGrid.Columns.Count - 1) // Edit button
            {
                var row = userGrid.Rows[e.RowIndex];
                string[] userInfo = row.Cells[0].Value?.ToString()?.Split('\n') ?? Array.Empty<string>();
                if (userInfo.Length > 0)
                {
                    Form editForm = CreateEditForm(userInfo, row);
                    editForm.ShowDialog();
                }
            }
        }

        private Form CreateEditForm(string[] userInfo, DataGridViewRow row)
        {
            Form editForm = new Form
            {
                Text = $"Edit User - {userInfo[0]}",
                Size = new Size(400, 500),
                StartPosition = FormStartPosition.CenterParent,
                FormBorderStyle = FormBorderStyle.FixedDialog,
                MaximizeBox = false,
                MinimizeBox = false
            };

            int yPos = 20;
            AddFormField(editForm, "Name:", userInfo[0], ref yPos);
            AddFormField(editForm, "Email:", userInfo.Length > 1 ? userInfo[1] : "", ref yPos);
            AddFormComboBox(editForm, "Role:", new[] { "Premium", "Basic" }, row.Cells[1].Value?.ToString(), ref yPos);
            AddFormComboBox(editForm, "Status:", new[] { "active", "inactive", "pending", "banned" }, row.Cells[2].Value?.ToString(), ref yPos);
            AddFormField(editForm, "Groups:", row.Cells[5].Value?.ToString(), ref yPos);

            Button saveButton = new Button
            {
                Text = "Save Changes",
                Location = new Point(20, yPos + 20),
                Size = new Size(340, 40),
                BackColor = Color.FromArgb(147, 51, 234),
                ForeColor = Color.White,
                FlatStyle = FlatStyle.Flat
            };

            saveButton.Click += (s, e) =>
            {
                UpdateRowData(row, editForm);
                editForm.Close();
                MessageBox.Show("User information updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            };

            editForm.Controls.Add(saveButton);
            return editForm;
        }

        private void AddFormField(Form form, string label, string value, ref int yPos)
        {
            form.Controls.Add(new Label
            {
                Text = label,
                Location = new Point(20, yPos),
                AutoSize = true
            });

            form.Controls.Add(new TextBox
            {
                Text = value,
                Location = new Point(20, yPos + 20),
                Width = 340,
                Name = label  // Used to identify the control when saving
            });

            yPos += 60;
        }

        private void AddFormComboBox(Form form, string label, string[] items, string selectedValue, ref int yPos)
        {
            form.Controls.Add(new Label
            {
                Text = label,
                Location = new Point(20, yPos),
                AutoSize = true
            });

            ComboBox combo = new ComboBox
            {
                Location = new Point(20, yPos + 20),
                Width = 340,
                DropDownStyle = ComboBoxStyle.DropDownList,
                Name = label  // Used to identify the control when saving
            };
            combo.Items.AddRange(items);
            combo.SelectedItem = selectedValue;
            form.Controls.Add(combo);

            yPos += 60;
        }

        private void UpdateRowData(DataGridViewRow row, Form editForm)
        {
            var nameBox = editForm.Controls.OfType<TextBox>().FirstOrDefault(c => c.Name == "Name:");
            var emailBox = editForm.Controls.OfType<TextBox>().FirstOrDefault(c => c.Name == "Email:");
            var roleBox = editForm.Controls.OfType<ComboBox>().FirstOrDefault(c => c.Name == "Role:");
            var statusBox = editForm.Controls.OfType<ComboBox>().FirstOrDefault(c => c.Name == "Status:");
            var groupsBox = editForm.Controls.OfType<TextBox>().FirstOrDefault(c => c.Name == "Groups:");

            if (nameBox != null && emailBox != null)
            {
                row.Cells[0].Value = $"{nameBox.Text}\n{emailBox.Text}";
            }
            if (roleBox?.SelectedItem != null) row.Cells[1].Value = roleBox.SelectedItem;
            if (statusBox?.SelectedItem != null) row.Cells[2].Value = statusBox.SelectedItem;
            if (groupsBox != null) row.Cells[5].Value = groupsBox.Text;
        }

        private void btn_Click(object sender, EventArgs e)
        {
            string[] menuItems = {
                "Dashboard",
                "Users Management",
                "Events Management",
                "Groups Management",
                "Reports Management",
                "Settings"
            };
            Button btn = sender as Button;
            if (btn == null)
               return;
            foreach (string item in menuItems)
            {
                if (btn.Text == "Events Management" && EMobj != null)
                {
                    EMobj.Owner = this;
                    EMobj.StartPosition = FormStartPosition.Manual;
                    EMobj.Location = new Point(this.Left + 250, this.Top + 30);
                    EMobj.Size = new Size( ClientSize.Width - 250, ClientSize.Height );
                    // eventobj.WindowStartupLocation = 
                    //eventobj.Left += 480;
                    //eventobj.Top += 20;
                    EMobj.Show();
                    GroupManagementobj.Hide();
                    ReportManagementobj.Hide();

                }
                else if (btn.Text == "Groups Management" && EMobj != null)
                {
                    GroupManagementobj.Owner = this;
                    GroupManagementobj.StartPosition = FormStartPosition.Manual;
                    GroupManagementobj.Location = new Point(this.Left + 250, this.Top + 30);
                    GroupManagementobj.Size = new Size(ClientSize.Width - 250, ClientSize.Height);
                   


                    // eventobj.WindowStartupLocation = 
                    //eventobj.Left += 480;
                    //eventobj.Top += 20;
                    GroupManagementobj.Show();
                    EMobj.Hide();
                    ReportManagementobj.Hide();

                }
                else if (btn.Text == "Reports Management" && EMobj != null)
                {
                    ReportManagementobj.Owner = this;
                    ReportManagementobj.StartPosition = FormStartPosition.Manual;
                    ReportManagementobj.Location = new Point(this.Left + 250, this.Top + 30);
                    ReportManagementobj.Size = new Size(ClientSize.Width - 250, ClientSize.Height);
                    ReportManagementobj.Show();
                    GroupManagementobj.Hide();
                    EMobj.Hide();
                }
                else
                {
                    ReportManagementobj.Hide();
                    GroupManagementobj.Hide();
                    EMobj.Hide();
                }
            }
        }
        private void UserManagementForm_Load(object sender, EventArgs e)
        {

        }
    }
}