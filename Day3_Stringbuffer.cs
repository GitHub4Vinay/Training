using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrngStringBuilder
{
    class Program
    {
        static void Main(string[] args)
        {

            string s1 = "vinay";
            s1 += " kumar";
            s1 += " irving";
            StringBuilder s2 = new StringBuilder("IMCS");
            s2.Append(" Group");
            s2.Append(" inc");

            Console.WriteLine(s1+"\n");
            Console.WriteLine(s2.ToString());
            Console.ReadLine();
        }
    }
}
