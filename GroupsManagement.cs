﻿using System;
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
    public partial class GroupsManagement : Form
    {
        
        public GroupsManagement()
        {
            InitializeComponent();
        }

        private void panel11_Paint(object sender, PaintEventArgs e)
        {

        }

        private void eventname1_Click(object sender, EventArgs e)
        {

        }

        private void panel12_Paint(object sender, PaintEventArgs e)
        {

        }

        private void eventtime1_Click(object sender, EventArgs e)
        {

        }

        private void eventbooking1_Click(object sender, EventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void event_categories_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void NewEvent_Click(object sender, EventArgs e)
        {
            Groups Addgroupobj = new Groups();
            Addgroupobj.ShowDialog();
            this.Refresh();
        }

        private void group_description1_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void group_description2_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel7_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
