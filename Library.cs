using System;
class Book{
    private string title;
    private string author;
    private double price;
    private bool availability;

    public Book(string title, string author, double price, bool availability){
        this.title = title;
        this.author = author;
        this.price = price;
        this.availability = availability;
    }

    public void BorrowBook(){
        if (availability){
            availability = false;
            Console.WriteLine($"{title} has been borrowed.");
        }
        else{
            Console.WriteLine($"{title} is not available.");
        }
    }

    public void DisplayBook(){
        Console.WriteLine($"Title: {title}, Author: {author}, Price: {price}, Available: {availability}");
    }
}

class Program{
    static void Main(){
        Book book1 = new Book("The Alchemist", "Paulo Coelho", 15.99, true);
        book1.DisplayBook();
        book1.BorrowBook();
        book1.DisplayBook();
    }
}
