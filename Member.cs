using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sofware_project
{
    internal class Member:User

    {
        public Member(string firstname, string lastname, string email, string phonenumber,
            string gender, string address, DateTime DOB, string username) :
                   base( firstname, lastname, email, phonenumber,
             gender, address, DOB, username )
        { }
    }

}

