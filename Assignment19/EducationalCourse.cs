
using System;
//Parent Class
class Course{
    //Protected variables
    protected string CourseName;
    protected string Duration;
    //Constructor
    public Course(string CourseName,string Duration){
        this.CourseName=CourseName;
        this.Duration=Duration;
    }
    //Method to display details
    public virtual void DisplayDetails(){
        Console.WriteLine($"CourseName: {CourseName}\nDuration: {Duration}");
    }
}
//Online Course is subclass of Course
class OnlineCourse:Course{
    //Some other details
    protected string Platform;
    protected bool IsRecorded;
    public OnlineCourse(string CourseName,string Duration,string Platform,bool IsRecorded):base(CourseName,Duration){
        this.Platform=Platform;
        this.IsRecorded=IsRecorded;
    }
    //override parent method
    public override void DisplayDetails()
    {
        base.DisplayDetails();
        Console.WriteLine($"Platform: {Platform}\nIs Recorded: {IsRecorded}");
    }
}
//subclass of Online Course
class PaidOnlineCourse:OnlineCourse{
    private double Fees;
    private double Discount;
    public PaidOnlineCourse(string CourseName,string Duration,string Platform,bool IsRecorded,double Fees,double Discount):base(CourseName,Duration,Platform,IsRecorded){
        this.Fees=Fees;
        this.Discount=Discount;
    }
    public override void DisplayDetails()
    {
        base.DisplayDetails();
        Console.WriteLine($"Fees: {Fees} \nDiscount:{Discount}");
    }
}
class EducationalCourse{
    //Main Method
    static void Main(string[] args){
        Course course= new Course("Java","02 Months");
        OnlineCourse onlineCourse= new OnlineCourse("Python","03 Months","CodingBlocked",false);
        PaidOnlineCourse paidOnlineCourse=new PaidOnlineCourse("AI","1 Month","hackerrank",true,10000,7600);
        Console.WriteLine("Course");
        course.DisplayDetails();
        Console.WriteLine("----------------------");
        Console.WriteLine("Online Course");
        onlineCourse.DisplayDetails();
        Console.WriteLine("----------------------");
        Console.WriteLine("Paid Online Course");
        paidOnlineCourse.DisplayDetails();
    }
}

