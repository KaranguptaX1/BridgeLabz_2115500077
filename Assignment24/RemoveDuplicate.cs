using System;
using System.Text;
class Remove{
    //Method to remove Duplicates
    static string RemoveDuplicates(string str){
        string output="";
        //check if string contains the char or not
        foreach(char ch in str){
            //if not present in output then add char
            if(!output.Contains(ch)){
                output+=ch;
            }
        }
        return output;
    }
    //Main method
    static void Main(string[] args){
        Console.WriteLine("Enter the text: ");
        StringBuilder sb= new StringBuilder(Console.ReadLine());
        sb= new StringBuilder(RemoveDuplicates(sb.ToString().ToLower()));
        Console.WriteLine(sb);
    }
}