namespace Assignment9.cs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> l = new List<int>() { 1,2,3,4,5,6,7,8,9,10,11,12};
            var q = from item in l
                    let a = item*item*item
                    where a>100 && a<1000
                    select a;
            Console.WriteLine("Cubes Greater than 100 and less than 1000:");
            foreach ( var a in q )
            {
                Console.WriteLine( a );
            }
        }
    }
}
