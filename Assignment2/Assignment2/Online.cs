using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    internal class Online
    {
        string name, title, author;
        int quantity, price;
        double result;

        public void Accept()
        {
            Console.WriteLine("Enter Name of the book: ");
            name = Console.ReadLine();
            Console.WriteLine("Enter Title of the book: ");
            title = Console.ReadLine();
            Console.WriteLine("Enter Name of the Author: ");
            author = Console.ReadLine();
            Console.WriteLine("Enter Quantity: ");
            quantity = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter price: ");
            price = int.Parse(Console.ReadLine());
        }
        public void Main()
        {
            Accept();
            Console.WriteLine("Total Price : " + (quantity * price));

        }
    }
}
