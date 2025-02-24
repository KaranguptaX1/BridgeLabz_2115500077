using System;
using System.Collections.Generic;
//abstract class
abstract class CourseType{
    //Properties
    public string Name{get;set;}
    public int Credits{get;set;}
    //Constructor
    public CourseType(string name,int credits){
        Name=name;
        Credits=credits;
    }
    //abstract method
    public abstract void Display();
}
//ExamCourse class
class ExamCourse:CourseType{
    public double  PassingMarks{get;set;}
    public ExamCourse(string name,int credits,double marks):base(name,credits){
        PassingMarks=marks;
    }
    //Override abstract method
    public override void Display(){
        Console.WriteLine($"Course Name: {Name}, Credits: {Credits}, Passing Marks : {PassingMarks}");
    }
}
//AssignmentCourse class
class AssignmentCourse:CourseType{
     public int NumberOfAssignments{get;set;}
    public AssignmentCourse(string name,int credits,int assignments):base(name,credits){
        NumberOfAssignments=assignments;
    }
    public override void Display(){
        Console.WriteLine($"Course Name: {Name}, Credits: {Credits},Number of Assignments: {NumberOfAssignments}");
    }
}
//Generic class
class Course<T> where T:CourseType{
    List<T> courses=new List<T>();
    //Method to AddCourse
    public void AddCourse(T course){
        courses.Add(course);
    }
    //Method to add Display
    public void Display(){
        foreach(var course in courses){
            course.Display();
        }
        Console.WriteLine();
    }
}
class UniversityManagement{
    //Main method
    static void Main(string[] args){
        //Exam Courses
        ExamCourse course1= new ExamCourse("Btech",192,400);
        ExamCourse course2= new ExamCourse("BBA",140,350);
        //Assignment courses

        AssignmentCourse course3= new AssignmentCourse("Excel Master",50,40);
        AssignmentCourse course4= new AssignmentCourse("Python Basic",35,20);
        //Separate list
        Course<ExamCourse> examCourses= new Course<ExamCourse>();
        Course<AssignmentCourse> assignmentCourses= new Course<AssignmentCourse>();
        //Add Courses
        examCourses.AddCourse(course1);
        examCourses.AddCourse(course2);
        //cannot add other type of courses in other list
        // examCourses.AddCourse(course3);
        assignmentCourses.AddCourse(course3);
        assignmentCourses.AddCourse(course4);
        //Display output
        examCourses.Display();
        assignmentCourses.Display();

    }
}