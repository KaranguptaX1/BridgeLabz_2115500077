using System;
using System.Collections.Generic;
//abstract class
abstract class Warehouse{
    //Properties
    public string Name{get;set;}
    public double Price{get;set;}
    //Constructor
    public Warehouse(string name,double price){
        Name=name;
        Price=price;
    }
    //abstract method
    public abstract void DisplayInfo();
}
//Electronic class
class Electronic:Warehouse{
    public string  Brand{get;set;}
    public Electronic(string name,double price,string brand):base(name,price){
        Brand=brand;
    }
    //Override parent class method
    public override void DisplayInfo(){
        Console.WriteLine($"Name: {Name},Price : {Price},Brand : {Brand}");
    }
}
//Groceries class
class Groceries:Warehouse{
    public int Quantity{get;set;}
    public Groceries(string name,double price,int quantity):base(name,price){
        Quantity=quantity;
    }
    public override void DisplayInfo(){
        Console.WriteLine($"Name: {Name},Price : {Price},Quantity : {Quantity}");
    }

}
//Furniture class
class Furniture:Warehouse{
    public string Material{get;set;}
    public Furniture(string name,double price,string material):base(name,price){
        Material=material;
    }
    public override void DisplayInfo(){
        Console.WriteLine($"Name: {Name},Price : {Price},Material :{Material}");
    }

}
//Generic storage class
class Storage<T> where T:Warehouse{
    private List<T> list= new List<T>();
    //AddItem method
    public void AddItem(T item){
        list.Add(item);
    }
    //DisplayList method
    public void DisplayList(){
        
        Console.WriteLine($"{typeof(T)} list:");
        foreach(var item in list){
            item.DisplayInfo();
        }
        Console.WriteLine();
    }
}
class WarehouseManagement{
    //Main Method
    static void Main(string [] args){
        //Objects of Storage and other classes
        Storage<Electronic> electronics= new Storage<Electronic>();
        Electronic fan= new Electronic("Fans",3500.00,"Bajaj");
        Electronic heater= new Electronic("Heater",1550,"Havells");
        Storage<Groceries> groceries= new Storage<Groceries>();
        Groceries apple= new Groceries("Apple",50,100);
        Groceries mango= new Groceries("Mango",86,50);
        Storage<Furniture> furniture= new Storage<Furniture>();
        Furniture sofa= new Furniture("Sofa",35000.50,"Wood");
        Furniture table = new Furniture("table",55000,"Glass");
        //Add items to there list
        electronics.AddItem(fan);
        electronics.AddItem(heater);

        groceries.AddItem(apple);
        groceries.AddItem(mango);
        groceries.AddItem(new Groceries("Milk",55,90));

        furniture.AddItem(sofa);
        furniture.AddItem(table);
        //Display output
        electronics.DisplayList();
        groceries.DisplayList();
        furniture.DisplayList();

    }
}