using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Sofware_project
{
    public partial class Profileupdateform : Form
    {
        public Profileupdateform()
        {
            InitializeComponent();
            Updateuserdetails();

        }
        private void Updateuserdetails()
        {
            User currentuser = LoginUser.GetInstance.GetCurrentUser();
            if (currentuser == null)
                return;
            firstname.Text = currentuser.GetFirstName();
            lastname.Text = currentuser.GetLastName();
            if( currentuser.GetDOB() != null && currentuser.GetDOB() != DateTime.MinValue)
              DOB.Text = currentuser.GetDOB().ToLongDateString();
            address.Text = currentuser.GetAddress();
            phonenumber.Text = currentuser.GetPhoneNumber();
            email.Text = currentuser.GetEmail();
            username.Text = currentuser.GetUsername();
            profileimage.Image = currentuser.GetPhoto(); ;
            
        }


        private void editprofilebutton_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.ReadOnlyChecked = true;

            openFileDialog1.Multiselect = false;
            Bitmap myBitmap;
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                myBitmap = new Bitmap(openFileDialog1.FileName);
                //pictureBox2.ImageLocation = openFileDialog1.FileName;

                profileimage.Image = myBitmap;
                User currentuser = LoginUser.GetInstance.GetCurrentUser();
                if (currentuser == null)
                    return;
                currentuser.SetPhoto( myBitmap );
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void Profileupdateform_Load(object sender, EventArgs e)
        {

        }


        private void firstname_TextChanged(object sender, EventArgs e)
        {

        }

        private void address_TextChanged(object sender, EventArgs e)
        {

        }
        //save button click
        private void button1_Click(object sender, EventArgs e)
        {
            User currentuser = LoginUser.GetInstance.GetCurrentUser();
            if (currentuser == null)
                return;
            currentuser.SetAddress(address.Text);
            currentuser.SetFirstName(firstname.Text);
            currentuser.SetLastName(lastname.Text);
            DateTime DOBDate = DateTime.MinValue;
            try
            {
                DOBDate = DateTime.Parse(DOB.Text);
            }
            catch (Exception ex)
            {
                DOBDate = DateTime.MinValue;
            }
            currentuser.SetDOB(DOBDate);
            currentuser.SetPhoneNumber(phonenumber.Text);
            currentuser.SetEmail(email.Text);
            currentuser.SetPhoto( profileimage.Image);
            if( LoginUser.GetInstance.UpdateToDB())
                this.Close();
        }

        private void changepswdbutton_Click(object sender, EventArgs e)
        {
            Changepasswordform pswdchangeformobj = new Changepasswordform();
            pswdchangeformobj.Show();
        }
    }
}
