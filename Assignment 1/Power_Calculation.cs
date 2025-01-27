using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter the base: ");
        double baseNumber = Convert.ToDouble(Console.ReadLine());
        Console.Write("Enter the exponent: ");
        double exponent = Convert.ToDouble(Console.ReadLine());
        double result = Math.Pow(baseNumber, exponent);
        Console.WriteLine("{0} raised to the power of {1} is: {2:F2}", baseNumber, exponent, result);
    }
}
