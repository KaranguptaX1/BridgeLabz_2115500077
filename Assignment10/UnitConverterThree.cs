using System;
class UnitConverter{
	//method to convert farhenheit to celsius
	public static double ConvertFarhenheitToCelsius(double farhenheit){
		return ((farhenheit-32)*5)/9;
	}
	//method to convert celsius to farhenheit
	public static double ConvertCelsiusToFarhenheit(double celsius){
		return ((celsius* 9)/5)+32;
	}
	
	//method to convert pounds to kilogram 
	public static double ConvertPoundsToKilogram(double pounds){
		return pounds*0.453592;
	}
	//method to convert kilogram  to pounds
	public static double ConvertKilogramToPounds(double kilogram){
		return kilogram*2.20462;
	}
	//method to convert gallons to liters
	public static double ConvertGallonsToLiters(double gallons){
		return gallons*3.78541;
	}
	//method to convert  liters to gallons 
	public static double ConvertLitersToGallons(double liters){
		return liters*0.264172;
	}
	
	static void Main(string[] args) {
		//input from user
		Console.Write("Enter the farhenheit(to celsius): ");
		double farhenheit=Convert.ToDouble(Console.ReadLine());
		Console.Write("Enter the celsius (to farhenheit): ");
		double celsius =Convert.ToDouble(Console.ReadLine());
		Console.Write("Enter the pounds (to kilogram): ");
		double pounds =Convert.ToDouble(Console.ReadLine());
		Console.Write("Enter the kilogram (to pounds): ");
		double kilograms=Convert.ToDouble(Console.ReadLine());
		Console.Write("Enter the gallons (to liters): ");
		double gallons =Convert.ToDouble(Console.ReadLine());
		Console.Write("Enter the liters (to gallons): ");
		double liters =Convert.ToDouble(Console.ReadLine()); 
		//Display the output
		Console.WriteLine($"{farhenheit} farhenheit in celsius is {ConvertFarhenheitToCelsius(farhenheit)}");
		Console.WriteLine($"{celsius} celsius in farhenheit {ConvertCelsiusToFarhenheit(celsius)}");
		Console.WriteLine($"{pounds} pounds  in  kilograms{ConvertPoundsToKilogram(pounds)}");
		Console.WriteLine($"{kilograms} kilograms  in  pounds {ConvertKilogramToPounds(kilograms)}");
		Console.WriteLine($"{gallons} gallons  in liters { ConvertGallonsToLiters(gallons)}");
		Console.WriteLine($"{liters} liters in  gallons {ConvertLitersToGallons(liters)}");




			}}