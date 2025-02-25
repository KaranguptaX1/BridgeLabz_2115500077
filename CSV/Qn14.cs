using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using CsvHelper;
using Newtonsoft.Json;

// Student class
class Student{
    public int ID { get; set; }
    public string Name { get; set; }
    public int Age { get; set; }
    public double Marks { get; set; }
}

class JsonCsvConverter{
    // Method to Convert JSON to CSV
    static void ConvertJsonToCsv(string jsonPath, string csvPath){
        try{
            string jsonData = File.ReadAllText(jsonPath);
            List<Student> students = JsonConvert.DeserializeObject<List<Student>>(jsonData);
            using (var writer = new StreamWriter(csvPath))
            using (var csv = new CsvWriter(writer, CultureInfo.InvariantCulture)){
                csv.WriteRecords(students);
            }
            Console.WriteLine($"JSON converted to CSV successfully: {csvPath}");
        }
        catch (Exception ex){
            Console.WriteLine($"Error in JSON to CSV conversion: {ex.Message}");
        }
    }
    // Method to Convert CSV to JSON
    static void ConvertCsvToJson(string csvPath, string jsonPath){
        try{
            using (var reader = new StreamReader(csvPath))
            using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture)){
                var students = csv.GetRecords<Student>();
                string jsonData = JsonConvert.SerializeObject(students, Formatting.Indented);
                File.WriteAllText(jsonPath, jsonData);
            }
            Console.WriteLine($"CSV converted to JSON successfully: {jsonPath}");
        }
        catch (Exception ex){
            Console.WriteLine($"Error in CSV to JSON conversion: {ex.Message}");
        }
    }
    //Main Method
    static void Main(){
        string csvPath = "Students.csv";
        string JsonPath = "students.json";
        ConvertJsonToCsv(JsonPath, csvPath);
        ConvertCsvToJson(csvPath, JsonPath);
    }
}

