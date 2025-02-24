using System;
using System.Collections.Generic;
class Compare{
    //Method to compare the sets without order
    static bool CompareSet<T>(HashSet<T> set1,HashSet<T> set2){
        foreach(var item in set1){
            if(!set2.Contains(item)){
                return false;
            }
        }
        foreach(var item in set2){
            if(!set1.Contains(item)){
                return false;
            }
        }
        return true;
    }
    //Main Method
    static void Main(string []args){
        HashSet<int> set1= new HashSet<int>{1,2,3,4,5,5,4};
        HashSet<int> set2= new HashSet<int>{2,4,5,4,1,};
        bool result=CompareSet(set1,set2);
        Console.Write("Both Sets are Equal: "+result);

    }
}