using System;
using System.Collections.Generic;
class Operations{
    static void Main(string[]args){
        HashSet<int> set1= new HashSet<int>{1,2,3};
        HashSet<int> set2= new HashSet<int>{1,2,4,5};
        HashSet<int> set3= new HashSet<int>(set1);
        //Symmetric difference with other set
        set3.SymmetricExceptWith(set2);
        //Display output
        foreach(var item in set3){
            Console.Write($"{item}, ");
        }
        Console.WriteLine();
    }
}