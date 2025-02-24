using System;
class BasicCalculator{
    // Method to get a number from the user
    static double GetNumber(string message){
        Console.Write(message);
        double number;
        while (!double.TryParse(Console.ReadLine(), out number)){
            Console.Write("Invalid input! Please enter a valid number: ");
        }
        return number;
    }
    // Method to perform addition
    static double Add(double a, double b) => a + b;
    // Method to perform subtraction
    static double Subtract(double a, double b) => a - b;
    // Method to perform multiplication
    static double Multiply(double a, double b) => a * b;
    // Method to perform division with error handling
    static double Divide(double a, double b){
        if (b == 0){
            Console.WriteLine("Error! Division by zero is not allowed.");
            return double.NaN; // Return Not-a-Number if division by zero occurs
        }
        return a / b;
    }
    // Method to display the result
    static void DisplayResult(double result){
        if (!double.IsNaN(result))
            Console.WriteLine($"Result: {result}");
    }
    static void Main(){
        while (true){
            // Display menu options
            Console.WriteLine("\nBasic Calculator");
            Console.WriteLine("1. Addition (+)");
            Console.WriteLine("2. Subtraction (-)");
            Console.WriteLine("3. Multiplication (*)");
            Console.WriteLine("4. Division (/)");
            Console.WriteLine("5. Exit");
            Console.Write("Choose an operation (1-5): ");
            // Get user choice
            string choice = Console.ReadLine();
            // Exit the program
            if (choice == "5"){
                Console.WriteLine("Exiting the calculator. Goodbye!");
                break;
            }
            // Get two numbers from user
            double num1 = GetNumber("Enter the first number: ");
            double num2 = GetNumber("Enter the second number: ");
            double result = 0;
            // Perform the chosen operation
            switch (choice){
                case "1":
                    result = Add(num1, num2);
                    break;
                case "2":
                    result = Subtract(num1, num2);
                    break;
                case "3":
                    result = Multiply(num1, num2);
                    break;
                case "4":
                    result = Divide(num1, num2);
                    break;
                default:
                    Console.WriteLine("Invalid choice! Please select a valid operation.");
                    continue;
            }
            // Display the result
            DisplayResult(result);
        }
    }
}
