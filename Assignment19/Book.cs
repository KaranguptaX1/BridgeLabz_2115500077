using System;
//Parent class
class Book{
    //Protected Variables
    protected string Title;
    protected int PublicationYear;
    //Constructor
    public Book(string Title,int PublicationYear){
        this.Title=Title;
        this.PublicationYear=PublicationYear;
    }
    //Display Info Method
    public virtual void DisplayInfo(){
        Console.WriteLine($"Book Details: \nTitle: {Title}\nPublication Year: {PublicationYear}");
    }
}
//Author Subclass
class Author:Book{
    //Additional variables
    private string Name;
    private string Bio;
    //Subclass Constructor    
    public Author(string Title,int year,string Name,string Bio):base(Title,year){
        this.Name=Name;
        this.Bio=Bio;
    }
    //Override Parent Class Method
    public override void DisplayInfo()
    {
        base.DisplayInfo();
        Console.WriteLine($"Author Name: {Name}\nBio :{Bio}");
        Console.WriteLine("--------------------------------");
    }

}
class Program{
//Main Method
    static void Main(string [] args){
        Book book= new Book("Iron Man",1990);
        Author author = new Author("Hulk",1991,"Stanlee","Marvel Writer");
        book.DisplayInfo();
        author.DisplayInfo();

    }
}