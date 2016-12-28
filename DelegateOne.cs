using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExDeligate
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Customer> c = new List<Customer>();
            c.Add(new Customer() { id = 1, fname = "vinay", lname = "kumar" });
            c.Add(new Customer() { id = 2, fname = "vin", lname = "ku" });
            Customer c1 = new Customer()
            {
                id = 3,
                fname = "vvv",
                lname = "kkk"

            };

            c.Add(c1);
            dprint d1 = new dprint(isprint);

          
            Customer.print(c,d1);


            dvinayprint dv = new dvinayprint(Vinay.Vinayprint);
            dv("vinay");
            Console.ReadLine();
            
        }
        public static bool isprint(Customer cust)
        {
            if (cust.id > 1)
                return true;
            else
                return false;
        }
    }

    class Customer
    {
        public int id { get; set; }
        public string fname { get; set; }
        public string lname { get; set; }
        public static void print(List<Customer> cus,dprint dp)
        {

            foreach(Customer member in cus)
            {

                if (dp(member))
                {
                    Console.WriteLine(member.id);
                }
            }
        }
    }
    class Vinay
    {
        public static void Vinayprint(string message)
        {
            Console.WriteLine(message);
        }
    }

     delegate bool dprint(Customer customer);
    public delegate void dvinayprint(string s);
}
