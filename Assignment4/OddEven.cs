using System;
class OddEven{
	static void Main(string[] args){
		//Input number from user
		Console.Write("Enter the number: ");
		int number = Convert.ToInt32(Console.ReadLine());
		//check if number is natural
		if (number>0){
			//for loop
			for (int i=1;i<=number;i++){
				//check if number is even or not
				if (i%2==0){
					//Display output
					Console.WriteLine($"{i} is Even");
				}
				else{
					Console.WriteLine($"{i} is Odd");
				}
			}}
		else{
			//Display the ouput if number is not natural
			Console.WriteLine("Enter a natural number!");
		}
		
	}}