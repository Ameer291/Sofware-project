using Software_project;
using System;
using System.Windows.Forms;

namespace Sofware_project
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new UserManagementForm()); // Start the application with LoginForm
        }
    }
}
