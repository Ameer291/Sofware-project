using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        int Membertype; // 0 for admin, 1 for member, 2 for non member

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

    }
}
