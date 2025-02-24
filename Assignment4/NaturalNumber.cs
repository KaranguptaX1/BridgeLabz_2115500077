using System;
class NaturalNumber{
	// method to calculate the sum of natural numbers
	static int SumNaturalNumber(int num){
		return (num * (num+1))/2;
	}
	static void Main(string[] args){
		//Input numbers from user
		Console.Write("Enter Natural number: ");
		int number = Convert.ToInt32(Console.ReadLine());
		//check if number is natural
		if (number >=0){
			//call the SumNaturalMethod
			int sum = SumNaturalNumber(number);
			//Display output
			Console.WriteLine($"The sum of {number} natural numbers is {sum}");	
		}
		else{
			Console.WriteLine($"The number {number} is not a natural number");
		}
	}
}