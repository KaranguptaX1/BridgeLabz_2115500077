using System;

class RectanglePerimeter
{
    static void Main(string[] args)
    {
        Console.Write("Enter the length of the rectangle: ");
        double length = double.Parse(Console.ReadLine());
        Console.Write("Enter the width of the rectangle: ");
        double width = double.Parse(Console.ReadLine());
        double perimeter = 2 * (length + width);
        Console.WriteLine($"The perimeter of the rectangle is: {perimeter}");
    }
}
