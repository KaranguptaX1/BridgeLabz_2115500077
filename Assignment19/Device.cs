
using System;
//Parent Class
class Device{
    //Protected Variables
    protected int DeviceId;
    protected bool Status;
    //Constructor
    public Device(int DeviceId,bool Status){
        this.DeviceId=DeviceId;
        this.Status=Status;
    }
    //Display Method
    public virtual void DisplayStatus(){
        Console.WriteLine($"DeviceID:{DeviceId}\nStatus: {Status}");
    }
}
//Thermostat subclass
class Thermostat:Device{
    //extra variable
    private double TemperatureSetting;
    //Subclass Constructor
    public Thermostat(int DeviceID,bool Status,double TemperatureSetting):base(DeviceID,Status){
        this.TemperatureSetting=TemperatureSetting;
    }
    //Override the parent class method
    public override void DisplayStatus()
    {
        base.DisplayStatus();
        Console.WriteLine($"Temperature Setting:{TemperatureSetting}");
        Console.WriteLine("-----------------------");
    }
}
class SmartHomeDevices{
    //Main Method
    static void Main(string[] args){
        Device device= new Device(111,true);
        Thermostat thermostat1= new Thermostat(112,true,35);
        Thermostat thermostat2= new Thermostat(113,false,0.00);
        device.DisplayStatus();
        thermostat1.DisplayStatus();
        thermostat2.DisplayStatus();
    }
}

