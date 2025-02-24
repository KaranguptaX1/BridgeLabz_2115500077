using System;
class Toggle{
    //method to toggle the character from lowercase to uppercase and viveversa
    public static string ToggleSentence(string word){
        string newWord="";
        foreach(char c in word){
            //get the ascii value
            int ascii = (int)c;
            //check if ascii value for (A-Z) and convert it to (a-z)
            if(ascii>=65 && ascii<=92){
                ascii-=65;
                ascii+=97;    
            }
            //check if ascii value for (a-z) and convert it to (A-Z)
            else if(ascii>=97 && ascii<=124){
                ascii-=97;
                ascii+=65;    
            }
            //get the character and add it to newWord
            newWord+=(char)ascii;
        }
        return newWord;
    }
    static void Main(string[] args){
        //Input from user
        Console.Write("Enter the sentence: ");
        string sentence = Console.ReadLine();
        //call the toggleSentence Method
        string result= ToggleSentence(sentence);
        //Display output
        Console.WriteLine(result);

    }
}