using System;
using System.Collections.Generic;
class University{
    public string Name { get; set; }
    public List<Department> Departments { get; set; }
    // Constructor 
    public University(string name){
        Name = name;
        Departments = new List<Department>();
    }
    // Method to add a department to the university
    public void AddDepartment(Department department){
        Departments.Add(department);
    }
}
class Department{
    public string Name { get; set; }
    // Constructor 
    public Department(string name){
        Name = name;
    }
}
class Faculty{
    public string Name { get; set; }
    // Constructor 
    public Faculty(string name){
        Name = name;
    }
}

class Program{
    static void Main(){
        var university = new University("Tech University");
        var department1 = new Department("Computer Science");
        var department2 = new Department("Mathematics");

        var faculty1 = new Faculty("Dr. Smith");
        var faculty2 = new Faculty("Dr. Johnson");
        // Adding departments to the university
        university.AddDepartment(department1);
        university.AddDepartment(department2);
        // Displaying university details
        Console.WriteLine($"University: {university.Name}");
        Console.WriteLine("Departments:");
        foreach (var dept in university.Departments){
            Console.WriteLine(dept.Name);
        }
        // Faculty members can exist independently of any department
        Console.WriteLine("Faculties:");
        Console.WriteLine(faculty1.Name);
        Console.WriteLine(faculty2.Name);
    }
}
