using System;
class FizzBuzz{
    static void Main(string[] args){
        // input from user
        Console.Write("Enter a positive integer: ");
        int number = int.Parse(Console.ReadLine());
        //check if number is positive
        if (number < 0){
            Console.WriteLine("Please enter a valid positive integer.");
            return;
        }
        // Create a string array to save the results
        string[] results = new string[number + 1];
        // Loop from 0 to the number
        for (int i = 0; i <= number; i++){
            if (i % 3 == 0 && i % 5 == 0){
                results[i] = "FizzBuzz";}
            else if (i % 3 == 0){
                results[i] = "Fizz";}
            else if (i % 5 == 0){
                results[i] = "Buzz";}
            else{
                results[i] = i.ToString();}
        }
        // display output
        Console.WriteLine();
        for (int i = 0; i <= number; i++){
            Console.WriteLine($"Index {i} = {results[i]}");
        }
    }
}
