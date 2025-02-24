using System;
class Power{
    static void Main(string[] args){
        // Get inputs for number and power
        Console.Write("Enter the number: ");
        int number = int.Parse(Console.ReadLine());
        Console.Write("Enter the power: ");
        int power = int.Parse(Console.ReadLine());
        // Initialize result to 1
        int result = 1;
        // Calculate power using a for loop
        for (int i = 1; i <= power; i++){
            result *= number; // Multiply result by the number in each iteration
        }
        // Display the result
        Console.WriteLine($"\n{number} raised to the power of {power} is: {result}");
    }
}
