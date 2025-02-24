using System;
class LeapYear{
	// method to check if the given year is a leap year
    public static string CheckLeapYear(int year){
        // check if the year is valid 
        if (year < 1582){
            return "Year must be >= 1582 (Gregorian calendar).";
        }
        // Check for leap year 
        if ((year % 4 == 0 && year % 100 != 0) || (year % 400 == 0)){
            return "This is Leap Year ";
        }
        return "This is Not a Leap Year"; // not a leap year
    }
	static void Main(string[] args){
		//Input from user
		Console.Write("Enter the Year: ");
		int year = Convert.ToInt32(Console.ReadLine());
		//call the method
		string isLeapYear= CheckLeapYear(year);
		//Display output
		Console.WriteLine(isLeapYear);
		
	}
}