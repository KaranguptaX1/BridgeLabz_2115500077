using System;
public class Employee{
    public int employeeID;
    protected string department;
    private double salary;
	//Constructor
    public Employee(int employeeID, string department, double salary){
        this.employeeID = employeeID;
        this.department = department;
        this.salary = salary;
    }
    // Public method to modify salary
    public void SetSalary(double salary){
        this.salary = salary;
    }

    public double GetSalary(){
        return salary;
    }
}

public class Manager : Employee{
    public Manager(int employeeID, string department, double salary) : base(employeeID, department, salary) { }

    public void DisplayEmployeeInfo(){
        Console.WriteLine("Employee ID: " + employeeID); // Accessing public member
        Console.WriteLine("Department: " + department); // Accessing protected member
        Console.WriteLine("Salary: "+ GetSalary());
    }
}

class Program{
    static void Main(string[] args){
        Manager manager = new Manager(1001, "HR", 75000);
        manager.DisplayEmployeeInfo();
        manager.SetSalary(80000);
        Console.WriteLine("New Salary: " + manager.GetSalary());
    }
}
