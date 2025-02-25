using System;
using System.Text.RegularExpressions;
class Program{
    static void Main(string[] args){
        Console.WriteLine("Enter the credit card number: ");
        string cardNumber = Console.ReadLine();
        Console.WriteLine(ValidateCreditCard(cardNumber));
    }
    static string ValidateCreditCard(string cardNumber){
        string visaPattern = @"^4[0-9]{15}$";
        string masterCardPattern = @"^5[0-9]{15}$";
        if (Regex.IsMatch(cardNumber, visaPattern)){
            return "Valid Visa";
        }
        else if (Regex.IsMatch(cardNumber, masterCardPattern)){
            return "Valid MasterCard";
        }
        else{
            return "Invalid";
        }
    }
}