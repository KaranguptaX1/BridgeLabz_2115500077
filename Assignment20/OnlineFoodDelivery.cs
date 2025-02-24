using System;
using System.Collections.Generic;
//Parent abstract class
abstract class FoodItem{
    //Private variable and properties
    private string itemName;
    private double price;
    private int quantity;
    public string ItemName{get{return itemName;}}
    public double Price{get{return price;}}
    public int Qunatity{get{return quantity;}}
    //Constructor
    public FoodItem(string itemName,double price,int quantity){
        this.itemName=itemName;
        this.price=price;
        this.quantity=quantity;
    }
    //GetItemDetails method
    public void GetItemDetails(){
        Console.WriteLine($"FoodItems: \nName:{ItemName}\nPrice: {Price:C}\nQuantity:{Qunatity}");
    }
    //abstract method
    public abstract double CalculateTotalPrice();
}
//Interface
interface IDiscountable{
    void ApplyDiscount(double discountRate);
    void GetDiscountDetails();
}
//VegItem subclass
class VegItem:FoodItem,IDiscountable{
    //Private variables
    private double tax=0.1;
    private double discount=0;
    //Constructor
    public VegItem(string itemName,double price,int quantity):base(itemName,price,quantity){}
    //Override parent class method
    public override double CalculateTotalPrice(){
        double total=Price*Qunatity+Price*Qunatity*tax;
        return total-discount;
    }
    //describe ApplyDiscount()
    public void ApplyDiscount(double discountRate){
        discount=(Price*Qunatity*discountRate)/100;
    }
    //Describe GetDiscountDetails()
    public void GetDiscountDetails(){
        Console.WriteLine($"Discount Applied: {discount:C}");
    } 
}
//NonVegItem subclass
class NonVegItem:FoodItem,IDiscountable{
    //Private variables
    private double tax=0.25;
    private double discount=0;
    public NonVegItem(string itemName,double price,int quantity):base(itemName,price,quantity){}
    public override double CalculateTotalPrice(){
        double total=Price*Qunatity+Price*Qunatity*tax;
        return total-discount;
    }
    public void ApplyDiscount(double discountRate){
        discount=(Price*Qunatity*discountRate)/100;
    }
    public void GetDiscountDetails(){
        Console.WriteLine($"Discount Applied: {discount:C}");
    } 
}
class OnlineFoodDelivery{
    //Main method
    static void Main(string[]args){
        //food item list
        List<FoodItem> foodItems=new List<FoodItem>();
        FoodItem pasta= new VegItem("Pasta",100.00,2);
        FoodItem burger= new NonVegItem("Chicken Burger",249.99,1);
        foodItems.Add(pasta);
        foodItems.Add(burger);
        foreach(FoodItem item in foodItems){
            //Item methods
            item.GetItemDetails();
            Console.WriteLine($"Price Before Discount: {item.CalculateTotalPrice():C}");
            //type cast to discountable
            if(item is IDiscountable discountable){
                discountable.ApplyDiscount(10);
                discountable.GetDiscountDetails();
                Console.WriteLine($"Price After Discount: {item.CalculateTotalPrice():C}");
            }
        }
    }
}