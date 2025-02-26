using System;
using Newtonsoft.Json;
using System.IO;
class Program{
    static void Main(){
        var json = File.ReadAllText("data.json");
        var data = JsonConvert.DeserializeObject<dynamic>(json);
        Console.WriteLine(data["name"]);
        Console.WriteLine(data["email"]);
    }
}