using System;
class BMI{
	//method calculates the bmi and put value in data
	public static void CalculateBMI(double[,] data){
		for(int i=0;i<data.GetLength(0);i++){
			double weight=data[i,0];
			double height=data[i,1];
			height/=100;
			data[i,2]= weight/(height*height);
			
		}
	} 
	//method to calculate the bmi status
	public static string[] CalculateBMIStatus(double[,] data){
		string[] status = new string[data.GetLength(0)];
		//for loop to iterate over data
		for(int i=0;i<data.GetLength(0);i++){
			double bmi=data[i,2];
			//check the bmi conditions
			if (bmi<=18.4){
			 	status[i]="Underweight";
			}
			else if (bmi>=18.5 && bmi<=24.9){
				status[i]="Normal";
			}
			else if (bmi>=25.0 && bmi<=39.9){
				status[i]="OverWeight";
			}
			else{
				status[i]="Obese";
			}}
			//return array
			return status;
	}
	static void Main(string[] args) {
		//Initialize array
		double[,] personsData = new double[10,3];
		//loop to take input height and weight
		for(int i=0;i<personsData.GetLength(0);i++){
		Console.Write($"Enter the weight (in kg) of Person {i+1} : ");
		double kilogram= Convert.ToDouble(Console.ReadLine());
		Console.Write($"Enter the height (in cm) of Person {i+1}: ");
		double height= Convert.ToDouble(Console.ReadLine());
		personsData[i,0]=kilogram;
		personsData[i,1]=height;
		}
		//call the calculateBMI method
		CalculateBMI(personsData);
		//call the calculateBMIStatus method
		string[] bmiStatus=CalculateBMIStatus(personsData);
		//Display output
		for(int i=0;i<personsData.GetLength(0);i++){			
			Console.WriteLine($"Person {i+1} weight {personsData[i,0]}, height {personsData[i,1]} \nhave bmi {personsData[i,2]:0.000} and bmi status {bmiStatus[i]}");
		}
	}
}