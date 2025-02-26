using System;
using Newtonsoft.Json;
class Car{
    public string Model { get; set; }
    public string Brand { get; set; }
    public string Color { get; set; }
}
class Program{
    static void Main(string[] args){
        Car car = new Car();
        car.Brand = "Maruti Suzuki";
        car.Model = "Swift";
        car.Color = "Grey";
        string json = JsonConvert.SerializerObject(car);
        File.WriteAllText("car.json",json);
        Console.WriteLine("Car object has been serialized to car.json");
    }
}