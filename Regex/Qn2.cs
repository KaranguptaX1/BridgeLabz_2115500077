using System;
using System.Text.RegularExpressions;
class Program{
    static void Main(string[] args){
        Console.WriteLine("Enter the license plate: ");
        string plate = Console.ReadLine();
        Console.WriteLine(ValidateLicensePlate(plate));
    }

    static string ValidateLicensePlate(string plate){
        string pattern = @"^[A-Z]{2}\d{4}$";
        if (Regex.IsMatch(plate, pattern)){
            return "Valid";
        }
        else{
            return "Invalid";
        }
    }
}