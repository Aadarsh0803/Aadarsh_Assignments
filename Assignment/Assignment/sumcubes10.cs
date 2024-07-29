using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    internal class sumcubes10
    {
        static void Main()
        {
            Console.Write("Enter a No:");
            int no = int.Parse(Console.ReadLine());
            int su = 0;
            for (int i = 0; i <= no; i++) {
                su += i * i * i;
            }Console.WriteLine(su);
        }
    }
}
