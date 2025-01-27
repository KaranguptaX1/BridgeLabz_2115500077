using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter the distance in kilometers: ");
        double kilometers = Convert.ToDouble(Console.ReadLine());
        double miles = kilometers * 0.621371;
        Console.WriteLine("The distance in miles is: {0:F2}", miles);
    }
}
