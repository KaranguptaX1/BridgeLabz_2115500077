using System;
class FibonacciGenerator{
    // Method to get a valid number from the user
    static int GetNumber(){
        Console.Write("Enter the number of terms for the Fibonacci sequence: ");
        int num;
        while (!int.TryParse(Console.ReadLine(), out  num) || num <= 0){
            Console.Write("Invalid input! Please enter a positive integer: ");
        }
        return num;
    }
    // Method to generate Fibonacci sequence
    static void GenerateFibonacci(int terms){
        long first = 0, second = 1, next;
        Console.WriteLine("Fibonacci Sequence:");
        for (int i = 0; i < terms; i++){
            Console.Write(first + " ");
            next = first + second;
            first = second;
            second = next;
        }
        Console.WriteLine();
    }

    static void Main(){
        // Get user input
        int terms = GetNumber();
        // Generate and display the Fibonacci sequence
        GenerateFibonacci(terms);
    }
}
