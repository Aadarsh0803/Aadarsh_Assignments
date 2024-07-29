namespace ExtraAssignments.cs
{
    internal class Program
    {
        public static void Main()
        {
            Console.WriteLine("Enter Amount: ");
            double amount = double.Parse(Console.ReadLine());
            Console.Write("Enter payment:");

            double payments = double.Parse(Console.ReadLine());
            int i = 1;
            while (amount >= 0)
            {
                Console.WriteLine($"Month = {i} Balance = {amount} total payments = {payments * i}");
                amount = Balance(amount) - payments;
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
