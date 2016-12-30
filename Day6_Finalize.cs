using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorEx
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer C1 = new Customer(20,"Vinay");
            Console.WriteLine(C1.ID +"  "+ C1.Name);

            Customer C2 = new Customer();
            C2.ID = 100;
            C2.Name = "Kumar";

            
            Console.WriteLine(C2.ID +"  "+ C2.Name);
            C1.Method();
           // Console.ReadLine();
        }
        
    }

    class Customer
    {
        private int iD;
        private string name;

        public int ID
        {
            get
            {
                return iD;
            }

            set
            {
                iD = value;
            }
        }

        public string Name
        {
            get
            {
                return name;
            }

            set
            {
                name = value;
            }
        }

    public    Customer(int ID, string Name)
        {
            iD = ID;
            name = Name;
            Console.WriteLine("with parameters");
        }
       public Customer()
        {
            Console.WriteLine("with out parameters");
        }
        public void Method()
        {
            Console.WriteLine("Vinay");
        }

        ~Customer()
        {
            Console.WriteLine("Finalizing Object");
            Console.ReadLine();
        }

    }
}
