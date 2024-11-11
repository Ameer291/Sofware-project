using Sofware_project;
using System;
using Microsoft.Data.SqlClient;
using System.Windows.Forms;

public partial class LoginForm : Form
{
    private Label lblUsername;
    private Label lblPassword;
    private TextBox txtUsername;
    private TextBox txtPassword;
    private Button btnLogin;
    private CheckBox chkRememberMe;
    private LinkLabel lnkForgotPassword;
    private LinkLabel lnkSignUp;

    public LoginForm()
    {
        InitializeComponent();
        SetupEventHandlers();
    }

    private void InitializeComponent()
    {
        this.lblUsername = new Label();
        this.lblPassword = new Label();
        this.txtUsername = new TextBox();
        this.txtPassword = new TextBox();
        this.btnLogin = new Button();
        this.chkRememberMe = new CheckBox();
        this.lnkForgotPassword = new LinkLabel();
        this.lnkSignUp = new LinkLabel();

        // Configure Username label and textbox
        this.lblUsername.Text = "Username/Email:";
        this.lblUsername.Location = new System.Drawing.Point(30, 15);
        this.txtUsername.Location = new System.Drawing.Point(150, 10);
        this.txtUsername.Size = new System.Drawing.Size(200, 20);

        // Configure Password label and textbox
        this.lblPassword.Text = "Password:";
        this.lblPassword.Location = new System.Drawing.Point(30, 50);
        this.txtPassword.Location = new System.Drawing.Point(150, 45);
        this.txtPassword.Size = new System.Drawing.Size(200, 20);
        this.txtPassword.UseSystemPasswordChar = true;

        // Configure Login button
        this.btnLogin.Text = "Sign in";
        this.btnLogin.Location = new System.Drawing.Point(150, 80);
        this.btnLogin.Size = new System.Drawing.Size(200, 23);

        // Configure Remember Me checkbox
        this.chkRememberMe.Text = "Remember me";
        this.chkRememberMe.Location = new System.Drawing.Point(150, 115);

        // Set properties for Forgot Password and Sign Up links
        this.lnkForgotPassword.Text = "Forgot password?";
        this.lnkForgotPassword.Location = new System.Drawing.Point(150, 140);

        this.lnkSignUp.Text = "Sign up";
        this.lnkSignUp.Location = new System.Drawing.Point(150, 165);

        // Adding controls to the form
        this.Controls.Add(this.lblUsername);
        this.Controls.Add(this.txtUsername);
        this.Controls.Add(this.lblPassword);
        this.Controls.Add(this.txtPassword);
        this.Controls.Add(this.btnLogin);
        this.Controls.Add(this.chkRememberMe);
        this.Controls.Add(this.lnkForgotPassword);
        this.Controls.Add(this.lnkSignUp);

        this.ClientSize = new System.Drawing.Size(384, 211);
        this.Text = "Login Form";
        this.StartPosition = FormStartPosition.CenterScreen;
    }

    private void SetupEventHandlers()
    {
        this.btnLogin.Click += new EventHandler(btnLogin_Click);
        this.lnkForgotPassword.LinkClicked += new LinkLabelLinkClickedEventHandler(lnkForgotPassword_LinkClicked);
        this.lnkSignUp.LinkClicked += new LinkLabelLinkClickedEventHandler(lnkSignUp_LinkClicked);
    }

    private void btnLogin_Click(object sender, EventArgs e)
    {
        string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\USERS\1002F\SOURCE\REPOS\SOFTWARE PROJECT\DATA\DB_TOGETHERCULTURE.MDF;Integrated Security=True";
        if (IsValidUser(txtUsername.Text.Trim(), txtPassword.Text, connectionString))
        {
            MessageBox.Show("Login Successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Hide();
            Form1 mainForm = new Form1();  // Assuming Form1 is your main form
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
        MessageBox.Show("Forgot Password feature not implemented yet.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
    }

    private void lnkSignUp_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
    {
        MessageBox.Show("Sign-up feature not implemented yet.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
    }
}
