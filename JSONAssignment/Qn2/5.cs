using System;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;
using System.IO;
class Program{
    static void Main(string[] args){
        string json1 = System.IO.File.ReadAllText("file1.json");
        JObject data1 = JObject.Parse(json1);
        string json2 = System.IO.File.ReadAllText("file2.json");
        JObject data2 = JObject.Parse(json2);
        data1.Merge(data2, new JsonMergeSettings
        {
            MergeArrayHandling = MergeArrayHandling.Union
        });
        File.WriteAllText("merged.json", data1.ToString());
    }
}