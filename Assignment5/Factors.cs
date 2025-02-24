using System;
class Factors{
    static void Main(string[] args){
        //input for the number
        Console.Write("Enter a number: ");
        int number = Convert.ToInt32(Console.ReadLine());
        // Display the factors of the number
        Console.WriteLine($"\nThe factors of {number} are:");
        // Loop through numbers from 1 to number-1
        for (int i = 1; i < number; i++){
            // Check if the number is divisible by i
            if (number % i == 0){
                Console.WriteLine(i); // Print i if it's a factor
            }
        }
        // Optional: Factor of the number itself
        Console.WriteLine(number); // The number itself is always a factor of itself
    }
}
