using System;

namespace Utilities
{
    public class DateFormatter
    {
        public string FormatDate(string inputDate)
        {
            if (string.IsNullOrWhiteSpace(inputDate))
                throw new ArgumentException("Input date cannot be null or empty");

            if (!DateTime.TryParseExact(inputDate, "yyyy-MM-dd", null, System.Globalization.DateTimeStyles.None, out DateTime parsedDate))
                throw new FormatException("Invalid date format. Expected format: yyyy-MM-dd");

            return parsedDate.ToString("dd-MM-yyyy");
        }
    }
}