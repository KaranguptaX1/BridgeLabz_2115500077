using System;
class MultiplicationSixToNone{
	static void Main(string[] args){
		//Input from user
		Console.Write("Enter the number : ");
		int num = int.Parse(Console.ReadLine());
		//Initialize array
		int[] table = new int[4];
		//calculate the results
		for(int i=0;i<4;i++){
			table[i]=num*(i+6);
		}
		//Display output
		for(int i=0;i<table.Length;i++){
			Console.WriteLine($"{num} * {i+6}= {table[i]}");
		}
	
	}}
		