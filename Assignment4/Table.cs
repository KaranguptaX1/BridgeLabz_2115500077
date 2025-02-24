using System;
class Table{
	static void Main(string[] args){
		//Input from user
		Console.Write("Enter the number between 6 and 9: ");
		int number = Convert.ToInt32(Console.ReadLine());
		//check if number is between 6 and 9
		if(number >=6 && number <=9){
			//for loop
			for (int i =1;i<11;i++){
				//display output
				Console.WriteLine($"{number} * {i} = {number*i}");
			}}
		else{
			//ouput if number is not between 6 and 9
			Console.WriteLine("Enter the number between 6 and 9!");
		}
		
	}}