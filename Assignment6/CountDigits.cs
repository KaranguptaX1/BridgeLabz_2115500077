using System;
class CountDigits{
	static void Main(string[] args){
		//Input from user
		Console.Write("Enter the number: ");
		int number = Convert.ToInt32(Console.ReadLine());
		//initialize the variables
		int count =0;
		int original_number=number;
		//loop to count the digits in number
		while(original_number!=0){
			original_number/=10;
			count+=1;
		}
		//Display output
		Console.WriteLine($"The number of digits in {number} is {count}");
	}}