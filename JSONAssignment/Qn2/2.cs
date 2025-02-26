using System;
using System.Collections.Generic;
using Newtonsoft.Json;
public class User{
    public string Name { get; set; }
    public int Age { get; set; }
}
class Program{
    static void Main(){
        List<User> users = new List<User>{
            new User { Name = "Karan", Age = 21 },
            new User { Name = "XYZ", Age = 25 }
        };
        string json = JsonConvert.SerializeObject(users, Formatting.Indented);
        Console.WriteLine(json);
    }
}