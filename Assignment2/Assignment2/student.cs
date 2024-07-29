using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    internal class Student1
    {
        int RollNo;
        string StudName;
        int MarksInEng;
        int MarksInMaths;
        int MarksInScience;
        Student1(int RollNo, string StudName, int MarksInEng, int MarksInMaths, int MarksInScience)
        {
            this.RollNo = RollNo;
            this.StudName = StudName;
            this.MarksInEng = MarksInEng;
            this.MarksInMaths = MarksInMaths;
            this.MarksInScience = MarksInScience;
        }
        void display()
        {
            Console.WriteLine(this.RollNo);
            Console.WriteLine(this.StudName);
            int total = this.MarksInScience + this.MarksInEng + this.MarksInMaths;
            Console.WriteLine("Total marks " + total);
            double per = (total * 100) / 300;
            Console.WriteLine($"Percentage of {this.StudName} is {per}%");


        }
        static void Main()
        {
            Student1 s1 = new Student1(103, "Aadarsh", 75, 90, 93);
            s1.display();
        }
    }
}