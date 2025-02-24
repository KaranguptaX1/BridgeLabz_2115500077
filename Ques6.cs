using System;
using System.IO;
using System.Text;
//Class to convert text to lowercase
class TextConverter{
    //Method to convert text to lowercase
    public static void ConvertToLowercase(string path, string path2){
        //Try block to handle exceptions
        try{
            using (FileStream fs = new FileStream(path, FileMode.Open, FileAccess.Read))
            using (BufferedStream bs = new BufferedStream(fs))
            using (StreamReader reader = new StreamReader(bs, Encoding.UTF8))
            using (FileStream fs2 = new FileStream(path2, FileMode.Create, FileAccess.Write))
            using (BufferedStream bs2 = new BufferedStream(fs2))
            using (StreamWriter writer = new StreamWriter(bs2, Encoding.UTF8)){
                string line;
                while ((line = reader.ReadLine()) != null){
                    writer.WriteLine(line.ToLower());
                }
            }
            Console.WriteLine("File converted successfully.");
        }
        //Catch block
        catch (IOException ex){
            Console.WriteLine($"Error: {ex.Message}");
        }
    }
    static void Main(string[] args){
        string path = "Assignment28/Sample.txt";
        string path2 = "test2.txt";
        ConvertToLowercase(path, path2);
    }
}
