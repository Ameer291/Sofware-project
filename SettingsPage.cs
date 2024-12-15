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
    public partial class SettingsPage : Form
    {
        Profile_Visibility PVObj;
        Dataandprivacy DataPrivacyObj;
        public SettingsPage()
        {
            InitializeComponent();
            PVObj = new Profile_Visibility();
            DataPrivacyObj = new Dataandprivacy();
            DataPrivacyObj.Owner = this;
            Updateuserdetails();

        }
        private void Updateuserdetails()
        {
            User currentuser = LoginUser.GetInstance.GetCurrentUser();
            if (currentuser == null)
                return;
            member_name.Text = currentuser.GetUsername();

        }
        private void SettingsPage_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click_2(object sender, EventArgs e)
        {

        }

        private void vScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            User currentuser = LoginUser.GetInstance.GetCurrentUser();
            if (currentuser == null)
                return;
            currentuser.DeleteUserFromDB();
            LoginUser.GetInstance.RemoveCurrentUser();
            this.Close();
        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Profileupdateform profFormObj = new Profileupdateform();
            profFormObj.ShowDialog();
        }

        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void member_name_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            PVObj.Owner = this;
            PVObj.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DataPrivacyObj.Show();
        }
    }
}
