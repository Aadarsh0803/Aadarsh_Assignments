using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace Assignment8
{
    public class Error
    {
  /*     public void create(string path)
        {
            File.Create(path);
        }*/
        public void Prog(string path)
        {
            try
            {
                int a, b;
                Console.WriteLine("Enter A and B values: ");
                a = int.Parse(Console.ReadLine());
                b = int.Parse(Console.ReadLine());
                int c = a / b;
                Console.WriteLine(c);
            }
            catch (Exception e)
            {
                File.AppendAllText(path, Environment.NewLine +e.Message);
            }
        }
    }
    internal class Errormessage
    {
        public static void Main()
        {
            Error error = new Error();
            //error.create("D:\\Work\\Aadarsh_Assignments\\Aadarsh_Assignments");
            error.Prog("D:\\Work\\Aadarsh_Assignments\\Aadarsh_Assignments\\practice3.txt");
        }
    }
}
