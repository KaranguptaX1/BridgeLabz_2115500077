using System;
namespace LibraryManagementSystem{
    class Book{
        //Initialize variables
        public static string  libraryName="Capgemini Library";
        private string Title,Author;
        private readonly string ISBN;
        //method to display library name
        public static void DisplayLibraryName(){
            Console.WriteLine($"Library name is {libraryName}");
        }
        // parametrized constructor
        public Book(string title,string author,string ISBN){
            this.Title= title;
            this.Author=author;
            this.ISBN= ISBN;

        }
        //Method to Display the book Details
        public void DisplayBookDetails(){
            if(this is Book){
                DisplayLibraryName();
                Console.WriteLine($"The Title is: {Title}");
                Console.WriteLine($"The Author is : {Author}");
                Console.WriteLine($"The ISBN is : {ISBN}");
                Console.WriteLine("---------------------------------");
            }
        }
    }
    //Other class to call the Book Class
    class Program{
        static void Main(string[] args){
            //Make the instance of Book
            Book book1 =new Book("Iron Man","Stan Lee","MAR001");
            Book book2 = new Book("Ncert","R.D. Sharma","NCER002");
            //call Display method
            book1.DisplayBookDetails();
            book2.DisplayBookDetails();
        }
    }
}