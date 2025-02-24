using System;
//class for Task
class Task{
    //varible for task
    internal int ProcessID;
    internal int BurstTime;
    internal int WaitingTime;
    internal int Turn_AroundTime;
    internal string Priority;
    //Constructor
    public Task(int ProcessID, int BurstTime, string Priority){
        this.ProcessID = ProcessID;
        this.BurstTime = BurstTime;
        this.Priority = Priority;
        this.WaitingTime = 0;
        this.Turn_AroundTime = 0;
    }
}
//Node class
class Node{
    internal Task data;
    internal int RemainingTime;
    internal Node next;
    //Constructor
    public Node(Task data){
        this.data = data;
        this.RemainingTime = data.BurstTime;
    }
}
//class for Round robin algorithm
class Algorithm{
    Node head;
    Node end;
    int length;
    Task[] processes;
    //Constructor
    public Algorithm(){
        this.length=0;
    }
    //Function to add the process
    public void AddNode(Task x){
        // if list is empty
        if(head==null){
            head = new Node(x);
            end=head;
            end.next=head;
        }
        //add to end of list
        else{
            end.next = new Node(x);
            end=end.next;
            end.next=head;
        }
        length++;
    }
    //delete the process from list
    public void DeleteNode(int id){
        if(processes==null)
            processes = new Task[length];
        
        Node temp = end;
        if(temp==null)
            return;
        if(head == end){
            processes[id] = head.data;
            head=null;
            end=null;
            return;
        }
        while(temp.next!=this.end && temp.next.data.ProcessID!=id){
            temp = temp.next;
        }
        if(temp.next.data.ProcessID!=id){
            return;
        }
        processes[id] = temp.next.data;
        if(temp.next==end)
            end=temp;
        temp.next = temp.next.next;
    }
    //display the list of processes
    public void DisplayList(){
        Node temp = head;
        if(head == null)
            return;
        while(temp!=end){
            Console.Write($"Process {temp.data.ProcessID},{temp.RemainingTime} - ");
            temp = temp.next;
        }
        if(temp!=null)
        Console.WriteLine($"Process {temp.data.ProcessID},{temp.RemainingTime}\n");
    }
    //Function to simulate the algorithm
    public void SimulateScheduling(){
        Console.WriteLine("Enter Time Quantum in Seconds -> ");
        int timeQuantum = Convert.ToInt32(Console.ReadLine());
        int RemainingTimeQuantum = timeQuantum;
        //for total time
        int clock = 0;
        Console.WriteLine("Simuation Start");
        Node temp = head;
        int x=0,y=1;
        while(x<this.length){
            Console.WriteLine($"Round {y}");
            RemainingTimeQuantum = timeQuantum;
            while(x<this.length && RemainingTimeQuantum > 0){
                //if process exceed the time quantam
                if(temp.RemainingTime>RemainingTimeQuantum){
                    clock += RemainingTimeQuantum;
                    temp.RemainingTime-=RemainingTimeQuantum;
                    RemainingTimeQuantum = 0;
                }
                //if process time is less than time quantam
                else if(temp.RemainingTime<RemainingTimeQuantum){
                    RemainingTimeQuantum -= temp.RemainingTime;
                    clock += temp.RemainingTime;
                    temp.RemainingTime = 0;
                }
                //if time is equal to time quantam
                else{
                    clock += RemainingTimeQuantum;
                    RemainingTimeQuantum = 0;
                    temp.RemainingTime = 0;
                }
                //proces is complete
                if(temp.RemainingTime==0){
                    temp.data.Turn_AroundTime = clock;
                    temp.data.WaitingTime = clock - temp.data.BurstTime;
                    this.DeleteNode(temp.data.ProcessID);
                    if(RemainingTimeQuantum!=0)
                        temp = temp.next;
                    x++;
                }
            }
            temp = temp.next;
            this.DisplayList();
            y++;
            Console.WriteLine();
        }
        Console.WriteLine();
        for(int i=0;i<length;i++){
            Console.WriteLine($"Process : ID - {this.processes[i].ProcessID}, Waiting Time - {this.processes[i].WaitingTime}, Turn-Around Time - {this.processes[i].Turn_AroundTime}");
        }
    }
}

class RoundRobin{
    //Main method to execute the methods and classes
    public static void Main(){
        Algorithm roundRobin = new Algorithm();
        roundRobin.AddNode(new Task(0,5,"High"));
        roundRobin.AddNode(new Task(1,3,"low"));
        roundRobin.AddNode(new Task(2,2,"high"));
        roundRobin.AddNode(new Task(3,4,"high"));
        roundRobin.SimulateScheduling();
    }
}