using Newtonsoft.Json;
using System;
using System.Collections.Generic;
class Person{
    public string Name { get; set; }
    public int Age { get; set; }
}
class Program{
    static void Main(string[] args){
        List<Person> people = new List<Person>{
            new Person { Name = "Karan", Age =21 },
            new Person { Name = "XYZ", Age = 22 }
        };
        string json = JsonConvert.SerializeObject(people, Formatting.Indented);
        Console.WriteLine(json);
    }
}