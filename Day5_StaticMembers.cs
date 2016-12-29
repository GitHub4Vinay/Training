using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticDemo
{
    class Program
    {
        static float i ;
        public int a;
        void print()
        {
            Console.WriteLine("Instance method Print ");
        }
        static void print1()
        {
            Console.WriteLine("Static method Print");
        }

        static void Main(string[] args)
        {
            i = 0.156f;
            Program p = new Program();
            p.a = 15;
            p.print();                              // Instance Method
            Program.print1();                       // static method call

            StaticEx se = new StaticEx();
            se.km = 100.65f;
            float result= StaticEx.convert(se.km); //public static method in another class
            
            
            Console.WriteLine(StaticEx.GetName);
            Console.WriteLine("KM "+result);

            
            Console.ReadLine();

        }
    }

    class StaticEx
    {
      static float f=1.609f;
      public float km;
        
      public static float convert(float miles)
        {
            return f * miles;
        }

        static float convert1(float miles)
        {
            return miles;
        }
        void print()
        {
            Console.WriteLine("Sample");
        }

        public static string GetName
        {
            get
            {
                return "Vinay";
            }
        }

         public static int GetID
        {
            set;get;
                      
           
        }
    }
}
