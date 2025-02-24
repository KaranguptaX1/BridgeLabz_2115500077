using System;
class CheckNumber{
	static void Main(string[] args){
		//Input number from user
		Console.Write("Enter number: ");
		double number = Convert.ToDouble(Console.ReadLine());
		//Check condition
		if (number>0){
			Console.WriteLine("Positive"); // if number is positive
		}
		else if (number<0){
			Console.WriteLine("Negative"); // if number is negative
		}
		else{
			Console.WriteLine("Zero"); // if number is zero
		}
	}
}