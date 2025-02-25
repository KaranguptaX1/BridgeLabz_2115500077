using System;
using System.IO;
class ReadCSV{
    static void Main(string[]args){
        //FilePath
        string path="Students.csv";
        try{
            //using StreamReader
            using (StreamReader sr= new StreamReader(path)){
                string line;
                line=sr.ReadLine();
                //check if file is empty or not
                if(line!=null){
                    Console.WriteLine(line);
                }
                else{
                    Console.WriteLine("Empty File.");
                    return;
                }
                //reading the data in set format
                while((line=sr.ReadLine())!=null){
                    string[] column=line.Split(',');
                    Console.WriteLine($"ID:{column[0]}, Name: {column[1]}, Age: {column[2]}, Marks: {column[3]}");
                }
            }
        }
        //catch exceptions
        catch(Exception ex){
            Console.WriteLine(ex.Message);
        }
    }
}