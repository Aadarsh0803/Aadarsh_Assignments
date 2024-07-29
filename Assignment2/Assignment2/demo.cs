using System;

public class Student
{
    // Data members
    public int RollNo { get; set; }
    public string Name { get; set; }
    public string Class { get; set; }
    public int Sem { get; set; }
    public string Branch { get; set; }
    public int[] Marks { get; set; }
    

    // Constructor
    public Student(int rollNo, string name, string className, int sem, string branch, int[] marks)
    {
        RollNo = rollNo;
        Name = name;
        Class = className;
        Sem = sem;
        Branch = branch;
        Marks = marks;
    }

    // Method to display result
    public void DisplayResult()
    {
        double average = 0;
        foreach (int mark in Marks)
        {
            if (mark < 35)
            {
                Console.WriteLine("Result: Failed");
                return;
            }
            average += mark;
        }

        average /= Marks.Length;

        if (average < 50)
        {
            Console.WriteLine("Result: Failed");
        }
        else
        {
            Console.WriteLine("Result: Passed");
        }
    }

    // Method to display data
    public void DisplayData()
    {
        Console.WriteLine($"Roll No: {RollNo}");
        Console.WriteLine($"Name: {Name}");
        Console.WriteLine($"Class: {Class}");
        Console.WriteLine($"Semester: {Sem}");
        Console.WriteLine($"Branch: {Branch}");
        Console.WriteLine("Marks: " + string.Join(", ", Marks));
    }
}

// Example usage
public class Program
{
    public static void Main()
    {
        int[] marks = { 40, 50, 60, 70, 80 };
        Student student = new Student(1, "John Doe", "10th", 1, "Science", marks);

        student.DisplayData();
        student.DisplayResult();
    }
}