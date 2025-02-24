using System;
class LeapYear2{
	static void Main(string[] args){
		//input year from user
		Console.Write("Enter the Year: ");
		int year = Convert.ToInt32(Console.ReadLine());
		//check for leap year conditions
		if (year>=1582 && ((year%4==0 && year%100!=0) || year%400==0)){
			//display output
			Console.WriteLine($"{year} is a leap year");
		}
		else{
			Console.WriteLine($"{year} is not a leap year");
		}
	}
}
