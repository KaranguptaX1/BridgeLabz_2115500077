using System;
using System.Text.RegularExpressions;
class Program{
    static void Main(string[] args){
        Console.WriteLine("Enter the text: ");
        string text = Console.ReadLine();
        var currencies = ExtractCurrencyValues(text);
        Console.WriteLine(string.Join(", ", currencies));
    }
    static MatchCollection ExtractCurrencyValues(string text){
        string pattern = @"\$\s*\d+(\.\d{1,2})?|\d+(\.\d{1,2})?";
        MatchCollection matches = Regex.Matches(text, pattern);
        return matches;
    }
}