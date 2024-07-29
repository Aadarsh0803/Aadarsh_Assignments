using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    internal class div7_12
    {
        static void Main()
        {
            Console.WriteLine("Nos div by 7:");
            for (int i = 200; i <= 300; i++)
            {
                if (i % 7 == 0)
                {
                    Console.Write(i + "  ");
                }
            }
        }
    }
}
