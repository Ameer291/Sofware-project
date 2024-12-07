using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Sofware_project
{
    public class EventData
    {
        private String Description;
        private String title;
        DateTime eventdate;
        int maxnumberofParticipants;
        string typeofevent;
        string location;
        string EventType;
        string EventStatus;
        string organiser;
        int eventId;
        public EventData()
        {
            this.eventId = -1;
        }
        public void UpdateEventData( String Description, String title, DateTime eventdate,int maxnumberofParticipants,
                              string typeofevent, string location, string event_status )
        {
            this.Description = Description;
            this.eventdate = eventdate;
            this.maxnumberofParticipants = maxnumberofParticipants;
            this.typeofevent = typeofevent;
            this.location = location;
            this.EventStatus = event_status;
            this.title = title;
            //this.title = title;
        }
        public void GetDataFromDB( int eventId )
        {
            this.eventId = eventId;
            DBConnection DBcon = new DBConnection();
            SqlConnection sqlcon = DBcon.ConnectDB();
            var query = "SELECT * FROM Events WHERE eventId = @eventId";
            try
            {
                using (var cmd = new SqlCommand(query, sqlcon))
                {
                    cmd.Parameters.Add("@eventId", SqlDbType.Int);
                    cmd.Parameters["@eventId"].Value = eventId;
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            DateTime DOB = DateTime.MinValue;
                            int i = reader.GetInt32(0);
                            title = reader.IsDBNull(1) ? "" : reader.GetString(1);
                            Description = reader.IsDBNull(2) ? "" : reader.GetString(2);
                            eventdate = reader.IsDBNull(3) ? DateTime.MinValue: reader.GetDateTime(3);
                            location = reader.IsDBNull(4) ? "" : reader.GetString(4);
                            maxnumberofParticipants = reader.IsDBNull(5) ? 50 : reader.GetInt32(5);
                            organiser = reader.IsDBNull(7) ? "" : reader.GetString(7);
                            typeofevent = reader.IsDBNull(8) ? "" : reader.GetString(8);
                            EventStatus = reader.IsDBNull(9) ? "" : reader.GetString(9);
                            // if( !reader.IsDBNull(10))
                            // DOB = (DateTime)reader.GetDateTime(10);
                        }
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Error connecting to database", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            DBcon.CloseDBConnection();
        }
        public string geteventdescription()
        {
            return this.Description;
        }

        public void seteventdescription(string Description)
        {
           this.Description = Description;
        }

        public string geteventtitle()
        {
            return this.title;
        }

        public void seteventtitle(string title)
        {
            this.title = title;
        }

        public DateTime geteventDate()
        {
            return this.eventdate;
        }


        public int getmaxnumberofParticipants()
        {
            return this.maxnumberofParticipants;
        }


        public string gettypeofevent()
        {
            return this.typeofevent;
        }

        public String getLocation()
        {
            return this.location;
        }

        public String getorganiser()
        {
            return this.organiser;
        }
        public void setorganiser( string organiser)
        {
            this.organiser = organiser;
        }
        public String getEventType()
        {
            return this.EventType;
        }

        public int SetEventId()
        {
            return this.eventId;
        }
        public int GetEventId()
        {
            return this.eventId;
        }
        public int GetEventCount()
        {
            DBConnection DBcon = new DBConnection();
            SqlConnection sqlcon = DBcon.ConnectDB();
            try
            {
                var query = "SELECT COUNT(1) FROM Events";
                using (var cmd = new SqlCommand(query, sqlcon))
                {
                    int count = Convert.ToInt32(cmd.ExecuteScalar());
                    return count;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error connecting to database: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return -1;
            }
            DBcon.CloseDBConnection();
        }

        public int GetEventIdFromDB( int nIndex )
        {
            int EventId = -1;
            DBConnection DBcon = new DBConnection();
            SqlConnection sqlcon = DBcon.ConnectDB();
            try
            {
                int nCurrentIdex = 0;
                var query = "SELECT EventId FROM Events";
                using (var cmd = new SqlCommand(query, sqlcon))
                {
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        if (nCurrentIdex == nIndex)
                        {
                            EventId = reader.GetInt32(0);
                            return EventId;
                        }
                        nCurrentIdex++;
                        
                    }
                    return EventId;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error connecting to database: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return -1;
            }
            DBcon.CloseDBConnection();
        }
        public int IsAlreadyExist()
        {
            DBConnection DBcon = new DBConnection();
            SqlConnection sqlcon = DBcon.ConnectDB();
            try
            {
                var query = "SELECT COUNT(1) FROM Events WHERE EventId = @EventId";
                using (var cmd = new SqlCommand(query, sqlcon))
                {
                    cmd.Parameters.AddWithValue("@EventId", this.eventId);
                    int count = Convert.ToInt32(cmd.ExecuteScalar());
                    return count;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error connecting to database: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return -1;
            }
            DBcon.CloseDBConnection();
        }
        public void UpdateDB()
        {
            if (this.eventId == -1)
                CreateEventToDB();
            else
                UpdateEventToDB();

            SqlTransaction transaction = null;
            DBConnection DBcon = new DBConnection();
            SqlConnection sqlcon = DBcon.ConnectDB();
            try
            {

                transaction = sqlcon.BeginTransaction();
                transaction.Commit();
            }
            catch (Exception ex)
            {
                if (transaction != null)
                    transaction.Rollback();
                MessageBox.Show("Error connecting to database: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            DBcon.CloseDBConnection();
        }
        public bool CreateEventToDB()
        {
            this.eventId = GetEventCount() + 1;
            try
            {
                DBConnection DBcon = new DBConnection();
                SqlConnection sqlcon = DBcon.ConnectDB();
                try
                {
                    var query = "INSERT INTO Events ( Description,Title,Location,EventDate,MaxAttendees,EventType,Organiser,CreatedDate) " +
                        "VALUES (@Description, @Title, @Location, @EventDate, @MaxAttendees,@EventType,@Organiser,@CreatedDate)";
                    using (var cmd = new SqlCommand(query, sqlcon))
                    {
                        //cmd.Parameters.AddWithValue("@EventId", this.eventId);
                        cmd.Parameters.AddWithValue("@Description", this.Description );
                        cmd.Parameters.AddWithValue("@Title", this.title);
                        cmd.Parameters.AddWithValue("@Location", this.location);
                        cmd.Parameters.AddWithValue("@EventDate", this.eventdate);
                        cmd.Parameters.AddWithValue("@MaxAttendees", this.maxnumberofParticipants);
                        cmd.Parameters.AddWithValue("@EventType", this.typeofevent);
                        cmd.Parameters.AddWithValue("@Organiser", this.organiser);
                        cmd.Parameters.AddWithValue("@CreatedDate", DateTime.Now);
                        return cmd.ExecuteNonQuery() > 0;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error connecting to database: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
                DBcon.CloseDBConnection();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error in insert to event database: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }
        public bool UpdateEventToDB()
        {
            try
            {
                DBConnection DBcon = new DBConnection();
                SqlConnection sqlcon = DBcon.ConnectDB();
                var query = "UPDATE Events SET " +
                    "Description = @Description," +
                    "Title = @Title, " +
                    "Location = @Location," +
                    "EventDate = @EventDate" +
                    " WHERE EventId = '" + this.eventId + "'";

                using ( var cmd = new SqlCommand( query, sqlcon ))
                {
                    // cmd.Parameters.AddWithValue("@Password", password);
                    cmd.Parameters.AddWithValue("@Description", this.Description);
                    cmd.Parameters.AddWithValue("@Title", this.title);
                    cmd.Parameters.AddWithValue("@Location", this.location);
                    cmd.Parameters.AddWithValue("@EventDate", this.eventdate);
                    cmd.Parameters.AddWithValue("@MaxAttendees", this.maxnumberofParticipants);
                    cmd.Parameters.AddWithValue("@EventType", this.typeofevent);
                    cmd.Parameters.AddWithValue("@Organiser", this.organiser);
                    cmd.ExecuteNonQuery();
                    return true;
                }
                DBcon.CloseDBConnection();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error in updating to event database: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }


        public bool DeleteEventFromDB()
        {
            try
            {
                DBConnection DBcon = new DBConnection();
                SqlConnection sqlcon = DBcon.ConnectDB();
                var query = "DELETE from Events " +
                    " WHERE EventId = '" + this.eventId + "'";

                using (var cmd = new SqlCommand(query, sqlcon))
                {
                    cmd.ExecuteNonQuery();
                    return true;
                }
                DBcon.CloseDBConnection();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error in updating to event database: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

    }
}
