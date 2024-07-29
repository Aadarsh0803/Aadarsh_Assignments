using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment8
{
    public class Car
    {
        public void Write(string path)
        {
            
            using (StreamWriter sw = new StreamWriter(path, true))
            {
                
            Console.WriteLine("Enter Car Model: ");
            string Car = Console.ReadLine();
            Console.WriteLine("Enter Year of Making: ");
            DateTime yom = DateTime.Parse(Console.ReadLine());
            sw.WriteLine($"Car Name: {Car}\nYear of Making: {yom}");
            }
        }
    }
    internal class Car2
    {
        public static void Main(string[] args)
        {
            string path = "D:\\Work\\Aadarsh_Assignments\\Aadarsh_Assignments\\practice2";
            Car car = new Car();
            car.Write(path);
        }
    }
}
