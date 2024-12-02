namespace Sofware_project
{
    partial class LoginForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.LinkLabel lnkForgotPassword;
        private System.Windows.Forms.LinkLabel lnkSignUp;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel pnlContainer;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.CheckBox chkRememberMe;

        private void InitializeComponent()
        {
            pnlContainer = new Panel();
            lblUsername = new Label();
            lblTitle = new Label();
            lblPassword = new Label();
            txtUsername = new TextBox();
            txtPassword = new TextBox();
            chkRememberMe = new CheckBox();
            btnLogin = new Button();
            lnkForgotPassword = new LinkLabel();
            lnkSignUp = new LinkLabel();
            pnlContainer.SuspendLayout();
            SuspendLayout();
            // 
            // pnlContainer
            // 
            pnlContainer.BackColor = Color.FromArgb(192, 192, 255);
            pnlContainer.Controls.Add(lblUsername);
            pnlContainer.Controls.Add(lblTitle);
            pnlContainer.Controls.Add(lblPassword);
            pnlContainer.Controls.Add(txtUsername);
            pnlContainer.Controls.Add(txtPassword);
            pnlContainer.Controls.Add(chkRememberMe);
            pnlContainer.Controls.Add(btnLogin);
            pnlContainer.Controls.Add(lnkForgotPassword);
            pnlContainer.Controls.Add(lnkSignUp);
            pnlContainer.Location = new Point(617, 178);
            pnlContainer.Name = "pnlContainer";
            pnlContainer.Size = new Size(614, 635);
            pnlContainer.TabIndex = 0;
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.Location = new Point(86, 186);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(95, 25);
            lblUsername.TabIndex = 0;
            lblUsername.Text = "Username:";
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblTitle.ForeColor = Color.White;
            lblTitle.Location = new Point(12, 11);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(206, 32);
            lblTitle.TabIndex = 1;
            lblTitle.Text = "Together Culture";
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Location = new Point(86, 255);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(91, 25);
            lblPassword.TabIndex = 1;
            lblPassword.Text = "Password:";
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(196, 183);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(257, 31);
            txtUsername.TabIndex = 2;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(196, 252);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(257, 31);
            txtPassword.TabIndex = 3;
            // 
            // chkRememberMe
            // 
            chkRememberMe.AutoSize = true;
            chkRememberMe.Location = new Point(230, 486);
            chkRememberMe.Name = "chkRememberMe";
            chkRememberMe.Size = new Size(154, 29);
            chkRememberMe.TabIndex = 4;
            chkRememberMe.Text = "Remember Me";
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(250, 326);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(100, 39);
            btnLogin.TabIndex = 5;
            btnLogin.Text = "Login";
            // 
            // lnkForgotPassword
            // 
            lnkForgotPassword.AutoSize = true;
            lnkForgotPassword.DisabledLinkColor = Color.Black;
            lnkForgotPassword.LinkColor = Color.Black;
            lnkForgotPassword.Location = new Point(214, 397);
            lnkForgotPassword.Name = "lnkForgotPassword";
            lnkForgotPassword.Size = new Size(154, 25);
            lnkForgotPassword.TabIndex = 6;
            lnkForgotPassword.TabStop = true;
            lnkForgotPassword.Text = "Forgot Password?";
            // 
            // lnkSignUp
            // 
            lnkSignUp.AutoSize = true;
            lnkSignUp.DisabledLinkColor = Color.Black;
            lnkSignUp.LinkColor = Color.Black;
            lnkSignUp.Location = new Point(261, 443);
            lnkSignUp.Name = "lnkSignUp";
            lnkSignUp.Size = new Size(75, 25);
            lnkSignUp.TabIndex = 7;
            lnkSignUp.TabStop = true;
            lnkSignUp.Text = "Sign Up";
            // 
            // LoginForm
            // 
            BackColor = Color.FromArgb(128, 128, 255);
            ClientSize = new Size(1937, 942);
            Controls.Add(pnlContainer);
            FormBorderStyle = FormBorderStyle.None;
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login Form";
            Load += LoginForm_Load_1;
            pnlContainer.ResumeLayout(false);
            pnlContainer.PerformLayout();
            ResumeLayout(false);
        }
    }
}

