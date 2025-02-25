using System;
using System.Text.RegularExpressions;
class Program{
    static void Main(string[] args){
        Console.WriteLine("Enter the hex color: ");
        string color = Console.ReadLine();
        Console.WriteLine(ValidateHexColor(color));
    }
    static string ValidateHexColor(string color){
        string pattern = @"^#[0-9A-Fa-f]{6}$";
        if (Regex.IsMatch(color, pattern)){
            return "Valid";
        }
        else{
            return "Invalid";
        }
    }
}