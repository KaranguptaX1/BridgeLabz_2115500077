using System;
namespace VehicleRegisitrationSystem{
    class Vehicle{
        //Initialize variables
        private string OwnerName;
        private string VehicleType;
        private readonly string RegistrationNumber;
        private static int RegistrationFee=10000;
        //Method to update Registration fees
        public static void UpdateRegistrationFee(int fees){
            RegistrationFee=fees;
        }
        //Constructor
        public Vehicle(string OwnerName,string VehicleType,string RegistrationNumber){
            this.OwnerName=OwnerName;
            this.VehicleType=VehicleType;
            this.RegistrationNumber=RegistrationNumber;
        }
        //Method to display details
        public void DisplayVehicleDetails(){
            Console.WriteLine($"The Owner is : {OwnerName}");
            Console.WriteLine($"The VehicleType is : {VehicleType}");
            Console.WriteLine($"The Registration Number: {RegistrationNumber}");
            Console.WriteLine($"The Registration Fees is : {RegistrationFee:C}");
            Console.WriteLine("____________________________________________");
        }

    }
    class Program{
        static void Main(string[] args){
            //make the instance
            Vehicle veh1= new Vehicle("Rahul Kumar","SUV","UP85AWXXXX");
            Vehicle.UpdateRegistrationFee(15000);
            Vehicle veh2 = new Vehicle("Lakshay","Luxury","DL1BACXXXX");
            //check the object
            if(veh1 is Vehicle){
                veh1.DisplayVehicleDetails();
            }
            if (veh2 is Vehicle){
                veh2.DisplayVehicleDetails();
            }

        }
    }
}