using System;
class Palindrome{
    //method to take input
    static string GetInput(string message){
        Console.Write(message);
        string sentence= Console.ReadLine();
        return sentence;
    }
    //method to check for palindrome
    public static bool CheckPalindrome(string message){
        message=message.ToLower();
        bool isPalindrome=true;
        int i=0;
        int j=message.Length-1;
        //loop to check the false condition
        while(i<=j){
            if(message[i]!=message[j]){
                isPalindrome=false;
            }
            i++;
            j--;
        }
        return isPalindrome;
        
    }
    //method to display the result in string
        public static void DisplayResult(bool result){
        if(result){
            Console.WriteLine("This is palindrome.");
        }
        else{
        Console.WriteLine("This is not  palindrome.");}
    }
    static void Main(string[] args){
        //call the methods
        string input= GetInput("Enter :");
        bool result= CheckPalindrome(input);
        DisplayResult(result);

        
    }
}