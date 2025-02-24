using System;

class PowerCalculation
{
    static void Main(string[] args)
    {
        Console.Write("Enter the base: ");
        double baseNum = double.Parse(Console.ReadLine());
        Console.Write("Enter the exponent: ");
        double exponent = double.Parse(Console.ReadLine());
        double power = Math.Pow(baseNum, exponent);
        Console.WriteLine($"{baseNum} raised to the power of {exponent} is: {power}");
    }
}
