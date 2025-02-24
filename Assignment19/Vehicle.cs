using System;
//Parent Class
class Vehicle{
    //Protected variables
    protected int MaxSpeed;
    protected string FuelType;
    //Constructor
    public Vehicle(int MaxSpeed,string FuelType){
        this.MaxSpeed=MaxSpeed;
        this.FuelType=FuelType;
    }
    //Method to Display Info
    public virtual void DisplayInfo(){
        Console.WriteLine($"Vehicle Information: \nMaxSpeed: {MaxSpeed}\nFuelType: {FuelType}");
    }
}
//Subclass
class Car:Vehicle{
    //special attribute
    private int SeatCapacity;
    //Constructor
    public Car(int MaxSpeed,string FuelType,int SeatCapacity):base(MaxSpeed,FuelType){
        this.SeatCapacity=SeatCapacity;
    }
    //override the parent class method
    public override void DisplayInfo(){
        base.DisplayInfo();
        Console.WriteLine($"Seat Capacity: {SeatCapacity} ");
    }

}
//truck subclass
class Truck:Vehicle{
    private int PayloadCapacity;
    public Truck(int MaxSpeed,string FuelType,int PayloadCapacity):base(MaxSpeed,FuelType){
        this.PayloadCapacity=PayloadCapacity;
    }
    public override void DisplayInfo(){
        base.DisplayInfo();
        Console.WriteLine($"Payload Capacity: {PayloadCapacity} ");
    }

}
//Motorcycle subclass
class Motorcycle:Vehicle{
    private bool HasSideCar;
    public Motorcycle(int MaxSpeed,string FuelType,bool HasSideCar):base(MaxSpeed,FuelType){
        this.HasSideCar=HasSideCar;
    }
    public override void DisplayInfo(){
        base.DisplayInfo();
        Console.WriteLine($"Has Side car: {HasSideCar} ");
    }
}
class Program{
    //Main Method
    static void Main(string [] args){
        //array to store vehicle types
        Vehicle[] vehicles= new Vehicle[3];
        vehicles[0]= new Car(120,"Petrol",5);
        vehicles[1]= new Truck(160,"diesel",50000);
        vehicles[2]= new Motorcycle(180,"Petrol",true);
        foreach( var vehicle in vehicles){
            if (vehicle is Car){
                Console.WriteLine("This is Car.");
            }
            else if(vehicle is Truck){
                Console.WriteLine("This is Truck.");
            }
            else if (vehicle is Motorcycle){
                Console.WriteLine("This is Motorcycle.");
            }
            else{
                Console.WriteLine("Not a valid Vehicle.");
            }
            //Display output
            vehicle.DisplayInfo();
        }
    }
}

