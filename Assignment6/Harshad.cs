using System;
class Harshad{
	static void Main(string[] args){
		//Input from user
		Console.Write("Enter the number: ");
		int number= Convert.ToInt32(Console.ReadLine());
		//variable initialization
		int sum =0;
		int original_number= number;
		//loop to sum the digits
		while(original_number!=0){
			int remainder = original_number%10;
			sum+=remainder;
			original_number/=10;
		}
		//check if number is Harshad or not
		if (number%sum==0){
			//Display output
			Console.WriteLine($"Harshad number");
		}
		else{
			Console.WriteLine($"Not Harshad number");
		}
	}}