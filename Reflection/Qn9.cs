using System;
using System.Collections.Generic;
using System.Reflection;
public class ObjectMapper{
    public static T ToObject<T>(Dictionary<string, object> properties) where T : new(){
        T obj = new T();
        Type type = typeof(T);
        foreach (var property in properties){
            FieldInfo fieldInfo = type.GetField(property.Key, BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance);
            if (fieldInfo != null && fieldInfo.FieldType == property.Value.GetType()){
                fieldInfo.SetValue(obj, property.Value);
            }
        }
        return obj;
    }
}
public class Person{
    public string Name;
    private int Age;
    public void Display(){
        Console.WriteLine($"Name: {Name}, Age: {Age}");
    }
}
class Program{
    static void Main(string[] args){
        Dictionary<string, object> data = new Dictionary<string, object>{
            {"Name", "Karan gupta"},
            {"Age", 30}
        };
        Person person = ObjectMapper.ToObject<Person>(data);
        person.Display();
    }
}