using System;
class Substring{
    //method to count the number of substring in word
    public static int CountSubstring(string word,string substring){
        int length= substring.Length;
        int count=0;
        //loop to iterative over word
        for(int i=0;i<=word.Length-length;i++){
            bool match=true;
            //loop to iterate over substring
            for (int j=0;j<length;j++){
                //check for pattern
                if (word[j+i]!=substring[j]){
                    match=false;
                    break;
                }
            }
            //if pattern found increase count
            if(match){
                count++;
            }
        }
        return count;
    }
    static void Main(string[] args){
        //Input from user
        Console.Write("Enter the String: ");
        string word= Console.ReadLine();
        Console.Write("Enter the substring: ");
        string substring=Console.ReadLine();
        //call the count substring method
        int count = CountSubstring(word,substring);
        //display output
        Console.Write(count);
    }
}