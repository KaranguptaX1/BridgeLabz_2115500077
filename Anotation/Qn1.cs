using System;
namespace Animals{
    //Animal Parent class
    class Animal{
        public virtual void MakeSound(){
            Console.WriteLine("Animal make sound.");
        } 
    }
    //Dog Subclass overriding parents method
    class Dog:Animal{
        public override void MakeSound()
        {
            Console.WriteLine("Woof Woof");
        }
    }
    class Program{
        //Main Method
        static void Main(string[] args){
            Dog dog= new Dog();
            dog.MakeSound();
        }
    }
}