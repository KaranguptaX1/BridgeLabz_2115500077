using System;
//Movie node class
class Movies{
    //properties of Movies
    public string title,director;
    public int year;
    public int rating;
    public Movies next,prev;
    //Constructor
    public Movies(string title,string director,int year,int rating){
        this.title=title;
        this.director=director;
        this.year=year;
        this.rating=rating;
        prev=null;
        next=null;
    }
}
//MoviesList class for Linked list 
class MovieList{
    private Movies head;
    //Method to add Movies on basis of position
    public void AddMovies(string title,string director,int year,int rating,int position=-1){
        Movies movie=new Movies(title,director,year,rating);
        //add at first or null position
        if(position==0 || head==null){
            if(head!=null){
            head.prev=movie;}
            movie.next=head;
            head=movie;
            return ;
        }
        //method to add at last
        if(position==-1){
            Movies temp1= head;
            while(temp1.next!=null){
                temp1=temp1.next;
            }
            temp1.next=movie;
            movie.prev=temp1;
            return ;
        }
        //method to add at specified location
        Movies temp= head;
        for(int i=0;i<position-1&&temp.next!=null;i++){
            temp=temp.next;
        }
        if(temp.next!=null){
        temp.next.prev=movie;}
        movie.prev=temp;
        movie.next=temp.next;
        temp.next=movie;

    }
    //Method to remove movies on basis of title
    public void RemoveMovie(string title){
        //if there is no list
        if (head==null){
            Console.WriteLine("No element to remove.");
            return;
        }
        //to remove first element
        if(head.title==title){
            head=head.next;
            if(head!=null){
            head.prev=null;}
            return ;
        }
        //to remove other element from other position
        Movies temp=head;
        while(temp.next!=null && temp.next.title!=title){
            temp=temp.next;
        }
        if(temp.next!=null){
            Movies removeNode=temp.next;
            temp.next=removeNode.next;
            if(removeNode.next!=null){
                removeNode.next.prev=temp;}
        }

    }
    //Search movie on basis of director or rating
    public Movies SearchMovie(string director=null,int rating=-1){
        Movies temp=head;
        while(temp!=null){
            if(temp.director==director ||temp.rating==rating){
                return temp;}
            temp=temp.next;
        }
        return null;
    }
    //Display method for reverse or same order
    public void Display(bool reverse=false){
        //if there is no list
        if(head==null){
            Console.WriteLine("No element in list.");
            return;
        }
        //To print in same order
        Movies temp=head;
        if(!reverse){
        while(temp!=null){
            Console.WriteLine($"Details : Title: {temp.title},Director: {temp.director}, Year: {temp.year},rating: {temp.rating}");
            temp=temp.next;
        }}
        //to print in reverse order
        else{
            while(temp.next!=null){
                temp=temp.next;
            }
            while(temp!=null){
                Console.WriteLine($"Details : Title: {temp.title},Director: {temp.director}, Year: {temp.year},rating: {temp.rating}");
                temp=temp.prev;
            }
        }
    }
    //update rating on title
    public void UpdateRating(string title,int rating){
        Movies temp=head;
        while(temp!=null){
            if(temp.title==title){
                temp.rating=rating;
                return;
            }
            temp=temp.next;
        }
        
    }
}
class Program{
    //Main method to call instance and methods
    static void Main(string []args){
        MovieList movieList=new MovieList();
        movieList.AddMovies("Tere Naam","Salman khan",2006,5);
        movieList.AddMovies("KGF","Yash",2006,1);
        movieList.AddMovies("Pushpa","Allu Arjun",2006,2,1);
        movieList.AddMovies("Doremon steel troops","Nobita",2018,8);
        
        Movies search= movieList.SearchMovie("Allu Arjun");
        if(search!=null){
        Console.WriteLine(search.title);}
        movieList.Display(true);
        Console.WriteLine();
        movieList.RemoveMovie("Pushpa");
        movieList.Display();
    }
}