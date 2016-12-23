using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day1Switch
{
    class Program
    {
        static void Main(string[] args)
        {
         Start:
            int i;
            string day,option;
            Console.WriteLine("Enter Day Number: ");
            i = Convert.ToInt32(Console.ReadLine());
            switch (i)
            {
                case 0:
                    day = "Sunday";
                    break;
                case 1:
                    day = "Monday";
                    break;
                case 2:
                    day = "Tuesday";
                    break;
                case 3:
                    day = "Wednesday";
                    break;
                case 4:
                    day = "Thurday";
                    break;
                case 5:
                    day = "Friday";
                    break;
                case 6:
                    day = "Saturday";
                    break;
                default:
                    day = "Not a valid number";
                    break;
                    
            }
            Console.WriteLine("it's {0}",day);
            Console.WriteLine("select YES to Continue NO to Quit");
            option = Console.ReadLine();
            switch(option)
            {
                case "YES":
                    goto Start;
                case "NO":
                    break;
                default:
                    break;
            }
            Console.ReadLine();
        }
    }
}
