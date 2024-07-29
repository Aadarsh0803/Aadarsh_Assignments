using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    internal class intrest
    {
        public static void Main()
        {

            double amount = 915.00;
            Console.Write("Enter payment:");

            double payments = double.Parse(Console.ReadLine());
            int i = 1;
            while(amount >= 0)
            {
                Console.WriteLine($"Month = {i} Balance = {amount} total payments = {payments * i}");
                amount = Balance(amount) -payments;
                i++;
            }
            double Balance(double balance)
            {
                balance = ((balance + (balance * 0.015)));
                return balance;
            }
        }
    }
}
