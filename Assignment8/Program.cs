namespace Assignment8
{
     class Program1
    {
        public void Write1(string path)
        {
            Console.WriteLine("enter Text to add in a file: ");
            string a = Console.ReadLine();
            File.AppendAllText(path, a);
        }
        internal class Program
        {
            static void Main(string[] args)
            {
                try { 
                    Program1 program = new Program1();
                program.Write1("D:\\Work\\Aadarsh_Assignments\\Aadarsh_Assignments\\practice.txt");
                }
                catch (IOException ex)
                {

                    Console.WriteLine(ex.Message);
                }
            }
        }
    }
}
