using System;
class WeekDay{
    static void Main(string[] args){
       // Input for user t
        Console.Write("Enter the month (1-12): ");
        int m = int.Parse(Console.ReadLine()); // Month
        Console.Write("Enter the day (1-31): ");
        int d = int.Parse(Console.ReadLine()); // Day
        Console.Write("Enter the year: ");
        int y = int.Parse(Console.ReadLine()); // Year

        // Calculate the day of the week using the formula
        int y0 = y - (14 - m) / 12;
        int x = y0 + y0 / 4 - y0 / 100 + y0 / 400;
        int m0 = m + 12 * ((14 - m) / 12) - 2;
        int d0 = (d + x + (31 * m0) / 12) % 7;

        // Determine the day using a switch case
        string dayName;
        switch (d0){
            case 0:
                dayName = "Sunday";
                break;
            case 1:
                dayName = "Monday";
                break;
            case 2:
                dayName = "Tuesday";
                break;
            case 3:
                dayName = "Wednesday";
                break;
            case 4:
                dayName = "Thursday";
                break;
            case 5:
                dayName = "Friday";
                break;
            case 6:
                dayName = "Saturday";
                break;
            default:
                dayName = "Invalid day";
                break;
        }

        // Output the result
        Console.WriteLine($"The day of the week for {m}/{d}/{y} is: {dayName}");
    }
}
