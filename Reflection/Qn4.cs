using System;
class Student{
    public string Name { get; set; }
    public int Age { get; set; }
    public Student(){
        Console.WriteLine("Student constructor called.");
    }
    public void DisplayInfo(){
        Console.WriteLine($"Name: {Name}, Age: {Age}");
    }
}
class Program{
    static void Main(string[] args){
        Type studentType = typeof(Student);
        object studentInstance = Activator.CreateInstance(studentType);
        if (studentInstance == null){
            Console.WriteLine("Failed to create an instance of Student.");
            return;
        }
        Student student = (Student)studentInstance;
        student.Name = "Karan Gupta";
        student.Age = 20;
        student.DisplayInfo();
    }
}