using System;

public class TriangleAreaCalculator
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Triangle Area Calculator");
        Console.WriteLine("------------------------");

        // Get the base from the user
        Console.Write("Enter the base of the triangle: ");
        string baseInput = Console.ReadLine();
        double triangleBase;

        // Validate base input
        while (!double.TryParse(baseInput, out triangleBase) || triangleBase <= 0)
        {
            Console.WriteLine("Invalid input. Please enter a positive number for the base.");
            Console.Write("Enter the base of the triangle: ");
            baseInput = Console.ReadLine();
        }

        // Get the height from the user
        Console.Write("Enter the height of the triangle: ");
        string heightInput = Console.ReadLine();
        double triangleHeight;

        // Validate height input
        while (!double.TryParse(heightInput, out triangleHeight) || triangleHeight <= 0)
        {
            Console.WriteLine("Invalid input. Please enter a positive number for the height.");
            Console.Write("Enter the height of the triangle: ");
            heightInput = Console.ReadLine();
        }

        // Calculate the area
        double area = 0.5 * triangleBase * triangleHeight;

        // Display the result
        Console.WriteLine($"The area of the triangle with base {triangleBase} and height {triangleHeight} is: {area}");
    }
}
