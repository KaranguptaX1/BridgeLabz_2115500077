using System;
class Mean{
	// method to calculate the mean height 
	static double MeanHeight(double[] arr,int number){
		double sum = 0;
		for(int i=0;i<number;i++){
			sum+=arr[i];
		}
		//mean height value
		return sum/number;
	}
	static void Main(string[] args){
		//Intialize variable
		int numbers=11;
		double [] heights = new double [numbers];
		int index=0;
		//Input from user for heights
		while(true){
			Console.Write("Enter the Heights in cm : ");
			heights[index]=double.Parse(Console.ReadLine());
			index++;
			//Check if number of players have reaches
			if (index==numbers){
				break;
			}
			
		}
		//Display output
		Console.WriteLine($"Mean Height of tema is : {MeanHeight(heights,numbers):0.000} cm");
		
	}}