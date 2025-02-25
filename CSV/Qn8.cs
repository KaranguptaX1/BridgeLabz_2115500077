using System;
using System.IO;
using CsvHelper;
using System.Globalization;
using System.Text.RegularExpressions;
class Employee{
    public int ID { get; set; }
    public string Name { get; set; }
    public string Email { get; set; }
    public string Phone { get; set; }
}
class ValidateCSV{
    //validate email
    static bool IsValidEmail(string email){
        return Regex.IsMatch(email, @"^[^@\s]+@[^@\s]+\.[^@\s]+$");
    }
    //validate phone
    static bool IsValidPhone(string phone){
        return Regex.IsMatch(phone, @"^\d{10}$");
    }
    //validate records
    static void ValidateRecords(string path){
        try{
            using (var reader = new StreamReader(path))
            using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture)){
                csv.Read();  
                csv.ReadHeader(); 
                while (csv.Read()){
                    var emp = new Employee{
                        ID = csv.GetField<int>(0),
                        Name = csv.GetField<string>(1) ?? "",  
                        Email = csv.GetField<string>(2) ?? "",
                        Phone = csv.GetField<string>(3) ?? ""
                    };
                    if (!IsValidEmail(emp.Email) || !IsValidPhone(emp.Phone)){
                        Console.WriteLine($" ID: {emp.ID}, Name: {emp.Name}, Email: {emp.Email}, Phone: {emp.Phone}");
                    }
                }
            }
        }
        catch (Exception ex){
            Console.WriteLine($"Error: {ex.Message}");
        }
    }

    static void Main(string[] args){
        string path = "EmailEmployees.csv"; 
        ValidateRecords(path);
    }
}