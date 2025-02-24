using System;
using System.Collections.Generic;
//Parent class
abstract class Vehicle{
    //Private variables
    private string vehicleNumber;
    private string type;
    private double rentalRate;
    //Properties of variables
    public string VehicleNumber{get {return vehicleNumber;}}
    public string Type{get{return type;}}
    public double RentalRate{get{return rentalRate;}}
    //Constructor
    public Vehicle(string vehicleNumber,string type,double rentalRate){
        this.rentalRate=rentalRate;
        this.type=type;
        this.vehicleNumber=vehicleNumber;
    }
    //Display method
    public void DisplayDetails(){
        Console.WriteLine($"Vehicle Details: \nVehicle Number: {vehicleNumber}\nType: {type}\nRental Rate: {rentalRate:C}");
    }
    //abstract method
    public abstract double CalculateRentalCost(int days);
}
//Interface
interface IInsurable{
    double CalculateInsurance();
    void GetInsuranceDetails();
}
//car subclass
class Car:Vehicle,IInsurable{
    //Private variables and properties
    private string insurancePolicyNumber;

    public string InsurancePolicyNumber{
        get{return insurancePolicyNumber;}
    }
    private double insurancePercent=0.1;
    public double InsurancePercent{
        get{return insurancePercent;}
        set{
            if(value<=1){
                insurancePercent=value;
            }
            else{
                Console.WriteLine("Value is greater than 100%.");
            }
        }
    }
    //Constructor
    public Car(string vehicleNumber,string type,double rentalRate,string insurancePolicyNumber):base(vehicleNumber,type,rentalRate){
        this.insurancePolicyNumber=insurancePolicyNumber;
    }
    //Override abstract method
    public override double CalculateRentalCost(int days){
        return days*RentalRate;
    }
    //Describe Interface methods
    public double CalculateInsurance(){
        return RentalRate*insurancePercent;
    }
    public void GetInsuranceDetails(){
        Console.WriteLine($"Polciy Number: {insurancePolicyNumber} Insurance cost is {CalculateInsurance():C}");
    }
}
//Bike subclass
class Bike:Vehicle,IInsurable{
    private string insurancePolicyNumber;
    public string InsurancePolicyNumber{
        get{return insurancePolicyNumber;}
    }
    private double insurancePercent=0.05;
    public double InsurancePercent{
        get{return insurancePercent;}
        set{
            if(value<=1){
                insurancePercent=value;
            }
            else{
                Console.WriteLine("Value is greater than 100%.");
            }
        }
    }
    public Bike(string vehicleNumber,string type,double rentalRate,string insurancePolicyNumber):base(vehicleNumber,type,rentalRate){
        this.insurancePolicyNumber=insurancePolicyNumber;
    }
    public override double CalculateRentalCost(int days){
        return days*RentalRate;
    }
    public double CalculateInsurance(){
        return RentalRate*insurancePercent;
    }
    public void GetInsuranceDetails(){
        Console.WriteLine($"Polciy Number: {insurancePolicyNumber} Insurance cost is {CalculateInsurance():C}");
    }
}
//Truck Subclass
class Truck:Vehicle,IInsurable{
    private string insurancePolicyNumber;
    public string InsurancePolicyNumber{
        get{return insurancePolicyNumber;}
    }
    private double insurancePercent=0.3;
    public double InsurancePercent{
        get{return insurancePercent;}
        set{
            if(value<=1){
                insurancePercent=value;
            }
            else{
                Console.WriteLine("Value is greater than 100%.");
            }
        }
    }
    public Truck(string vehicleNumber,string type,double rentalRate,string insurancePolicyNumber):base(vehicleNumber,type,rentalRate){
        this.insurancePolicyNumber=insurancePolicyNumber;
    }
    public override double CalculateRentalCost(int days){
        return days*RentalRate;
    }
    public double CalculateInsurance(){
        return RentalRate*insurancePercent;
    }
    public void GetInsuranceDetails(){
        Console.WriteLine($"Polciy Number: {insurancePolicyNumber} Insurance cost is {CalculateInsurance():C}");
    }
}
class VehicleRental{
    //MainMethod
    static void Main(string [] args){
        List<Vehicle> vehicles= new List<Vehicle>();
        Car veh1= new Car("UP85AWXXXX","petrol",1000.0,"AW132");
        Bike veh2= new Bike("JK06PSYYYY","petrol",450.05,"INS_312");
        Truck veh3 = new Truck("NL06OPTTTT","diesel",5000.00,"OP902");
        vehicles.Add(veh1);
        vehicles.Add(veh2);
        vehicles.Add(veh3);
        veh3.InsurancePercent=0.8;
        foreach(var vehicle in vehicles){
            vehicle.DisplayDetails();
            Console.WriteLine($"Rental Cost: {vehicle.CalculateRentalCost(3):C}");
            //type cast vehicle into insurable
            if (vehicle is IInsurable insurable){
                Console.WriteLine($"Insurance Cost: {insurable.CalculateInsurance():C}");
                insurable.GetInsuranceDetails();
            }

        } 
    }
}