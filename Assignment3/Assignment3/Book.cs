using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3
{
    internal class Book
    {
        public string Name { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public int Quantity { get; set; }
        public int Price { get; set; }
        public double Result { get; set; }

        // Method to accept input values
        public void Accept(string Name, string Title, string Author, int Quantity, int Price)
        {
            Console.WriteLine("Enter Name of the book: ");
            Name = Console.ReadLine();
            Console.WriteLine("Enter Title of the book: ");
            Title = Console.ReadLine();
            Console.WriteLine("Enter Name of the Author: ");
            Author = Console.ReadLine();
            Console.WriteLine("Enter Quantity: ");
            Quantity = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter price: ");
            Price = int.Parse(Console.ReadLine());
        }

        // Method to calculate and display the total price
        public void DisplayTotalPrice()
        {
            Result = Quantity * Price;
            Console.WriteLine("Total Price : " + Result);
        }
    }

    class Program1
    {
        static void Main(string[] args)
        {
            // Create an instance of the Online class
            Online online = new Online();

            // Call the Accept method to input data
            online.Accept(online.Name, online.Title, online.Author, online.Quantity, online.Price);

            // Call the DisplayTotalPrice method to calculate and show the total price
            online.DisplayTotalPrice();
        }
    }
}
