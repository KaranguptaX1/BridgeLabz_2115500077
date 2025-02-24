using System;
class Course{
    private string courseName;
    private int duration;
    private double fee;
    private static string instituteName = "Tech Academy";
	//Constructor
    public Course(string courseName, int duration, double fee){
        this.courseName = courseName;
        this.duration = duration;
        this.fee = fee;
    }
    //display method
    public void DisplayCourseDetails(){
        Console.WriteLine($"Course: {courseName}, Duration: {duration} months, Fee: {fee}, Institute: {instituteName}");
    }
	//method to update institute name
    public static void UpdateInstituteName(string newName){
        instituteName = newName;
    }
}

class Program{
    static void Main(){
        Course c1 = new Course("C# Programming", 3, 500);
        Course c2 = new Course("Java Programming", 4, 600);

        c1.DisplayCourseDetails();
        c2.DisplayCourseDetails();

        Course.UpdateInstituteName("Advanced Tech Institute");

        c1.DisplayCourseDetails();
        c2.DisplayCourseDetails();
    }
}
