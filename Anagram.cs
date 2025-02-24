using System;
class Anagram{
    //method to check the anagram
    public static bool CheckAnagrams(string word1,string word2){
        //if length of words are not equal then it is not anagram
        if (word1.Length!=word2.Length){
            return false;
        }
        //array to store the frequency of characters
        int[] Count1= new int[26];
        int[] Count2= new int[26];
        for(int i=0;i<word1.Length;i++){
            //get the ascii value
            int ascii1 = (int)word1[i];
            int ascii2 = (int)word2[i];
            
            //check if ascii value for (A-Z) and convert it to (a-z)
            if(ascii1>=65 && ascii1<=92){
                ascii1+=32;     
            }
            if(ascii2>=65 && ascii2<=92){
                ascii2+=32;     
            }
            //store the count in array
            Count1[ascii1-97]++;
            Count2[ascii2-97]++;

        }
               //loop to check if they are not same (not anagram)
        for(int i=0;i<26;i++){
            if (Count1[i]!=Count2[i]){
                return false;
            }
        }
        return true;

}
    static void Main(string[] args){
        //Input from user
        Console.Write("Enter the word1: ");
        string word1 = Console.ReadLine();
        Console.Write("Enter the word2: ");
        string word2 = Console.ReadLine();
        //Display output
        Console.WriteLine($"Is Anagram? {CheckAnagrams(word1,word2)}");
    }
}
