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
    public partial class Profile_Visibility : Form
    {
        public Profile_Visibility()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void Profile_Visibility_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            User currentuser = LoginUser.GetInstance.GetCurrentUser();
            if (currentuser == null)
                return;
            int visibility = 0;
            currentuser.setProfVisibility(visibility);
            this.Hide();
        }
    }
}
