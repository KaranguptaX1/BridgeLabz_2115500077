using System;
class Vote{
	static void Main(string[] args){
		//Input age from User
		Console.Write("Enter Your Age: ");
		int age = Convert.ToInt32(Console.ReadLine());
		//check if age is greater than equal to 18 or not 
		if (age>=18){
			//Display output
			Console.WriteLine($"The person's age is {age} and can vote.");
		}
		else{
			Console.WriteLine($"The person's age is {age} and cannot vote.");
		}
	}
}