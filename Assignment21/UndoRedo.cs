using System;
//Text node class
class TextNode{
    //variables
    public string text;
    public TextNode next,prev;
    //constructor
    public TextNode(string text){
        this.text=text;
        next=null;
        prev=null;
    }
}
//Functionalities class
class Functionalities{
    private TextNode head;
    private TextNode currentHead;
    //total available undo and redo operations
    private int undo=10;
    private int redo=0;
    //method to add the text in new node
    public void Add(string Text){
        TextNode text= new TextNode(Text);
        if(head==null){
            head=text;
            currentHead=text;
            return;
        }
        TextNode temp=head;
        while(temp.next!=null){
            temp=temp.next;
        }
        text.next=temp.next;
        temp.next=text;
        text.prev=temp;
        currentHead=text;
    }
    //method to move to previous node
    public void Undo(){
        if (currentHead==null){
            Console.WriteLine("No current state.");
            return;
        }
        if(currentHead.prev!=null && undo>0){
            currentHead=currentHead.prev;
            undo--;
            redo++;
            // Console.WriteLine($"Undo: {undo}");
            return;
        }
        Console.WriteLine("No back state");

    }
    //method to move to next node 
    public void Redo(){
        if (currentHead==null){
            Console.WriteLine("No current state.");
            return;
        }
        if(currentHead.next!=null && redo<11){
            currentHead=currentHead.next;
            undo++;
            redo--;
            // Console.WriteLine($"Undo: {undo}");
            return;
        }
        Console.WriteLine("No forward state");

    }
    //method to display the current node text
    public void Display(){
        TextNode temp=currentHead;
        Console.WriteLine("--------------------------");
        Console.WriteLine($"Current text: {temp.text}");
        Console.WriteLine("--------------------------");}
    }

class Program{
    //Main method to call the instance and methods
    static void Main(string []args){
        Functionalities texts=new Functionalities();
        int x=1;
        while(x>0){
            Console.WriteLine("Enter 1 to Add  New Text:");
            Console.WriteLine("Enter 2 to Undo Text:");
            Console.WriteLine("Enter 3 to Redo Text:");
            Console.WriteLine("Enter 4 to Display Current Text:");
            Console.WriteLine("Enter value less than 0 to exit:");
            x=Convert.ToInt32(Console.ReadLine());
            switch(x){
                case 1:
                    Console.Write("Enter the string: ");
                    string text=Console.ReadLine();
                    texts.Add(text);
                    break;

                case 2:
                    texts.Undo();
                    break;

                case 3:
                    texts.Redo();
                    break;
                case 4:
                    texts.Display();
                    break;
                default:
                    break;
            }
            

        }

}}