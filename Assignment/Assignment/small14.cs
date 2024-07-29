using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    internal class small14
    {
        static void Main()
        {
            
            int[] a = new int[5];
            
            for (int i = 0; i < 5; i++)
            {
                Console.Write("enter " + i + " value: ");

                a[i] = Convert.ToInt32(Console.ReadLine());

            }Array.Sort(a);
            Console.WriteLine(a[0]);
        }
    }
}
