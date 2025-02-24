using System;
class Palindrome{
    public static bool IsPalindrome(string word){
       string reverseWord="";
       for(int i=word.Length-1;i>=0;i--){
        reverseWord+=word[i];
       }
       if (reverseWord==word){
        return true;
       }
       return false;
    }
    static void Main(string[] args){
        Console.Write("Enter the String: ");
        string word = Console.ReadLine();
        bool result= IsPalindrome(word);
        Console.WriteLine($"IsPalindrome?{result} " );


    }
}
