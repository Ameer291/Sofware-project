using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Microsoft.VisualBasic.ApplicationServices;

namespace Sofware_project
{
    internal class User
    {
        private string FirstName;
        private string LastName;
        private string Email;
        private string Password;    
        private string PhoneNumber;
        private string Gender;
        private string Address;
        private DateTime DOB;
        private string Username;
        private Image Photo;
        int Membertype; // 1 for admin,0 for member, 2 for non member
        int profilevisibility; //1 admin only 2 -admin &user 3 everyone
        public User(string firstname, string lastname, string email, string phonenumber,
            string gender, string address, string username, string Password )
        {
            this.FirstName = firstname;
            this.LastName = lastname;
            this.Gender = gender;
            this.Address = address;
            this.Username = username;
            this.Email = email;
            this.PhoneNumber = phonenumber;
            this.Password = Password;
            this.Membertype = 1;
        }
        public string GetFirstName()
        {
            return this.FirstName;
        }
        public void SetFirstName(String FirstName)
        {
            this.FirstName = FirstName;

        }
        public string GetLastName()
        {
            return this.LastName;
        }
        public void SetLastName(String LastName)
        {
            this.LastName = LastName;

        }
        public string GetGender()
        {
            return this.Gender;
        }
        public void SetGender(String Gender)
        {
            this.Gender = Gender;

        }
        public string GetAddress()
        {
            return this.Address;
        }
        public void SetAddress(String Address)
        {
            this.Address = Address;

        }
        public string GetUsername()
        {
            return this.Username;
        }
        public void SetUsername(String Username)
        {
            this.Username = Username;

        }

        public string GetEmail()
        {
            return this.Email;
        }
        public void SetEmail(String Email)
        {
            this.Email = Email;

        }

        public string GetPhoneNumber()
        {
            return this.PhoneNumber;
        }
        public void SetPhoneNumber(String PhoneNumber)
        {
            this.PhoneNumber = PhoneNumber;

        }
        
        public DateTime GetDOB()
        {
            return this.DOB;
        }
        public void SetDOB(DateTime DOB)
        {
            this.DOB = DOB;

        }
        public void SetUserType(int usertype)
        {
            this.Membertype = usertype;
        }
        public string GetPassword()
        {
            return this.Password;
        }
        public void SetPassword(String Password)
        {
            this.Password = Password;

        }

        public Image GetPhoto()
        {
            return this.Photo;
        }
        public void SetPhoto(Image Photo)
        {
            this.Photo = Photo;

        }
        public int GetMemberType()
        {
            return this.Membertype;
        }

        public void SetMemberType(int membertype )
        {
            this.Membertype = membertype;

        }
        public void setProfVisibility( int visibility )
        {
            this.profilevisibility = visibility;
        }
        public int GetUserID()
        {
            return 1;
        }
        public bool DeleteUserFromDB()
        {
            try
            {
                DBConnection DBcon = new DBConnection();
                SqlConnection sqlcon = DBcon.ConnectDB();
                var query = "DELETE from Users " +
                    " WHERE UserName = '" + this.GetUsername() + "'";

                using (var cmd = new SqlCommand(query, sqlcon))
                {
                    cmd.ExecuteNonQuery();
                    return true;
                }
                DBcon.CloseDBConnection();
                this.FirstName = "";
                this.LastName = "";
                this.Gender = "";
                this.Address = "";
                this.Username = "";
                this.Email = "";
                this.PhoneNumber = "";
                this.Password = "";
                this.Membertype = 1;
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
