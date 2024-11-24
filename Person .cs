using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public abstract class Person : BaseEntity
    {
        public string FullName { get; private set; }
        public string Email { get; private set; }

        protected Person(int id, string fullName, string email) : base(id)
        {
            FullName = fullName;
            Email = email;
        }
    }

}
