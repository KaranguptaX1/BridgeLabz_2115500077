using System;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.IO;
class MergeJson{
    static void Main(string[] args){
        string filepath1 = "file1.json";
        string filepath2 = "file2.json";
        string json1 = File.ReadAllText(filepath1);
        string json2 = File.ReadAllText(filepath2);
        JObject data1 = JObject.Parse(json1);
        JObject data2 = JObject.Parse(json2);
        data1.Merge(data2);
        string mergedJson = JsonConvert.SerializeObject(data1, Formatting.Indented);
        File.WriteAllText("merged.json", mergedJson);
        Console.WriteLine("Merged JSON has been written to merged.json");
    }
}