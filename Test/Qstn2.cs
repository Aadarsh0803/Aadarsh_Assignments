using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aadarsh_Assignment1
{
    internal class Qstn2
    {
        public static void Main()
        {
            int[,] mat = new int[3,3];
            try
            {

                for (int i = 0; i < 3; i++)
                {
                    for (int j = 0; j < 3; j++)
                    {
                        Console.Write($"Enter {i} {j} value");
                        mat[i, j] = int.Parse(Console.ReadLine());
                    }
                }

                for (int i = 0; i < 3; i++)
                {
                    for (int j = 0; j < 3; j++)
                    {
                        Console.Write(mat[i, j] + " ");
                    }
                    Console.WriteLine();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

        }
    }
}
