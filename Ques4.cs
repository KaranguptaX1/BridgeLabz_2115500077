using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
//Employee class
class Employee{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Department { get; set; }
    public double Salary { get; set; }
}
//EmployeeManager class
class EmployeeManager{
    private static string filePath = "employees.json";
    //Method to save employees
    public static void SaveEmployees(List<Employee> employees){
        //Try block
        try{
            string json = JsonSerializer.Serialize(employees, new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText(filePath, json);
            Console.WriteLine("Employees saved successfully.");
        }
        //Catch block to catch IOException
        catch (IOException ex){
            Console.WriteLine($"Error saving employees: {ex.Message}");
        }
    }
    //Method to load employees
    public static List<Employee> LoadEmployees(){
        //Try block
        try{
            if (!File.Exists(filePath)){
                Console.WriteLine("No employee data found.");
                return new List<Employee>();
            }
            string json = File.ReadAllText(filePath);
            return JsonSerializer.Deserialize<List<Employee>>(json) ?? new List<Employee>();
        }
        //Catch block to catch IOException
        catch (IOException ex){
            Console.WriteLine($"Error loading employees: {ex.Message}");
            return new List<Employee>();
        }
    }
}
class Program{
    static void Main(string[] args){
        List<Employee> employees = new List<Employee>{
            new Employee { Id = 1, Name = "Rahul", Department = "HR", Salary = 50000 },
            new Employee { Id = 2, Name = "Karan", Department = "IT", Salary = 70000 },
            new Employee { Id = 3, Name = "Prakhar", Department = "Finance", Salary = 65000 }
        };
        EmployeeManager.SaveEmployees(employees);
        Console.WriteLine("\nRetrieving Employees:");
        List<Employee> retrievedEmployees = EmployeeManager.LoadEmployees();
        foreach (var emp in retrievedEmployees){
            Console.WriteLine($"ID: {emp.Id}, Name: {emp.Name}, Department: {emp.Department}, Salary: {emp.Salary:C}");
        }
    }
}
