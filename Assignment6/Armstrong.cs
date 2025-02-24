using System;
class Armstrong{
	static void Main(string[] args){
		//Input from user
		Console.Write("Enter the number: ");
		int number = Convert.ToInt32(Console.ReadLine());
		//variable initialization
		int sum=0;
		int original_number= number;
		//while loop
		while(original_number!=0){
			//calculating remainder
			int remainder= original_number%10;
			sum+=(int)Math.Pow(remainder,3);// add Power(remainder,3) to sum
			original_number/=10; // divide number to get next digit
		}
		//check if sum is equal to number
		if (sum==number){
			//Display output
			Console.WriteLine($"{number} is an armstrong number");
		}
		else{
			Console.WriteLine($"{number} is not an armstrong number");
			
		}
		
	}}