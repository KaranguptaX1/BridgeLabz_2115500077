using System;
class UnitConverter{
	//method to convert km to miles
	public static double ConvertYardsToFeet(double yards){
		return yards*3;
	}
	//method to convert miles to km
	public static double ConvertFeetToYards(double feet){
		return feet*0.333333;
	}
	//method to convert meters to feet
	public static double ConvertMetersToInches(double meters){
		return meters*39.3701;
	}
	//method to convert feet to meters
	public static double ConvertInchesToMeters(double inches){
		return inches*0.0254;
	}
	//method to convert inches to centimeters
	public static double ConvertInchesToCentimeters(double inches){
		return inches*2.54;
	}
	
	static void Main(string[] args) {
		//Input from user
		Console.Write("Enter the yards(to Feet): ");
		double yard=Convert.ToDouble(Console.ReadLine());
		Console.Write("Enter the feets(to yards): ");
		double feet=Convert.ToDouble(Console.ReadLine());
		Console.Write("Enter the meters(to inches): ");
		double meters=Convert.ToDouble(Console.ReadLine());
		Console.Write("Enter the inches(to meters): ");
		double inches=Convert.ToDouble(Console.ReadLine());
		Console.Write("Enter the inches(to centimeters): ");
		double inchesTwo=Convert.ToDouble(Console.ReadLine());
		//display the output
		Console.WriteLine($"{yard} yards in feet is {ConvertYardsToFeet(yard)}");
		Console.WriteLine($"{feet} feets in yards is {ConvertFeetToYards(feet)}");
		Console.WriteLine($"{meters} Meters to inches is {ConvertMetersToInches(meters)}");
		Console.WriteLine($"{inches} inches in meters is {ConvertInchesToMeters(inches)}");
		Console.WriteLine($"{inchesTwo} inches in centimeters is {ConvertInchesToCentimeters(feet)}");
		
	}}