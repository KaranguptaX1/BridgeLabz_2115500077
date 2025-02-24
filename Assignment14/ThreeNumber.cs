using System;
class ThreeNumber{
	//method to take input 
	public static double GetNumber(string message){
		double number;
		Console.Write(message);
		//Convert the string into double
		while(!double.TryParse(Console.ReadLine(),out number)){
			Console.Write("Invalid Input!.Enter a Integer: ");
		}
		return number;
	}
    //Method to find the maximum number
    public static double FindMaxNumber(double num1,double num2, double num3){
        //use of Inbuilt Max function
        return Math.Max(num1,Math.Max(num2,num3));
    }
    static void Main(string[] args){
        //Input from user
        double number1= GetNumber("Enter First Number: ");
        double number2= GetNumber("Enter Second Number: ");
        double number3= GetNumber("Enter Third Number: ");
        //call the method to fing Max number
        double maxNumber=FindMaxNumber(number1,number2,number3);
        //Display output
        Console.WriteLine($"The Maximum is: {maxNumber}");

    }
}