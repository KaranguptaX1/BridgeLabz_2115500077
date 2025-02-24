using System;
using System.Diagnostics;
using System.IO;
class FileReading{
    //Method to read using FileStream
    static void ReadAndWriteWithFileStream(string filePath,string destinationPath){
        Stopwatch sw = Stopwatch.StartNew();
        using (FileStream fs = new FileStream(filePath, FileMode.Open, FileAccess.Read))
        using (FileStream fw = new FileStream(destinationPath, FileMode.Create, FileAccess.Write)){
            byte[] buffer = new byte[4096];
            int bytesRead;
            while((bytesRead=fs.Read(buffer,0,buffer.Length))>0){
                    fw.Write(buffer,0,bytesRead);
                }
        }
        sw.Stop();
        //Display the fileStream time
        Console.WriteLine($"FileStream Time: {sw.ElapsedMilliseconds} ms");
    }
    static void ReadAndWriteWithBufferedStream(string filePath,string destinationPath){
        Stopwatch sw = Stopwatch.StartNew();
        using (FileStream fs = new FileStream(filePath, FileMode.Open, FileAccess.Read))
        using(BufferedStream bs = new BufferedStream(fs))
        using (FileStream fw = new FileStream(destinationPath, FileMode.Create, FileAccess.Write))
        using(BufferedStream bw = new BufferedStream(fw)){
            byte[] buffer = new byte[4096];
            int bytesRead;
            while((bytesRead=bs.Read(buffer,0,buffer.Length))>0){
                    bw.Write(buffer,0,bytesRead);
                }
        }
        sw.Stop();
        //Display the fileStream time
        Console.WriteLine($"BufferedStream Time: {sw.ElapsedMilliseconds} ms");
    }
    //Main method
    static void Main(){   
        string filePath = "1.txt";
        //Try catch block
        try{
        Console.WriteLine("Reading file using FileStream...");
        ReadAndWriteWithFileStream(filePath,"3.txt");
        Console.WriteLine("Reading file using BufferedStream...");
        ReadAndWriteWithFileStream(filePath,"4.txt");
        }
        catch(IOException ex){
            Console.WriteLine(ex.Message);
        }
        catch(Exception ex){
            Console.WriteLine(ex.Message);
        }
        
    }
}
