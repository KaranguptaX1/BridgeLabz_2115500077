using System;
using System.Collections;
using System.Collections.Generic;
class Frequency{
    //Method to return the count of each item in list
    static Dictionary<TKey,int> FrequencyCounter<TKey>(List<TKey> list){
        Dictionary<TKey,int> dict= new Dictionary<TKey,int>();
        foreach(var item in list){
            //if element already exists in dict
            if(dict.ContainsKey(item)){
                dict[item]++;
            }
            //if not exist
            else{
                dict[item]=1;
            }
        }
        return dict;
    }
    static void Main(string [] args){
        List<string> list = new List<string>{"apple","banana","apple","orange"};
        Dictionary<string,int> dict=FrequencyCounter(list);
        Console.WriteLine("Frequency of each Element:");
        //Display output
        foreach(var item in dict){
            Console.Write($"{item.Key}: {item.Value}, ");
        }

    }
}