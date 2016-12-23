using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day1Forloop
{
    class Program
    {
        static void Main(string[] args)
        {
            int i,count;
            Console.WriteLine("Enter the value for Counter: ");
            count = Convert.ToInt32(Console.ReadLine());
            for (i = 1; i <= count; i++)
            {
                Console.WriteLine(i);
            }
            Console.ReadLine();
        }
    }
}
