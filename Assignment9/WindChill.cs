using System;
class WindChill{
	//method to calculate the windchill
	public double CalculateWindChill(double temperature,double windspeed){
		double windchill= 35.74 + 0.6215* temperature + (0.4275*temperature -35.75) * windspeed*0.16;
		return windchill;
	}
	static void Main(string[] args) {
		//Input from user
		Console.Write("Enter the temperature: ");
		double temperature= Convert.ToDouble(Console.ReadLine());
		Console.Write("Enter the windspeed: ");
		double windSpeed= Convert.ToDouble(Console.ReadLine());
		//Call the class instance
		WindChill chill = new WindChill();
		//call the method
		double windchill= chill.CalculateWindChill(temperature,windSpeed);
		//Display the output
		Console.WriteLine($"The WindChill is : {windchill:0.00000}");

	}

}