using System;
using System.Text.RegularExpressions;
class Program{
    static void Main(string[] args){
        Console.WriteLine("Enter the SSN: ");
        string ssn = Console.ReadLine();
        ValidateSSN(ssn);
    }
    static void ValidateSSN(string ssn){
        string pattern = @"^\d{3}-\d{2}-\d{4}$";
        if (Regex.IsMatch(ssn, pattern)){
            Console.WriteLine($"{ssn} is valid");
        }
        else{
            Console.WriteLine($"{ssn} is invalid");
        }
    }
}