using System;
class NumberChecker{
    // method to find the count of digits 
    public static int CountDigits(int num){
        int count = 0;
        //loop to count digts
        while (num != 0){
            count++;
            num /= 10;
        }
        return count;
    }

    // method to store the digits of number in a digits array
    public static int[] StoreDigits(int num){
        int count = CountDigits(num);
        int[] digits = new int[count];
        int index = count - 1;
        //loop to store digits
        while (num != 0){
            digits[index] = num % 10;
            num /= 10;
            index--;
        }
        return digits;
    }
    // method to find the sum of the digits 
    public static int SumOfDigits(int[] digits){
        int sum = 0;
        foreach (int digit in digits){
            sum += digit;
        }
        return sum;
    }

    // method to find the sum of the squares of the digits
    public static int SumOfSquaresOfDigits(int[] digits){
        int sum = 0;
        foreach (int digit in digits){
            sum += (int)Math.Pow(digit, 2);
        }
        return sum;
    }

    // method to check if number is  Harshad number
    public static bool IsHarshadNumber(int num, int[] digits)
    {
        int sumOfDigits = SumOfDigits(digits);
        return num % sumOfDigits == 0;
    }

    // method to find  frequency of each digit 
    public static int[,] DigitFrequency(int[] digits){
        int[,] frequency = new int[10, 2];
        for (int i = 0; i < 10; i++){
            frequency[i, 0] = i; // Digit
            frequency[i, 1] = 0; // Frequency
        }
        foreach (int digit in digits){
            frequency[digit, 1]++;
        }
        return frequency;
    }
    
    static void Main(string[] args){
        Console.Write("Enter a number: ");
        int num = Convert.ToInt32(Console.ReadLine());
        // Call methods and display results
        int[] digits = StoreDigits(num);
        //Display output
        Console.WriteLine($"Count of digits: {CountDigits(num)}");
        //print digits
        Console.Write("Digits: ");
        for (int i=0;i<digits.Length;i++){
        	 Console.Write($" {digits[i]}, ");
        }
        Console.WriteLine();
        //print sum of digits
        Console.WriteLine($"Sum of digits: {SumOfDigits(digits)}");
        //print sum of squares
        Console.WriteLine($"Sum of squares of digits: {SumOfSquaresOfDigits(digits)}");
        //print harshad number
        Console.WriteLine($"Is Harshad Number: {IsHarshadNumber(num, digits)}");

        // Display digit frequencies
        int[,] frequency = DigitFrequency(digits);
        Console.WriteLine("Digit Frequencies:");
        for (int i = 0; i < 10; i++){
            if (frequency[i, 1] > 0){
                Console.WriteLine($"Digit: {frequency[i, 0]}, Frequency: {frequency[i, 1]}");
            }
        }
    }
}
