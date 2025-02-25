using System;
using System.IO;
using System.Globalization;
using System.Collections.Generic;
using CsvHelper;
//student class
class Student{
    public int ID { get; set; }
    public string Name { get; set; }
    public int Age { get; set; }
    public double Marks { get; set; }
}
//Record class
class Records{
    //Method to filter students with marks > 80
    static List<Student> GetTopStudents(string path){
        try{
            using (StreamReader sr = new StreamReader(path))
            using (CsvReader csv = new CsvReader(sr, CultureInfo.InvariantCulture)){
                var students = csv.GetRecords<Student>();  
                var topStudents = new List<Student>();
                //separate students with marks greater than 80  
                foreach (var student in students){
                    if (student.Marks > 80){
                        topStudents.Add(student);
                    }
                }
                return topStudents;
            }
        }
        catch (Exception ex){
            Console.WriteLine($"Error: {ex.Message}");
            return new List<Student>(); 
        }
    }
    // Main method
    static void Main(string[] args){
        string path = "Students.csv";  
        var qualifyingStudents = GetTopStudents(path);
        if (qualifyingStudents.Count > 0){
            Console.WriteLine("Students with more than 80 marks:");
            foreach (var student in qualifyingStudents){
                Console.WriteLine($"{student.ID}, {student.Name}, {student.Age}, {student.Marks}");
            }
        }
        else{
            Console.WriteLine("No students found with marks above 80.");
        }
    }
}