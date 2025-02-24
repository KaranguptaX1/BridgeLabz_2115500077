using System;
class TwoStrings{
    public static string Compare(string word1, string word2){
        //check if both words are same 
        if (word1==word2){
            return "Both words are equal";
        }
        //get the minimum length between words
        int minLength=Math.Min(word1.Length,word2.Length);
        for(int i=0; i<minLength;i++){
            //convert the char to ascii for comparison
            int ch1= (int)word1[i];
            int ch2= (int)word2[i];
            //if ascii of ch1> ch2 it means it has higher order
            if (ch1>ch2){
                return word2+" comes before "+word1;
            }
            else if(ch2>ch1){
                return word1+" comes before "+word2;
            }
        }
        //if both words remain same till the minLength than calculate using Length of words
        if(word1.Length<word2.Length){
            return word2+" comes before "+word1;
        }
        else{
            return word1+" comes before "+word2;
            }
    }
    static void Main(){
        //Input from user
        Console.Write("Enter the Word1: ");
        string word1= Console.ReadLine();
        Console.Write("Enter the Word2: ");
        string word2= Console.ReadLine();
        //call the Compare method 
        string result =Compare(word1,word2);
        //Display the output
        Console.WriteLine(result);

    }
}