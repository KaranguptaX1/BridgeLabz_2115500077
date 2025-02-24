using System;
class Numbers{
	static void Main(string[] args){
		//Initialize array
		int []numbers =new int [5];
		//Input numbers from user
		for (int i=0;i<5;i++){
			Console.Write($"Enter the numbers: ");
			numbers[i]= int.Parse(Console.ReadLine());
		}
		//loop to check the number are even ,odd , negative,zero
		for (int i=0;i<numbers.Length;i++){
			if (numbers[i]>0){
				if (numbers[i]%2==0){
					Console.WriteLine($"the number {numbers[i]} is even");
				}
				else{
					Console.WriteLine($"the number {numbers[i]} is odd");
				}
			}
			else if (numbers[i]==0){
				Console.WriteLine($"the number {numbers[i]} is Zero");
			}
			else{
				//Display output
				Console.WriteLine($"the number {numbers[i]} is Negative");
			}
		}
		//compare the first number and last number
		if (numbers[0]>numbers[numbers.Length -1]){
			//Display output
			Console.WriteLine($"the number {numbers[0]} is greater than last number {numbers[numbers.Length -1]}");
		}
		else if (numbers[0]==numbers[numbers.Length -1]){
			Console.WriteLine($"the number {numbers[0]} is equal to last number {numbers[numbers.Length -1]}");}
		else{
			Console.WriteLine($"the number {numbers[0]} is less than last number {numbers[numbers.Length -1]}");}
		}
}