using System;
using System.Numerics;
class StoreAllDigits{
    static void Main(string[] args){
        // Input from user
        Console.Write("Enter the number: ");
        BigInteger number = BigInteger.Parse(Console.ReadLine());
        // Initialize variable and arrays
        int maxDigit = 10;
        int[] digits = new int[maxDigit];
        int index = 0;
        // Store digits in array
        while (number != 0){
            if (index == maxDigit){
                maxDigit += 10;
                int[] temp = new int[maxDigit];
                for (int i = 0; i < digits.Length; i++){
                    temp[i] = digits[i];
                }
                digits = temp;
            }
            int lastDigit = (int)(number % 10); // Cast to int
            digits[index] = lastDigit;
            number /= 10;
            index++;
        }
        // Initialize variables
        int largest = 0; 
        int secondLargest = 0;
        // Loop to find largest and second largest digits
        for (int i = 0; i < index; i++){
            if (digits[i] > largest){
                secondLargest = largest;
                largest = digits[i];
            }
            else if (digits[i] > secondLargest && digits[i] != largest){
                secondLargest = digits[i];
            }
        }
        // Display the output
        Console.WriteLine($"Largest digit: {largest}");
        Console.WriteLine($"Second largest digit: {secondLargest}");
       
    }
}
