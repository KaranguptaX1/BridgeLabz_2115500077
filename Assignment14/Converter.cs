using System;
class Converter{
    //method to get input
    static double GetInput(string unit){
        Console.Write($"Enter the temperature in {unit} : ");
        double input= Convert.ToDouble(Console.ReadLine());
        return input;
    }
    //method to convert Celsius to fahrenheit
    public static double ConvertCelsiusToFahrenheit(double celsius){
        double fahrenheit= (celsius *(double)9/5)+32;
        return fahrenheit;
    }
    //method to convert fahrenheit to celsius
    public static double ConvertFahreheitToCelsius(double fahrenheit){
        double celsius= (fahrenheit-32)*((double)5/9);
        return celsius;
    }
    //Display method
    static void Display(double temp,string unit){
        Console.WriteLine($"The temperature after Conversion is{temp} {unit}.");

    }
    static void Main(string [] args){
        //call the methods
        double inputCelsius= GetInput("celsius");
        double result= ConvertCelsiusToFahrenheit(inputCelsius);
        Display(result,"fahrenheit");
        double inputFahrenheit= GetInput("fahrenheit");
        double result2= ConvertFahreheitToCelsius(inputFahrenheit);
        Display(result2,"celsius");
        
    }

}