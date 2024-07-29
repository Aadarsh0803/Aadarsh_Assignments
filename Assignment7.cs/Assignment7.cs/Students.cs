using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment7.cs
{
    internal class Students
    {
        public static void Main()
        {
            List<string> strings = new List<string>();
            strings.Add("Suhas");
            strings.Add("Aadarsh");
            strings.Add("Venkat");
            strings.Add("Raghava");
            strings.Add("Abhilash");
            strings.Add("Sandeep");
            strings.Add("Omkar");
            strings.Add("Sathvik");
                      
            strings.Sort();
            strings.Reverse();
            Console.WriteLine(string.Join(", ",strings));
        }
    }
}
