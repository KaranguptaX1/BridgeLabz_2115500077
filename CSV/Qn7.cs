using System;
using System.IO;
using System.Globalization;
using System.Collections.Generic;
using CsvHelper;
//Employee class
class Employee{
    public int ID { get; set; }
    public string Name { get; set; }
    public string Department { get; set; }
    public double Salary { get; set; }
}
//sort class
class Sort{
    static void TopSalaries(string path){
        try{
            using (StreamReader sr = new StreamReader(path))
            using (CsvReader csv = new CsvReader(sr, CultureInfo.InvariantCulture)){
                var employees = csv.GetRecords<Employee>().ToList(); 
                // Sort employees by Salary in descending order
                employees.Sort((e1, e2) => e2.Salary.CompareTo(e1.Salary));
                Console.WriteLine("Top 5 Highest Paid Employees:");
                for (int i = 0; i < Math.Min(5, employees.Count); i++){
                    var emp = employees[i];
                    Console.WriteLine($"{emp.ID}, {emp.Name}, {emp.Department}, {emp.Salary}");
                }
            }
        }
        catch (Exception ex){
            Console.WriteLine($"Error: {ex.Message}");
        }
    }
    //Main Method
    static void Main(string[] args){
        string path = "Employees.csv"; 
        TopSalaries(path);
    }
}