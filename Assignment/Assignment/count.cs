using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Assignment
{
    internal class count
    {
        static void Main()
        {
            Console.WriteLine("Enter no:");
            int s = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[s];
            Console.WriteLine("Enter arr elements:");
            for (int i = 0; i < s; i++) {
                
                    Console.Write($"Enter element {i + 1}: ");
                    arr[i] = int.Parse(Console.ReadLine());
                
            }
            Console.WriteLine($"[{string.Join(", ", arr)}]");
          //  for(int)

        }
    }
}
