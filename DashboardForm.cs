using System;
using System.Windows.Forms;

namespace Sofware_project
{
    public partial class DashboardForm : Form
    {
        public DashboardForm()
        {
            InitializeComponent();
        }

        private void DashboardForm_Load(object sender, EventArgs e)
        {
            // Here you might want to call methods to fetch data and update the UI accordingly.
            LoadActiveMembers();
            LoadThisWeekEvents();
        }

        private void LoadActiveMembers()
        {
            // This is a placeholder for database interaction.
            lblActiveMembers.Text = "156 Active Members";  // Example static data
        }

        private void LoadThisWeekEvents()
        {
            lblEventsThisWeek.Text = "12 Events This Week";  // Example static data
        }
    }
}
