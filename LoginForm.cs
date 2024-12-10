using Microsoft.Data.SqlClient;
using Sofware_project;
using System;
using System.Data.Common;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Net;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Software_project;

namespace Sofware_project
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
        private void UpdateCurrentUser(string username)
        {
            DBConnection DBcon = new DBConnection();
            SqlConnection sqlcon = DBcon.ConnectDB();
            var query = "SELECT * FROM Users WHERE UserName = @Username";
            try
            {
                using (var cmd = new SqlCommand(query, sqlcon))
                {
                    cmd.Parameters.Add("@Username", SqlDbType.VarChar);
                    cmd.Parameters["@Username"].Value = username;
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            DateTime DOB = DateTime.MinValue;
                            String firstname = reader.IsDBNull(1) ? "" : reader.GetString(1);
                            String lastname = reader.IsDBNull(8) ? "" : reader.GetString(8);
                            String email = reader.IsDBNull(2) ? "" : reader.GetString(2);
                            String gender = reader.IsDBNull(11) ? "" : reader.GetString(11);
                            String phonenumber = reader.IsDBNull(13) ? "" : reader.GetString(13);
                            String address = reader.IsDBNull(13) ? "" : reader.GetString(12);
                            String password = reader.IsDBNull(3) ? "" : reader.GetString(3);
                            //if( !reader.IsDBNull(10))
                            //    DOB = (DateTime)reader.GetDateTime(10);


                            User CurrentUsrObj = new Member( firstname, lastname, email, phonenumber,
                                                             gender, address, username, password);
                            CurrentUsrObj.SetDOB( DOB);
                            LoginUser.GetInstance.SetCurrentUser(CurrentUsrObj);
                        }
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Error cin select query", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            string connectionString = null;// @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\mithra\gouri2024\togetherculture\Sofware-project\data\db_togetherculture.mdf;Integrated Security=True";
            if (IsValidUser(txtUsername.Text.Trim(), txtPassword.Text, connectionString))
            {
                MessageBox.Show("Login Successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                UpdateCurrentUser(txtUsername.Text.Trim());
                // Save username for "Remember Me" functionality
                if (chkRememberMe.Checked)
                {
                    Sofware_project.Properties.Settings.Default.Username = txtUsername.Text;
                    Sofware_project.Properties.Settings.Default.RememberMe = true;
                    Sofware_project.Properties.Settings.Default.Save(); // Saves the settings to disk
                }
                else
                {
                    Sofware_project.Properties.Settings.Default.RememberMe = false;
                    Sofware_project.Properties.Settings.Default.Username = string.Empty;
                    Sofware_project.Properties.Settings.Default.Save(); // Saves the settings to disk
                }

                this.Hide();
                if ( LoginUser.GetInstance.GetCurrentUser().GetMemberType() == 0 )
                {
                    UserManagementForm UserManagementObj = new UserManagementForm(); // Open the main form
                    UserManagementObj.Show();
                }
                else if ( LoginUser.GetInstance.GetCurrentUser().GetMemberType() == 1 )
                {
                    Form1 Form1obj = new Form1();// Open the main form
                    Form1obj.Show();
                    // display  User activity form here
                }
            }
            else
            {
                MessageBox.Show("Invalid credentials, please try again.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //private void btnLogin_Click(object sender, EventArgs e)
        //{
        //    if (IsValidUser(txtUsername.Text.Trim(), txtPassword.Text))
        //    {
        //        this.Hide();
        //        DashboardForm dashboard = new DashboardForm();
        //        dashboard.Show();
        //        dashboard.FormClosed += (s, args) => this.Close(); // Close LoginForm when Dashboard is closed
        //    }
        //    else
        //    {
        //        MessageBox.Show("Invalid credentials, please try again.");
        //    }
        //}


        private bool IsValidUser(string username, string password, string connectionString)
        {
            bool isValid = false;
            DBConnection DBcon = new DBConnection();
            SqlConnection conn = DBcon.ConnectDB();
            try
            {

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


        private void lblUsername_Click(object sender, EventArgs e)
        {

        }

        private void lnkSignUp_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void LoginForm_Load_1(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click_1(object sender, EventArgs e)
        {

        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {

        }
    }
}