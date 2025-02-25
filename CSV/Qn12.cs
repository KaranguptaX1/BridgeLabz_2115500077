using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using CsvHelper;
class DuplicateDetector{
    static void DetectDuplicates(string filePath){
        var seenIds = new HashSet<string>();
        var duplicateRecords = new List<dynamic>();
        try{
            using (var reader = new StreamReader(filePath))
            using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture)){
                csv.Read();
                csv.ReadHeader();
                while (csv.Read()){
                    var record = csv.GetRecord<dynamic>(); 
                    //get the id
                    string id = record.ID; 
                    //check if id already present
                    if (!seenIds.Add(id)){
                        duplicateRecords.Add(record);
                    }
                }
            }
            // Print duplicate records
            if (duplicateRecords.Count > 0){
                Console.WriteLine("Duplicate Records Found:");
                foreach (var record in duplicateRecords){
                    Console.WriteLine($"ID: {record.ID}, Name: {record.Name}");
                }
            }
            else{
                Console.WriteLine("No duplicate records found!");
            }
        }
        catch (Exception ex){
            Console.WriteLine($"Error: {ex.Message}");
        }
    }
    static void Main()
    {
        string filePath = "Employees.csv";
        DetectDuplicates(filePath);
    }
}