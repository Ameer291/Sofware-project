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
            string gender, string address, string username, string Password) :
                   base( firstname, lastname, email, phonenumber,
             gender, address,username, Password)
        { }
    }

}

