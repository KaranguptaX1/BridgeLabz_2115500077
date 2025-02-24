using System;
class OddEvenArrays{
    static void Main(string[] args){
        // input from user
        Console.Write("Enter a natural number: ");
        int number = int.Parse(Console.ReadLine());
        if (number<1){
        	Console.WriteLine("Enter a valid natural number");
        	return;
        }
        // Create arrays to store odd and even numbers
        int[] evenNumbers = new int[number / 2 + 1];
        int[] oddNumbers = new int[number / 2 + 1];
        int evenIndex = 0, oddIndex = 0;
        // Populate the arrays with odd and even numbers
        for (int i = 1; i <= number; i++){
            if (i % 2 == 0){
                evenNumbers[evenIndex++] = i;
            }
            else{
                oddNumbers[oddIndex++] = i;
            }
        }
        // Print the odd numbers array
        Console.WriteLine("Odd Numbers:");
        for (int i = 0; i < oddIndex; i++){
            Console.Write(oddNumbers[i] + " ");
        }
        Console.WriteLine();
        // Print the even numbers array
        Console.WriteLine("Even Numbers:");
        for (int i = 0; i < evenIndex; i++){
            Console.Write(evenNumbers[i] + " ");
        }
        Console.WriteLine();
    }
}
