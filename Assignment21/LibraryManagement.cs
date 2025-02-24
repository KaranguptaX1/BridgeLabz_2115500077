using System;
//book node class
class Book{
    //variable for book
    public string title,author,genre;
    public int bookId;
    public bool availabilityStatus;
    //Prev and next pointer
    public Book next,prev;
    //constructor
    public Book(int bookId,string title,string author,string genre){
        this.title=title;
        this.author=author;
        this.genre=genre;
        this.bookId=bookId;
        availabilityStatus=true;
        prev=null;
        next=null;
    }
}
//Book list class
class BookList{
    //head pointer
    private Book head;
    //length variable
    private int length;
    //method to add at specified position
    public void AddBook(int bookId,string title,string author,string genre,int position=-1){
        Book book=new Book(bookId,title,author,genre);
        //add at null list or first position
        if(position==0 || head==null){
            if(head!=null){
            head.prev=book;}
            book.next=head;
            head=book;
            length++;
            return ;
        }
        //add at last position
        if(position==-1){
            Book temp1= head;
            while(temp1.next!=null){
                temp1=temp1.next;
            }
            temp1.next=book;
            book.prev=temp1;
            length++;
            return ;
        }
        //add at other positons
        Book temp= head;
        for(int i=0;i<position-1&&temp.next!=null;i++){
            temp=temp.next;
        }
        if(temp.next!=null){
        temp.next.prev=book;}
        book.prev=temp;
        book.next=temp.next;
        temp.next=book;
        length++;

    }
    //method to remove the book
    public void RemoveBook(int bookId){
        //if list is null
        if (head==null){
            Console.WriteLine("No element to remove.");
            return;
        }
        //remove the first element
        if(head.bookId==bookId){
            head=head.next;
            if(head!=null){
            head.prev=null;
            length--;}
            return ;
        }
        //remove from other positons
        Book temp=head;
        while(temp.next!=null && temp.next.bookId!=bookId){
            temp=temp.next;
        }
        if(temp.next!=null){
            Book removeNode=temp.next;
            temp.next=removeNode.next;
            if(removeNode.next!=null){
                removeNode.next.prev=temp;}
            length--;
        }

    }
    //method to search book by author
    public Book SearchBookByAuthor(string author){
        Book temp=head;
        while(temp!=null){
            if(temp.author==author){
                return temp;}
            temp=temp.next;
        }
        return null;
    }
    //method to search book by title
    public Book SearchBookByTitle(string title){
        Book temp=head;
        while(temp!=null){
            if(temp.title==title){
                return temp;}
            temp=temp.next;
        }
        return null;
    }
    //method to display either in forward or reverse order
    public void Display(bool reverse=false){
        if(head==null){
            Console.WriteLine("No element in list.");
            return;
        }
        Book temp=head;
        //method to display in forward 
        if(!reverse){
        while(temp!=null){
            Console.WriteLine($"BookId:{temp.bookId}, Title: {temp.title},author: {temp.author},Genre: {temp.genre},Availabilty status:{temp.availabilityStatus}");
            temp=temp.next;
        }}
        //method to display in reverse
        else{
            while(temp.next!=null){
                temp=temp.next;
            }
            while(temp!=null){
                Console.WriteLine($"BookId:{temp.bookId}, Title: {temp.title},author: {temp.author},Genre: {temp.genre},Availabilty status:{temp.availabilityStatus}");
                temp=temp.prev;
            }
        }
    }
    //method to update the status
    public void UpdateStatus(int bookId,bool status){
        Book temp=head;
        while(temp!=null){
            if(temp.bookId==bookId){
                temp.availabilityStatus=status;
                return;
            }
            temp=temp.next;
        }
        
    }
    //method to get the books number or length of list
    public void Getlength(){
        Console.WriteLine($"Number of books: {length}");
    }
}
class Program{
    //Main method to call the instance and methods
    static void Main(string []args){
        BookList bookList=new BookList();
        bookList.AddBook(1,"Harry Potter","JK Rowling","Fiction");
        bookList.AddBook(2,"KGF","Yash","Adventure");
        bookList.AddBook(3,"Brief History of time","Stephan Hawkings","Science");
        bookList.AddBook(4,"Doremon","Fujiyama","Ficiton",1);
        
        Book search= bookList.SearchBookByAuthor("Yash");
        if(search!=null){
        Console.WriteLine(search.title);}
        bookList.Display(true);
        Console.WriteLine();
        bookList.RemoveBook(2);
        bookList.Getlength();
        bookList.Display();
    }
}