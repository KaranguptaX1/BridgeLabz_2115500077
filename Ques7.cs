using System;
using System.IO;
class Program{
    //Write student details Method
    static void WriteStudentDetails(string path){
        int rollNumber = 42;
        string name = "Rahul";
        double gpa = 8.75;
        using (FileStream fs = new FileStream(path, FileMode.Create, FileAccess.Write))
        using (BinaryWriter writer = new BinaryWriter(fs)){
            writer.Write(rollNumber);
            writer.Write(name);
            writer.Write(gpa);
        }
        Console.WriteLine("Student details written to the file.");
    }
    //Read student details Method
    static void ReadStudentDetails(string path){
        using (FileStream fs = new FileStream(path, FileMode.Open, FileAccess.Read))
        using (BinaryReader reader = new BinaryReader(fs)){
            int rollNumber = reader.ReadInt32();
            string name = reader.ReadString();
            double gpa = reader.ReadDouble();
            Console.WriteLine("Student Details:");
            Console.WriteLine($"Roll Number: {rollNumber}");
            Console.WriteLine($"Name: {name}");
            Console.WriteLine($"GPA: {gpa}");
        }
    }
    //Main Method
    public static void Main(string[] args){
        string path = "students.dat";
        WriteStudentDetails(path);
        ReadStudentDetails(path);
    }
}
