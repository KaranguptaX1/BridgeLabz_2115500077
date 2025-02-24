using System;
class Prime{
	static void Main(string[]args){
		//Initialize variables
		bool is_prime=true;
		//input from user
		Console.Write("Enter the number: ");
		int number = Convert.ToInt32(Console.ReadLine());
		//check if number greater than 1
		if (number>1){
			//loop to check prime condition
			for(int i=2; i<number;i++){
				if (number%i==0){
					is_prime=false;
					break;
				}
			}
			//is_prime condition output
			if (is_prime){
				Console.WriteLine($"{number} is Prime number");
			}
			else{
				Console.WriteLine($"{number} is not Prime");
			}
		}
		else{
			Console.Write("Enter a natural number greater than 1");
		}
	}}