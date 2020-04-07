using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA_Management
{
    class Student:Person
    {
        public string KNum { get; set; }
        public string course { get; set; }
        public SortedSet<string> StudentModule { get; set; }

        public Student()
        {

        }
        public Student(string fname, string sName, string email, string knumber, string course,  SortedSet<string> Mcode) : base(fname, sName,  email)
        {
            this.KNum = knumber;
            this.course = course;
            this.StudentModule = Mcode;
        }
    }
}
