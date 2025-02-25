using System;
using System.Text.RegularExpressions;
class Program{
    static void Main(string[] args){
        Console.WriteLine("Enter the text: ");
        string text = Console.ReadLine();
        var dates = ExtractDates(text);
        Console.WriteLine(string.Join(", ", dates));
    }
    static MatchCollection ExtractDates(string text){
        string pattern = @"\b\d{2}/\d{2}/\d{4}\b";
        MatchCollection matches = Regex.Matches(text, pattern);
        return matches;
    }
}