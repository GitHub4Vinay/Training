using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3Overloading
{
    class Program
    {
        static void Main(string[] args)
        {
            MethodA(2, 3);
            MethodA(5.01,6.03);
            MethodA(2, 3, 5);
            Console.WriteLine(multiplication(3, 6));
            Console.WriteLine(multiplication(1,2, 6));
            Console.WriteLine(multiplication(3.0, 6.1));
            Console.ReadLine();
        }
        static void MethodA(int a, int b)
        {
            int c;
            c = a + b;
            Console.WriteLine(c);
        }
        static void MethodA(int a, int b,int c)
        {
            int d;
            d = a + b+c;
            Console.WriteLine(d);
        }
        static void MethodA(double a, double b)
        {
            
            Console.WriteLine(a+b);
        }
        static int  multiplication(int a, int b)
        {
            return a * b;
        }
        static int multiplication(int a, int b, int c)
        {
            return a * b * c;
        }
        static double multiplication(double a, double b)
        {
            return a * b;
        }

    }
}
