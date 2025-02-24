using System;
class PositiveNegative{
	//method to check if number is positve,negative,zero
	public static int Check(double number){
		if (number>0){
			return 1;}
		else if (number<0){
			return -1;}
		else{
			return 0;}
		
	}
	
	static void Main(string[] args){
		//Input from user
		Console.Write("Enter the number: ");
		double number = Convert.ToDouble(Console.ReadLine());
		//call the method
		int result = Check(number);
		//display the output
		if (result==1){
			Console.WriteLine($"The number is Positive");
		}
		else if (result==-1){
			Console.WriteLine($"The number is Negative");
		}
		else{
			Console.WriteLine($"The number is Zero");
		}
	
}}