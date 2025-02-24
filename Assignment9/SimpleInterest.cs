using System;
class SimpleInterest{
	//method to calculate the simple interest using principal, rate,time
	public double CalculateSimpleInterest(double principal,double rate,double time){
		double simpleInterest= (principal*rate*time)/100;
		return simpleInterest;
	}
	static void Main(string[] args){
		//Input from user
		Console.Write("Enter the Principal Amount: ");
		double principal = Convert.ToDouble(Console.ReadLine());
		Console.Write("Enter the Rate of Interest: ");
		double rate = Convert.ToDouble(Console.ReadLine());
		Console.Write("Enter the Time Period: ");
		double time = Convert.ToDouble(Console.ReadLine());
		//call the class instance
		SimpleInterest interest = new SimpleInterest();
		//call the method
		double simpleInterest= interest.CalculateSimpleInterest(principal,rate,time);
		//display the output
		Console.WriteLine($"The Simple Interest is {simpleInterest} for Principal {principal}, Rate of interest {rate} and Time {time}");
}
}