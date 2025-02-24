using System;
class CountDownFor{
	static void Main(string[] args){
		Console.Write("Enter the Counter Value: ");
		int counter = Convert.ToInt32(Console.ReadLine());
		if (counter<1){
			Console.WriteLine("Enter Valid CountDown number!");
			return;
		}
		for(int count =counter;count>=1;count-- ){
			Console.WriteLine(count);
			
		}
		Console.WriteLine("Rocket Launch !!!");
		
	}
}