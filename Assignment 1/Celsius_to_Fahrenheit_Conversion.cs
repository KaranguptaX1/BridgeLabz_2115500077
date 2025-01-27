using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter the temperature in Celsius: ");
        double celsius = Convert.ToDouble(Console.ReadLine());
        double fahrenheit = (celsius * 9 / 5) + 32;
        Console.WriteLine("The temperature in Fahrenheit is: {0:F2}", fahrenheit);
    }
}
