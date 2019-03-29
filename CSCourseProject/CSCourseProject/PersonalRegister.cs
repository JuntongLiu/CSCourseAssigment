using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSCourseProject
{
    class PersonalRegister
    {
        // For testing purpose, we try two way to store the personal information: 
        // 1.)  List,    2.) ArrayList

        List<Personal> personalList;                    // 1. declare a list

        public PersonalRegister()
        {
            personalList = new List<Personal>();
        }

        // Try to use ArrayList to store the information also
        ArrayList personArray = new ArrayList();                  // 2. Create an ArrayList


        // Add a new person to the List and ArrayList 
        public void AddRestPersonal(string sname, float slon)
        {
            Personal person = new Personal();
            person.PersonName = sname;
            person.PersonSalary = slon;
            personalList.Add(person);

            // We save it into the arrayList also, just for testing....
            personArray.Add(person);
        }

        public void ShowList()
        {
            // We display the information in the List
            foreach (Personal person in personalList)
            {
                string pname = person.PersonName;
                float plon = person.PersonSalary;
                Console.WriteLine("Name: " + pname + " " + "Lon: " + plon);
            }

            // We display the contents in the arrayList
            foreach (Personal person in personArray)
            {
                Console.WriteLine("From ArrayList: " + person.PersonName + " Has Salary: " + person.PersonSalary);
                Console.WriteLine();
            }
        }
    }
}
