using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter the first number: ");
        int number1 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter the second number: ");
        int number2 = Convert.ToInt32(Console.ReadLine());
        int sum = number1 + number2;
        Console.WriteLine("The sum of {0} and {1} is: {2}", number1, number2, sum);
    }
}
