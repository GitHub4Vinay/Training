using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrayofstudents
{
    public class student
    {
        public string fname;
        public string lname;
        public int rolno;
    }

    class Program
    {
       

        static void Main(string[] args)
        {
            student[] arr = new student[5];
            
            for (int j=0; j<arr.Length; j++)
            {
                arr[j] = new student();
                Console.WriteLine("Enter First Name of the Student :\t");
                arr[j].fname = Convert.ToString(Console.ReadLine());
                Console.WriteLine("Enter Last Name of the Student :\t");
                arr[j].lname = Convert.ToString(Console.ReadLine());
                Console.WriteLine("Enter Roll number of the Student:\t");
                arr[j].rolno = Convert.ToInt32(Console.ReadLine());

            }
            foreach (student st in arr)
            {
                Console.Write(st.fname+st.lname+"\t"+st.rolno+"\n");

            }
            Console.ReadLine();
        }
    }
}
