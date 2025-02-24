using System;
class Person{
    private string name;
    private int age;
    // Parameterized Constructor
    public Person(string name, int age){
        this.name = name;
        this.age = age;
    }
    // Copy Constructor
    public Person(Person p){
        name = p.name;
        age = p.age;
    }
    public void DisplayDetails(){
        Console.WriteLine($"Name: {name}, Age: {age}");
    }
}

class Program{
    static void Main(){
        Person person1 = new Person("Alice", 25);
         // Copy constructor
        Person person2 = new Person(person1); 
		//Display output
        person1.DisplayDetails();
        person2.DisplayDetails();
    }
}
