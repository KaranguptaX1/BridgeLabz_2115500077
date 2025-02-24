using System;
class Frequency{
	static void Main(string[] args){
		//Input from the user
		Console.Write("Enter the number: ");
		int number=Convert.ToInt32(Console.ReadLine());
		//calculate  the digits
		int count=(int)Math.Log10(number) +1;
		//intialize digits array
		int[] digits = new int[count];
		int index=0;
		//store the digits
		while (number!=0){
			digits[index]=number%10;
			number/=10;
			index++;
		}
		//intialize and calculate the frequency of each digit
		int [] frequency =new int[10];
		for(int i=0;i<count;i++){
			frequency[digits[i]]+=1;
		}
		//display output
		for(int i=0;i<frequency.Length;i++){
			Console.WriteLine($"The frequency of digit {i} is {frequency[i]}");
		}
	}}