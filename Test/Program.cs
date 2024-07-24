namespace Aadarsh_Assignment1
{
    //qstn 1
    internal class Program
    {
        static void Main(string[] args)
        {
            double deposite = 1000D;
            double intrest = 0.05;
            double newDeposite;
            int years = 0;
            while (deposite < 100000)
            {
                years += 1;
                newDeposite = deposite+(deposite * intrest);
                deposite = newDeposite;
             
            } 
            Console.WriteLine(years);
        }
    }
}
