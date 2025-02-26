using System;
using System.Collections.Generic;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;
using System.IO;
public class User{
    public string Name { get; set; }
    public int Age { get; set; }
}
class Program{
    static void Main(string[] args){
        string filepath1 = "data.json";
        string json = File.ReadAllText(filepath1);
        List<User> users = JsonConvert.DeserializeObject<List<User>>(json);
        foreach (var user in users){
            if (user.Age > 25){
                Console.WriteLine(JsonConvert.SerializeObject(user));
            }
        }
    }
}