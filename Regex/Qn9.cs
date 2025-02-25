using System;
using System.Text.RegularExpressions;
class Program{
    static void Main(string[] args){
        Console.WriteLine("Enter a text: ");
        string[] badWords = {"damn", "stupid", "idiot", "fool", "moron"};
        string output = CensorBadWords(input, badWords);
        Console.WriteLine(output);
    }
    static string CensorBadWords(string input, string[] badWords){
        foreach (string word in badWords){
            string pattern = $@"\b{Regex.Escape(word)}\b";
            input = Regex.Replace(input, pattern, "****", RegexOptions.IgnoreCase);
        }
        return input;
    }
}