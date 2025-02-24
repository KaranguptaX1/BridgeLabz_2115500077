using System;
using System.Collections.Generic;
class Operations{
    static void Main(string[]args){
        //Make Hashsets
        HashSet<int> set1= new HashSet<int>{1,2,4,5,6,100,3};
        HashSet<int> set2= new HashSet<int>{1,2};
        //IsSubsetOf Method
        bool result= set2.IsSubsetOf(set1);
        //Display method
        Console.Write(result);
    }
}

