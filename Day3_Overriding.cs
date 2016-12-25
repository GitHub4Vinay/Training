using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Overriding
{

   
    class Oldemployee 
    {
        protected double sal, bonus;
        public  virtual double ar(double a)
        {
            sal = a;
            bonus = sal * 0.25;
            return bonus;
        }  
            
    }
    class Newemployee : Oldemployee
    {
        public override double ar(double a)
        {
            sal = a;
            bonus = sal * 0.10;
            return bonus;

        }
        
    }
    


    class Program
    {
        static void Main(string[] args)
        {
             Oldemployee e1 = new Newemployee();
             e1.ar(1000.00);
             Console.WriteLine("Bonus to New Employee "+e1.ar(1000.00));
             Console.ReadLine();

            
        }
    }
}
