using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Assignment2
{
    internal class Student
    {
        int rollNo, clas, sem;
        string name, branch;
         int[] marks = new int[5];


        public Student(int rollNo, int clas, int sem, string name, string branch)
        {
            this.rollNo = rollNo;
            this.clas = clas;
            this.sem = sem;
            this.name = name;
            this.branch = branch;
           
        }

        public void DisplayResult()
        {
            double average = 0;
            int sum = 0;
            bool flag = false;

            foreach (int mark in marks)
            {
                if (mark < 35)
                {
                    flag = true;
                    
                }
                sum += mark;
            }
            average = sum / 5;
            if (flag)
            {
                Console.WriteLine("Result = Failed");
            }

            else if (average < 50)
            {
                Console.WriteLine("Result: Failed");
            }
            else
            {
                Console.WriteLine("Result: Passed");
            }
        }

        public void DisplayData()
        {
            Console.WriteLine($"Roll No: {rollNo} Name: {name} Class: {clas} Semester: {sem} Branch: {branch}");
            Console.WriteLine("Marks: " + string.Join(", ", marks));
        }
        public void details()
        {


            for (int i = 0; i < 5; i++)
            {
                    Console.WriteLine("Please enter student " + (i + 1) + " marks: ");
                    marks[i] = int.Parse(Console.ReadLine());
            }
        }


        public static void Main()
        {
            int rollno = int.Parse(Console.ReadLine());
            int clas = int.Parse(Console.ReadLine());
            int sem = int.Parse(Console.ReadLine());
            string name = Console.ReadLine();
            string branch = Console.ReadLine();            
            Student student = new Student(rollno, clas, sem,name , branch);
            student.details();
            student.DisplayData();
            student.DisplayResult();
            
        }
    }
}
