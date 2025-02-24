using System;
class Duplicate{
	//method to remove duplicate
    public static string RemoveDuplicate(string word){
        string newWord="";
        for(int i=0;i<word.Length;i++){
        	//check if newWord contians the character or not, we add if it does not have that
            bool itContain=false;
            for(int j=0;j<newWord.Length;j++){
                if(newWord[j]==word[i]){
                   itContain=true;
                   break;
               }
           }
           if (!itContain){
               newWord+=word[i];
           }
           
        }
        return newWord;
    }
    static void Main(string[] args){
    	//Input from user
        Console.Write("Enter the String: ");
        string word = Console.ReadLine();
        //call the method
        string result= RemoveDuplicate(word);
        //display output
        Console.WriteLine(result);
    }
}
