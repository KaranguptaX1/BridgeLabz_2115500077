using System;
using System.Collections.Generic;
//abstract Parent Class
abstract class LibraryItem{
    //Variable and properties
    private string itemId,title,author;
    private bool isAvailable=true;
    public string ItemId{get{return itemId;}set{itemId=value;}}
    public string Title{get{return title;}set{itemId=value;}}
    public string Author{get{return author;}set{itemId=value;}}
    public bool IsAvailable{get{return isAvailable;}set{isAvailable=value;}}
    //Constructor
    public LibraryItem(string itemId,string title,string author){
        this.itemId=itemId;
        this.author=author;
        this.title=title;
    }
    //Get ItemDetails method
    public void GetItemDetails(){
        Console.WriteLine($"Item Details: \nItemId:{ItemId}\nTitle: {Title}\nAuthor:{Author}");
    }
    //abstract method
    public abstract int GetLoanDuration();
}
//Interface
interface IReservable{
    void ReserveItem();
    bool CheckAvailability();
}
//Book subclass
class Book:LibraryItem,IReservable{
    //loanDuration variable
    private int loanDuration=14;
    //Constructor
    public Book(string itemId,string title,string author):base(itemId,title,author){}
    //override the GetLoanDuration
    public override int GetLoanDuration(){
        return loanDuration;
    }
    //ReserveItem Method
    public void ReserveItem(){
        if(IsAvailable){
            IsAvailable=false;
            Console.WriteLine($"Book {Title} has been reserved.");
        }
        else{
            Console.WriteLine($"Book {Title} is not available.");
        }
    }
    //Check Availability method
    public bool CheckAvailability(){
        return IsAvailable;
    }

}
//Magazine Subclass
class Magazine:LibraryItem,IReservable{
    private int loanDuration=10;
    public Magazine(string itemId,string title,string author):base(itemId,title,author){}
    public override int GetLoanDuration(){
        return loanDuration;
    }
    public void ReserveItem(){
        if(IsAvailable){
            IsAvailable=false;
            Console.WriteLine($"Magazine {Title} has been reserved.");
        }
        else{
            Console.WriteLine($"Magazine {Title} is not available.");
        }
    }
    public bool CheckAvailability(){
        return IsAvailable;
    }
}
//DVD subclass
class DVD:LibraryItem,IReservable{
    private int loanDuration=7;
    public DVD(string itemId,string title,string author):base(itemId,title,author){}
    public override int GetLoanDuration(){
        return loanDuration;
    }
    public void ReserveItem(){
        if(IsAvailable){
            IsAvailable=false;
            Console.WriteLine($"DVD {Title} has been reserved.");
        }
        else{
            Console.WriteLine($"DVD {Title} is not available.");
        }
    }
    public bool CheckAvailability(){
        return IsAvailable;
    }
}

class LibraryManagement{
    //MainMethod
    static void Main(string[] args){
        List<LibraryItem> library = new List<LibraryItem>();
        Book book1= new Book("101","Iron Man","Stanlee");
        Magazine magazine1 = new Magazine("102","Inception","Christopher Nolan");
        DVD dvd1= new DVD("103","The Melluha","Sir Singh");
        library.Add(book1);
        library.Add(magazine1);
        library.Add(dvd1);
        //For loop in library item
        foreach(var item in library){
            Console.WriteLine("---------------------------");
            item.GetItemDetails();
            Console.WriteLine($"Loan Duration: {item.GetLoanDuration()}");
            if(item is IReservable reservable){
                reservable.ReserveItem();
                Console.WriteLine($"Availablity after reservation: {reservable.CheckAvailability()}");
            }
        }
    }

}