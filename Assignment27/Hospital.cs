using System;
using System.Collections.Generic;
class HospitalTriage{
    static void Main(){
        List<(string Name, int Severity)> patients = new List<(string, int)>{
            ("John", 3),
            ("Alice", 5),
            ("Bob", 2)};
        // Sort patients based on severity (Descending order)
        patients.Sort((a, b) => b.Severity.CompareTo(a.Severity));
        // Process patients in order
        Console.WriteLine("Treatment Order:");
        foreach (var patient in patients){
            Console.WriteLine(patient.Name);
        }
    }
}
