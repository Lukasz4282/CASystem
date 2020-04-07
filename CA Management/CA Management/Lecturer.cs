using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA_Management
{
    class Lecturer:Person
    {
        public string LectID { get; set; }
        public SortedSet<string> LectCourse { get; set; }
        public Lecturer()
        {

        }
        public Lecturer(string fname, string sName, string email, string id, SortedSet<string> Course) : base(fname, sName, email)
        {
            this.LectID = id;
            this.LectCourse =Course;
        }
    }
}
