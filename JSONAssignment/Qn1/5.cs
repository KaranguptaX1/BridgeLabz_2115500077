using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json.Schema;
using System;
class Program{
    static void Main(string[] args){
        string filepath1 = "file1.json";
        string filepath2 = "file2.json";
        string json = File.ReadAllText(filepath1);
        string schemaJson = File.ReadAllText(filepath2);
        JSchema schema = JSchema.Parse(schemaJson);
        JObject obj = JObject.Parse(json);
        bool isValid = obj.IsValid(schema, out IList<string> errors);
        Console.WriteLine($"Valid: {isValid}");
        if(!isValid){
            Console.WriteLine(string.Join(", ", errors));
        }
    }
}