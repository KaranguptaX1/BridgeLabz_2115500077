using System;
class MaxFactors{
    static void Main(string[] args){
        // Input number from user
        Console.Write("Enter a positive integer: ");
        int number=int.Parse(Console.ReadLine());
        if(number<1){
        	Console.WriteLine("Enter a natural number!");
        	return ;
        }
        // Initialize variables
        int maxFactor = 10; 
        int[] factors = new int[maxFactor];
        int index = 0;
        // Calculate factors and store them in the array
        for (int i = 1; i <= number; i++){
            if (number % i == 0){
                if (index == maxFactor){
                    // Double the size of the array
                    maxFactor *= 2;
                    int[] temp = new int[maxFactor];
                    for (int j = 0; j < factors.Length; j++){
                        temp[j] = factors[j];
                    }
                    factors = temp;
                }
                // Store the factor
                factors[index++] = i;
            }
        }
        // Display the factors
        Console.WriteLine($"Factors of {number}:");
        for (int i = 0; i < index; i++){
            Console.Write(factors[i] + " ");
        }
        Console.WriteLine();
    }
}
