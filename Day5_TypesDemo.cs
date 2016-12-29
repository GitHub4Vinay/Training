using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypesDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            int?[] array = new int?[4];
            array[0] = null;
            array[1] = 2;
            array[2] = 3;
            array[3] = 4;
            Console.Write("Array Elements :");
            foreach (int? i in array)
            {
                Console.Write(i+"  ");
            }
            Console.WriteLine("\n");
            Console.Write("List Elemts: ");

            List<string> names = new List<string>();
            names.Add("vinay");
            names.Add(null);
            names.Add("kumar");
            names.Add("IMCS");
            foreach(string member in names)
            {
                Console.Write(member + "  ");
            }
            Console.WriteLine("\n");
            foreach (string s in names)
            {
              //  Console.WriteLine(s);

                if (s==null)
                    {
                    Console.WriteLine("Index of null in the list is "+names.IndexOf(s));
                }
            }
           int? j = null ;
           int k = 10;
           int? L = j + k; 
           Console.WriteLine(L);

            var student = new { FirstName = "Vinay", LastName = "Kumar", ID = 13654 };
            
            Console.WriteLine(student.LastName);

            

            Console.ReadLine();

            
        }
    }
}
