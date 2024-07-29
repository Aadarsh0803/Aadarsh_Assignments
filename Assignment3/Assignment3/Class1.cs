using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    internal class Online
    {
        public string name { get; set; }
        public string title { get; set; }
        public string author { get; set; }
        public int quantity { get; set; }
        public int price { get; set; }
        public double result { get; set; }

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
            result = quantity * price;
        }
        public void Show()
        {
            
            Console.WriteLine($"Name: {name}\nTitle {title}\nAuthor:{author}\nQuantity: {quantity}\nPrice: {price}");
        }
        public void Main()
        {
            Accept();
            Show();
            Console.WriteLine("Total Price : " + (result));

        }
    }
}
