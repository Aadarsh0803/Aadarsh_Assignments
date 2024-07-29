using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment9.cs
{
    internal class Order
    {
        public int Id {  get; set; }
        public string Name { get; set; }
        public DateTime Date { get; set; }
        public int Quantity { get; set; }
        public override string ToString()
        {
            return $"Id: {Id} Name: {Name} Date: {Date} Quantity: {Quantity}";
        }
        public static void Main()
        {



            List<Order> orders = new List<Order>()
        {
            new Order(){Id = 1,Name = "Adarsh", Date = new DateTime(2003,12,23),Quantity = 5},
            new Order(){Id = 1,Name = "Jashwanth", Date = new DateTime(2024,1,3),Quantity = 15},
            new Order(){Id = 1,Name = "Surendra", Date = new DateTime(2009,6,17),Quantity = 52},
            new Order(){Id = 1,Name = "Vastav", Date = new DateTime(2010,8,9),Quantity = 15},
            new Order(){Id = 1,Name = "Sudheer", Date = new DateTime(2006,2,5),Quantity = 24},
            new Order(){Id = 1,Name = "Sai", Date = new DateTime(1996,6,29),Quantity = 35},
            new Order(){Id = 1,Name = "Rohith", Date = new DateTime(1999,10,15),Quantity = 28},
            new Order(){Id = 1,Name = "Sanjay", Date = new DateTime(2000,11,21),Quantity = 52},
            new Order(){Id = 1,Name = "Sridheer", Date = new DateTime(2015,3,26),Quantity = 12},
            new Order(){Id = 1,Name = "Mani", Date = new DateTime(2008,12,21),Quantity =10},
            new Order(){Id = 1,Name = "Chaitanya", Date = new DateTime(2023,1,6),Quantity = 19},
        };
            Console.WriteLine("Order by Date: ");
            var j = from n in orders
                    orderby n.Date descending
                    select n;
            foreach (var o in j)
            {
                Console.WriteLine(o.Name + " " + o.Date);
            }
            Console.WriteLine();
            Console.WriteLine("Order by Quantity: ");
            var i = from n in orders
                    orderby n.Quantity descending
                    select n;
            foreach (var o in i)
            {
                Console.Write(o.Name + " ");
                Console.WriteLine(o.Quantity);
            }
            
        }
    }

}
