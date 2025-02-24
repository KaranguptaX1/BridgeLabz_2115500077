using System;
public class Student{
    public int rollNumber;
    protected string name;
    private double CGPA;
    //Constructor
    public Student(int rollNumber, string name, double CGPA){
        this.rollNumber = rollNumber;
        this.name = name;
        this.CGPA = CGPA;
    }
    // Public methods to access and modify CGPA
    public double GetCGPA(){
        return CGPA;
    }
    public void SetCGPA(double CGPA){
        this.CGPA = CGPA;
    }
}

public class PostgraduateStudent : Student{
    public PostgraduateStudent(int rollNumber, string name, double CGPA)
        : base(rollNumber, name, CGPA) { }

    public void DisplayName(){
    	 // Accessing protected member
        Console.WriteLine("Name: " + name);
    }
}

class Program{
    static void Main(string[] args){
        PostgraduateStudent student = new PostgraduateStudent(101, "Rahul Kumar", 8.5);
        student.DisplayName();
        Console.WriteLine("CGPA: " + student.GetCGPA());
    }
}
