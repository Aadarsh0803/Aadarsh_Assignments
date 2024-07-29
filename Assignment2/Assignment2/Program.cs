using System;
using System.ComponentModel.DataAnnotations;
using System.Security.Principal;

namespace Assignment2
{
    public class Account
    {
        private string name;
        private int accountNo;
        private decimal balance ;
        private string accountType;
        private int debit, withdraw, amount, choice;

        public void Accept()
        {
            Console.WriteLine("Enter Account holder name:");
            name = Console.ReadLine();
            Console.WriteLine("Enter Account NO:");
            accountNo = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Account Type:");
            accountType = Console.ReadLine();
            Console.WriteLine("Enter your Balance:");
            balance = Decimal.Parse(Console.ReadLine()); 
            Console.WriteLine("To credit press 1 or To debit Press 2");
            choice = int.Parse(Console.ReadLine());
        }

        public void Trans(int choice,  decimal balance) 
        {
            if (choice == 1)
            {
                Console.WriteLine("Enter amount to credit: ");
                amount = int.Parse(Console.ReadLine());
                balance = balance + amount;
            }
            else
            {
                Console.WriteLine("Enter amount to Debit: ");
                amount = int.Parse(Console.ReadLine());
                balance = balance - amount;
            }
        }

        public void Show()
        {
            Console.WriteLine($"Your Bank balance is : {    balance}");
        }

        public static void Main()
        {
            Account account = new Account();
            account.Accept();
           // decimal balance;
            account.Trans(account.choice,  account.balance); 
            account.Show();

            Account account2 = new Account();
            account2.Accept();
            //decimal balance1;
            account2.Trans(account2.choice, account2.balance); 
            account2.Show();
        }
    }
}
