using System;
//Friend node class
class Friend{
    //variables of friends
     internal int UserID;
     internal string Name;
     internal int Age;
    //Constructor
    public Friend(int UserID, string Name, int Age){
        this.UserID = UserID;
        this.Name = Name;
        this.Age = Age;
    }
}
//class for Node 
class Node{
    internal Friend holder;
    internal LinkedList friends;
    internal Node next;
    //Constructor
    public Node(Friend holder){
        this.holder = holder;
        friends = new LinkedList();
    }
}
//Linked list class
class LinkedList{
    internal Node head;
    internal Node end;
    internal int length=0;
    //method to add user
    public void AddUser(Friend user){
        //if null
        if(head==null){
            head = new Node(user);
            end = head;
        }
        //at last position
        else{
            end.next = new Node(user);
            end = end.next;
        }
        length++;
    }
    //Add connection between friends
    public void AddConnection(string user1, string user2){
        Node temp = head;
        Node friend1=null,friend2=null;
        while(temp!=null){
            if(temp.holder.Name == user1){
                friend1 = temp;
            }
            if(temp.holder.Name == user2){
                friend2 = temp;
            }
            temp= temp.next;
        }
        if(friend1!=null && friend2!=null){
        friend1.friends.AddUser(friend2.holder);
        friend2.friends.AddUser(friend1.holder);
        }
    }
    //method to delete user
    public void DeleteUser(Friend User){
        Node temp =head;
        if(head.holder == User){
            head = head.next;
            length--;
            return;
        }
        while(temp.next!=end && temp.next.holder!=User){
            temp = temp.next;
        }
        if(temp.next.holder!=User){
            return;
        }
        temp.next=temp.next.next;
    }
    //method to remove the connection between friends
    public void RemoveConnection(string user1, string user2){
        Node temp = head;
        Node friend1=null,friend2=null;
        while(temp!=null){
            if(temp.holder.Name == user1){
                friend1 = temp;
            }
            if(temp.holder.Name == user2){
                friend2 = temp;
            }
            temp= temp.next;
        }
        friend1.friends.DeleteUser(friend2.holder);
        friend2.friends.DeleteUser(friend1.holder);
    }
    //method to display the mutual friends
    public void MutualFriends(string u1, string u2){
        Node friend1=null,friend2=null;
        Node temp = this.head;
        while(temp!=null){
            if(temp.holder.Name == u1){
                friend1 = temp;
            }
            if(temp.holder.Name == u2){
                friend2 = temp;
            }
            temp= temp.next;
        }
        Node list1 = friend1.friends.head,list2;
        Console.WriteLine($"Mutual Friends of {u1} and {u2}");
        while(list1 !=null){
            list2 = friend2.friends.head;
            while(list2 !=null){
                if(list1.holder == list2.holder){
                    Console.WriteLine($"Name -> {list1.holder.Name}");
                }
                list2 = list2.next;
            }
            list1 = list1.next;
        }
        Console.WriteLine();
    }
    //method to display all friends
    public void DisplayAllFriends(string u1){
        Console.WriteLine($"All Friends of {u1}");
        Node friend1=null;
        Node temp = head;
        while(temp!=null){
            if(temp.holder.Name == u1){
                friend1 = temp;
            }
            temp= temp.next;
        }
        Node friendsList = friend1.friends.head;

        while(friendsList != null){
            Console.WriteLine(friendsList.holder.Name);
            friendsList = friendsList.next;
        } 
        Console.WriteLine();
    }
    //method to search the user by name
    public void SearchUser(string Name){
        Node temp = head;
        while(temp!=null){
            if(temp.holder.Name==Name){
                Console.WriteLine($"ID -> {temp.holder.UserID}\nName -> {temp.holder.Name}\nAge -> {temp.holder.Age}\n");
                return;
            }
        }
    }
    //method to search the user by id
    public void SearchUser(int id){
        Node temp = head;
        while(temp!=null){
            if(temp.holder.UserID==id){
                Console.WriteLine($"ID -> {temp.holder.UserID}\nName -> {temp.holder.Name}\nAge -> {temp.holder.Age}\n");
                return;
            }
            temp = temp.next;
        }
    }
    //method to count the friends
    public void CountFriends(){
        Node temp = head;
        while(temp!=null){
            Console.WriteLine($"No of Friends of {temp.holder.Name} -> {this.head.friends.length}");
            temp = temp.next;
        }
        Console.WriteLine();
    }
}

class SocialMedia{
    //Main methdo to cal the instance and methods
    public static void Main(){
        LinkedList users = new LinkedList();
        users.AddUser(new Friend(3,"Rahul Kumar",22));
        users.AddUser(new Friend(2,"Karan Gupta",21));
        users.AddUser(new Friend(1,"Prakhar Gupta",22));
        users.AddConnection("Rahul Kumar","Karan Gupta");
        users.AddConnection("Karan Gupta","Prakhar Gupta");
        users.AddConnection("Rahul Kumar","Prakhar Gupta");
        users.MutualFriends("Prakhar Gupta","Karan Gupta");
        users.DisplayAllFriends("Rahul Kumar");
        users.DisplayAllFriends("Karan Gupta");
        users.CountFriends();
        users.RemoveConnection("Rahul Kumar","Karan Gupta");
        users.DisplayAllFriends("Rahul Kumar");
        users.DisplayAllFriends("Karan Gupta");
        users.SearchUser("Rahul Kumar");
        users.SearchUser(1);
        users.CountFriends();

    }
}