using System;
class NumberChecker {
	//method to count the number of digits 
    public static int CountDigits(int num) {
        int count = 0;
        //loop to count digits
        while (num != 0) {
            count++;
            num /= 10;
        }
        return count;
    }
	//method to storeDigits in array
    public static int[] StoreDigits(int num) {
        int count = CountDigits(num);
        int[] digits = new int[count];
        //start index from last to store number correctly
        int index = count - 1;
        //assigning digits
        while (num != 0) {
            digits[index] = num % 10;
            num /= 10;
            index--;
        }
        return digits;
    }
    //check for duck number(it does not have zeros)
    public static bool IsDuckNumber(int[] digits) {
        for (int i = 1; i < digits.Length; i++) {
            if (digits[i] == 0) {
                return true;
            }
        }
        return false;
    }
    //check for armstrong number
    public static bool IsArmstrong(int[] digits) {
        int sum = 0;
        int originalNum = 0;
        int count = digits.Length;
        //for loop to find the sum and number
        foreach (int digit in digits) {
            sum += (int)Math.Pow(digit, count);
            originalNum = originalNum * 10 + digit;
        }
        return sum == originalNum;
    }
    //finding the largest and second largest digits
    public static int[] Largest(int[] digits) {
        int largest = int.MinValue;
        int secondLargest = int.MinValue;
        //loop to find largest and second largest
        foreach (int digit in digits) {
            if (digit > largest) {
                secondLargest = largest;
                largest = digit;
            } else if (digit > secondLargest && digit < largest) {
                secondLargest = digit;
            }
        }

        return new int[] { largest, secondLargest };
    }
	//method to find smallest and second smallest digits
    public static int[] Smallest(int[] digits) {
        int smallest = int.MaxValue;
        int secondSmallest = int.MaxValue;
        //loop to find the smallest and second smallest digits
        foreach (int digit in digits) {
            if (digit < smallest) {
                secondSmallest = smallest;
                smallest = digit;
            } else if (digit < secondSmallest && digit > smallest) {
                secondSmallest = digit;
            }
        }

        return new int[] { smallest, secondSmallest };
    }

    static void Main(string[] args) {
    	//Input from user
        Console.Write("Enter a number: ");
        int num = Convert.ToInt32(Console.ReadLine());
        //call method to store Digits
        int[] digits = StoreDigits(num);
        //display count of digits
        Console.WriteLine($"Number of digits: {CountDigits(num)}");
        //printing digits
        Console.Write("Digits: ");
        for (int i=0;i<digits.Length;i++){
        	 Console.Write($" {digits[i]}, ");
        }
        Console.WriteLine();
        //check for duck number
        Console.WriteLine($"Is Duck Number: {IsDuckNumber(digits)}");
        //check for amrstrong number
        Console.WriteLine($"Is Armstrong Number: {IsArmstrong(digits)}");
        //print largest and second largest number
        int[] largest = Largest(digits);
        Console.WriteLine($"Largest digit: {largest[0]}");
        Console.WriteLine($"Second largest digit: {largest[1]}");
        //print smallest and second smallest number
        int[] smallest = Smallest(digits);
        Console.WriteLine($"Smallest digit: {smallest[0]}");
        Console.WriteLine($"Second smallest digit: {smallest[1]}");
    }
}
