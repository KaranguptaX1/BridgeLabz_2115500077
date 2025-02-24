using System;
using System.Collections.Generic;
class School{
    public string Name { get; set; }
    public List<Student> Students { get; set; }
    // Constructor 
    public School(string name){
        Name = name;
        Students = new List<Student>();
    }
    // Method to add a student to the school
    public void AddStudent(Student student){
        Students.Add(student);
    }
}
class Student{
    public string Name { get; set; }
    public List<Course> Courses { get; set; }
    // Constructor 
    public Student(string name){
        Name = name;
        Courses = new List<Course>();
    }
    // Method to enroll a student in a course
    public void EnrollInCourse(Course course){
        Courses.Add(course);
        course.AddStudent(this);
    }
    // Method to show all courses the student is enrolled in
    public void ShowEnrolledCourses(){
        Console.WriteLine($"{Name} is enrolled in the following courses:");
        foreach (var course in Courses){
            Console.WriteLine(course.Name);
        }
    }
}
class Course{
    public string Name { get; set; }
    public List<Student> Students { get; set; }
    // Constructor 
    public Course(string name){
        Name = name;
        Students = new List<Student>();
    }
    // Method to add a student to the course
    public void AddStudent(Student student){
        Students.Add(student);
    }
    // Method to show all students enrolled in the course
    public void ShowEnrolledStudents(){
        Console.WriteLine($"The following students are enrolled in {Name}:");
        foreach (var student in Students){
            Console.WriteLine(student.Name);
        }
    }
}
class Program{
    static void Main(){
        var school = new School("Greenwood High");
        var student1 = new Student("Alice");
        var student2 = new Student("Bob");
        var course1 = new Course("Math");
        var course2 = new Course("Science");
        // Enrolling students in courses
        student1.EnrollInCourse(course1);
        student2.EnrollInCourse(course1);
        student1.EnrollInCourse(course2);
        // Adding students to the school
        school.AddStudent(student1);
        school.AddStudent(student2);
        // Displaying enrolled courses and students
        student1.ShowEnrolledCourses();
        course1.ShowEnrolledStudents();
        course2.ShowEnrolledStudents();
        
    }
}
