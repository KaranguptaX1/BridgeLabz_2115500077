
using System;
//Parent class
class Person{
    //Protected variables
    protected string Name;
    protected int Id;
    //constructor method
    public Person(string Name,int Id){
        this.Name=Name;
        this.Id=Id;
    }
    //display method
    public virtual void Display(){
        Console.WriteLine($"Name: {Name}\nId: {Id}");
    }
}
//Interface class
interface Worker{
    public void PerformDuties();
}
//Subclass chef
class Chef:Person,Worker{
    //Constructor
    public Chef(string Name, int id):base(Name,id){}
    //Override Parent class
    public void PerformDuties(){
        Console.WriteLine("Duty: Cooking");
    }
    //Override interface Worker
    public override void Display(){
        Console.Write("Chef ");
        base.Display();
    }
}
//Waiter subclass
class Waiter:Person,Worker{
    public Waiter(string Name, int id):base(Name,id){}
    public void PerformDuties(){
        Console.WriteLine("Duty: Recieve and Serve Orders ");
    }
    public override void Display(){
        Console.Write("Waiter ");
        base.Display();
    }
}
class Restaurant{
    //Main Method
    static void Main(string [] args){
        Chef chef= new Chef("Abhishek",123);
        Waiter waiter = new Waiter("David",121);
        chef.Display();
        chef.PerformDuties();
        Console.WriteLine("---------------------");
        waiter.Display();
        waiter.PerformDuties();
    }
}



