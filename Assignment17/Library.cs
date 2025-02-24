using System;
using System.Collections.Generic;
// class to represent books
class Book{
	//Initialize variables
    public string Title{get;}
    public string Author{get;}
    //Constructor
    public Book(string title,string author){
        Title=title;
        Author=author;
    }
    //Display method for book
    public void Display(){
        Console.WriteLine($"Book: {Title}, Author: {Author}");
    }

}
//class to represent Library
class Library{
	//Initialize variable
    public string Name{get;}
    public List<Book> Books {get;} =new  List<Book>();
    //Constructor
    public Library(string name){
        Name=name;
    }
    //Add book  method
    public void AddBook(Book book){
        if (!Books.Contains(book)){
        	Books.Add(book);
        }
        else{
        	Console.WriteLine($"The book {book.Title} is already available");
        }
    }
    //Method to display to books
    public void DisplayBooks(){
        Console.WriteLine($"Library:  {Name} has following books: ");
        foreach(var book in Books){
            book.Display();
        }
        Console.WriteLine("------------------------------------");

    }
}
//Main class to execute program
class Program{
    static void Main(string[] args){
    	//creating independent programs
        Book book1 = new Book("Iron Man","Stanlee");
        Book book2 = new Book ("SinghSuho","ORV");
        Book book3= new Book("Dragonball","Akira Toriyama");
        //creating library objects
        Library library1= new Library("The Central Library");
        Library library2= new Library("The Royal Library");
        //adding books
        library1.AddBook(book1);
        library1.AddBook(book2);
        library1.AddBook(book2);
        library2.AddBook(book2);
        library2.AddBook(book3);
        //Display books
        library1.DisplayBooks();
        library2.DisplayBooks();

    }
}