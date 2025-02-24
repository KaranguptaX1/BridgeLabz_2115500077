using System;
using System.IO;
using System.Text;
class Program{
    // ReadLargeFile reads a large file line by line and prints lines containing the word "error"
    public static void ReadLargeFile(string path){
        // Try Block
        try{
            using (StreamReader reader = new StreamReader(path, Encoding.UTF8)){
                string line;
                while ((line = reader.ReadLine()) != null){
                    if (line.IndexOf("error", StringComparison.OrdinalIgnoreCase) >= 0){
                        Console.WriteLine(line);
                    }
                }
            }
        }
        //Catch Block
        catch (IOException ex){
            Console.WriteLine($"Error reading file: {ex.Message}");
        }
    }
    public static void Main(string[] args){
        string path = "Assignment28/12.txt";
        ReadLargeFile(path);
    }
}
