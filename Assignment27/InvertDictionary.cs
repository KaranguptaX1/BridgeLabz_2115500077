using System;
using System.Collections.Generic;
class InvertDictionary{
    //Method to invert the dictionary mapping
    static Dictionary<TValue,List<TKey>> InvertDict<TKey,TValue>(Dictionary<TKey,TValue> dict){
        Dictionary<TValue,List<TKey>> invertDict= new Dictionary<TValue, List<TKey>>();
        foreach(var item in dict){
            if(invertDict.ContainsKey(item.Value)){
                invertDict[item.Value].Add(item.Key);
            }
            else{
                invertDict[item.Value]=new List<TKey>{item.Key};
            }
        }
        return invertDict;

    }
    //Main Method
    static void Main(string []args){
        Dictionary<string,int> dict= new Dictionary<string, int>();
        dict.Add("A",1);
        dict.Add("B",2);
        dict.Add("C",1);
        dict.Add("D",4);
        Dictionary<int,List<string>> result= InvertDict(dict);
        foreach(var item in result){
            Console.Write(item.Key+": ["+ string.Join(", ",item.Value)+"] ,");
        }

    }
}