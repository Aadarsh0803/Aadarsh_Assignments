using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionsAssignment
{
    internal class Employee
    {
        static void Main(string[] args)
        {
            SortedDictionary<int, string> employees = new SortedDictionary<int, string>();


            employees.Add(1003, "Aadarsh");
            employees.Add(1005, "Jaswanth");
            employees.Add(1004, "Sai");
            employees.Add(1001, "sri Vastav");
            employees.Add(1002, "Sridhar");


            Console.WriteLine("Employee List:");
            foreach (var employee in employees)
            {
                Console.WriteLine($"Employee Code: {employee.Key}, Employee Name: {employee.Value}");
            }
        }
    }
}