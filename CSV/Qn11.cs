using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using CsvHelper;
class LargeCSVReader{
    static void ReadLargeCSV(string filePath, int chunkSize = 100){
        int totalRecordsProcessed = 0;
        try{
            using (var reader = new StreamReader(filePath))
            using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture)){
                csv.Read();
                csv.ReadHeader(); 
                List<dynamic> chunk = new List<dynamic>();
                while (csv.Read()){
                    chunk.Add(csv.GetRecord<dynamic>());
                    // Process every 100 records
                    if (chunk.Count >= chunkSize){
                        totalRecordsProcessed += chunk.Count;
                        Console.WriteLine($"Processed {totalRecordsProcessed} records...");
                        // Clear list to free memory
                        chunk.Clear(); 
                    }
                }
                // Process remaining records
                if (chunk.Count > 0){
                    totalRecordsProcessed += chunk.Count;
                    Console.WriteLine($"Processed {totalRecordsProcessed} records...");
                }
            }
            Console.WriteLine($"Total Records Processed: {totalRecordsProcessed}");
        }
        //Handle Exceptions
        catch (Exception ex){
            Console.WriteLine($"Error: {ex.Message}");
        }
    }

    static void Main(){
        string filePath = "Students.csv"; 
        ReadLargeCSV(filePath);
    }
}