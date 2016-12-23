using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day1Ternary
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b;
            string result;
            Console.WriteLine("Enter value for a: ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter value for b: ");
            b = Convert.ToInt32(Console.ReadLine());

            result = a > b ? "a is bigger" : "b is bigger";
            Console.WriteLine(result);
            Console.ReadLine();
        }
    }
}
