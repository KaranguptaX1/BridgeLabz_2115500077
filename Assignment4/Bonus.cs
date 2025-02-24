using System;
class Bonus{
	static void Main(string[] args){
		//Inputs from user
		Console.Write("Enter Salary: ");
		double salary = Convert.ToDouble(Console.ReadLine());
		Console.Write("Enter Year of Service: ");
		double years =Convert.ToDouble(Console.ReadLine());
		//check if service is more than 5
		if (years>5){
			double bonus =5;
			//calculate bonus amount
			double bonus_amount = bonus/100 *salary;
			//display output
			Console.WriteLine($"Total Salary is :{salary+bonus_amount}");
		}
		else{
			Console.WriteLine($"Total Salary is: {salary}");
		}
	}
}