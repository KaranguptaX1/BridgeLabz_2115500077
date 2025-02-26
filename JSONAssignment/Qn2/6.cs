using System;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Xml.Linq;
class Program{
    static void Main(){
        string filepath1 = "data.json";
        string json = File.ReadAllText(filepath1);
        JObject data = JObject.Parse(json);
        XDocument xml = JsonConvert.DeserializeXNode(data.ToString(), "root");
        Console.WriteLine(xml);
    }
}