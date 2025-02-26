using System;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.IO;
class Program{
    static void Main(string[] args){
        string json = File.ReadAllText("data.json");
        JObject data = JObject.Parse(json);
        PrintKeysValues(data);
    }
    static void PrintKeysValues(JToken token, string prefix = ""){
        if (token is JObject obj){
            foreach (var property in obj.Properties()){
                PrintKeysValues(property.Value, $"{prefix}{property.Name}.");
            }
        }
        else{
            Console.WriteLine($"{prefix}{token}");
        }
    }
}