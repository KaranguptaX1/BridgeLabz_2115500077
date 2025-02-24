using System;
class LeapYear{
	static void Main(string[] args){
		//input year from user
		Console.Write("Enter the Year: ");
		int year = Convert.ToInt32(Console.ReadLine());
		//check for Gregorian calender
		if (year>=1582){
			//check for leap year conditions
			if (year%4==0 && year%100!=0){
				//display output
				Console.WriteLine($"{year} is Leap Year");
				
			}
			else if (year%400==0){
				Console.WriteLine($"{year} is Leap Year");
				
			}
			//not leap year conditions
			else{
			Console.WriteLine($"{year} is not leap year");
			}
			}
		else{
			Console.WriteLine($"{year} is not leap year");
		}
	}
}
