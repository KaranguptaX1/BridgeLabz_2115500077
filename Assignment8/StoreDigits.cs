using System;
class StoreDigits{
	static void Main(string[] args){
		//Input from user
		Console.Write("Enter the number: ");
		int number=Convert.ToInt32(Console.ReadLine());
		//initialize variable and arrays
		int maxDigit=10;
		int[] digits = new int[maxDigit];
		int index=0;
		//store digits in array
		while(number!=0){
			if (index==maxDigit){
				break;
			}
			int lastDigit= number%10;
			digits[index]=lastDigit;
			number/=10;
			index++;
			
		}
		//initialize variables
		int largest=0;
		int secondLargest=0;
		//loop to find largest and second largest digits
		for (int i = 0; i < digits.Length; i++){
            if (digits[i] > largest){
                secondLargest = largest;
                largest = digits[i];
            }
            else if (digits[i] > secondLargest && digits[i] != largest){
                secondLargest = digits[i];
            }
        }
        //display the output
        Console.WriteLine($"Largest digit: {largest}");
        Console.WriteLine($"Second largest digit: {secondLargest}");
		
	}}