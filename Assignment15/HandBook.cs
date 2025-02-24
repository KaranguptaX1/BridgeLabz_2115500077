using System;
public class Book{
    // Private fields
    private string title;
    private string author;
    private double price;
    // Constructor to initialize attributes
    public Book(string title, string author, double price){
        this.title = title;
        this.author = author;
        this.price = price;
    }
    // Method to display book details
    public void DisplayDetails(){
        Console.WriteLine($"Title: {title}");
        Console.WriteLine($"Author: {author}");
        Console.WriteLine($"Price: ${price:F2}");
    }
}

class Program{
    static void Main(){
        // Creating Book objects
        Book book1 = new Book("The Iron Man", "Stan Lee", 1.99);
        Book book2 = new Book("Atomic Habits", "James Clear", 19.99);
        // Displaying details
        Console.WriteLine("=== Book 1 Details ===");
        book1.DisplayDetails();
        Console.WriteLine("\n=== Book 2 Details ===");
        book2.DisplayDetails();
    }
}
