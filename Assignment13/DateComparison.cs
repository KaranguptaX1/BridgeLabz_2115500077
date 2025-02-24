using System;
class DateComparison{
//method to manually compare dates
public static string CompareManually(DateTime date1,DateTime date2){
 		if (date1 < date2){
            return $"{date1} is earlier than {date2}";
        }
        else if (date1 > date2){
            return $"{date1} is later than {date2}";
        }
        else{
            return $"{date1} is the same as {date2}";
        }
}
//method to understand result better
public static String ResultStatus(int result,DateTime date1 ,DateTime date2){
	if (result==-1){
		return ($"{date1} is earlier than {date2}");
	}
	else if(result==0){
		return($"{date1} is same as {date2}");
	}
	else{
		return($"{date1} is later than {date2}");
	}
	}
static void Main(string [] args){
//Input from user
Console.Write("Enter a date (dd-MM-yyyy): ");
string input1= Console.ReadLine();
DateTime date1= DateTime.ParseExact(input1,"dd-MM-yyyy",null);
Console.Write("Enter a date (dd-MM-yyyy): ");
string input2= Console.ReadLine();
DateTime date2= DateTime.ParseExact(input2,"dd-MM-yyyy",null);
//Get the result using compare,compareTo
int result1= DateTime.Compare(date1,date2);
int result2= date1.CompareTo(date2);
//Dispaly output
Console.WriteLine($"Using Compare Result : {ResultStatus(result1,date1,date2)}");
Console.WriteLine($"Using compare Result : {ResultStatus(result2,date1,date2)}");
Console.WriteLine($"using manual Result : {CompareManually(date1,date2)}");

}}