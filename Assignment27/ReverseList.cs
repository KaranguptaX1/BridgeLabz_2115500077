using System;
using System.Collections;
using System.Collections.Generic;
class Reverse{
    //Method to reverse the ArrayList
    static void ReverseArrayList(ArrayList arr){
        int left=0;
        int right= arr.Count-1;
        //swapping left and right elements to reverse the list
        while(left<right){
            object temp=arr[left];
            arr[left]=arr[right];
            arr[right]=temp;
            left++;
            right--;

        }
    }
    //Method to reverse linked list
    static LinkedList<T> ReverseLinkedList<T>(LinkedList<T> list){
        //create anothe Linked List
        LinkedList<T> reverselist= new LinkedList<T>();
        //Add elements to other list
        foreach(var item in list){
            reverselist.AddFirst(item);
        }
        return reverselist;
    }
    //Main method
    static void Main(string[] args){
        //ArrayList reverse
        ArrayList arrayList= new ArrayList{1,2,3,4,5,6};
        ReverseArrayList(arrayList);
        Console.WriteLine("Reverse ArrayList: "+ string.Join(", ",arrayList.ToArray()));
        //Linked list reverse
        LinkedList<int> linkedList= new LinkedList<int>(new int[]{1,2,3,4,5});
        LinkedList<int> reverselist=ReverseLinkedList(linkedList);
        Console.WriteLine("Reverse LinkedList: "+string.Join(", ",reverselist));

    }
}