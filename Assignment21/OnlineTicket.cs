using System;
//class to ticket node
class TicketNode{
    //variables of ticket node
    public int ticketId;
    public string customerName,movieName;
    public int seatNumber;
    public string bookingTime;
    public TicketNode Next;
    //Constructor
    public TicketNode(int ticketId,string customerName,string movieName,int seatNumber,string bookingTime){
        this.ticketId=ticketId;
        this.customerName=customerName;
        this.movieName=movieName;
        this.seatNumber=seatNumber;
        this.bookingTime=bookingTime;
        Next=this;
    }
}
//Ticket List class
class Tickets{
    private TicketNode head;
    private int length;
    //method to add ticket
    public void AddTicket(int ticketId,string customerName,string movieName,int seatNumber,string bookingTime){
        TicketNode ticket=new TicketNode(ticketId,customerName,movieName,seatNumber,bookingTime);
        //If list is empty
        if(head==null){
            head=ticket;
            head.Next=head;
            length++;
            return;
        }
        //add at last position
        TicketNode temp=head;
        while(temp.Next!=head){
            temp=temp.Next;
        }
        ticket.Next=head;
        temp.Next=ticket;
        length++;
        }
    //method to remove the ticket using ticketid
    public void RemoveTicket(int ticketId){
        if(head==null){
            Console.WriteLine("No element in list");
            return;
        }
        if(head.ticketId==ticketId){
            TicketNode temp= head;
            while(temp.Next!=head){
                temp=temp.Next;
            }
            head=head.Next;
            temp.Next=head;
            return;
        }
        TicketNode prev= head;
        while(prev.Next!=head && prev.Next.ticketId!=ticketId){
            prev=prev.Next;
        }
        if(prev.Next!=head){
            prev.Next=prev.Next.Next;
            length--;
            return ;
        }
        Console.WriteLine($"No Element matched {ticketId}");

    }
    //method to display all tickets
    public void Display(){
        TicketNode temp= head;
        while(temp.Next!=head){
            Console.WriteLine($"TicketId:{temp.ticketId},Customer Name:{temp.customerName},MovieName: {temp.movieName},SeatNumber: {temp.seatNumber},Booking Time: {temp.bookingTime}");
            temp=temp.Next;
        }
        Console.WriteLine($"TicketId:{temp.ticketId},Customer Name:{temp.customerName},MovieName: {temp.movieName},SeatNumber: {temp.seatNumber},Booking Time: {temp.bookingTime}");

    }
    //method to search ticket using customer name
    public TicketNode SearchTicketByCustomerName(string name){
        if(head==null){
            Console.WriteLine("No Element in list.");
        }
        if(head.customerName==name){
            return head;
        }
        TicketNode temp=head.Next;
        while(temp!=head){
            if(temp.customerName==name){
                return temp;
            }
            temp=temp.Next;
        }
        return null;
    }
    //methdo to search ticket by movie name
    public TicketNode SearchTicketByMovieName(string name){
        if(head==null){
            Console.WriteLine("No Element in list.");
        }
        if(head.movieName==name){
            return head;
        }
        TicketNode temp=head.Next;
        while(temp!=head){
            if(temp.movieName==name){
                return temp;
            }
            temp=temp.Next;
        }
        return null;
    }
    //method to get total tickets
    public void TotalTickets(){
        Console.WriteLine($"Total Tickets:{length}");
    }
}
class Program{
    //Main method to call the class and methods
    static void Main(string[] args){
        Tickets ticketList= new Tickets();
        ticketList.AddTicket(1,"Rahul","KGF",45,"17:00");
        ticketList.AddTicket(3,"karan","Fairy Tail",32,"15:00");
        ticketList.AddTicket(2,"prakhar","KGF",44,"17:00");
        ticketList.AddTicket(4,"Nikhil","pushpa",60,"20:00");
        ticketList.RemoveTicket(2);
        TicketNode search=ticketList.SearchTicketByCustomerName("Rahul");
        if (search!=null){
            Console.WriteLine(search.ticketId+" "+search.seatNumber);
        }
        ticketList.Display();
        ticketList.RemoveTicket(4);
        ticketList.AddTicket(4,"Amogh","Openhiemer",110,"23:00");
        Console.WriteLine();
        ticketList.Display();


    }
}