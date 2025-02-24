using System;
class Book{
    private string title;
    private string author;
    private double price;
    // Default Constructor
    public Book(){
        title = "Unknown";
        author = "Unknown";
        price = 0.0;
    }
    // Parameterized Constructor
    public Book(string title, string author, double price){
        this.title = title;
        this.author = author;
        this.price = price;
    }
    public void DisplayBookDetails()
    {
        Console.WriteLine($"Title: {title}, Author: {author}, Price: {price}");
    }
}

class Program{
    static void Main(){
        Book book1 = new Book();
        Book book2 = new Book("C# Programming", "John Doe", 29.99);
        //Displau output
        book1.DisplayBookDetails();
        book2.DisplayBookDetails();
    }
}
