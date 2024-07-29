using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    internal class temp
    {
        static void Main()
        {
            Console.Write("Enter temperature in farenheit: ");
            float tempe = Convert.ToSingle(Console.ReadLine());
            float far = (tempe - 32) * 5 / 9;
            Console.WriteLine("temperature in celcius: "+ far);
        }
    }
}
