using System;
using System.Collections.Generic;
//Base class
abstract class Product{
    //Properties
    public string Name { get; set; }
    public double Price { get; set; }
    //Constructor
    public Product(string name, double price){
        Name = name;
        Price = price;
    }
    public abstract void Display();
}
//BookCategory class
class BookCategory : Product{
    public string Author { get; set; }
    //constructor
    public BookCategory(string name, string author, double price): base(name, price){
        Author = author;
    }
    //override parent class method
    public override void Display(){
        Console.WriteLine($"BookName: {Name}, Author: {Author}, Price: {Price:C}");
    }
}
// ClothingCategory class
class ClothingCategory : Product{
    public string Seller { get; set; }
    public ClothingCategory(string name, string seller, double price): base(name, price){
        Seller = seller;
    }
    public override void Display(){
        Console.WriteLine($"Clothing: {Name}, Seller: {Seller}, Price: {Price:C}");
    }
}
// Generic ProductList Class
class ProductList<T> where T : Product{
    private List<T> products = new List<T>();
    // Add a product 
    public void AddProduct(T product){
        products.Add(product);
    }
    // Apply discount (Generic Method)
    public void ApplyDiscount<TProduct>(TProduct product, double discount) where TProduct: Product{
        product.Price -= product.Price * (discount / 100);
        Console.WriteLine($"Discount of {discount}% applied on {product.Name} so new Price: ₹{product.Price}");
    }
    // Display products
    public void DisplayInfo(){
        foreach (var product in products){
            product.Display();
        }
    }
}
class MarketPlace{
    //Main Method
    static void Main(){
        ProductList<BookCategory> books = new ProductList<BookCategory>();
        ProductList<ClothingCategory> clothings = new ProductList<ClothingCategory>();
        // Adding books
        var book1 = new BookCategory("Harry Potter", "J.K. Rowling", 1200);
        var book2 = new BookCategory("One Piece", "Ichiro Oda", 800);
        books.AddProduct(book1);
        books.AddProduct(book2);

        // Adding clothes
        var cloth1 = new ClothingCategory("Shirt", "Wrogn", 1500);
        var cloth2 = new ClothingCategory("Jeans", "PeterEngland", 3000);
        clothings.AddProduct(cloth1);
        clothings.AddProduct(cloth2);
        //Display Products
        books.DisplayInfo();
        Console.WriteLine();
        clothings.DisplayInfo();
        Console.WriteLine();
        // Apply discounts
        books.ApplyDiscount(book1, 10);
        clothings.ApplyDiscount(cloth1, 20);
        //Display output
        Console.WriteLine();
        books.DisplayInfo();
        Console.WriteLine();
        clothings.DisplayInfo();
    }
}
