using System;
public class Book{
    public string ISBN;
    protected string title;
    private string author;

    public Book(string ISBN, string title, string author){
        this.ISBN = ISBN;
        this.title = title;
        this.author = author;
    }

    // Public methods to get and set author name
    public string GetAuthor(){
        return author;
    }

    public void SetAuthor(string author){
        this.author = author;
    }
}

public class EBook : Book{
    public EBook(string ISBN, string title, string author)
        : base(ISBN, title, author) { }

    public void DisplayBookInfo(){
        Console.WriteLine("ISBN: " + ISBN); // Accessing public member
        Console.WriteLine("Title: " + title); // Accessing protected member
    }
}

class Program{
    static void Main(string[] args){
        EBook ebook = new EBook("123-456-789", "C# Programming", "John Doe");
        ebook.DisplayBookInfo();
        Console.WriteLine("Author: " + ebook.GetAuthor());
    }
}
