using System;
using System.Collections.Generic;
class Customer{
    public string Name { get; set; }
    public List<Order> Orders { get; set; }
    // Constructor 
    public Customer(string name){
        Name = name;
        Orders = new List<Order>();
    }
    // Method to place an order
    public void PlaceOrder(Order order){
        Orders.Add(order);
    }
}
class Order{
    public List<Product> Products { get; set; }
    // Constructor 
    public Order(){
        Products = new List<Product>();
    }
    // Method to add a product to the order
    public void AddProduct(Product product){
        Products.Add(product);
    }
}
class Product{
    public string Name { get; set; }
    // Constructor 
    public Product(string name){
        Name = name;
    }
}
class Program{
    static void Main(){
        var customer = new Customer("Alice");
        var product1 = new Product("Laptop");
        var product2 = new Product("Smartphone");
        var order = new Order();
        order.AddProduct(product1);
        order.AddProduct(product2);
        customer.PlaceOrder(order);
        // Displaying the customers order with products
        Console.WriteLine($"{customer.Name} placed an order with the following products:");
        foreach (var prod in order.Products){
            Console.WriteLine(prod.Name);
        }
    }
}
