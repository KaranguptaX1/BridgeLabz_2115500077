using System;
using System.Text;
using System.IO;
class Write{
    static void WriteFile(string path){
        try{
            //Write the data in file
            Console.WriteLine("Enter the data(Type exit to exit.)");
            using(StreamWriter sw= new StreamWriter(path,false,Encoding.UTF8)){
                while(true){
                    string input= Console.ReadLine();
                    if(input.ToLower()=="exit"){
                        break;
                    }
                    input+=" ";
                    sw.Write(input);
                }
            }
            //Show the data of file
            using(StreamReader sr= new StreamReader(path)){
                string content= sr.ReadToEnd();
                Console.WriteLine(content);
            }
            }
        catch(IOException e){
            Console.WriteLine(e.Message);
        }
    }
    //Main method
    static void Main(){
        string path="Sample2.txt";
        WriteFile(path);
    }

}