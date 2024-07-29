using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4
{
    class Bookself
    {
        public int bid;
        string bname;
        string bauthor;
        int bprice;
        int bquantity;
        int total;
        int Bid
        {
            get { return bid; }
            set { bid = value; }
        }
        string Bname

        {
            get { return bname; }
            set { bname = value; }
        }
        string Bauthor
        {
            get { return bauthor; }
            set { bauthor = value; }

        }
        int Bprice
        {
            get { return bprice; }
            set { bprice = value; }
        }
        int Bquantity
        {
            get { return bquantity; }
            set { bquantity = value; }
        }

        public void show()
        {
            Console.WriteLine("book id is " + bid);
            Console.WriteLine("book name is " + bname);
            Console.WriteLine("book author is " + bauthor);
            Console.WriteLine("book price is " + bprice);

            Console.WriteLine("total price is  " + (bquantity * bprice));

        }
        internal class A5
        {
            static void Main()
            {
                Console.WriteLine("enter book id");
                int bid = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("enter book price");
                int bprice = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("enter book name");
                string bname = Console.ReadLine();
                Console.WriteLine("enter book author");
                string bauthor = Console.ReadLine();
                Console.WriteLine("enter book quantity");
                int bquantity = Convert.ToInt32(Console.ReadLine());

                Bookself b = new Bookself();
                b.Bid = bid;
                b.Bprice = bprice;
                b.Bauthor = bauthor;
                b.Bname = bname;
                b.Bquantity = bquantity;


                b.show();
            }

        }
    }

}