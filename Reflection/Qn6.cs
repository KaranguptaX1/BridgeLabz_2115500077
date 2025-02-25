using System;
using System.Reflection;
[AttributeUsage(AttributeTargets.Class)]
public class AuthorAttribute : Attribute{
    public string Name { get; }
    public AuthorAttribute(string name){
        Name = name;
    }
}
[Author("ABCD")]
public class SampleClass{
    public void Display(){
        Console.WriteLine("Method inside SampleClass.");
    }
}
class Program{
    static void Main(string[] args){
        Type type = typeof(SampleClass);
        object[] attributes = type.GetCustomAttributes(typeof(AuthorAttribute), false);
        if (attributes.Length > 0){
            AuthorAttribute authorAttribute = (AuthorAttribute)attributes[0];
            Console.WriteLine($"Author of {type.Name}: {authorAttribute.Name}");
        }
        else{
            Console.WriteLine("No Author attribute found.");
        }
    }
}