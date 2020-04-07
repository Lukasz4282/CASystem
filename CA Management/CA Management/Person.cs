using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA_Management
{
    public abstract class Person
    {
        public string firstName { get; set; }
        public string surname { get; set; }
        public string email { get; set; }

        public Person()
        {

        }
        public Person(string fname, string sName,  string email)
        {
            this.firstName = fname;
            this.surname = sName;
            this.email = email;
        }
    }
}
