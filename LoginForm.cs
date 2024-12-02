using Microsoft.Data.SqlClient;
using Sofware_project;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Software_project
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
            SetupEventHandlers();
            LoadRememberedUsername();
        }

        private void SetupEventHandlers()
        {
            btnLogin.Click += btnLogin_Click;
            lnkForgotPassword.LinkClicked += lnkForgotPassword_LinkClicked;
            lnkSignUp.LinkClicked += lnkSignUp_LinkClicked;
        }

        private void LoadRememberedUsername()
        {
            // Load remembered username if the "Remember Me" option was previously selected
            //if (Software_project.Properties.Settings.Default.RememberMe)
            //{
            //    txtUsername.Text = Software_project.Properties.Settings.Default.Username;
            //    chkRememberMe.Checked = true;
            //}
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\USERS\1002F\SOURCE\REPOS\SOFTWARE PROJECT\DATA\DB_TOGETHERCULTURE.MDF;Integrated Security=True";
            if (IsValidUser(txtUsername.Text.Trim(), txtPassword.Text, connectionString))
            {
                MessageBox.Show("Login Successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Save username for "Remember Me" functionality
                if (chkRememberMe.Checked)
                {
                    //Properties.Settings.GetType
                    string text = txtUsername.Text;
                    //Software_project.Properties.Settings.Default.Username = "text";
                    //Software_project.Properties.Settings.Default.RememberMe = true;
                    //Software_project.Properties.Settings.Default.Save(); // Saves the settings to disk
                }
                else
                {
                    //Software_project.Properties.Settings.Default.RememberMe = false;
                    //Software_project.Properties.Settings.Default.Username = string.Empty;
                    //Software_project.Properties.Settings.Default.Save(); // Saves the settings to disk
                }

                this.Hide();
                Form1 mainForm = new Form1(); // Open the main form
                mainForm.Show();
            }
            else
            {
                MessageBox.Show("Invalid credentials, please try again.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool IsValidUser(string username, string password, string connectionString)
        {
            bool isValid = false;
            using (var conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    var query = "SELECT COUNT(1) FROM Users WHERE Username = @Username AND Password = @Password";
                    using (var cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Username", username);
                        cmd.Parameters.AddWithValue("@Password", password);
                        int count = Convert.ToInt32(cmd.ExecuteScalar());
                        isValid = count == 1;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Database connection error: " + ex.Message, "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            return isValid;
        }

        private void lnkForgotPassword_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ForgotPasswordForm forgotPasswordForm = new ForgotPasswordForm();
            forgotPasswordForm.ShowDialog();  // Open the Forgot Password form
        }

        private void lnkSignUp_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            RegistrationForm registerForm = new RegistrationForm();
            registerForm.Show();  // Open the Sign-Up (Registration) form
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
        }

        private void pnlContainer_Paint(object sender, PaintEventArgs e)
        {
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click_1(object sender, EventArgs e)
        {

        }

        private void lblUsername_Click(object sender, EventArgs e)
        {

        }

        private void lnkSignUp_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }
    }
}
