private void InitializeComponent()
{
    this.lblUsername = new System.Windows.Forms.Label();
    this.lblPassword = new System.Windows.Forms.Label();
    this.txtUsername = new System.Windows.Forms.TextBox();
    this.txtPassword = new System.Windows.Forms.TextBox();
    this.btnLogin = new System.Windows.Forms.Button();
    this.chkRememberMe = new System.Windows.Forms.CheckBox();
    this.lnkForgotPassword = new System.Windows.Forms.LinkLabel();
    this.lnkSignUp = new System.Windows.Forms.LinkLabel();
    this.SuspendLayout();

    // Label Username
    this.lblUsername.AutoSize = true;
    this.lblUsername.Location = new System.Drawing.Point(50, 100);
    this.lblUsername.Name = "lblUsername";
    this.lblUsername.Size = new System.Drawing.Size(55, 13);
    this.lblUsername.Text = "Username/Email:";

    // TextBox Username
    this.txtUsername.Location = new System.Drawing.Point(150, 97);
    this.txtUsername.Name = "txtUsername";
    this.txtUsername.Size = new System.Drawing.Size(200, 20);

    // Label Password
    this.lblPassword.AutoSize = true;
    this.lblPassword.Location = new System.Drawing.Point(50, 140);
    this.lblPassword.Name = "lblPassword";
    this.lblPassword.Size = new System.Drawing.Size(53, 13);
    this.lblPassword.Text = "Password:";

    // TextBox Password
    this.txtPassword.Location = new System.Drawing.Point(150, 137);
    this.txtPassword.Name = "txtPassword";
    this.txtPassword.Size = new System.Drawing.Size(200, 20);
    this.txtPassword.UseSystemPasswordChar = true;

    // Button Login
    this.btnLogin.Location = new System.Drawing.Point(150, 180);
    this.btnLogin.Name = "btnLogin";
    this.btnLogin.Size = new System.Drawing.Size(200, 23);
    this.btnLogin.Text = "Sign in";
    this.btnLogin.UseVisualStyleBackColor = true;
    this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);

    // CheckBox Remember Me
    this.chkRememberMe.AutoSize = true;
    this.chkRememberMe.Location = new System.Drawing.Point(150, 220);
    this.chkRememberMe.Name = "chkRememberMe";
    this.chkRememberMe.Size = new System.Drawing.Size(94, 17);
    this.chkRememberMe.Text = "Remember me";
    this.chkRememberMe.UseVisualStyleBackColor = true;

    // LinkLabel Forgot Password
    this.lnkForgotPassword.AutoSize = true;
    this.lnkForgotPassword.Location = new System.Drawing.Point(150, 250);
    this.lnkForgotPassword.Name = "lnkForgotPassword";
    this.lnkForgotPassword.Size = new System.Drawing.Size(86, 13);
    this.lnkForgotPassword.TabStop = true;
    this.lnkForgotPassword.Text = "Forgot password?";
    this.lnkForgotPassword.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkForgotPassword_LinkClicked);

    // LinkLabel Sign Up
    this.lnkSignUp.AutoSize = true;
    this.lnkSignUp.Location = new System.Drawing.Point(150, 280);
    this.lnkSignUp.Name = "lnkSignUp";
    this.lnkSignUp.Size = new System.Drawing.Size(46, 13);
    this.lnkSignUp.TabStop = true;
    this.lnkSignUp.Text = "Sign up";
    this.lnkSignUp.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkSignUp_LinkClicked);

    // LoginForm
    this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
    this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
    this.ClientSize = new System.Drawing.Size(400, 350);
    this.Controls.Add(this.lnkSignUp);
    this.Controls.Add(this.lnkForgotPassword);
    this.Controls.Add(this.chkRememberMe);
    this.Controls.Add(this.btnLogin);
    this.Controls.Add(this.txtPassword);
    this.Controls.Add(this.lblPassword);
    this.Controls.Add(this.txtUsername);
    this.Controls.Add(this.lblUsername);
    this.Name = "LoginForm";
    this.Text = "Together Culture Login";
    this.ResumeLayout(false);
    this.PerformLayout();
}


