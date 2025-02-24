using System;
using System.Collections.Generic;

class Student{
    public string Name { get; set; }
    public List<Course> EnrolledCourses { get; set; }
    // Constructor
    public Student(string name){
        Name = name;
        EnrolledCourses = new List<Course>();
    }
    // Method to enroll a student in a course
    public void EnrollCourse(Course course){
        EnrolledCourses.Add(course);
    }
}
class Professor{
    public string Name { get; set; }
    // Constructor
    public Professor(string name){
        Name = name;
    }
    // Method to assign a professor to a course
    public void AssignCourse(Course course){
        course.Professor = this;
    }
}
class Course{
    public string Name { get; set; }
    public Professor Professor { get; set; }
    // Constructor
    public Course(string name){
        Name = name;
    }
}

class Program{
    static void Main(){
        var student1 = new Student("Alice");
        var student2 = new Student("Bob");
        var professor = new Professor("Dr. Smith");

        var course1 = new Course("Computer Science");
        var course2 = new Course("Mathematics");
        var course3 = new Course("Physics");

        // Assigning professor to the courses
        professor.AssignCourse(course1);
        professor.AssignCourse(course2);
        professor.AssignCourse(course3);

        // Enrolling students in the courses
        student1.EnrollCourse(course1);
        student1.EnrollCourse(course2);
        student2.EnrollCourse(course2);
        student2.EnrollCourse(course3);

        // Displaying course enrollment and professor details for all courses
        Console.WriteLine($"{student1.Name} and {student2.Name} enrolled in the following courses taught by {professor.Name}:");
        
        // Displaying course details for student1
        foreach (var course in student1.EnrolledCourses){
            Console.WriteLine($"{student1.Name} is enrolled in {course.Name}");
        }

        // Displaying course details for student2
        foreach (var course in student2.EnrolledCourses){
            Console.WriteLine($"{student2.Name} is enrolled in {course.Name}");
        }
    }
}
