using System;
using System.Text.RegularExpressions;
class Program{
    static void Main(string[] args){
        Console.WriteLine("Enter the text: ");
        string text = Console.ReadLine();
        var links = ExtractLinks(text);
        Console.WriteLine(string.Join(", ", links));
    }
    static MatchCollection ExtractLinks(string text){
        string pattern = @"https?://[^\s]+";
        MatchCollection matches = Regex.Matches(text, pattern);
        return matches;
    }
}