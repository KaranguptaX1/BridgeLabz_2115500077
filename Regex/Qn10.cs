using System;
using System.Text.RegularExpressions;
class Program{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter the IP address: ");
        string ipAddress = Console.ReadLine();
        Console.WriteLine(ValidateIPAddress(ipAddress));
    }
    static bool ValidateIPv4(string ipAddress){
        string pattern = @"^((25[0-5]|2[0-4][0-9]|1[0-9]{2}|[1-9]?[0-9])\.){3}(25[0-5]|2[0-4][0-9]|1[0-9]{2}|[1-9]?[0-9])$";
        return Regex.IsMatch(ipAddress, pattern);
    }
}