namespace Software_project
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
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.btnSendLink = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lblEmail = new System.Windows.Forms.Label();

            this.SuspendLayout();

            // txtEmail
            this.txtEmail.Location = new System.Drawing.Point(50, 50);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(200, 20);
            this.txtEmail.TabIndex = 0;

            // btnSendLink
            this.btnSendLink.Location = new System.Drawing.Point(50, 90);
            this.btnSendLink.Name = "btnSendLink";
            this.btnSendLink.Size = new System.Drawing.Size(100, 23);
            this.btnSendLink.TabIndex = 1;
            this.btnSendLink.Text = "Send Reset Link";
            this.btnSendLink.UseVisualStyleBackColor = true;
            this.btnSendLink.Click += new System.EventHandler(this.btnSendLink_Click);

            // btnCancel
            this.btnCancel.Location = new System.Drawing.Point(160, 90);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(90, 23);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);

            // lblEmail
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(47, 30);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(76, 13);
            this.lblEmail.TabIndex = 3;
            this.lblEmail.Text = "Enter your email:";

            // ForgotPasswordForm
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 150);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.btnSendLink);
            this.Controls.Add(this.btnCancel);
            this.Name = "ForgotPasswordForm";
            this.Text = "Forgot Password";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Button btnSendLink;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lblEmail;
    }
}

