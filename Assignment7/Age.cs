using System;
class Age{
	static void Main(string[] args){
		//Initialize array
		int []ages =new int [10];
		//Input ages from user
		for (int i=0;i<10;i++){
			Console.Write($"Enter the age of student {i+1}: ");
			ages[i]= int.Parse(Console.ReadLine());
		}
		//Iteration over array
		for (int i=0;i<10;i++){
			//check if age is positive
			if (ages[i]>=0){
				//check if age is above 17
				if (ages[i]>=18){
					//Display output
					Console.WriteLine($"the student with age {ages[i]} can vote.");
				}
				else{
					Console.WriteLine($"the student with age {ages[i]} cannot vote.");
				}
			}
			else{
				Console.WriteLine("Invalid age!");
			}
		}
	}}