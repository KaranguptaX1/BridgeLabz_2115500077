using System;
class Vehicle{
    private string ownerName;
    private string vehicleType;
    private static double registrationFee = 100.0;
	//Constructor
    public Vehicle(string ownerName, string vehicleType){
        this.ownerName = ownerName;
        this.vehicleType = vehicleType;
    }
	//Display method
    public void DisplayVehicleDetails(){
        Console.WriteLine($"Owner: {ownerName}, Vehicle: {vehicleType}, Registration Fee: {registrationFee}");
    }
	//Update Fees method
    public static void UpdateRegistrationFee(double newFee){
        registrationFee = newFee;
    }
}

class Program{
    static void Main(){
        Vehicle v1 = new Vehicle("Alice", "Car");
        Vehicle v2 = new Vehicle("Bob", "Motorcycle");

        v1.DisplayVehicleDetails();
        v2.DisplayVehicleDetails();

        Vehicle.UpdateRegistrationFee(150.0);

        v1.DisplayVehicleDetails();
        v2.DisplayVehicleDetails();
    }
}
