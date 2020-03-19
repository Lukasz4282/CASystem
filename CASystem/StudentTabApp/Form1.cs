using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

//Kenny change the dir variables here and in WeekCAFile.cs to wherever ur project is stored since the dir here is set to "C:\Users\ldebi\Desktop\StudentTabApp\StudentTabApp"

namespace StudentTabApp
{
    public partial class Form1 : Form
    {
        List<WeekCA> WeekList = WeekCAFile.GetSemesterCA(); //List of all instances of the WeekCA class. GetSemesterCA is a function in WeekCA.cs which loads
        //from file into objects and returns a list of objects.
        List<string> CAList = new List<string>(); //List of CA's, used for saving a list of CA's (that we then pass into WeekCA).
        WeekCA SelectedWeek = new WeekCA(); //Tells the program which week we selected, so it can display the data in that week.

        public Form1()
        {
            SelectedWeek = WeekList[0]; //Not really needed, just default the first week as the selected when starting program
            InitializeComponent();


                listBox1.Items.Clear(); //Clear listbox before populating, not needed but good practice
            foreach (WeekCA c in WeekList) //Foreach week in the list
            {
                foreach (string e in c.CA) //Foreach string in each weeks list of CA
                {
                    if (!listBox1.Items.Contains(e)) //Populating the menu
                    {
                        listBox1.Items.Add(e); 
                        CAList.Add(e);
                    }
                }
                }
            foreach (var b in WeekList) //Populating the left hand side listbox
            {
                listBox3.Items.Add(b.WeekNo);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
           //We make a new list of CA's.
                List<string> CA = new List<string>();

                foreach(string a in listBox2.Items)
                {
                    CA.Add(a); //We populate it
                }

                            string joined = string.Join("\n", CA.ToArray()); //Since we cant display a list, we need to join it into a string
                            SelectedWeek.SaveChanges(txtName.Text, txtDate.Text, CA.ToList()); 
                            MessageBox.Show(SelectedWeek.ShowDetails() + joined); //Call ShowDetails() to show values of the selected week and joined
                                                                                  //to show the CA's in a messagebox
        }

      

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close(); //Exit
        }

        private void btnMoveCAs_Click(object sender, EventArgs e)
        {
            listBox2.Items.Add(listBox1.SelectedItem); //Add selected item to right box
            int index = listBox1.SelectedIndex;
            listBox1.Items.RemoveAt(index); //Remove selected item from left box

            List<string> CA = new List<string>();

            foreach (string a in listBox2.Items)
            {
                CA.Add(a);
            }
            SelectedWeek.SaveChanges(SelectedWeek.WeekNo, SelectedWeek.Date, CA.ToList()); //Save the changes so we can then switch weeks and the changes will remain
            

        }

        private void btnRemoveItem_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(listBox2.SelectedItem);
            int index = listBox2.SelectedIndex;
            listBox2.Items.RemoveAt(index); //Same thing but other way around

            List<string> CA = new List<string>();

            foreach (string a in listBox2.Items)
            {
                CA.Add(a);
            }
            SelectedWeek.SaveChanges(SelectedWeek.WeekNo, SelectedWeek.Date, CA.ToList());
        }

        private void listBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBox2.Items.Clear();//Clear both listboxes to populate with data from new selected week
            listBox1.Items.Clear();

            
                foreach (string b in CAList)
                {
                    listBox1.Items.Add(b); //Populate listbox1 with all CA's that we can then select to add into a week from, not really needed but very handy
                }
            

            string WeekNo = listBox3.SelectedItem.ToString();
         
            foreach(WeekCA a in WeekList)
            {
                if (a.WeekNo == WeekNo)
                {
                   
                    txtName.Text = a.WeekNo;
                    txtDate.Text = a.Date;

                    foreach (string j in a.CA)
                    {
                       
                        listBox2.Items.Add(j);
                        for (var i = listBox1.Items.Count - 1; i >= 0; i--)
                        {
                            var item = listBox1.Items[i];
                                
                                if (listBox2.Items.Contains(item))
                                {
                                    listBox1.Items.Remove(item); //What we do here is basically check if an item in the object instances CA list exists in listbox1,
                                                                 //and if it does we remove it from listbox1. This makes it so we dont have multiple repeats of the same
                                                                 //CA on either listbox1 or listbox2
                                }
                            
                        }

                        

                    }

                    SelectedWeek = a; //and our choice becomes the new SelectedWeek

                    return;
                }
            }
        }

        //It will read and write from: C:\Users\ldebi\Desktop\StudentTabApp\StudentTabAppstudents, this path is just a temp file that it needs for some reason


        private const string path = @"C:\Users\ldebi\Desktop\CASystem\CAFile.txt"; //Change this

        private void btnSaveToFile_Click(object sender, EventArgs e)
        {
 
                // create the output stream for a text file
                StreamWriter textOut =
                    new StreamWriter(
                    new FileStream(path, FileMode.Create, FileAccess.Write));

                // write each customer

                foreach (WeekCA s in WeekList)
                {
                int i = s.CA.Count;
                //MessageBox.Show(i.ToString());
                int y = 0;
                textOut.Write(s.WeekNo + "|"); //We use | between entries because we then read it and the program needs it to know where to split a line into a string array
                textOut.WriteLine(s.Date);


                
                    foreach (string g in s.CA)
                    {
                        if (y != i - 1)
                            textOut.Write(g + ":"); //I wrote these lines because if the last CA in a file i saved with a :, it will think theres an entry after the :
                                                    //and the next time you run the program it would read an empty entry. This fixes the problem.
                        else textOut.Write(g);
                        y++;
                    }

                i = 0;
                i = s.CA.Capacity;

                textOut.Write("\n" + "\n"); //This is here because its just easier to read when its nicely formatted.
                }

                // write the end of the document
                textOut.Close();

            MessageBox.Show("Saved to " + path); //Show to the user that the file has been saveds
            
        }

        private void btnAddStudent_Click(object sender, EventArgs e)
        {
            //Creates new week, saves from user input and saves to file.
            WeekCA newWeek = new WeekCA();
            newWeek.WeekNo = txtName.Text;
            newWeek.Date = txtDate.Text;
            List<string> CA = new List<string>();

            foreach (string a in listBox2.Items)
            {
                CA.Add(a);
            }

            newWeek.CA = CA;

            listBox3.Items.Add(newWeek.WeekNo);

            WeekList.Add(newWeek);

            MessageBox.Show("New Week and selected details have been added. Please click save to file to save the new entry");
        }

      
    }
}

