using System;
using System.Collections.Generic;

// Define the Student class
public class Student
{
    public int RollNo { get; set; }
    public string Name { get; set; }
    public string Branch { get; set; }

    public override string ToString()
    {
        return $"Roll No: {RollNo}, Name: {Name}, Branch: {Branch}";
    }
}

// Define the interface IStudentRepository
public interface IStudentRepository
{
    List<Student> GetAllStudents();
    void AddStudent(Student student);
    Student GetStudentById(int rollno);
    bool RemoveStudent(int rollno);
    bool UpdateStudent(int rollno, string name, string branch);
}

// Implement the interface in the StudentRepository class
public class StudentRepository : IStudentRepository
{
    private List<Student> students = new List<Student>();

    public void AddStudent(Student student)
    {
        students.Add(student);
    }

    public List<Student> GetAllStudents()
    {
        return students;
    }

    public Student GetStudentById(int rollno)
    {
        return students.Find(student => student.RollNo == rollno);
    }

    public bool RemoveStudent(int rollno)
    {
        Student student = GetStudentById(rollno);
        if (student != null)
        {
            students.Remove(student);
            return true;
        }
        return false;
    }

    public bool UpdateStudent(int rollno, string name, string branch)
    {
        Student student = GetStudentById(rollno);
        if (student != null)
        {
            student.Name = name;
            student.Branch = branch;
            return true;
        }
        return false;
    }
}

class Program
{
    static void Main(string[] args)
    {
        IStudentRepository repository = new StudentRepository();

        while (true)
        {
            Console.WriteLine("\nOptions:");
            Console.WriteLine("1. Add Student");
            Console.WriteLine("2. Get All Students");
            Console.WriteLine("3. Get Student by Roll No");
            Console.WriteLine("4. Remove Student");
            Console.WriteLine("5. Update Student");
            Console.WriteLine("6. Exit");

            int choice = int.Parse(Console.ReadLine());
            

            switch (choice)
            {
                case 1:
                    Console.Write("Enter roll number: ");
                    int rollno = int.Parse(Console.ReadLine());
                    Console.Write("Enter name: ");
                    string name = Console.ReadLine();
                    Console.Write("Enter branch: ");
                    string branch = Console.ReadLine();
                    repository.AddStudent(new Student { RollNo = rollno, Name = name, Branch = branch });
                    break;
                case 2:
                    List<Student> students = repository.GetAllStudents();
                    Console.WriteLine("\nAll Students:");
                    students.ForEach(student => Console.WriteLine(student));
                    break;
                case 3:
                    Console.Write("Enter roll number: ");
                    rollno = int.Parse(Console.ReadLine());
                    Student student = repository.GetStudentById(rollno);
                    Console.WriteLine(student != null ? student.ToString() : "Student not found.");
                    break;
                case 4:
                    Console.Write("Enter roll number: ");
                    rollno = int.Parse(Console.ReadLine());
                    Console.WriteLine(repository.RemoveStudent(rollno) ? "Student removed successfully." : "Student not found.");
                    break;
                case 5:
                    Console.Write("Enter roll number: ");
                    rollno = int.Parse(Console.ReadLine());
                    Console.Write("Enter new name: ");
                    name = Console.ReadLine();
                    Console.Write("Enter new branch: ");
                    branch = Console.ReadLine();
                    Console.WriteLine(repository.UpdateStudent(rollno, name, branch) ? "Student updated successfully." : "Student not found.");
                    break;
                case 6:
                    return;
                default:
                    Console.WriteLine("Choose option between 1 to 6");
            }
        }
    }
}
