using System;
class DateFormatting{
	static void Main(string[] args){
		//datetime instance
		DateTime datetime =DateTime.Now;
		//different formats to print
		Console.WriteLine(datetime.ToString("dd/MM/yyyy"));
		Console.WriteLine(datetime.ToString("yyyy-MM-dd"));
		Console.WriteLine(datetime.ToString("ddd,MMM dd,yyyy"));
		
	}}