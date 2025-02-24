using System;
class ThreeLargest{
	static void Main(string[] args){
		//Input numbers from user
		Console.Write("Enter number1: ");
		int number1 = Convert.ToInt32(Console.ReadLine());
		Console.Write("Enter number2: ");
		int number2 = Convert.ToInt32(Console.ReadLine());
		Console.Write("Enter number3: ");
		int number3 = Convert.ToInt32(Console.ReadLine());
		//Display the output 
		Console.WriteLine(string.Format("Is the first number the largest?{0}",(number1> number2 && number1> number3)?"Yes" : "No")); // is first Largest
		Console.WriteLine(string.Format("Is the second number the largest?{0}",(number2> number1 && number2> number3)?"Yes" : "No")); //is second largest
		Console.WriteLine(string.Format("Is the third number the largest?{0}",(number3> number1 && number3> number2)?"Yes" : "No")); // is third largest
	}
}