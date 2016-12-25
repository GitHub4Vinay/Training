using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int i=0,j=0;
            int[] arr1 = new int[8];
            ArrayList arrls1 = new ArrayList();
            arrls1.Add(6);
            arrls1.Add("vinay");
            arrls1.Add("IMCS");
            arrls1.Add(10.0);

            Hashtable h1 = new Hashtable();
            h1.Add(1, "kumar");
            h1.Add(2,"vinay");
            h1[10] = "IMCS";
            h1[4] = "";
            
           

            while (i < arr1.Length)
            {
                arr1[i] = i+2;
                i++;
            }
            Console.WriteLine("Array Elements: ");
            foreach (int element in arr1)
            {
                Console.WriteLine(element);
            }
            Console.WriteLine();
            Console.WriteLine("ArrayList Elements: ");
            for (j=0;j<arrls1.Count;j++)
            {
                Console.WriteLine(arrls1[j]);
            }


            Console.WriteLine("HashTable Count: " + h1.Count);
            Console.WriteLine("HashTable Keys: ");
            foreach (int vi in h1.Keys)
            {
                Console.WriteLine(vi);
            }
            Console.WriteLine("HashTable Values: ");
            foreach (string vi in h1.Values)
            {
                Console.WriteLine(vi);
            }

            Console.ReadLine();
        }
    }
}
