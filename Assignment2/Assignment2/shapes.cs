using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Assignment2
{
    internal class Shapes
    {
        // Renamed methods for clarity
        public int CalculateRectangleArea(int length, int depth)
        {
            return length * depth;
        }

        public double CalculateTriangleArea(double baseLength, double height)
        {
            return baseLength * height * 0.5;
        }

        public double CalculateCircleArea(double radius)
        {
            return Math.PI * radius * radius; // Using Math.PI for pi
        }

        public int CalculateSquareArea(int sideLength)
        {
            return sideLength * sideLength;
        }

        public static void Main()
        {
            Shapes s = new Shapes();
            Console.WriteLine("Choose shape:\n1. Rectangle\n2. Triangle\n3. Circle\n4. Square");
            int choice = int.Parse(Console.ReadLine());

            try
            {
                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Enter Length: ");
                        int length = int.Parse(Console.ReadLine());
                        Console.WriteLine("Enter Depth: ");
                        int depth = int.Parse(Console.ReadLine());
                        int rectangleArea = s.CalculateRectangleArea(length, depth);
                        Console.WriteLine($"Rectangle Area = {rectangleArea}");
                        break;
                    case 2:
                        Console.WriteLine("Enter base: ");
                        double baseLength = double.Parse(Console.ReadLine());
                        Console.WriteLine("Enter height: ");
                        double height = double.Parse(Console.ReadLine());
                        double triangleArea = s.CalculateTriangleArea(baseLength, height);
                        Console.WriteLine($"Triangle Area = {triangleArea}");
                        break;
                    case 3:
                        Console.WriteLine("Enter radius: ");
                        double radius = double.Parse(Console.ReadLine());
                        double circleArea = s.CalculateCircleArea(radius);
                        Console.WriteLine($"Circle Area = {circleArea}");
                        break;
                    case 4:
                        Console.WriteLine("Enter side length: ");
                        int sideLength = int.Parse(Console.ReadLine());
                        int squareArea = s.CalculateSquareArea(sideLength);
                        Console.WriteLine($"Square Area = {squareArea}");
                        break;
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid input format. Please enter numbers.");
            }
        }
    }
}

