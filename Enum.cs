using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day1Enum
{
    enum example
    {
        lesser,
        same=50,
        greater,
    };
    class Program
    {
        static void Main(string[] args)
        {
              int a,b;
            Console.WriteLine("Enter a random number: ");
            a = Convert.ToInt32(Console.ReadLine());
            b= (int)example.same;
            if (a == b)
            {
                Console.WriteLine("Given number is "+example.same);
            }
            else if (a < b)
            {
                Console.WriteLine("Given number is " + example.lesser);
            }
            else
            {
                Console.WriteLine("Given number is " + example.greater);
            }
            Console.ReadLine();

        }
    }
}
