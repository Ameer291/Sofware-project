using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using tcc;

namespace Sofware_project
{
    public partial class EventsManagement : Form
    {
        EventData eventdataobj1;
        EventData eventdataobj2;
        EventData eventdataobj3;
        int PageNum;
        public EventsManagement()
        {
            InitializeComponent();
            PageNum = 1;
            eventdataobj1 = null;
            eventdataobj2 = null;
            eventdataobj3 = null;
            this.Size = new Size(1400, 800);
            UpdateEventDetails();
            //UpdateEventManagementPage();

        }

        private void UpdateEventManagementPage()
        {
            eventstatus1.Hide();
            eventstatus2.Hide();
            eventstatus3.Hide();
            if (eventdataobj1 != null)
            {
                totalnum_events.Text = eventdataobj1.GetEventCount().ToString();
                if (eventdataobj1.GetEventId() != -1)
                {
                    eventname1.Text = eventdataobj1.geteventtitle();
                    event_description1.Text = eventdataobj1.geteventdescription();
                    eventdate1.Text = eventdataobj1.geteventDate().ToLongDateString();
                    eventlocation1.Text = eventdataobj1.getLocation();
                    eventorganiser1.Text = eventdataobj1.getorganiser();
                    eventtype1.Text = eventdataobj1.gettypeofevent();
                    duration1.Text = eventdataobj1.Getduration().ToString();
                    String booking = "0/" + eventdataobj1.getmaxnumberofParticipants().ToString() + "Bookings";
                    booking1.Text = booking;

                }
            }
            if (eventdataobj2.GetEventId() != -1)
            {
                panel6.Show();
                eventname2.Text = eventdataobj2.geteventtitle();
                event_description2.Text = eventdataobj2.geteventdescription();
                eventdate2.Text = eventdataobj2.geteventDate().ToLongDateString();
                eventlocation2.Text = eventdataobj2.getLocation();
                eventorganiser2.Text = eventdataobj2.getorganiser();
                eventtype2.Text = eventdataobj2.gettypeofevent();
                duration2.Text = eventdataobj2.Getduration().ToString();
                String booking = "0/" + eventdataobj2.getmaxnumberofParticipants().ToString() + "Bookings";
                booking2.Text = booking;
            }
            else
                panel6.Hide();
            if (eventdataobj3.GetEventId() != -1)
            {
                Event3Panel.Show();
                eventname3.Text = eventdataobj3.geteventtitle();
                event_description3.Text = eventdataobj3.geteventdescription();
                eventdate3.Text = eventdataobj3.geteventDate().ToLongDateString();
                eventlocation3.Text = eventdataobj3.getLocation();
                eventorganiser3.Text = eventdataobj3.getorganiser();
                eventtype3.Text = eventdataobj3.gettypeofevent();
                duration3.Text = eventdataobj3.Getduration().ToString();
                String booking = "0/" + eventdataobj3.getmaxnumberofParticipants().ToString() + "Bookings";
                booking3.Text = booking;
            }
            else
                Event3Panel.Hide();
        }
        private void UpdateEventDetails()
        {
            int EventId;
            if (eventdataobj1 == null)
                eventdataobj1 = new EventData();
            // if (PageNum == 1)
            EventId = eventdataobj1.GetEventIdFromDB(0);
            eventdataobj1.GetDataFromDB(EventId);

            EventId = eventdataobj1.GetEventIdFromDB(1);
            if (eventdataobj2 == null)
                eventdataobj2 = new EventData();
            eventdataobj2.GetDataFromDB(EventId);


            EventId = eventdataobj1.GetEventIdFromDB(2);
            if (eventdataobj3 == null)
                eventdataobj3 = new EventData();
            eventdataobj3.GetDataFromDB(EventId);
            UpdateEventManagementPage();
            // eventtype3.Text = eventdataobj3.gete
        }
        private void EventsManagement_Load(object sender, EventArgs e)
        {
        }

        private void eventtype_Click(object sender, EventArgs e)
        {

        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void eventedit1_Click(object sender, EventArgs e)
        {
            Events_info_create eventobj = new Events_info_create();
            eventobj.FormClosing += new FormClosingEventHandler(this.event_Refresh);
            eventobj.SetEventDetails(eventdataobj1);
            eventobj.ShowDialog();
            this.Refresh();

        }

        private void event_Refresh(object sender, EventArgs e)
        {
            UpdateEventDetails();
        }
        private void eventdelete1_Click(object sender, EventArgs e)
        {
            eventdataobj1.DeleteEventFromDB();
            UpdateEventDetails();
        }

        private void eventedit2_Click(object sender, EventArgs e)
        {
            Events_info_create eventobj = new Events_info_create();
            eventobj.FormClosing += new FormClosingEventHandler(this.event_Refresh);
            eventobj.SetEventDetails(eventdataobj2);
            eventobj.ShowDialog();
            this.Refresh();
        }

        private void eventdelete2_Click(object sender, EventArgs e)
        {
            eventdataobj2.DeleteEventFromDB();
            UpdateEventDetails();
        }

        private void eventedit3_Click(object sender, EventArgs e)
        {
            Events_info_create eventobj = new Events_info_create();
            eventobj.FormClosing += new FormClosingEventHandler(this.event_Refresh);
            eventobj.SetEventDetails(eventdataobj3);
            eventobj.ShowDialog();
            this.Refresh();
        }

        private void eventdelete3_Click(object sender, EventArgs e)
        {
            eventdataobj3.DeleteEventFromDB();
            UpdateEventDetails();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Events_info_create eventobj = new Events_info_create();
            eventobj.FormClosing += new FormClosingEventHandler(this.event_Refresh);
            eventobj.ShowDialog();
            this.Refresh();
        }
    }
}
