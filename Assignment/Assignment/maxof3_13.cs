using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    internal class maxof3_13
    {
        static void Main()
        {
            Console.WriteLine("Enter no1:");
            int no1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter no2:");
            int no2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter no3:");
            int no3 = int.Parse(Console.ReadLine());
            if(no1 > no2 && no1 > no3)
            {
                Console.WriteLine(no1);
            }
            else if (no2 > no3 && no2 > no1)
            {
                Console.WriteLine(no2);
            }
            else
            {
                Console.WriteLine(no3);
            }
        }
    }
}
