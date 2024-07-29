using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    internal class mark15
    {
        static void Main()
        {
            int[] a = new int[10];
            int total = 0;

            for (int i = 0; i < 10; i++)
            {
                Console.Write("enter " + i + " value: ");

                a[i] = Convert.ToInt32(Console.ReadLine());
                total += a[i];
            }
            Console.WriteLine("Total: "+total);
            Console.WriteLine("Average: " + total / 10);
            Array.Sort(a);
            Console.WriteLine("Minimum Marks: " + a[0]);
            Console.WriteLine("Maximum Marks: " + a[9]);
            Console.WriteLine("Marks in Ascending: " + $"[{string.Join(",",a)}]");
            Array.Reverse(a);
            Console.WriteLine("Marks in Descending: " + $"[{string.Join(",",a)}]");

            
        }
    }
}
