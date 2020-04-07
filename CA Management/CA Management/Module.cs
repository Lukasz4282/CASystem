using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA_Management
{
    public class Module
    {
        public string ModuleCode { get; set; }
        public string ModuleName { get; set; }
        public string Lecturer { get; set; }
        public SortedDictionary<string, string> ModuleCA { get; set; }

        public Module()
        {

        }
        public Module(string code, string name, string lect, SortedDictionary<string,string> CA)
        {
            this.ModuleCode = code;
            this.ModuleName = name;
            this.ModuleCA = CA;
            this.Lecturer = lect;
        }


    }
}
