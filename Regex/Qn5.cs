using System;
using System.Text.RegularExpressions;
class Program
{
    static void Main(){
        Console.WriteLine("Enter the text: ");
        string text = Console.ReadLine();
        var capitalizedWords = ExtractCapitalizedWords(text);
        Console.WriteLine(string.Join(", ", capitalizedWords));
    }
    static MatchCollection ExtractCapitalizedWords(string text){
        string pattern = @"\b[A-Z][a-z]*\b";
        MatchCollection matches = Regex.Matches(text, pattern);
        return matches;
    }
}