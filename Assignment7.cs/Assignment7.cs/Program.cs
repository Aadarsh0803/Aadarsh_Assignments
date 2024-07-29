namespace Assignment7.cs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            List<int> list = new List<int>();
            for (int i = 0; i < 4; i++)
            {
                Console.Write("Enter value " + (i + 1));
                list.Add(int.Parse(Console.ReadLine()));
            }
            list.Sort();
            Console.WriteLine(string.Join(", ", list));

        }
    }
}
