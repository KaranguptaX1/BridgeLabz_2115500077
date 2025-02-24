using System;
class SumNaturalNumber{
	//method to sum using recursion
	public static int SumUsingRecursion(int num){
		//base condition or break condition
		if (num==1){
			return 1;
		}
		//else return statement and call function again
		return num + SumUsingRecursion(num-1);
	}
	//method returns sum using formula
	public static int SumUsingFormulae(int num){
		return (num*(num+1))/2;
	}
	static void Main(string[] args) {
		//input from user
		Console.Write("Enter the natural number: ");
		int number = int.Parse(Console.ReadLine());
		//Condition to check if number is natural or not
		if (number<1){
			Console.WriteLine("This is not natural number!");
			return ;
		}
		//call both methods
		int sumRecursion= SumUsingRecursion( number);
		int sumFormulae=SumUsingFormulae(number);
		//compare the results
		if (sumRecursion==sumFormulae){
			//Display output
			Console.WriteLine($"Sum of both is same!");
		}
		else{Console.WriteLine($"Sum is different!");}
		
		
	}
	}