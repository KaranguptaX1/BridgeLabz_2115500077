using System;
using System.Collections.Generic;
//Parent class 
abstract class Employee{
    //private varibles
    private int employeeId;
    private string name;
    private double baseSalary;
    //properties of variables
    public int EmployeeId{get{return employeeId;}}
    public string Name{get{return name;}}
    public double BaseSalary{get{return baseSalary;}}
    //Constructor
    public Employee(int employeeId,string name, double baseSalary){
        this.employeeId=employeeId;
        this.name=name;
        this.baseSalary=baseSalary;
    }
    //abstract method
    public abstract double CalculateSalary();
    //Display Details method
    public void DisplayDetails(){
        Console.WriteLine($"Employee Details: \nEmployee ID :{employeeId}\nName: {name}\nSalary: {CalculateSalary()}");
    }
}
//Interface class
interface IDepartment{
    //methods
    void AssignDepartment(string dept);
    string GetDepartmentDetails();
}
//FullTimeEmployee subclass
class FullTimeEmployee:Employee,IDepartment{
    private string department;
    //Constructor
    public FullTimeEmployee(int employeeId,string name,double baseSalary):base(employeeId,name,baseSalary){}
    //Assign department method of interface
    public void AssignDepartment(string dept){
        department=dept;
    }
    //GetDepartmentDetails method of interface
    public string GetDepartmentDetails(){
        return $"{Name} works in {department} department ";
    }
    //override parent class method
    public override double CalculateSalary(){
        return BaseSalary;
    }
}
//PartTimeEmployee subclass
class PartTimeEmployee:Employee,IDepartment{
    //private variables
    private int workHours;
    private double salaryPerHour;
    private string department;
    //Constructor
    public PartTimeEmployee(int employeeId,string name,int hours,double hourlySalary):base(employeeId,name,0){
        workHours=hours;
        salaryPerHour=hourlySalary;
    }
    //Override parent class method
    public override double CalculateSalary(){
        double salary = salaryPerHour*workHours;
        return salary;
    }
    //Interface class methods description
    public void AssignDepartment(string dept){
        department=dept;
    }
    public string GetDepartmentDetails(){
        return ($"{Name} works in {department} department ");
    }
}
class EmployeeManagement{
    //Main Method
    static void Main(string [] args){
        //List of employees
        List<Employee> employees = new List<Employee>();
        FullTimeEmployee employee1= new FullTimeEmployee(112,"Rahul Kumar",50000);
        PartTimeEmployee employee2= new PartTimeEmployee(011,"Mohan",240,70);
        employee1.AssignDepartment("Backend");
        employee2.AssignDepartment("Frontend trainee");
        employees.Add(employee1);
        employees.Add(employee2);
        foreach (var employee in employees){
            employee.DisplayDetails();
            //check employee forIDepartment and type cast into deptEmployee
            if(employee is IDepartment deptEmployee){
                Console.WriteLine(deptEmployee.GetDepartmentDetails());
            }
            Console.WriteLine("---------------------------");
        }
    }
}
