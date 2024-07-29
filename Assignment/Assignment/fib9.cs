using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    internal class fib9
    {
        static void Main()
        {
            int n, n1=0,n2=1, num;
            Console.Write("Enter no: ");
            num = Convert.ToInt32(Console.ReadLine());
            Console.Write(n1 +" "+ n2 + " ");
            for (n = 2; n < num; n++) {
                n = n1 + n2;
                Console.Write(n + " ");
                n1 = n2;
                n2 = n;
            }
        }
    }
}
