using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace Assignment
{
    internal class nos3
    {
        static void Main()
        {
            Console.Write("Enter no 1:");
            int no1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter no 2:");
            int no2 = Convert.ToInt32(Console.ReadLine());
            for (int i = no1; i <= no2; i++)
            {
                Console.Write(i + " ");

            }
        }
    }
}
