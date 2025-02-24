using System;
class NumberDivisibleByFive{
	static void Main(string[]  args){
		//Input number from user
		Console.Write("Enter the number:");
		int number = Convert.ToInt32(Console.ReadLine());
		// check the condition if number is divisible by 5
		if (number % 5 == 0){
			//Display statement
			Console.WriteLine($"Is the number {number} divisible by 5? {number % 5 == 0}");
		}
		else{
			Console.WriteLine($"Is the number {number} divisible by 5? {number % 5 == 0}");
		}
	}
}