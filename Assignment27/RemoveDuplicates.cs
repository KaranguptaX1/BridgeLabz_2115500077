using System;
using System.Collections.Generic;
class Remove{
    //Remove the duplicates from list
    static List<T> RemoveDuplicates<T>(List<T> arr){
        List<T> list= new List<T>();
        foreach(T item in arr){
            if(!list.Contains(item)){
                list.Add(item);
            }
        }
        return list;
    }
    //Main method
    static void Main(string [] args){
        List<int> list = new List<int>{2,4,5,6,4,2,1};
        List<int> removeList= RemoveDuplicates(list);
        //Display output
        foreach(int var in removeList){
            Console.Write($"{var}, ");
        }

    }
}