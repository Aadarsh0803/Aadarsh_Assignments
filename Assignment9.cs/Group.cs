using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment9.cs
{
    internal class Order1
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime Date { get; set; }
        public int Quantity { get; set; }
        public override string ToString()
        {
            return $"Id: {Id} Name: {Name} Date: {Date} Quantity: {Quantity}";
        }
        public static void Main()
        {
            List<Order1> orders = new List<Order1>()
        {
            new Order1(){Id = 1,Name = "Adarsh", Date = new DateTime(2003,12,23),Quantity = 5},
            new Order1(){Id = 1,Name = "Jashwanth", Date = new DateTime(2024,1,3),Quantity = 15},
            new Order1(){Id = 1,Name = "Surendra", Date = new DateTime(2009,6,17),Quantity = 52},
            new Order1(){Id = 1,Name = "Vastav", Date = new DateTime(2010,8,9),Quantity = 15},
            new Order1(){Id = 1,Name = "Sudheer", Date = new DateTime(2006,2,5),Quantity = 24},
            new Order1(){Id = 1,Name = "Sai", Date = new DateTime(1996,6,29),Quantity = 35},
            new Order1(){Id = 1,Name = "Rohith", Date = new DateTime(1999,10,15),Quantity = 28},
            new Order1(){Id = 1,Name = "Sanjay", Date = new DateTime(2000,11,21),Quantity = 52},
            new Order1(){Id = 1,Name = "Sridheer", Date = new DateTime(2015,3,26),Quantity = 12},
            new Order1(){Id = 1,Name = "Mani", Date = new DateTime(2008,12,21),Quantity =10},
            new Order1(){Id = 1,Name = "Chaitanya", Date = new DateTime(2023,1,6),Quantity = 19},
        };
            
            var groupedOrders = orders.OrderByDescending(o => o.Date).GroupBy(o => new { o.Date.Year, o.Date.Month })
     .OrderByDescending(g => g.Key.Year).ThenByDescending(g => g.Key.Month);

            Console.WriteLine("\nOrders grouped by month (most recent to least recent):");
            foreach (var group in groupedOrders)
            {
                Console.WriteLine($"\nMonth: {group.Key.Month}, Year: {group.Key.Year}");
                foreach (var order in group)
                {
                    Console.WriteLine(order);
                }
            }
        }
    }

}
