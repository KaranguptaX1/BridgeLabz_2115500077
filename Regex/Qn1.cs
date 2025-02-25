using System;
using System.Text.RegularExpressions;
class Program{
    static void Main(string[] args){
        Console.WriteLine("Enter the username: ");
        string username = Console.ReadLine();
        Console.WriteLine(ValidateUsername(username));
    }
    static string ValidateUsername(string username){
        string pattern = @"^[a-zA-Z][a-zA-Z0-9_]{4,14}$";
        if (Regex.IsMatch(username, pattern)){
            return "Valid";
        }
        else{
            return "Invalid";
        }
    }
}