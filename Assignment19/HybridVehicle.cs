
using System;
//Parent class
class Vehicle{
    //Protected variables
    protected int MaxSpeed;
    protected string Model;
    //constructor
    public Vehicle(int Maxspeed, string Model){
        this.MaxSpeed = Maxspeed;
        this.Model = Model;
    }
    //Display vehicle info method
    public virtual void DisplayVehicleInfo(){
        Console.WriteLine($"Model: {Model}\nMaxSpeed: {MaxSpeed}");
    }
}
//Interface
interface Refuelable{
    void Refuel();
}
//PetrolVehicle subclass
class PetrolVehicle : Vehicle, Refuelable{
    private int TankCapacity;
    //constructor
    public PetrolVehicle(int maxspeed, string model, int Tankcapacity) : base(maxspeed, model){
        this.TankCapacity = Tankcapacity;
    }
    //Implement Refuel method 
    public void Refuel(){
        Console.WriteLine("Refueling...");
    }
    //Override parent class method
    public override void DisplayVehicleInfo(){
        base.DisplayVehicleInfo();
        Console.WriteLine($"TankCapacity: {TankCapacity} liters");
    }
}
//Electric vehicle subclass
class ElectricVehicle : Vehicle{
    private int BatteryCapacity;
    //Constructor
    public ElectricVehicle(int maxspeed, string model, int BatteryCapacity) : base(maxspeed,model){
        this.BatteryCapacity = BatteryCapacity;
    }
    //Charge method
    public void Charge(){
        Console.WriteLine("Charging...");
    }
    //Override parent class method
    public override void DisplayVehicleInfo(){
        base.DisplayVehicleInfo();
        Console.WriteLine($"Battery Capacity: {BatteryCapacity} kWh");
    }
}
class Program{
    //Main Method
    public static void Main(string[] args){
        ElectricVehicle electric = new ElectricVehicle(200, "Tesla", 95);
        PetrolVehicle petrol = new PetrolVehicle(350, "Buggati Chiron", 100);
        Console.WriteLine("Electric Vehicle Details");
        electric.DisplayVehicleInfo();
        electric.Charge();
        Console.WriteLine("-------------------------------");
        Console.WriteLine("Petrol Vehicle Details");
        petrol.DisplayVehicleInfo();
        petrol.Refuel();
    }
}



