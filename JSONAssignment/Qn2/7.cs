using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using CsvHelper;
using Newtonsoft.Json;
public class User{
    public string Name { get; set; }
    public int Age { get; set; }
}
class Program{
    static void Main(string[] args){
        using var reader = new StreamReader("data.csv");
        using var csv = new CsvReader(reader, CultureInfo.InvariantCulture);
        var users = csv.GetRecords<User>();
        string json = JsonConvert.SerializeObject(users, Formatting.Indented);
        Console.WriteLine(json);
    }
}