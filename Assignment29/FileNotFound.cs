using System;
using System.IO;
class Program{
    static void Main(string[]args){
        //Path file
        string path= "Assignment29/Sample.txt";
        //try catch block
        try{
            using(StreamReader sr= new StreamReader(path)){
                string content;
                //read and put the readline in content and break if null
                while((content=sr.ReadLine())!=null){
                    Console.WriteLine(content);
                }

            }
        }
        //catch IoException
        catch(IOException){
            Console.WriteLine("File Not Found");
        }
        //Catch other Exception
        catch(Exception ex){
            Console.WriteLine(ex.Message);
        }
    }
}