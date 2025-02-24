using System;
using System.Collections.Generic;
class Operations{
    static void Main(string[]args){
        HashSet<int> set1= new HashSet<int>{1,2,3};
        HashSet<int> set2= new HashSet<int>{2,4,5,4,1};
        HashSet<int> set3= new HashSet<int>(set1);
        //Union with other set
        set3.UnionWith(set2);
        //Display output
        foreach(var item in set3){
            Console.Write($"{item}, ");
        }
        Console.WriteLine();
        //Intersect with other set
        HashSet<int> set4=new HashSet<int>(set1) ;
        set4.IntersectWith(set2);
        //Display output
        foreach(var item in set4){
            Console.Write($"{item}, ");
        }
        
    }
}