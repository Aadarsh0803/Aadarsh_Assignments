using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment9.cs
{
    internal class EvenCount9
    {
        internal class Order
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public DateTime Date { get; set; }
            public int Quantity { get; set; }
            public override string ToString()
            {
                return $"Id: {Id} Name: {Name} Date: {Date} Quantity: {Quantity}";
            }
        }
        internal class item
        {
            public string Name { get; set; }
            public int Price { get; set; }
        }
        internal class nos
        {
            public int no { get; set; }
        }
        public static void Main()
        {
            List<Order> orders = new List<Order>()
        {
            new Order(){Id = 1,Name = "Adarsh", Date = new DateTime(2003,12,23),Quantity = 5},
            new Order(){Id = 2,Name = "Jashwanth", Date = new DateTime(2024,1,3),Quantity = 15},
            new Order(){Id = 3,Name = "Surendra", Date = new DateTime(2009,6,17),Quantity = 53},
            new Order(){Id = 4,Name = "Vastav", Date = new DateTime(2010,8,9),Quantity = 15},
            new Order(){Id = 5,Name = "Sudheer", Date = new DateTime(2006,2,5),Quantity = 24},
            new Order(){Id = 6,Name = "Sai", Date = new DateTime(1996,6,29),Quantity = 35},
            new Order(){Id = 7,Name = "Rohith", Date = new DateTime(1999,10,15),Quantity = 28},
            new Order(){Id = 8,Name = "Sanjay", Date = new DateTime(2000,11,21),Quantity = 52},
            new Order(){Id = 9,Name = "Sridheer", Date = new DateTime(2015,3,26),Quantity = 12},
            new Order(){Id = 10,Name = "Mani", Date = new DateTime(2008,12,21),Quantity =10},
            new Order(){Id = 11,Name = "Chaitanya", Date = new DateTime(2023,1,6),Quantity = 19},
        };
            List<item> it = new List<item>()
            {
                new item(){Name = "Pen", Price = 5},
                new item(){Name = "Pencil", Price = 5},
                new item(){Name = "sketch", Price = 5},
                new item(){Name = "Box", Price = 5},
                new item(){Name = "Bag", Price = 5},

            };
            List<nos> nos = new List<nos>()
            {
                new nos(){ no = 1},
                new nos(){ no = 2},
                new nos(){ no = 3},
                new nos(){ no = 4},
                new nos(){ no = 5},
                new nos(){ no = 6},
                new nos(){ no = 7},
            };
            int q = (from i in nos
                    
                    where i.no%2 == 0
                    
                select i).Count();
           
                Console.WriteLine(q);
            
        }
    }
}
