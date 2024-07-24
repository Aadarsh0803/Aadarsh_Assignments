using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace Aadarsh_Assignment1
{
    class Car()
    {
        public string Model;
        public DateTime YOM;

        public void Accept()
        {
            Console.WriteLine("Enter Model Name: ");
            //Car c = new Car();
            Model = Console.ReadLine();
            Console.WriteLine("Enter Date of Making:");
            YOM = DateTime.Parse(Console.ReadLine());
        }

        public string Display()
        {
            return $"Mode: {Model} Year of Making: {YOM}";
            Console.WriteLine($"Mode: {Model} Year of Making: {YOM}");
        }
    }

    internal class qstn3
    {
        public static void Main()
        {
            try
            {
                Car c = new Car();
                string filePath = Console.ReadLine();
                
                c.Accept();
                c.Display();
            } catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
