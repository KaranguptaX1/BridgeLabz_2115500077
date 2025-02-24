using System;
class Employee
{   //Initialize variables
    private static string CompanyName = "ABC Company";
    private string Name;
    private readonly int Id;
    private string Designation;
    private static int  TotalEmployees=0;
	//Method to display total employee
    public static void DisplayTotalEmployees(){
       Console.WriteLine($"The Total number of Employees is: {TotalEmployees} ");
    }
    // Constructor
    internal protected Employee(int id, string name, string designation)
    {
        this.Name = name;
        this.Id = id;
        this.Designation = designation;
        TotalEmployees++;
    }
    //Method to display employee details
    public void DisplayEmployee()
    {
        if(this is Employee)
        {
            Console.WriteLine($"The Company name is: {CompanyName}");
            Console.WriteLine($"The Employee Id is: {Id}");
            Console.WriteLine($"The Employee Name is :{Name}");
            Console.WriteLine($"The Employee Designation is: {Designation}");
            Console.WriteLine("--------------------------------------------");
        }
        else
        {
            Console.WriteLine($"This is not Employee of {CompanyName}");
        }
    }

}
class Program
{
    static void Main(string[] args)
    {
    	//make the instance of class
        Employee emp1 = new Employee(123, "Aman", "Worker");
        Employee emp2 = new Employee(011, "Shashank", "Manager");
        //Display total number of employees
        Employee.DisplayTotalEmployees();
        //Display employee details
        emp1.DisplayEmployee();
        emp2.DisplayEmployee();
    }
}