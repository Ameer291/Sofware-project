namespace Software_project
{
    partial class LoginForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Panel pnlContainer;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.CheckBox chkRememberMe;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.LinkLabel lnkForgotPassword;
        private System.Windows.Forms.LinkLabel lnkSignUp;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pnlContainer = new Panel();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            lblUsername = new Label();
            txtUsername = new TextBox();
            lblPassword = new Label();
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
            pnlContainer.Anchor = AnchorStyles.None;
            pnlContainer.BackColor = Color.FromArgb(192, 192, 255);
            pnlContainer.BorderStyle = BorderStyle.FixedSingle;
            pnlContainer.Controls.Add(label3);
            pnlContainer.Controls.Add(label2);
            pnlContainer.Controls.Add(label1);
            pnlContainer.Controls.Add(lblUsername);
            pnlContainer.Controls.Add(txtUsername);
            pnlContainer.Controls.Add(lblPassword);
            pnlContainer.Controls.Add(txtPassword);
            pnlContainer.Controls.Add(chkRememberMe);
            pnlContainer.Controls.Add(btnLogin);
            pnlContainer.Controls.Add(lnkForgotPassword);
            pnlContainer.Controls.Add(lnkSignUp);
            pnlContainer.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            pnlContainer.Location = new Point(296, 80);
            pnlContainer.Margin = new Padding(2);
            pnlContainer.Name = "pnlContainer";
            pnlContainer.Size = new Size(343, 384);
            pnlContainer.TabIndex = 0;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(59, 304);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(170, 20);
            label3.TabIndex = 10;
            label3.Text = "Don't have an account?";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.FromArgb(255, 224, 192);
            label2.Location = new Point(2, 20);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(85, 20);
            label2.TabIndex = 9;
            label2.Text = "Cambridge";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(-1, 0);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(127, 20);
            label1.TabIndex = 8;
            label1.Text = "Together Culture";
            label1.Click += label1_Click_1;
            // 
            // lblUsername
            // 
            lblUsername.Location = new Point(16, 92);
            lblUsername.Margin = new Padding(2, 0, 2, 0);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(80, 18);
            lblUsername.TabIndex = 0;
            lblUsername.Text = "Username/Email:";
            lblUsername.Click += lblUsername_Click;
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(101, 90);
            txtUsername.Margin = new Padding(2);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(161, 27);
            txtUsername.TabIndex = 1;
            // 
            // lblPassword
            // 
            lblPassword.Location = new Point(16, 132);
            lblPassword.Margin = new Padding(2, 0, 2, 0);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(80, 18);
            lblPassword.TabIndex = 2;
            lblPassword.Text = "Password:";
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(101, 130);
            txtPassword.Margin = new Padding(2);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(161, 27);
            txtPassword.TabIndex = 3;
            txtPassword.UseSystemPasswordChar = true;
            // 
            // chkRememberMe
            // 
            chkRememberMe.Location = new Point(16, 180);
            chkRememberMe.Margin = new Padding(2);
            chkRememberMe.Name = "chkRememberMe";
            chkRememberMe.Size = new Size(167, 23);
            chkRememberMe.TabIndex = 4;
            chkRememberMe.Text = "Remember me";
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(104, 251);
            btnLogin.Margin = new Padding(2);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(160, 34);
            btnLogin.TabIndex = 5;
            btnLogin.Text = "Sign in";
            btnLogin.Click += btnLogin_Click_1;
            // 
            // lnkForgotPassword
            // 
            lnkForgotPassword.LinkColor = Color.FromArgb(128, 128, 255);
            lnkForgotPassword.Location = new Point(206, 181);
            lnkForgotPassword.Margin = new Padding(2, 0, 2, 0);
            lnkForgotPassword.Name = "lnkForgotPassword";
            lnkForgotPassword.Size = new Size(136, 18);
            lnkForgotPassword.TabIndex = 6;
            lnkForgotPassword.TabStop = true;
            lnkForgotPassword.Text = "Forgot password?";
            // 
            // lnkSignUp
            // 
            lnkSignUp.LinkColor = Color.FromArgb(128, 128, 255);
            lnkSignUp.Location = new Point(230, 304);
            lnkSignUp.Margin = new Padding(2, 0, 2, 0);
            lnkSignUp.Name = "lnkSignUp";
            lnkSignUp.Size = new Size(72, 18);
            lnkSignUp.TabIndex = 7;
            lnkSignUp.TabStop = true;
            lnkSignUp.Text = "Sign up";
            lnkSignUp.LinkClicked += lnkSignUp_LinkClicked_1;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(128, 128, 255);
            ClientSize = new Size(972, 576);
            Controls.Add(pnlContainer);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(2);
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login Form";
            Load += LoginForm_Load;
            pnlContainer.ResumeLayout(false);
            pnlContainer.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
    }
}


