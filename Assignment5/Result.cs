using System;
class Result{
	static void Main(string[] args){
		//Input from the user
		Console.Write("Enter your Physics marks: ");
		double physics_marks=Convert.ToDouble(Console.ReadLine());
		Console.Write("Enter your Chemistry marks: ");
		double chemistry_marks=Convert.ToDouble(Console.ReadLine());
		Console.Write("Enter your Maths marks: ");
		double math_marks=Convert.ToDouble(Console.ReadLine());
		// check condition for marks
		if ((physics_marks>100 || physics_marks<0) || (chemistry_marks>100 || chemistry_marks<0) || (math_marks<0 || math_marks>100)){
			Console.WriteLine("Enter marks between 0 and 100");
			return;
		}
		//average percentage
		double average = (physics_marks+chemistry_marks+math_marks) /3;
		//conditions to check grade
		switch(average){
			case double n when (n>=80):
				Console.WriteLine("Grade A");
				break;
			case double n when (n>=70 && n<=79):
				Console.WriteLine("Grade B");
				break;
			case double n when (n>=60 && n<=69):
				Console.WriteLine("Grade C");
				break;
			case double n when (n>=50 && n<=59):
				Console.WriteLine("Grade D");
				break;
			case double n when (n>=40 && n<=49):
				Console.WriteLine("Grade E");
				break;
			case double n when (n<=39):
				Console.WriteLine("Grade F");
				break;
			default:
				Console.WriteLine("Not Valid");
				break;
		}
		
	}}