using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.IO;
using System.Linq;
class Program{
    static void Main(string[] args){
        string json = File.ReadAllText("people.json");
        JArray people = JArray.Parse(json);
        var filteredPeople = people.Where(p => (int)p["age"] > 25);
        Console.WriteLine(JsonConvert.SerializeObject(filteredPeople, Formatting.Indented));
    }
}