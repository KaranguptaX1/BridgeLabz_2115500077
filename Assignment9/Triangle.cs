using System;
class Triangle{
	//method to calculate the number of rounds using the sides and distance
	public static double CalculateRounds(double side1,double side2,double side3, int distance){
		return distance/(side1+side2+side3);
	}
	static void Main(string[] args){
		//Input from user
		Console.Write("Enter the first side of triangle: ");
		double side1= Convert.ToDouble(Console.ReadLine());
		Console.Write("Enter the second side of triangle: ");
		double side2= Convert.ToDouble(Console.ReadLine());
		Console.Write("Enter the third side of triangle: ");
		double side3= Convert.ToDouble(Console.ReadLine());
		int toRun= 5000;
		//Call the methods
		double rounds = CalculateRounds(side1,side2,side3,toRun);
		//Display the output
		Console.WriteLine($"The number of rounds to complete are: {rounds:0.000}");
		

}}