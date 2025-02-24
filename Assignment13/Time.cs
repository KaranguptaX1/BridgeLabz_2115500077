using System;
class Time{
	static void Main(string []args){
		//print current time in GMT
		DateTime gmtTime = DateTime.UtcNow;
		Console.WriteLine("Current GMT Time: "+gmtTime.ToString("yyyy-MM-dd HH:mm:ss")+ " UTC");
		//time Zone ID are differnt on mac/windows(Indian Standard Time)
		//Print current time in IST
		TimeZoneInfo istZone = TimeZoneInfo.FindSystemTimeZoneById("Asia/Kolkata");
		DateTime istTime = TimeZoneInfo.ConvertTimeFromUtc(gmtTime,istZone);
		Console.WriteLine("Current IST Time: "+ istTime.ToString("yyyy-MM-dd HH:mm:ss")+" IST");
		//Print current Pacific Standard Time
		TimeZoneInfo pstZone= TimeZoneInfo.FindSystemTimeZoneById("America/Los_Angeles");
		DateTime pstTime =TimeZoneInfo.ConvertTimeFromUtc(gmtTime,pstZone);
		Console.WriteLine("Current PST Time: "+ pstTime.ToString("yyyy-mm-dd HH:mm:ss")+ " PST");
	}}