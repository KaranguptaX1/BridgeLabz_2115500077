using System;
using System.Text.RegularExpressions;
class Program{
    static void Main(string[] args){
        Console.WriteLine("Enter the text: ");
        string text = Console.ReadLine();
        var emails = ExtractEmails(text);
        foreach (var email in emails){
            Console.WriteLine(email);
        }
    }
    static MatchCollection ExtractEmails(string text){
        string pattern = @"\b[A-Za-z0-9._%+-]+@[A-Za-z0-9.-]+\.[A-Za-z]{2,}\b";
        MatchCollection matches = Regex.Matches(text, pattern);
        return matches;
    }
}