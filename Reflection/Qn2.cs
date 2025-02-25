using System;
using System.Reflection;
class Person{
    private int age;
    public Person(int age){
        this.age = age;
    }
    public void DisplayAge(){
        Console.WriteLine($"Current age: {age}");
    }
}
class Program{
    static void Main(string[] args){
        Person person = new Person(25);
        person.DisplayAge();
        Type personType = typeof(Person);
        FieldInfo ageField = personType.GetField("age", BindingFlags.NonPublic | BindingFlags.Instance);
        if (ageField == null){
            Console.WriteLine("Age not found.");
            return;
        }
        ageField.SetValue(person, 30);
        int updatedAge = (int)ageField.GetValue(person);
        Console.WriteLine($"Updated age: {updatedAge}");
        person.DisplayAge();
    }
}