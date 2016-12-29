using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ExceptionsEx
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader s = null;
            s= new StreamReader(@"C:\Drivers\vinay.txt");
        
            string fi = s.ReadToEnd();
           
            char[] charray = new char[10];
          
            int j = 0;
            try
            {
                for (int i = 0; i < fi.Length; i++)
                {

                    char a = fi[i];
                    charray[j] = a;
                    j++;
                }
            }
            catch(IndexOutOfRangeException ex1)
            {
                Console.WriteLine("Please check the size of the array");
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);

            }
            finally
            {
                if (s != null)
                    s.Close();
            }
            Console.WriteLine("Inserted Elements");
            for (int b=0; b<charray.Length;b++)
            {
                Console.WriteLine(charray[b]);
            }
            Console.ReadLine();
        }
    }
}
