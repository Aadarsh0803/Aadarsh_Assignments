using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    internal class oddeven5
    {
        static void Main()
        {
            Console.Write("Enter size: ");
            int size = int.Parse(Console.ReadLine());
            int[] arr = new int[size];
            int odd=0, even=0;
            for (int i = 0; i < size; i++)
            {
                Console.Write("Enter Element"+(i+1)+": ");
                arr[i] = int.Parse(Console.ReadLine());

            }
            Console.WriteLine($"[{string.Join(",", arr)}]");
            for (int i = 0; i < size; i++)
            {
                if (arr[i] % 2 == 0)
                {
                    odd++;
                }
                else
                {
                    even++;
                }
            }Console.WriteLine("Even nos: " + even + "\nOdd nos: " + odd); 
        }
    }
}
