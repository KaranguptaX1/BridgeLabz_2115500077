using System;
class ThreeFriend{
	static void Main(string[] args){
		//Initialize the arrays and variables
		string[] names={"Amar","Akbar","Anthony"};
		int[] ages =  new int[3];
		double[] heights =new double[3];
		int minAgeIndex;
		int tallestIndex;
		//for loop for Input age and height from user
		for(int i=0;i<names.Length;i++){
			Console.Write($"Enter the age of {names[i]}: ");
			ages[i]=Convert.ToInt32(Console.ReadLine());
			Console.Write($"Enter the height of {names[i]}: ");
			heights[i]=Convert.ToDouble(Console.ReadLine());
			
		}
		
		minAgeIndex=0;
		tallestIndex=0;
		//Finding the minimum age index and tallest height index
		for (int j=1;j<ages.Length;j++){
			if (ages[minAgeIndex]>ages[j]){
				minAgeIndex=j;
			}
			if (heights[tallestIndex]<heights[j]){
				tallestIndex=j;
			}
			
		}
		//Display the output
		Console.WriteLine($"Youngest is {names[minAgeIndex]} of age {ages[minAgeIndex]}.");
		Console.WriteLine($"Tallest is {names[tallestIndex]} of height {heights[tallestIndex]}.");
		
	}}