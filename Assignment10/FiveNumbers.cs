using System;
class FiveNumbers{
	//method to check if number is positive or negative
	public static bool IsPositive(double number){
		return number>=0;
	}
	//method to check if number is even or odd
	public static bool IsEven(double number){
		return number%2==0;
	}
	//method to compare the two two numbers
	public static int Compare(double number1,double number2){
		if (number1>number2){
			return 1;
		}
		else if (number1==number2){
			return 0;
		}
		else{
			return -1;
		}
		
	}
	static void Main(string[] args){
		double[] numbers = new double[5];
		//Input from user for numbers
		for(int i =0; i<numbers.Length;i++){
			Console.Write($"Enter the number {i+1}: ");
			numbers[i]=Convert.ToDouble(Console.ReadLine());
		}
		//loop over numbers
		for(int i=0;i<numbers.Length;i++){
			Console.WriteLine($"Number {numbers[i]}");
			//display output of number is positive or negative
			if(IsPositive(numbers[i])){ //call the method to check positive
				Console.WriteLine($"{numbers[i]} is Positive");
			}
			else{
				Console.WriteLine($"{numbers[i]} is Negative");
			}
			//display output of number is even or odd
			if (IsEven(numbers[i])){//call the method to check even
				Console.WriteLine($"{numbers[i]} is Even");
			}
			else{
				Console.WriteLine($"{numbers[i]} is Odd");
			}
			
		}
		//call the compare method for first and last numbers
		int result= Compare(numbers[0],numbers[numbers.Length -1]);
		//display output
		if (result==1){
			Console.WriteLine($"{numbers[0]} is greater {numbers[numbers.Length -1]} ");
		}
		else if(result==0){
			Console.WriteLine($"{numbers[0]} is equal to {numbers[numbers.Length -1]} ");
		}
		else{
			Console.WriteLine($"{numbers[0]} is less than  {numbers[numbers.Length -1]} ");
		}
	}}