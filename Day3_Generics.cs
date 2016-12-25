using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            Genericexmp<double> g1 = new Genericexmp<double>();
            double a = g1.output(10.96,9);
            
            Genericexmp<int> g2 = new Genericexmp<int>();
            double b = g2.output(10, 9);
            Console.WriteLine("Double output \t"+a);
            Console.WriteLine("Integer output \t" + b);
            Console.ReadLine();
        }
    }

    public class Genericexmp <T>
    {
        public T output(T t1,T t2)
        {
            dynamic a = t1;
            dynamic b = t2;

            return a + b;
        }
    }

}
