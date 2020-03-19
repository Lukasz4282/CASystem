using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//This is the class. It stores data for each week, including a list of the CA which can be displayed. Each instance of WeekCA is a week on the calendar

namespace StudentTabApp
{
    public class WeekCA
    {
        public string WeekNo { get; set; }
        public string Date { get; set; }
        public List<string> CA { get; set; }    //This is a list of CA's, AKA the right listbox entries

        //Some constructors

        public WeekCA()
        {
            this.WeekNo = "";
            this.Date = "";
            this.CA = null;
        }

        public WeekCA(string WeekNo, string Date)
        {
            this.WeekNo = WeekNo;
            this.Date = Date;                  
        }

        public WeekCA(string WeekNo, string Date, List<string> CA)
        {
            this.WeekNo = WeekNo;
            this.Date = Date;           
            this.CA = CA;
        }

        //Function to show values of properties of an object instance

        public string ShowDetails()
        {
            string result = ("\n" + this.WeekNo + "\n" + this.Date + "\n");
            return result;
        }

        //Function to save changes to object instance

        public void SaveChanges(string WeekNo, string Date, List<string> CA)
        {
            this.WeekNo = WeekNo;
            this.Date = Date;
            this.CA = CA;
        }
    }
}
