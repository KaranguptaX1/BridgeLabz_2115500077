using System;
class CountDownWhile{
	static void Main(string[] args){
		Console.Write("Enter the Counter Value: ");
		int counter = Convert.ToInt32(Console.ReadLine());
		int count=counter;
		if (count<1){
			Console.WriteLine("Enter Valid CountDown number!");
			return;
		}
		while(count>0){
			Console.WriteLine(count);
			count-=1;
		}
		Console.WriteLine("Rocket Launch !!!");
		
	}
}