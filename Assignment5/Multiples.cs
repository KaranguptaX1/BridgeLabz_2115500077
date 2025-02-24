using System;
class Multiples{
    static void Main(string[] args){
        //input for the number
        Console.Write("Enter a number: ");
        int number = Convert.ToInt32(Console.ReadLine());
        // Display multiples of the number below 100
        Console.WriteLine($"\nThe multiples of {number} below 100 are:");
        // Loop from 100 down to 1
        for (int i = 100; i >= 1; i--){
            // Check if i is a multiple of the given number
            if (i % number == 0){
                Console.WriteLine(i); // Print multiple of the number
            }
        }
    }
}
