using System;
using System.IO;
class Program{
    //Main Method
    static void Main(string []args){
        string sourcePath="Sample.txt";
        string DestinationPath="Destination.txt";
        try{
            //check if file exist to read
            if(!File.Exists(sourcePath)){
                Console.WriteLine("File does not exists");
                return;
            }
            //use filestream read and write mode
            using(FileStream fsRead= new FileStream(sourcePath,FileMode.Open,FileAccess.Read))
            using(FileStream fsWrite= new FileStream(DestinationPath,FileMode.Create,FileAccess.Write)){
                //Chunk size to read and write the file
                byte[] buffer = new byte[4096];
                int bytesRead;
                while((bytesRead=fsRead.Read(buffer,0,buffer.Length))>0){
                    fsWrite.Write(buffer,0,bytesRead);
                }
            }
            Console.WriteLine("File Copied successfully.");
        }
        //handle IOException
        catch(IOException ex){
            Console.WriteLine(ex.Message);
        }
        //handle other exceptions;
        catch(Exception ex){
            Console.WriteLine(ex.Message);
        }
    }
}