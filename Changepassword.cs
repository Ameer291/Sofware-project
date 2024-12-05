using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sofware_project
{
    public partial class Changepasswordform : Form
    {
        public Changepasswordform()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            User currentuser = LoginUser.GetInstance.GetCurrentUser();
            string oldpswdinDB = currentuser.GetPassword();
            if (currentpassword.Text != oldpswdinDB)
            {
                old_pswd_error.Visible = true;
                return;
            }
            if (newpswd_edit.Text != newpswdconfirm_edit.Text)
            {
                old_pswd_error.Visible = true;
                return;
            }
            currentuser.SetPassword(newpswd_edit.Text);



        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void old_pswd_error_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void Changepasswordform_Load(object sender, EventArgs e)
        {

        }

        private void currentpassword_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
