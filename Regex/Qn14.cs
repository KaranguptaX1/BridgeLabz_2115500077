using System;
using System.Text.RegularExpressions;
class Program{
    static void Main(string [] args){
        Console.WriteLine("Enter the text: ");
        string text = Console.ReadLine();
        var repeatingWords = FindRepeatingWords(text);
        Console.WriteLine(string.Join(", ", repeatingWords));
    }
    static System.Collections.Generic.List<string> FindRepeatingWords(string text){
        string pattern = @"\b(\w+)\s+\1\b";
        MatchCollection matches = Regex.Matches(text, pattern);
        var repeatingWords = new System.Collections.Generic.List<string>();
        foreach (Match match in matches){
            repeatingWords.Add(match.Groups[1].Value);
        }
        return repeatingWords;
    }
}