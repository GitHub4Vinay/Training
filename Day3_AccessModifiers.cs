using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessModifiers
{
   public  class Am1
            {
                private int id;
                public string firstname;
                protected string lastname;

        public Am1()
        {
            id = 10;
           // Console.WriteLine(id);

        }

    }
    public class Am2 : Am1
    {
        
      public  Am2()
        {
            lastname = "KKK";
                           
            Console.WriteLine("Protected Access Modifier: "+ lastname);
        }
        
    } 
    


    class Program
    {
        static void Main(string[] args)
        {
            Am1 V1 = new Am1();
            V1.firstname = "vinay";
            Am2 v2 = new Am2();
            
           
            Console.WriteLine("Public Access Modifier : " + V1.firstname);
           
            Console.ReadLine();
        }
    }
}
