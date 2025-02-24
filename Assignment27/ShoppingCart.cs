using System;
using System.Collections.Generic;
class ShoppingCart{
    Dictionary<string, double> cart = new Dictionary<string, double>();
    SortedDictionary<double, List<string>> sortedCart = new SortedDictionary<double, List<string>>();
    LinkedList<KeyValuePair<string, double>> orderedCart = new LinkedList<KeyValuePair<string, double>>();
    // Method to add Item in cart
    public void AddItem(string item, double price){
        cart[item] = price;
        orderedCart.AddLast(new KeyValuePair<string, double>(item, price));
        // Store in sortedCart with price as key
        if (!sortedCart.ContainsKey(price)){
            sortedCart[price] = new List<string>();
        }
        sortedCart[price].Add(item);
    }
    // Method to display items sorted by price
    public void DisplaySortedItems(){
        Console.WriteLine("\nSorted Items by Price:");
        foreach (var entry in sortedCart){
            foreach (var item in entry.Value){
                Console.WriteLine($"{item}: {entry.Key:C}");
            }
        }
    }
    // Method to display the ordered items
    public void DisplayOrderedItems(){
        Console.WriteLine("\nItems in Order:");
        foreach (var item in orderedCart){
            Console.WriteLine($"{item.Key}: {item.Value:C}");
        }
    }
}
class Shopping{
    // Main Method
    static void Main(){
        ShoppingCart cart = new ShoppingCart();
        cart.AddItem("Laptop", 100000);
        cart.AddItem("Mouse", 2500);
        cart.AddItem("Keyboard", 500);
        cart.AddItem("Monitor", 15000);
        cart.AddItem("USB Drive", 500); 
        // Display output
        cart.DisplaySortedItems();
        cart.DisplayOrderedItems();
    }
}
