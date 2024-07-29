using System;
using System.Collections.Generic;

namespace ExtraAss
{
    internal class Program
    {

        public delegate bool DivisibleByThreeDelegate(int number);

        static void Main(string[] args)
        {
            List<int> NumList = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12 };


            DivisibleByThreeDelegate isDivisibleByThree = IsDivisibleByThree;

            Console.WriteLine("Numbers divisible by 3:");
            foreach (int num in NumList)
            {
                if (isDivisibleByThree(num))
                {
                    Console.WriteLine(num);
                }
            }
        }


        public static bool IsDivisibleByThree(int number)
        {
            return number % 3 == 0;
        }
    }
}
