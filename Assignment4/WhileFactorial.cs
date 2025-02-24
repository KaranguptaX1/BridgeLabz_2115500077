using System;
class WhileFactorial{
	//method to calculate the factorial using while loop
	static int Factorial(int num){
		int factorial=1;
		//while loop
		while (num>0){
			factorial*=num;
			num--;
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