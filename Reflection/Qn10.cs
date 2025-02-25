using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;
public class JsonConverter{
    public static string ToJson(object obj){
        if (obj == null) return "null";
        Type type = obj.GetType();
        StringBuilder json = new StringBuilder();
        json.Append("{");
        FieldInfo[] fields = type.GetFields(BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance);
        List<string> jsonFields = new List<string>();
        foreach (var field in fields){
            string fieldName = field.Name;
            object fieldValue = field.GetValue(obj);
            string valueString = fieldValue is string ? $"\"{fieldValue}\"" : fieldValue.ToString();
            jsonFields.Add($"\"{fieldName}\": {valueString}");
        }
        json.Append(string.Join(", ", jsonFields));
        json.Append("}");
        return json.ToString();
    }
}
public class Person{
    public string Name;
    private int Age;
    public Person(string name, int age){
        Name = name;
        Age = age;
    }
}
class Program{
    static void Main(){
        Person person = new Person("John Doe", 30);
        string json = JsonConverter.ToJson(person);
        Console.WriteLine(json);
    }
}