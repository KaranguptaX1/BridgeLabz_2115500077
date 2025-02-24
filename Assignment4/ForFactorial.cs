using System;
class ForFactorial{
	//method to calculate the factorial using for loop
	static int Factorial(int num){
		int factorial=1;
		//for loop
		for (int i =1; i<=num;i++){
			factorial*=i;
		}
		return factorial;
	}
	static void Main(string[] args){
		//Input number from user
		Console.Write("Enter the number : ");
		int number = Convert.ToInt32(Console.ReadLine());
		//check if number is positive
		if (number>=0){
			//call the method
			int factorial = Factorial(number);
			//Display output if positive number
			Console.WriteLine($"The factorial of number {number} is {factorial}");
		}
		else{
			//Display output if negative number
			Console.WriteLine("Please enter a positive number");
		}
		
	}}