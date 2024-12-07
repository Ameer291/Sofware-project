using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Sofware_project
{
    public partial class Events_info_create : Form
    {
        private EventData eventDataobj;
        public Events_info_create()
        {

            InitializeComponent();
            UpdateEventDetails();
            if (this.event_name.Text.IsNullOrEmpty())
                update_create_eventbtn.Text = "Create";
            else
                update_create_eventbtn.Text = "Update";

        }

        public void UpdateEventDetails()
        {
            if (this.eventDataobj != null)
            {
                event_date.Text = eventDataobj.geteventDate().ToLongDateString();
                event_name.Text = eventDataobj.geteventtitle();
                event_description.Text = eventDataobj.geteventdescription();
                event_location.Text = eventDataobj.getLocation();
                total_bookings.Text = eventDataobj.getmaxnumberofParticipants().ToString();
                organiser.Text = eventDataobj.getorganiser();
                event_type.Text = eventDataobj.gettypeofevent();
            }
        }

        public void SetEventDetails(EventData EventDataObj)
        {
            this.eventDataobj = EventDataObj;
            event_name.Text = eventDataobj.geteventtitle();

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void eventtype1_Click(object sender, EventArgs e)
        {

        }

        private void event_description_TextChanged(object sender, EventArgs e)
        {

        }

        private void Events_info_create_Load(object sender, EventArgs e)
        {
            UpdateEventDetails();
            if (this.event_name.Text.IsNullOrEmpty())
                update_create_eventbtn.Text = "Create";
            else
                update_create_eventbtn.Text = "Update";
        }

        private void update_create_eventbtn_Click(object sender, EventArgs e)
        {
            bool Exist = true;
            DateTime eventdate = DateTime.MinValue;
            int maxbookings = 50;
            String datestr = event_date.Text;
            try
            {
                eventdate = DateTime.Parse(datestr);
            }
            catch (Exception ex)
            {
                eventdate = DateTime.MinValue;
            }
            try
            {
                maxbookings = Int32.Parse(total_bookings.Text);
            }
            catch (Exception ex)
            {

            }

            if (event_name.Text == "")
            {
                MessageBox.Show("Event name should be filled: ", "Event Details",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (event_description.Text == "")
            {
                MessageBox.Show("Event description should be filled: ", "Event Details",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (event_type.Text == "")
            {
                MessageBox.Show("Select Event type : ", "Event Details",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (this.eventDataobj == null)
            {
                this.eventDataobj = new EventData();

            }
            this.eventDataobj.UpdateEventData(event_description.Text,
                                              event_name.Text, eventdate, maxbookings, event_type.Text,
                                              event_location.Text, event_status.Text);
            this.eventDataobj.setorganiser(organiser.Text);
            this.eventDataobj.UpdateDB();

            //Exist = eventdataobj.IsAlreadyExist();
            //if (!Exist)
            //    eventdataobj.CreateEventToDB();
            //else
            //    eventdataobj.UpdateEventToDB();
            this.Close();
        }


        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
