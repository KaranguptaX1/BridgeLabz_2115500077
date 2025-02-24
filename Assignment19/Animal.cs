using System;
//Base Class
class Animal{
    //Protected Variables so derived class can access them
    protected string Name;
    protected int Age;
    //Constructor
    public Animal(string Name,int Age){
        this.Name=Name;
        this.Age=Age;
    }
    //Method to make sounds
    public virtual void MakeSound(){
        Console.WriteLine("Animal makes a sound");
    }

}
//Dog subclass
class Dog:Animal{
    //special attribute of class
    public string Breed{get;}
    //Constructor
    public Dog(string Name,int Age,string Breed):base(Name,Age){
        this.Breed=Breed;
    }
    //overriding the method
    public override void MakeSound(){   
        Console.WriteLine($"Dog Name {Name} of breed {Breed} Barks");
    }
}
//Bird Subclass
class Bird:Animal{
    //special attribute of class
    public string Species{get;}
    public Bird(string Name,int Age,string Species):base(Name,Age){
        this.Species=Species;
    }
     //overriding the method
    public override void MakeSound(){   
        Console.WriteLine($"Bird Chirps ");
    }
}
class Cat:Animal{
    //special attribute of class
    public string Color{get;}
    public Cat(string Name,int Age,string Color):base(Name,Age){
        this.Color=Color;
    }
     //overriding the method
    public override void MakeSound(){   
        Console.WriteLine("Cat Meows");
    }
}
class Program{
    //call the main Method
    static void Main(){
        Animal animal=new Animal("lion",18);
        Bird bird=new Bird("sparrow",2,"Tiny");
        Dog dog = new Dog("brony",3,"Labrador");
        Cat cat =new Cat("Kitten",5,"Polish");
        animal.MakeSound();
        bird.MakeSound();
        dog.MakeSound();
        cat.MakeSound();
    }
}
