using System;
using System.Text.RegularExpressions;
class Program{
    static void Main(string[] args){
        Console.WriteLine("Enter the text: ");
        string text = Console.ReadLine();
        var languages = ExtractProgrammingLanguages(text);
        Console.WriteLine(string.Join(", ", languages));
    }
    static MatchCollection ExtractProgrammingLanguages(string text){
        string pattern = @"\b(Java|Python|JavaScript|Go|C\+\+|C#|Ruby|Swift|PHP|Rust|Kotlin|TypeScript)\b";
        MatchCollection matches = Regex.Matches(text, pattern);
        return matches;
    }
}