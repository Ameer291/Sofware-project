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
       // private string Password;    
        private string PhoneNumber;
        private string Gender;
        private string Address;
        private DateTime DOB;
        private string Username;

        public User(string firstname, string lastname, string email, string phonenumber,
            string gender, string address, DateTime DOB, string username)
        {
            this.FirstName = firstname;
            this.LastName = lastname;
            this.DOB = DOB;
            this.Gender = gender;
            this.Address = address;
            this.Username = username;
            this.Email = email;
            this.PhoneNumber = phonenumber;
        }

    }
    


}
