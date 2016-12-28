using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InInterface
{

    interface IPublish
    {
        void ConsolePrint();

    }

    interface IAdd
    {
        
        int add(int a,int b);

    }
    class Addition :IPublish,IAdd
    {
        public void ConsolePrint()
        {
            Console.WriteLine("Addition Result");
        }
        public int add(int a, int b)
        {
            return a + b;
        }
    }

    public abstract class abs1
    {
        
        int c=6;
        public abstract void display();
        public int product(int a,int b)
        {
            return a * b*c;
        }

    }
    class Program :abs1
    {
        public override void display()
        {
            Console.WriteLine("Multiplication Result");
        }
        static void Main(string[] args)
        {
            Addition m1 = new Addition();
            m1.ConsolePrint();
           int a= m1.add(3, 4);
            Console.WriteLine(a);
            

            Program p1 = new Program();
           
            int result= p1.product(2, 3);
            p1.display();

            Console.WriteLine(result);
           
            Console.ReadLine();
        }
    }
}
