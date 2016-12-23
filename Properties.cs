using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day1Properties
{
    class Employee
    {
        String Fname, Lname;
        public string FirstName
        {
            get
            {
                return Fname;
            }
            set
            {
                Fname = value;
            }
        }
        public string LastName
        {
            get
            {
                return Lname;
            }
            set
            {
                Lname = value;
            }
        }

        public override string ToString()
        {
            return "FirstName  " + Fname + ", LastName  " + Lname;
        }

        static void Main(string[] args)
        {
            Employee employee = new Employee();
            employee.FirstName = "Vinay";
            employee.LastName = "kumar";

            Console.WriteLine("emp details-{0}", employee);
            Console.ReadLine();

        }
    }
}
