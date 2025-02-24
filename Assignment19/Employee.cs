
using System;
//parent class
class Employee{
    //Protected Variables
    protected string Name;
    protected int Id;
    protected double Salary;
    //Constructor
    public Employee(string Name, int Id,double Salary){
        this.Name=Name;
        this.Id=Id;
        this.Salary=Salary;
    }
    //Method to override
    public virtual void DisplayDetails(){
        Console.WriteLine($"Employee Details: \nName: {Name}\nId: {Id} \nSalary: {Salary}");
        Console.WriteLine("-----------------------------------");
    }
}
//Manger Subclass
class Manager:Employee{
    //special attribute
    private int TeamSize;
    //Constructor
    public Manager(string Name,int id,double Salary,int TeamSize):base(Name,id,Salary){
        this.TeamSize=TeamSize;
    }
    //override the displaydetails method
    public override void DisplayDetails(){
        Console.WriteLine($"Manager Details: \nName: {Name}\nID: {Id}\nSalary: {Salary}\nTeamSize:{TeamSize}");
        Console.WriteLine("-----------------------------------");
    }
}
class Developer:Employee{
    private string ProgrammingLanguage;
    public Developer(string Name,int id,double Salary,string language):base(Name,id,Salary){
        ProgrammingLanguage=language;
    }
    public override void DisplayDetails(){
        Console.WriteLine($"Developer Details: \nName: {Name}\nID: {Id}\nSalary: {Salary}\nLanguage:{ProgrammingLanguage}");
        Console.WriteLine("-----------------------------------");
    }
}
class Intern:Employee{
    private string InternshipDuration;
    public Intern(string Name,int id,double Salary,string duration):base(Name,id,Salary){
        InternshipDuration=duration;
    }
    public override void DisplayDetails(){
        Console.WriteLine($"Intern Details: \nName: {Name}\nID: {Id}\nSalary: {Salary}\nInternship Duration:{InternshipDuration}");
        Console.WriteLine("-----------------------------------");
    }
}
class Program{
    //using all the classes in main method
    static void Main(string[] args){
        Employee employee=new Employee("Rahul",2115500117,40000.00);
        employee.DisplayDetails();
        Manager manager= new Manager("Karan",2115500017,60000.55,10);
        Developer developer= new Developer("Amogh",2211550,45000.57,"Java");
        Intern intern =new Intern("Vivek",1024422,25000,"10");
        manager.DisplayDetails();
        developer.DisplayDetails();
        intern.DisplayDetails();
    }
}

