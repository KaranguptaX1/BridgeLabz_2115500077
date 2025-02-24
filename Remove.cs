using System;
class Remove{
	//method to remove all same char from word
    public static string RemoveCharacter(string word,char character){
        string newWord="";
        for(int i=0;i<word.Length;i++){
        	//check if this char does not match match with char given 
        	//then add char to new Word
            if(word[i]!=character){
                newWord+=word[i];
            }
        }
        return newWord;

    }
    static void Main(string[] args){
    	//Input from user
        Console.Write("String: ");
        string word = Console.ReadLine();
        Console.Write("Character to Remove: ");
        char ch = Console.ReadKey().KeyChar;
		//call the method 
        string result= RemoveCharacter(word,ch);
        //Display output
        Console.WriteLine();
        Console.WriteLine($"Modified String :{result}");
    }
}