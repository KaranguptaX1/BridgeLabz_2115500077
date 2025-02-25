using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using CsvHelper;
class Student{
    public int ID { get; set; }
    public string Name { get; set; } = string.Empty;
    public int Age { get; set; }
    public double Marks { get; set; }
    public override string ToString(){
        return $"ID={ID}, Name='{Name}', Age={Age}, Marks={Marks}";
    }
}

class Convert{
    //Main method
    static void Main(){
        string filePath = "students.csv"; 
        List<Student> students = new List<Student>();
        try{
            using (var reader = new StreamReader(filePath))
            using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture)){
                students = new List<Student>(csv.GetRecords<Student>()); 
            }
            // Print all students
            foreach (var student in students)
            {
                Console.WriteLine(student);
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }
    }
}

