using System;
using System.IO;
class Reader{
    //Method to read and count the word in file
    static int ReadAndCountWord(string path,string word){
        try{
            using (StreamReader sr= new StreamReader(path)){
                string line;
                int count=0;
                while((line=sr.ReadLine())!=null){
                    foreach(string words in line.Split()){
                        if (words==word){
                            count++;
                        }
                    }
                }
            return count;
            }
        }
        catch(IOException e){
            Console.WriteLine(e.Message);
            return 0;
        }
    }
    //Main  method
    static void Main(){
        string filePath="sample.txt";
        //take input from user
        Console.WriteLine("Enter the word to search: ");
        string word=Console.ReadLine();
        //call the method
        int count=ReadAndCountWord(filePath,word);
        //Display output
        Console.WriteLine($"The word {word} count is : {count}");
        
    }
}