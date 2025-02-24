using System;
class BMI{
	static void Main(string[] args){
		// Input from user
		Console.Write("Enter Weight in kg: ");
		double weight = Convert.ToDouble(Console.ReadLine());
		Console.Write("Enter Height in cm: ");
		double height = Convert.ToDouble(Console.ReadLine());
		//height in meter
		double height_m = height/100;
		//calculate bmi
		double bmi = weight/(height_m * height_m);
		//conditions for bmi result
		if (bmi<=18.4){
			Console.WriteLine("UnderWeight");
		}
		else if (bmi>=18.5 && bmi <=24.9){
			Console.WriteLine("Normal");
		}
		else if (bmi>=25 && bmi <= 39.9){
			Console.WriteLine("OverWeight");
		}
		else if (bmi>=40.0){
			Console.WriteLine("Obese");
		}
		else{
			Console.WriteLine("Invalid BMI!");
		}
	}
}