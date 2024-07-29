using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    internal class sameword18
    {
        static void Main()
        {
            Console.Write("Ënter a word1: ");
            string word1 = Console.ReadLine();
            Console.Write("Enter a word2: ");
            string word2 = Console.ReadLine();
            bool Flag = false;
            if (word1 == word2) {
               Flag = true; 
            }
            if (Flag)
            {
                Console.WriteLine("True");
            }
            else
            {
                Console.WriteLine("False");
            }
        }
    }
}
