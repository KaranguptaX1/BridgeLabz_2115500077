using System;
using System.Collections.Generic;
// Parent class
abstract class Vehicle{
    //Private variables and properties
    private int vehicleId;
    private string driverName;
    private double ratePerKm;
    public int VehicleId { get { return vehicleId; } }
    public string DriverName { get { return driverName; } }
    public double RatePerKm { get { return ratePerKm; } }
    // Constructor 
    public Vehicle(int vehicleId, string driverName, double ratePerKm){
        this.vehicleId = vehicleId;
        this.driverName = driverName;
        this.ratePerKm = ratePerKm;
    }
    //Method to display details
    public void GetVehicleDetails(){
        Console.WriteLine($"ID: {vehicleId}\nDriver: {driverName}\nRate per Km: {ratePerKm}");
    }
    //Abstract calculateFare
    public abstract double CalculateFare(double distance);
}
//Interface
interface IGPS{
    string GetCurrentLocation();
    void UpdateLocation(string newLocation);
}

//Car subclass
class Car : Vehicle, IGPS{
    //Private variable
    private string location;
    public Car(int vehicleId, string driverName, double ratePerKm, string location) : base(vehicleId, driverName, ratePerKm){
        this.location = location;
    }
    // override parent class method
    public override double CalculateFare(double distance){
        return distance * RatePerKm;
    }
    //Describe GetCurrentLocation()
    public string GetCurrentLocation(){
        return location;
    }
    //Describe UpdateLocation()
    public void UpdateLocation(string newLocation){
        location = newLocation;
        Console.WriteLine($"Car location updated to: {newLocation}");
    }
}

// Bike subclass
class Bike : Vehicle, IGPS{
    private string location;
    public Bike(int vehicleId, string driverName, double ratePerKm, string location) : base(vehicleId, driverName, ratePerKm){
        this.location = location;
    }
    public override double CalculateFare(double distance){
        return distance * RatePerKm;
    }
    public string GetCurrentLocation(){
        return location;
    }
    public void UpdateLocation(string newLocation){
        location = newLocation;
        Console.WriteLine($"Bike location updated to: {newLocation}");
    }
}
// Auto subclass
class Auto : Vehicle, IGPS{
    private string location;
    public Auto(int vehicleId, string driverName, double ratePerKm, string location) : base(vehicleId, driverName, ratePerKm){
        this.location = location;
    }
    public override double CalculateFare(double distance){
        return distance * RatePerKm;
    }
    public string GetCurrentLocation(){
        return location;
    }
    public void UpdateLocation(string newLocation){
        location = newLocation;
        Console.WriteLine($"Auto location updated to: {newLocation}");
    }
}
class RideHailing{
    //Main Method
    static void Main(string[] args){
        List<Vehicle> rides = new List<Vehicle>();
        Car car1 = new Car(121, "Rahul Kumar", 12, "Mathura Road");
        Bike bike1 = new Bike(122, "Karan", 5, "Indiranagar");
        Auto auto1 = new Auto(123, "Prakhar", 8, "Koramangala");
        rides.Add(car1);
        rides.Add(bike1);
        rides.Add(auto1);
        //Display output
        foreach (var ride in rides){
            ride.GetVehicleDetails();
            double fare = ride.CalculateFare(10);
            Console.WriteLine($"Total Fare for 10 km: {fare}");
            if (ride is IGPS gpsEnabled){
                Console.WriteLine($"Current Location: {gpsEnabled.GetCurrentLocation()}");
                gpsEnabled.UpdateLocation("Electronic City");
            }
            Console.WriteLine();
        }
    }
}
