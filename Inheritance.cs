using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day1Inheritance
{
    class BaseExamp
    {
        public int a, b, c;
    }
    class Mathoperations: BaseExamp
    {
        public int mul()
        { return a * b * c; }
        public int add()
        { return a + b + c; }

    }


    class Program
    {
        static void Main(string[] args)
        {
            Mathoperations M1 = new Mathoperations();
            M1.a = 2;
            M1.b = 3;
            M1.c = 4;
            Console.WriteLine(M1.mul());
            Console.WriteLine(M1.add());
            Console.ReadLine();

        }
    }
}
