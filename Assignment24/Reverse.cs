using System;
using System.Text;
class Reverse{
    //Method to reverse string 
    static string ReverseString(string str){
        char[] charArray= str.ToCharArray();
        Array.Reverse(charArray);
        return new string(charArray);
    }
    
    static void Main(){
        //Main method
        Console.WriteLine("Enter the text");
        string input= Console.ReadLine();
        //String Builder
        StringBuilder sb= new StringBuilder(input);
        sb=new StringBuilder(ReverseString(sb.ToString()));
        Console.WriteLine(sb);

    }
}