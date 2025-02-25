using System;
using System.Text.RegularExpressions;
class Program{
    static void Main(string[] args){   
        Console.WriteLine("Enter the text: ");
        string input = Console.ReadLine();
        string output = ReplaceMultipleSpaces(input);
        Console.WriteLine(output);
    }
    static string ReplaceMultipleSpaces(string input){
        string pattern = @"\s+";
        string result = Regex.Replace(input, pattern, " ");
        return result;
    }
}