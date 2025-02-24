using System;
class NumberChecker{
	//method to check prime number
	public static bool IsPrime(int number){
		if (number<2){
			return false;
		}
		for (int i=2; i<number;i++){
			if (number%2==0){
				return false;
			}
		}
		return true;
	}
	//method to check IsNeon (sumofDigits of number^2 == number)
	public static bool IsNeonNumber(int number){
		int square= number*number;
		int sumOfDigits =0;
		while (square>0){
			sumOfDigits+=square%10;
			square/=10;
		}
		return sumOfDigits==number;
	}
	//method to check spy number( sumofDigits== product)
	public static bool IsSpyNumber(int num){
		int sum=0;
		int product =1;
		while(num>0){
			int digit = num% 10;
			sum+=digit;
			product*=digit;
			num/=10;
		}
		return sum ==product;
	}
	//method to check automorphic(last digit of square of number == num)
	public static bool IsAutomorphic(int num){
		int square =num * num;
		int lastDigit= square%10;
		return lastDigit==num;
	}
	//method to check to BuzzNumber(num  divisible by 7 or num divisible by 10)
	public static bool IsBuzzNumber(int num)
    {
        return num % 7 == 0 || num % 10 == 7;
    }
	
	static void Main(string[] args){
		//Input from user
		Console.Write("Enter a number: ");
        int num = Convert.ToInt32(Console.ReadLine());

        // Display output
        Console.WriteLine($"Is Prime?: {IsPrime(num)}");
        Console.WriteLine($"Is Neon Number?: {IsNeonNumber(num)}");
        Console.WriteLine($"Is Spy Number ?: {IsSpyNumber(num)}");
        Console.WriteLine($"Is Automorphic Number?: {IsAutomorphic(num)}");
        Console.WriteLine($"Is Buzz Number?: {IsBuzzNumber(num)}");
		
	} }