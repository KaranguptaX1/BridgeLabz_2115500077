using System;
using System.Collections.Generic;
class Operations{
    static void Main(string[]args){
        HashSet<int> set1= new HashSet<int>{1,2,4,5,6,100,3};
        //Initialize array with hashset size
        int[] arr= new int[set1.Count];
        //Copy element from hashset to array
        set1.CopyTo(arr);
        //Sort the array
        Array.Sort(arr);
        //Display output
        foreach(var item in arr){
            Console.Write($"{item}, ");
        }
    }
}

