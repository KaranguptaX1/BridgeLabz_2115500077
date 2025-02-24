using System;
using System.Collections.Generic;
class NthElement{
    //method to get the nth element from last
    static void GetNthElement<T>(LinkedListNode<T> head,int number){
        //if head is null or number is less than 1
        if(head==null ||number<=0){
            Console.WriteLine($"Elements are less than {number} or you want 0 element");
            return;
        }
        //fast and slow pointers
        LinkedListNode<T> fast=head;
        LinkedListNode<T> slow=head;
        //move fast pointer to nth place
        for(int i=0;i<number;i++){
            if(fast==null){
                Console.WriteLine($"Elements are less than {number}");
                return ;
            }
            fast=fast.Next;
        }
        //move both pointers
        while(fast!=null){
            fast=fast.Next;
            slow=slow.Next;
        }
        //display the nth element from last
        Console.WriteLine($"{number} element from last: {slow.Value}");
    }
    //Main method
    static void Main(string [] args){
        LinkedList<string>  list = new LinkedList<string>(new string[]{"hello","world","new","for"});
        LinkedListNode<string> head= list.First;
        GetNthElement(head,2);
    }
}