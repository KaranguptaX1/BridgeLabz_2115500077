using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
class FrequencyCounter{
    //return the dict of frequency of each word
    static Dictionary<string,int> CountFrequencies(string content){
        Dictionary<string,int> dict= new Dictionary<string, int>();
        //using regex to replace the . and , from content
        content = Regex.Replace(content.ToLower(), @"[,.]", "");
        foreach(string item in content.Split()){
            if(dict.ContainsKey(item)){
                dict[item]++;
            }
            else{
                dict[item]=1;
            }
        }
        return dict;

    }
    //Main method
    static void Main(string[]args){
        string path="sample.txt";
        string content="";
        //using StreamReader to read the file content
        using(StreamReader sr= new StreamReader(path)){
            content=sr.ReadToEnd();
        }
        //call the method
        Dictionary<string,int> dict= CountFrequencies(content);
        //Display the content
        foreach(var item in dict){
            Console.Write(item.Key+": "+ item.Value+" ,");
        }



        


    }
}