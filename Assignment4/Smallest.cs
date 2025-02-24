using System;
class Smallest{
	// method to checkout if first number is smallest
	static bool IsSmallest(int num1, int num2, int num3){
		return num1<num2 && num1<num3;
	}
	
	static void Main(string[] args){
		//Input numbers from user
		Console.Write("Enter the number1: ");
		int number1 = Convert.ToInt32(Console.ReadLine());
		Console.Write("Enter the number2: ");
		int number2 = Convert.ToInt32(Console.ReadLine());
		Console.Write("Enter the number3: ");
		int number3 = Convert.ToInt32(Console.ReadLine());
		// call the method 
		bool smallest = IsSmallest(number1,number2,number3);
		//Display the output
		Console.WriteLine($"Is the first number the smallest? {smallest}");
		}
		
}
	