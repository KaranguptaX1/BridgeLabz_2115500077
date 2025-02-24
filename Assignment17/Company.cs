using System;
using System.Collections.Generic;
//class to represent the employee
class Employee{
    private string employeeName{get;}
    private int age{get;}
    public Employee(string name,int age){
        this.employeeName=name;
        this.age=age;
    }
    public void Display(){
        Console.WriteLine($"Name: {employeeName} , Age: {age}");
    }
}
//class to represent department
class Department{
    public string departmentName{get;}
    //List of employees
    private List<Employee> employees= new List<Employee>();
    //Constructor
    public Department(string departmentName){
        this.departmentName=departmentName;
    }
    //method to add employee
    public void AddEmployee(string employeeName,int age){
        employees.Add(new Employee(employeeName,age));     
    }
    //method to show department employee
    public void DisplayDepartmentEmployees(){
        Console.WriteLine($"Department: {departmentName}");
        foreach(var employee in employees){
            employee.Display();
        }
    }

}
class Company{
    private string companyName{get;}
    private List<Department> departments= new List<Department>();
    public Company(string name){
        companyName=name;
    }
    public void AddDepartment(string departmentName){
        departments.Add(new Department(departmentName));
    }
    // Method to add an employee to a specific department
    public void AddEmployeeToDepartment(string departmentName, string employeeName, int age) {
        Department dept = departments.Find(d => d.departmentName == departmentName);
        if (dept != null) {
            dept.AddEmployee(employeeName, age);
        } else {
            Console.WriteLine($"Department {departmentName} not found.");
        }
    }
    // Display details of the company
    public void DisplayCompany() {
        Console.WriteLine($"Company: {companyName}");
        foreach (var dept in departments) {
            dept.DisplayDepartmentEmployees();
        }
    }
    // Destructor to show composition (Deleting a company deletes all departments and employees)
    ~Company() {
        Console.WriteLine($"Company {companyName} is being deleted. All departments and employees are also removed.");
    }


}

// Main program
class Program {
    static void Main(string[] args) {
        // Create a company
        Company myCompany = new Company("Tech Solutions");

        // Add departments
        myCompany.AddDepartment("IT");
        myCompany.AddDepartment("HR");

        // Add employees to departments
        myCompany.AddEmployeeToDepartment("IT", "Alice", 21);
        myCompany.AddEmployeeToDepartment("IT", "Bob", 54);
        myCompany.AddEmployeeToDepartment("HR", "Charlie", 25);

        // Display company details
        myCompany.DisplayCompany();

    }
}