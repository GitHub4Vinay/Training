using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boxnunbox
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b;
            a = 100;
            object c = a; //Boxing
            Console.WriteLine("Boxing Result "+c);
            b = (int)c; //Unboxing
            Console.WriteLine("Unboxing Result "+b);

            Console.ReadLine();
        }
    }
}
