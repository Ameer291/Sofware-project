using Microsoft.Data.SqlClient;
using System;
using System.Net.Mail;
using System.Windows.Forms;

namespace Software_project
{
    public partial class ForgotPasswordForm : Form
    {
        public ForgotPasswordForm()
        {
            InitializeComponent();
        }

        private void btnSendLink_Click(object sender, EventArgs e)
        {
            string email = txtEmail.Text.Trim();
            if (string.IsNullOrEmpty(email))
            {
                MessageBox.Show("Please enter your email address.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // Check if the email exists in the database
            string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\USERS\1002F\SOURCE\REPOS\SOFTWARE PROJECT\DATA\DB_TOGETHERCULTURE.MDF;Integrated Security=True";
            string registeredEmail = GetEmailFromDatabase(email, connectionString);

            if (registeredEmail != null)
            {
                SendPasswordResetEmail(registeredEmail);
                MessageBox.Show("A password reset link has been sent to your email.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show("Email not found. Please check your email address.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private string GetEmailFromDatabase(string email, string connectionString)
        {
            string registeredEmail = null;
            using (var conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT Email FROM Users WHERE Email = @Email";
                    using (var cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Email", email);
                        registeredEmail = cmd.ExecuteScalar() as string;
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Error connecting to the database.", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            return registeredEmail;
        }

        private void SendPasswordResetEmail(string email)
        {
            try
            {
                MailMessage mail = new MailMessage("your_email@example.com", email);
                mail.Subject = "Password Reset Request";
                mail.Body = $"Hello, \n\nPlease click the link below to reset your password:\n\nhttps://yourapp.com/reset-password?email=" + email;
                SmtpClient smtpClient = new SmtpClient("smtp.your-email-provider.com")
                {
                    Port = 587,
                    Credentials = new System.Net.NetworkCredential("your_email@example.com", "your_email_password"),
                    EnableSsl = true
                };
                smtpClient.Send(mail);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error sending email: " + ex.Message, "Email Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lblEmail_Click(object sender, EventArgs e)
        {

        }
    }
}

