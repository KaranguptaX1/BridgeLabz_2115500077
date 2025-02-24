using System;
class Season{
	static void Main(string[] args){
		//Inputs from user
		Console.WriteLine("Enter the  month in number : ");
		int month= Convert.ToInt32(Console.ReadLine());
		Console.WriteLine("Enter the day : ");
		int day= Convert.ToInt32(Console.ReadLine());
		//check if month and days lie in spring season 
		if (( day <=31 && day>=20) && (month>=3 && month<=6)){
			Console.WriteLine("Its a Spring Season");
		}
		else{
			Console.WriteLine("Not a Spring Season");
		}
	}
}