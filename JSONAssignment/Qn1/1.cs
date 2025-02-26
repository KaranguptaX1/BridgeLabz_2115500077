using System;
using Newtonsoft.Json;
using System.IO;
class Student{
    public string Name { get; set; }
    public int Age { get; set; }
    public string[] Subjects { get; set; }
}
class Program{
    static void Main(string[] args){
        Student student = new Student();
        student.Name = "Karan";
        student.Age = 21;
        student.Subjects = new string[]{"Python", "C#", "Java"};        
        string json = JsonConvert.SerializeObject(student);
        File.WriteAllText("student.json", json);
        Console.WriteLine("Student object has been serialized to student.json");
    }
}