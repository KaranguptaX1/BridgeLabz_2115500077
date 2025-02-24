using System;
class Factor{
	static void Main(string[] args){
		//Input from user
		Console.Write("Enter the number: ");
		int number = Convert.ToInt32(Console.ReadLine());
		//initialize variable
		int greatest_factor=1;
		//check condition if number is greater than 1
		if(number<1){
			Console.WriteLine("Enter number greater than 1!");
			return;
		}
		//for loop to find greatest factor
		for (int i= number-1;i>1;i--){
			if(number%i ==0){
				greatest_factor = i;
				break;
			}
		}
		//display output
		Console.WriteLine($"The greatest factor of {number} is {greatest_factor}");
	}}