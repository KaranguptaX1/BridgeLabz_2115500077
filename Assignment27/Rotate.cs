using System;
using System.Collections.Generic;
class Rotate{
    //Method to rotate the list
    static void RotateList<T>(List<T> arr,int number){
        for(int i=0;i<number;i++){
            //storing the first index data
            T temp=arr[0];
            //remove the first index data
            arr.RemoveAt(0);
            //add at last index
            arr.Add(temp);
        }

    }
    static void Main(string[] args){
        //make the list
        List<int> list= new List<int>{10,20,30,40,50};
        //call the method
        RotateList(list,2);
        //display output
        foreach(var item in list){
            Console.Write($"{item} ,");
        }

    }
}