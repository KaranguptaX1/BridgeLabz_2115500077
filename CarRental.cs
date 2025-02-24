using System;
class CarRental{
    private string customerName;
    private string carModel;
    private int rentalDays;
    private double totalCost;
    private const double ratePerDay = 50.0;
	//parameterized constructor
    public CarRental(string customerName, string carModel, int rentalDays){
        this.customerName = customerName;
        this.carModel = carModel;
        this.rentalDays = rentalDays;
        CalculateTotalCost();
    }
    //calculate total cost
    private void CalculateTotalCost(){
        totalCost = rentalDays * ratePerDay;
    }//Display method
    public void DisplayRental(){
        Console.WriteLine($"Customer: {customerName}, Car: {carModel}, Days: {rentalDays}, Total Cost: ${totalCost}");
    }
}

class Program{
    static void Main(){
        CarRental rental1 = new CarRental("Alice", "Toyota Corolla", 5);
        rental1.DisplayRental();
    }
}
