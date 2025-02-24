using System;
class Abundant{
    static void Main(string[] args){
        // Get input for the number
        Console.Write("Enter a number: ");
        int number = int.Parse(Console.ReadLine());
        // Initialize sum 
        int sum = 0;
        // Find all divisors of the number and calculate their sum
        for (int i = 1; i < number; i++){
        	// Check if i is a divisor
            if (number % i == 0) {
                sum += i; // Add the divisor to the sum
            }
        }
        // Check if the number is abundant
        if (sum > number){
            Console.WriteLine($"{number} is an Abundant Number.");
        }
        else{
            Console.WriteLine($"{number} is Not an Abundant Number.");
        }
    }
}
