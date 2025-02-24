using System;
//Parent Method
class Person{
    //protected variables
    protected string Name;
    protected int Age;
    //Constructor
    public Person(string Name, int Age){
        this.Name = Name;
        this.Age = Age;
    }
    //Display Info method
    public virtual void DisplayInfo(){
        Console.WriteLine($"Name: {Name}");
        Console.WriteLine($"Age: {Age}");
    }
    //Display role method
    public virtual void DisplayRole(){
        Console.WriteLine("Role: Person");
    }
}
//Teacher subclass of Person
class Teacher : Person{
    private string Subject;
    public Teacher(string name, int age, string Subject) : base(name, age){
        this.Subject = Subject;
    }
    //Override Display method
    public override void DisplayInfo(){
        base.DisplayInfo();
        Console.WriteLine($"Subject: {Subject}");
    }
    //Override Role method
    public override void DisplayRole(){
        Console.WriteLine("Role: Teacher");
    }
}
//Student subclass of Person
class Student : Person{
    private int Grade;
    public Student(string name, int age, int Grade) : base(name, age){
        this.Grade = Grade;
    }
    //Override parent class methods
    public override void DisplayInfo(){
        base.DisplayInfo();
        Console.WriteLine($"Grade: {Grade}");
    }
    public override void DisplayRole(){
        Console.WriteLine("Role: Student");
    }
}
//Staff subclass of Person
class Staff : Person{
    public string Department;
    public Staff(string name, int age, string Department) : base(name, age){
        this.Department = Department;
    }
    public override void DisplayInfo(){
        base.DisplayInfo();
        Console.WriteLine($"Department: {Department}");
    }
    public override void DisplayRole(){
        Console.WriteLine("Role: Staff");
    }
}
class SchoolSystem{
    //Main Method to call the classes Objects
    public static void Main(string[] args){
        Teacher teacher = new Teacher("Gaurav Sir", 35, "Science");
        Student student = new Student("Rahul Kumar", 22, 10);
        Staff staff = new Staff("Ms. Sushma", 25, "Management");
        Person[] people = new Person[3];
        people[0] = teacher;
        people[1] = student;
        people[2] = staff;
        foreach(Person person in people){
            person.DisplayRole();
            person.DisplayInfo();
            Console.WriteLine("-------------------------");
        }
    }
}