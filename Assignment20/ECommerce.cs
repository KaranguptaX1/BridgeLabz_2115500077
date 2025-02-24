using System;
using System.Collections.Generic;

//Parent class
abstract class Product{
    //Private variables
    private int productId;
    private string name;
    private double price;
    // Properties of variables
    public int ProductId { get { return productId; } }
    public string Name { get { return name; } }
    public double Price { get { return price; } }
    //Constructor
    public Product(int productId, string name, double price)
    {
        this.productId = productId;
        this.name = name;
        this.price = price;
    }
    //abstract method
    public abstract double CalculateDiscount();
    //Method to display details
    public void DisplayDetails(){
        Console.WriteLine($"Product Details:\nId: {productId}\nName: {name}\nPrice: {price:C}");
    }
}

// Interface 
interface ITaxable{
    //methods
    double CalculateTax();
    string GetTaxDetails();  
}

// Electronics subclass
class Electronics : Product, ITaxable{
    private double tax;
    private double discount=0.1;
    public Electronics(int productId, string name, double price,double tax) : base(productId, name, price) { 
        this.tax=tax;
    }
    public override double CalculateDiscount()
    {
        return Price * discount;
    }

    public double CalculateTax()
    {
        return Price * tax;
    }

    public string GetTaxDetails()
    {
        return $"Electronics Tax: {CalculateTax():C}";
    }
}

// Clothing Class
class Clothing : Product, ITaxable{
    private double tax;
    private double discount=0.2;
    public Clothing(int productId, string name, double price,double tax) : base(productId, name, price) { 
        this.tax=tax;
    }
    public override double CalculateDiscount(){
        return Price * discount;
    }
    public double CalculateTax(){
        return Price * tax;
    }
    public string GetTaxDetails(){
        return $"Clothing Tax: {CalculateTax():C}";
    }
}
// Groceries Class (Now Implements ITaxable)
class Groceries : Product, ITaxable{
    private double tax;
    private double discount=0.05;
    public Groceries(int productId, string name, double price,double tax) : base(productId, name, price) { 
        this.tax=tax;
    }
    public override double CalculateDiscount(){
        return Price * discount;
    }

    public double CalculateTax(){
        return Price * tax;
    }

    public string GetTaxDetails(){
        return $"Groceries Tax: {CalculateTax():C}";
    }
}
// E-Commerce class
class ECommerce{
    //Calculate Final Price method
    static void CalculateFinalPrice(List<Product> products){
        //loop through products
        foreach (Product product in products){
            //call the DisplayDetails method
            product.DisplayDetails();
            //calculate discount
            double discount = product.CalculateDiscount();
            Console.WriteLine($"Discount: {discount}");
            double tax = 0;
            //type cast product to taxable ITaxable
            if (product is ITaxable taxable){
                tax = taxable.CalculateTax();
                Console.WriteLine(taxable.GetTaxDetails());
            }
            double finalPrice = product.Price + tax - discount;
            Console.WriteLine($"Final Price: {finalPrice:C}");
        }
    }
    //Main Method
    static void Main(string[] args){
        List<Product> products = new List<Product>();
        Electronics product1 = new Electronics(12, "Fan", 1200,0.01);
        Clothing product2 = new Clothing(13, "Pants", 999,0.1);
        Groceries product3 = new Groceries(14, "Apple", 15,0.02);
        products.Add(product1);
        products.Add(product2);
        products.Add(product3);
        CalculateFinalPrice(products);
    }
}
