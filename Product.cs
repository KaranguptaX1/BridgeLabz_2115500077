using System;
class Product{
    private string productName;
    private double price;
    private static int totalProducts = 0;
    //Constructor
    public Product(string productName, double price){
        this.productName = productName;
        this.price = price;
        totalProducts++;
    }
    public void DisplayProductDetails(){
        Console.WriteLine($"Product: {productName}, Price: {price}");
    }

    public static void DisplayTotalProducts(){
        Console.WriteLine($"Total Products: {totalProducts}");
    }
}

class Program{
    static void Main(){
        Product p1 = new Product("Laptop", 1200);
        Product p2 = new Product("Phone", 800);

        p1.DisplayProductDetails();
        p2.DisplayProductDetails();

        Product.DisplayTotalProducts();
    }
}
