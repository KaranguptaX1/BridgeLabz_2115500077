using System;
class SumNaturalNumber{
	//method to calculate the sum using number
	public static int Sum(int number){
		//variable initialize
		int sum=0;
		//for loop till the number
		for (int i=1;i<=number;i++){
			//add the value to sum
			sum+=i;
		}
		//return sum
		return sum;
	}
	static void Main(string[] args){
		//Input from user
		Console.Write("Enter the number: ");
		int number= Convert.ToInt32(Console.ReadLine());
		//call the method
		int sum = Sum(number);
		//display the method
		Console.WriteLine($"The sum of {number} natural number is {sum}");
		
		
	}
	}