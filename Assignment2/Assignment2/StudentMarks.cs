using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    internal class StudentMarks
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
            result = quantity * price;
            Console.WriteLine("Total Price : " + result);
        }
      /*  public void Display()
        {
            result = quantity * price;
            Console.WriteLine("Total Price : " + result);
        }*/
        static void Main()
        {
            StudentMarks studentMarks = new StudentMarks();
            studentMarks.Accept();
            //studentMarks.Display();
        }
    }
}
