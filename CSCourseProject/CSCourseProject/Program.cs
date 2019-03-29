using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSCourseProject
{
    class Program
    {
        static void Main(string[] args)
        {

            // Create a personal list object
            PersonalRegister employeeList = new PersonalRegister();
            int i = 0;
            // create 3 person list
            for (i = 0; i < 3; i++)
            {
                Console.WriteLine("Input the personal's name: ");
                string sname = Console.ReadLine();
                Console.WriteLine("Input " + sname + " " + " lon: ");
                float slon = float.Parse(Console.ReadLine());

                // add to the list
                employeeList.AddRestPersonal(sname, slon);     // This is a public function, but somehow, can not find.   what is wrong

            }

            // Show the list
            employeeList.ShowList();


        }
    }
}
