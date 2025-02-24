using System;
class Season{
	//method to  check if it is spring season
	public static bool IsSpringSeason(int date,int month){
		//Conditions to check season
		if ((date>=20 && date<=31) && (month<=6 && month>=3)){
			return true;
		}
		else{
			return false;
		}
	}
	static void Main(string [] args){
		//Input from user
		Console.Write("Enter the Date: ");
		int date = Convert.ToInt32(Console.ReadLine());
		Console.Write("Enter the Month in number: ");
		int month = Convert.ToInt32(Console.ReadLine());
		//call the method
		bool result = IsSpringSeason(date,month);
		//Display the output
		if (result){
			Console.WriteLine("Yes it is Spring Season");
			
		}
		else{
		Console.WriteLine($"No it is Spring Season");}
		
	}}