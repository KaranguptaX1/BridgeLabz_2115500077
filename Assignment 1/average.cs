using System;

class AverageCalculation
{
    static void Main(string[] args)
    {
        Console.Write("Enter the first number: ");
        double number1 = double.Parse(Console.ReadLine());
        Console.Write("Enter the second number: ");
        double number2 = double.Parse(Console.ReadLine());
        Console.Write("Enter the third number: ");
        double number3 = double.Parse(Console.ReadLine());
        double average = (number1 + number2 + number3) / 3;
        Console.WriteLine($"The average of {number1}, {number2}, and {number3} is: {average}");
    }
}
