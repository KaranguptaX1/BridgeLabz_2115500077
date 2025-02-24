using System;
class MaximumTen{
	static void Main(string[] args){
		//Initialize the variables and array
		double [] numbers = new double [10];
		double total =0.0;
		int index=0;
		//loop to take input from user
		while(true){
			Console.Write("Enter the number: ");
			double num =double.Parse(Console.ReadLine());
			//check if number is less than 1 or index is 10 to break loop
			if (num<=0 || index==10){
				break;
			} 
			//assign value
			numbers[index]=num;
			//increment
			index++;
			
		}
		//loop to find the total
		for(int i=0;i<index;i++){
			total+=numbers[i];
		}
		//Display output
		Console.WriteLine($"The total value is {total}");
	}}