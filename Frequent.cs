using System;
class Frequent{
    public static char CalculateMostFrequent(string word){
        int[] charCount= new int[26];
        foreach(char ch in word){
            int ascii = (int)ch;
            //To convert chararcter to lowercase
            if(ascii>=65 && ascii<=90){
                ascii+=32;  
            }
            //store count of char in array
            charCount[ascii-97]++;
        }
        //find the maximum count in array and return the maxindex+97
        int maxIndex=0;
        int maxCount=0;
        for(int i=0;i<26;i++){
            if(charCount[i]>maxCount){
                maxIndex=i;
                maxCount=charCount[i];
            }
        }
        //return char 
        return (char)(maxIndex+97);

    }
    static void Main(string[] args){
        //Input from user
        Console.Write("Enter the String: ");
        string word= Console.ReadLine();
        //call the method
        char result= CalculateMostFrequent(word);
        //display output
        Console.WriteLine(result);

    }
}