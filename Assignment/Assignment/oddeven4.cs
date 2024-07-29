using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    internal class oddeven4
    {
        static void Main()
        {
            Console.Write("Enter no:");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine( n % 2 == 0 ? "even" : "odd");
        }
    }
}
