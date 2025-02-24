using System;
class Multiplication{
	static void Main(string[] args){
		//Input from user
		Console.Write("Enter the number: ");
		int num = int.Parse(Console.ReadLine());
		//Initialize array
		int[] table = new int[10];
		//calculate the results
		for(int i=1;i<11;i++){
			table[i-1]=num*i;
		}
		//Display output
		for(int i=0;i<table.Length;i++){
			Console.WriteLine($"{num} * {i+1}= {table[i]}");
		}
	
	}}
		