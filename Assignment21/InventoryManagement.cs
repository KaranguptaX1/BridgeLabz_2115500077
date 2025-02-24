using System;
//Item node class
class ItemNode{
    //Item variables 
    public int itemId ;
    public string name;
    public int quantity;
    public double price;
    public ItemNode Next;
    //Constructor
    public ItemNode(int itemId,string name,int quantity,double price){
        this.itemId=itemId;
        this.name=name;
        this.quantity=quantity;
        this.price=price;
        Next=null;
    }
}
//Inventory linked list
class Inventory{
    //head pointer
    public ItemNode head;
    //length variable
    public int length=0;
    //method to add at specified location
    public void AddItems(int itemId,string name,int quantity,double price,int position=-1){
        ItemNode item= new ItemNode(itemId,name,quantity,price);
        //add at first position or if list is empty
        if(position==0 || head==null){
            item.Next=head;
            head=item;
            length++;
            return;
        }
        //add at last position
        if(position==-1){
            ItemNode temp=head;
            while(temp.Next!=null){
                temp=temp.Next;
            }
            temp.Next=item;
            length++;
            return;
        }
        //add at any other position
        ItemNode prev=head;
        for(int i=0;i<position-1&& prev.Next!=null;i++){
            prev=prev.Next;
        }
        item.Next=prev.Next;
        prev.Next=item;
        length++;
        
    }
    //method to delete items
    public void DeleteItems(int itemId){
        //if list is null
        if(head==null){
            Console.WriteLine("No element to delete.");
            length--;
            return;
        }
        //remove first element
        if(head.itemId==itemId){
            head=head.Next;
            length--;
            return;
        }
        //remove any other element 
        ItemNode temp= head;
        while(temp.Next!=null && temp.Next.itemId!=itemId){
            temp=temp.Next;
        }
        if(temp.Next!=null){
            temp.Next=temp.Next.Next;
            length--;
        }
    }
    //method to search by item id
    public ItemNode SearchByItemId(int itemId){
        ItemNode temp=head;
        while(temp!=null){
            if(temp.itemId==itemId){
                return temp;
            }
        temp=temp.Next;
        }
        return null;
    }
    //method to search by item name
    public ItemNode SearchByItemName(string name){
        ItemNode temp=head;
        while(temp!=null){
            if(temp.name==name){
                return temp;
            }
        temp=temp.Next;
        }
        return null;
    }
    //method to display the items
    public void Display(){
        ItemNode temp= head;
        //if there is no list
        if(temp==null){
            Console.WriteLine("No element in list");
            return;
        }
        //display the list
        while(temp!=null){
            Console.WriteLine($"Item ID:{temp.itemId},Name: {temp.name},quantity:{temp.quantity},Price:{temp.price}");
            temp=temp.Next;
        }
    }
    //method to update the quantity
    public void UpdateQuantity(int itemId,int quantity){
        ItemNode search = SearchByItemId(itemId);
        if(search!=null){
            search.quantity=quantity;
        }
    }
    // method to calculate the total value
    public void TotalValue(){
        double total=0;
        ItemNode temp= head;
        //if list is null
        if(temp==null){
            Console.WriteLine("No element in list");
            return;
        }
        //calculate the total price
        while(temp!=null){
            total+=temp.price*temp.quantity;
            temp=temp.Next;
        }
        Console.WriteLine($"Total value of Inventory: {total}");
    }
    //method to compare the strings
    private bool Compare(string s1,string s2){
        int i=0;
        int j=0;
        while(i<s1.Length && j<s2.Length){
            if(s1[i]<s2[j]){
                return true;
            }
            else if(s1[i]>s2[j]){
                return false;
            }
            i++;
            j++;      
            }
        if(i<=s1.Length){
            return true;
        }
        return false;
    }
    //method to sort on basis of price and name
    public void SortAscending(){
        //sort list on basis of name
        for(int i=0;i<length-1;i++){
            ItemNode temp=head;
            for(int j=0;j<length-1-i;j++){
                if(!(Compare(temp.name,temp.Next.name))){
                    Console.WriteLine(temp.name +" "+ temp.Next.name);
                    ItemNode x= new ItemNode(0,"",0,0);
                    //transfering the data between nodes
                    x.name=temp.name;
                    x.itemId=temp.itemId;
                    x.price=temp.price;
                    x.quantity=temp.quantity;
                    temp.name=temp.Next.name;
                    temp.itemId=temp.Next.itemId;
                    temp.price=temp.Next.price;
                    temp.quantity=temp.Next.quantity;
                    temp.Next.name=x.name;
                    temp.Next.itemId=x.itemId;
                    temp.Next.price=x.price;
                    temp.Next.quantity=x.quantity;
                }
                temp=temp.Next;
            }
            
        }
        //sort on basis of price
        for(int i=0;i<length-1;i++){
            ItemNode temp=head;
            for(int j=0;j<length-1-i;j++){
                if(temp.price>temp.Next.price){
                    ItemNode x=new ItemNode(0,"",0,0);
                    x.name=temp.name;
                    x.itemId=temp.itemId;
                    x.price=temp.price;
                    x.quantity=temp.quantity;
                    temp.name=temp.Next.name;
                    temp.itemId=temp.Next.itemId;
                    temp.price=temp.Next.price;
                    temp.quantity=temp.Next.quantity;
                    temp.Next.name=x.name;
                    temp.Next.itemId=x.itemId;
                    temp.Next.price=x.price;
                    temp.Next.quantity=x.quantity;
                }
                temp=temp.Next;
            }
        }


    }
    //sort on basis of descending order
    public void SortDescending(){
        for(int i=0;i<length-1;i++){
            ItemNode temp=head;
            for(int j=0;j<length-1-i;j++){
                if((Compare(temp.name,temp.Next.name))){
                    Console.WriteLine(temp.name +" "+ temp.Next.name);
                    ItemNode x= new ItemNode(0,"",0,0);
                    x.name=temp.name;
                    x.itemId=temp.itemId;
                    x.price=temp.price;
                    x.quantity=temp.quantity;
                    temp.name=temp.Next.name;
                    temp.itemId=temp.Next.itemId;
                    temp.price=temp.Next.price;
                    temp.quantity=temp.Next.quantity;
                    temp.Next.name=x.name;
                    temp.Next.itemId=x.itemId;
                    temp.Next.price=x.price;
                    temp.Next.quantity=x.quantity;
                }
                temp=temp.Next;
            }
            
        }
        for(int i=0;i<length-1;i++){
            ItemNode temp=head;
            for(int j=0;j<length-1-i;j++){
                if(temp.price<temp.Next.price){
                    ItemNode x=new ItemNode(0,"",0,0);
                    x.name=temp.name;
                    x.itemId=temp.itemId;
                    x.price=temp.price;
                    x.quantity=temp.quantity;
                    temp.name=temp.Next.name;
                    temp.itemId=temp.Next.itemId;
                    temp.price=temp.Next.price;
                    temp.quantity=temp.Next.quantity;
                    temp.Next.name=x.name;
                    temp.Next.itemId=x.itemId;
                    temp.Next.price=x.price;
                    temp.Next.quantity=x.quantity;
                }
                temp=temp.Next;
            }
        }


    }
}
class Program{
    //Main method to call the instance and methods
    static void Main(){
    Inventory itemList= new Inventory();
    itemList.AddItems(1,"fans",10,1200);
    itemList.AddItems(2,"woodChips",100,50);
    itemList.AddItems(5,"iron",50,500);
    itemList.AddItems(3,"iron",50,400);
    itemList.AddItems(4,"towel",100,605);
    itemList.AddItems(4,"chart",60,605);
    
    
    Console.WriteLine(itemList.length);
    itemList.Display();
    itemList.TotalValue();
    itemList.SortAscending();
    itemList.Display();
    itemList.SortDescending();
    itemList.Display();


    }

}