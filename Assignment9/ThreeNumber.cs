using System;
class ThreeNumber{
	public static double[] FindSmallestAndLargest(double number1,double number2, double number3){
		//variable initialize
		double largest,smallest;
		//conditions to find the largest
		if (number1> number2 ){
			if (number1> number3){
				largest=number1;
			}
			else{
				largest=number3;
			}
		}
		else{
			if(number2>number3){
				largest=number2;
			}
			else{
				largest=number3;
			}
		}
		//Condition to find the smallest
		if (number1< number2 ){
			if (number1< number3){
				smallest=number1;
			}
			else{
				smallest=number3;
			}
		}
		else{
			if(number2<number3){
				smallest=number2;
			}
			else{
				smallest=number3;
			}
		}
		//return statement
		return new double[]{largest,smallest};
	}
	static void Main(string[] args) {
		//Input numbers from user
		Console.Write("Enter the first number: ");
		double number1 = Convert.ToDouble(Console.ReadLine());
		Console.Write("Enter the second number: ");
		double number2 = Convert.ToDouble(Console.ReadLine());
		Console.Write("Enter the three number: ");
		double number3 = Convert.ToDouble(Console.ReadLine());
		//call the method
		double[] result=FindSmallestAndLargest(number1,number2,number3);
		//Display the output
		Console.WriteLine("Largest: "+result[0] + " Smallest: "+ result[1]);
	}}