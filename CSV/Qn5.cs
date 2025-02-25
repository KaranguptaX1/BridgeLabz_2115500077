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
    public int Salary { get; set; }
}
//Record class
class Records{
    //Method to search Employee
    static List<Employee> SearchEmployee(string path,string name){
        try{
            using (StreamReader sr = new StreamReader(path))
            using (CsvReader csv = new CsvReader(sr, CultureInfo.InvariantCulture)){
                var employees = csv.GetRecords<Employee>();  
                var result = new List<Employee>();
                foreach (var employee in employees){
                    if (employee.Name==name){
                        result.Add(employee);
                    }
                }
                return result;
            }
        }
        //handle exception and return empty list
        catch (Exception ex){
            Console.WriteLine($"Error: {ex.Message}");
            return new List<Employee>(); 
        }
    }
    // Main method
    static void Main(string[] args){
        string path = "Employees.csv";  
        string name= "Rahul";
        var result = SearchEmployee(path,name.ToLower());
        //if list Contains
        if (result.Count > 0){
            Console.WriteLine("Employees Found: ");
            foreach (var employee in result){
                Console.WriteLine($"{employee.ID}, {employee.Name}, {employee.Department}, {employee.Salary}");
            }
        }
        else{
            Console.WriteLine("Not Found");
        }
    }
}