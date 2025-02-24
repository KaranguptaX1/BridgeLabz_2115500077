using System;
using System.IO;
class Program{
    //Main Method
    static void Main(string[]args){
        //Path file
        string path= "info.txt";
        //try catch block
        try{
            using(StreamReader sr= new StreamReader(path)){
                //read the first line
                Console.WriteLine(sr.ReadLine());
            }
        }
        //catch IoException
        catch(IOException){
            Console.WriteLine("Error Reading File");
        }
        //Catch other Exception
        catch(Exception ex){
            Console.WriteLine(ex.Message);
        }
    }
}