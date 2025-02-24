using System;
public class Employee{
    // Private fields 
    private string name;
    private int id;
    private double salary;
    // Constructor to initialize attributes
    public Employee(string name, int id, double salary){
        this.name = name;
        this.id = id;
        this.salary = salary;
    }
    // Method to display employee details
    public void DisplayDetails(){
        Console.WriteLine($"Employee ID: {id}");
        Console.WriteLine($"Name: {name}");
        Console.WriteLine($"Salary: ${salary:F2}");
    }
}
class Program{
	static void Main(){
        // Creating Employee objects
        Employee emp1 = new Employee("Rahul Kumar", 101, 50000);
        Employee emp2 = new Employee("Manju Kumari", 102, 60000);
        // Displaying details
        Console.WriteLine("=== Employee 1 Details ===");
        emp1.DisplayDetails();
        Console.WriteLine("\n=== Employee 2 Details ===");
        emp2.DisplayDetails();
    }
}
