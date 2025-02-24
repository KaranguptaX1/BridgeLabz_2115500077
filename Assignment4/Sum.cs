using System;
class Sum{
	static void Main(string[] args){
		//Initialize the vaiables
		double total=0.0;
		double  user_input;
		//while loop and check if user_input is not equal to zero to take the inputs from user
		while(true){
		Console.Write("Enter the value(0 to stop) :");
		user_input = Convert.ToDouble(Console.ReadLine());
		if (user_input==0){
			break;
		}
		//add the numbers in total
		total+=user_input;
		}
		//display the output
		Console.WriteLine($"The sum of numbers user entered is {total}");
		
	}
}