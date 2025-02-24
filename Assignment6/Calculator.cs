using System;
class Calculator{
    static void Main(string[] args){
        // Get user input for the first number
        Console.Write("Enter the first number: ");
        double first = Convert.ToDouble(Console.ReadLine());
        // Get user input for the second number
        Console.Write("Enter the second number: ");
        double second = Convert.ToDouble(Console.ReadLine());
        // Get the operator
        Console.Write("Enter the operator (+, -, *, /): ");
        string op = Console.ReadLine();
        // Perform the operation using switch...case
        double result;
        switch (op){
            case "+":
                result = first + second;
                Console.WriteLine($"Result: {first} + {second} = {result}");
                break;

            case "-":
                result = first - second;
                Console.WriteLine($"Result: {first} - {second} = {result}");
                break;

            case "*":
                result = first * second;
                Console.WriteLine($"Result: {first} * {second} = {result}");
                break;

            case "/":
                if (second != 0){
                    result = first / second;
                    Console.WriteLine($"Result: {first} / {second} = {result}");
                }
                else{
                    Console.WriteLine("Error: Division by zero is not allowed.");
                }
                break;
            default:
                Console.WriteLine("Invalid operator. Please use +, -, *, or /.");
                break;
        }
    }
}
