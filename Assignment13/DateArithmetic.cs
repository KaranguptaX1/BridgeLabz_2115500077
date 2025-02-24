using System;
class Arithmetic{
static void Main(string[] args){
	//current the datetime
	DateTime datetime= DateTime.Now;
	//added 7 Days time
	DateTime addedDayTime=datetime.AddDays(7);
	//added 1 month time
	DateTime addedMonthTime= addedDayTime.AddMonths(1);
	//added 2 year time
	DateTime addedYearTime= addedMonthTime.AddYears(2);
	//subtract 3 weeks time
	DateTime subtract3WeeksTime= addedYearTime.AddDays(-21);
	//Display output
	Console.WriteLine($"The Current time: {datetime} \nAdded 7 Day: {addedDayTime} \nAdded Month Time: {addedMonthTime} \nAdded 2 Years Time: {addedYearTime}\nSubtracted 21 Days : {subtract3WeeksTime}");
	}
}