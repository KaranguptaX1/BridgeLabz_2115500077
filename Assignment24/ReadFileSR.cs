using System;
using System.IO;
class Reader{
    //Method to read and show file contents using StreamReader
    static void ReadAndShowFile(string path){
        try{
            using (StreamReader sr= new StreamReader(path)){
                string line;
                while((line=sr.ReadLine())!=null){
                    Console.WriteLine(line);
                }
            }
        }
        catch(IOException e){
            Console.WriteLine(e.Message);
        }
    }
    //Main  method
    static void Main(){
        string filePath="sample.txt";
        ReadAndShowFile(filePath);
        
    }
}