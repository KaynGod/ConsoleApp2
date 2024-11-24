using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class User : Person
    {
        public string PhoneNumber { get; set; }
        public string Address { get; set; }

        public User(int id, string fullName, string email, string phoneNumber, string address)
            : base(id, fullName, email)
        {
            PhoneNumber = phoneNumber;
            Address = address;
        }
    }

}
