using System;
class UnitConverter{
	//method to convert km to miles
	public static double ConvertKmToMiles(double km){
		return km*0.621371;
	}
	//method to convert miles to km
	public static double ConvertMilesToKm(double miles){
		return miles*1.60934;
	}
	//method to convert meters to feet
	public static double ConvertMetersToFeet(double meters){
		return meters*3.28084;
	}
	//method to convert feet to meters
	public static double ConvertFeetToMeters(double feet){
		return feet*0.3048;
	}
	
	static void Main(string[] args) {
		//Input from user
		Console.Write("Enter the kilometers: ");
		double kilometers=Convert.ToDouble(Console.ReadLine());
		Console.Write("Enter the miles: ");
		double miles=Convert.ToDouble(Console.ReadLine());
		Console.Write("Enter the meters: ");
		double meters=Convert.ToDouble(Console.ReadLine());
		Console.Write("Enter the feets: ");
		double feet=Convert.ToDouble(Console.ReadLine());
		//display the output
		Console.WriteLine($"{kilometers} km in miles is {ConvertKmToMiles(kilometers)}");
		Console.WriteLine($"{miles} miles in kilometers is {ConvertMilesToKm(miles)}");
		Console.WriteLine($"{meters} Meters in feet is {ConvertMetersToFeet(meters)}");
		Console.WriteLine($"{feet} feet in meters is {ConvertFeetToMeters(feet)}");
	}}