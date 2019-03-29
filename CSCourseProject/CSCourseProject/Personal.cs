using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSCourseProject
{
    class Personal
    {
        string personName;
        float personSalary;
        //string position;
        //string sex;
        //ushort age;
        //DateTime startDate;
        //string department;
        //string homeAddress;
        //string telephone;
        //string emailAddress;

        public string PersonName
        {
            get
            {
                return personName;
            }
            set
            {
                if (!String.IsNullOrEmpty(value))
                {
                    personName = value;
                }
            }
        }

        
        public float PersonSalary
        {
            get
            {
                return personSalary;
            }

            set
            {
                // Here we install an we publish an event when a person's salary change, to notice manger
                // To do this, we need to create a delegate type and and use the delegate type to declare
                // a delegate variable here. It must has the same signature as the following function. 
                if (PersonSalary != value && PersonSalary != 0)
                {
                    //SalaryChangedNotice(string name, string department);
                }
                else if (PersonSalary == 0)
                {
                    personSalary = value;
                }
            }
        }

        //public string GetName()
        //{
        //    return personName;
        //}

        //public float GetLon()
        //{
        //    return personLon;
        //}

        //public void SetName(string sname)
        //{
        //    personName = sname;
        //}

        //public void SetLon(float slon)
        //{
        //    personLon = slon;
        //}
    }
}
