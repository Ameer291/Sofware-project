namespace Sofware_project
{
    partial class ForgotPasswordForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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
            txtEmail = new TextBox();
            btnSendLink = new Button();
            btnCancel = new Button();
            lblEmail = new Label();
            SuspendLayout();
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(67, 77);
            txtEmail.Margin = new Padding(4, 5, 4, 5);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(265, 27);
            txtEmail.TabIndex = 0;
            // 
            // btnSendLink
            // 
            btnSendLink.Location = new Point(67, 138);
            btnSendLink.Margin = new Padding(4, 5, 4, 5);
            btnSendLink.Name = "btnSendLink";
            btnSendLink.Size = new Size(133, 35);
            btnSendLink.TabIndex = 1;
            btnSendLink.Text = "Send Reset Link";
            btnSendLink.UseVisualStyleBackColor = true;
            btnSendLink.Click += btnSendLink_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(213, 138);
            btnCancel.Margin = new Padding(4, 5, 4, 5);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(120, 35);
            btnCancel.TabIndex = 2;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(63, 46);
            lblEmail.Margin = new Padding(4, 0, 4, 0);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(120, 20);
            lblEmail.TabIndex = 3;
            lblEmail.Text = "Enter your email:";
            lblEmail.Click += lblEmail_Click;
            // 
            // ForgotPasswordForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(400, 231);
            Controls.Add(lblEmail);
            Controls.Add(txtEmail);
            Controls.Add(btnSendLink);
            Controls.Add(btnCancel);
            Margin = new Padding(4, 5, 4, 5);
            Name = "ForgotPasswordForm";
            Text = "Forgot Password";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Button btnSendLink;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lblEmail;
    }
}

