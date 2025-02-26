using System;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json.Schema;
using System.IO;
class Program{
    static void Main(string[] args){
        string filepath1 = "data.json";
        string json = File.ReadAllText(filepath1);
        string jsonData = """
        {
            "email": "test@example.com"
        }
        """;
        JSchema schema = JSchema.Parse(schemaJson);
        JObject data = JObject.Parse(jsonData);
        bool isValid = data.IsValid(schema);
        if (isValid){
            Console.WriteLine("Email is valid!");
        }
        else{
            Console.WriteLine("Email is invalid!");
        }
    }
}