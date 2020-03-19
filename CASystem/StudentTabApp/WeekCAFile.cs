using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

//

namespace StudentTabApp
{

    public static class WeekCAFile
    {
        private const string path = @"C:\Users\ldebi\Desktop\CASystem\CAFile.txt"; //Change this

        public static void SetSemesterCA(List<WeekCA> Week)
        {
            // create the output stream for a text file
            StreamWriter textOut =
                new StreamWriter(
                new FileStream(path, FileMode.Create, FileAccess.Write));

            // write each customer
            foreach (WeekCA c in Week)
            {
                textOut.Write(c.WeekNo + "|");
                textOut.WriteLine(c.Date);
            }

            // write the end of the document
            textOut.Close();
        }



        public static List<WeekCA> GetSemesterCA()
        {
            // if the directory doesn't exist, create it


            // create the object for the input stream for a text file
            StreamReader textIn =
                new StreamReader(
                    new FileStream(path, FileMode.OpenOrCreate, FileAccess.Read));

            // create the array list for customers
            List<WeekCA> WeekList = new List<WeekCA>();
            List<string[]> CAsList = new List<string[]>();

            // read the data from the file and store it in the ArrayList
            while (textIn.Peek() != -1)
            {
                string row = textIn.ReadLine();
                string[] columns = row.Split('|');
                WeekCA s = new WeekCA();
                s.WeekNo = columns[0];
                s.Date = columns[1];

               

                string row2 = textIn.ReadLine();
                string[] columns2 = row2.Split(':');
                List<string[]> m = new List<string[]>();
                var studentCA = new List<string>();

               
                
                    foreach (var f in columns2)
                    {
                    if (f != "")
                        studentCA.Add(f);
                    }
                
                


                s.CA = studentCA;
  


                WeekList.Add(s);

                string spacing = textIn.ReadLine();
            }

            textIn.Close();

            return WeekList;
        }


    }
}
