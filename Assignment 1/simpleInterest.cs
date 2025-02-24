using System;

class SimpleInterest
{
    static void Main(string[] args)
    {
        Console.Write("Enter the Principal: ");
        double principal = double.Parse(Console.ReadLine());
        Console.Write("Enter the Rate of Interest: ");
        double rate = double.Parse(Console.ReadLine());
        Console.Write("Enter the Time (in years): ");
        double time = double.Parse(Console.ReadLine());
        double simpleInterest = (principal * rate * time) / 100;
        Console.WriteLine($"The Simple Interest is: {simpleInterest}");
    }
}
