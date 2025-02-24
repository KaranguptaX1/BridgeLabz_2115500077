using System;
using System.IO;
using System.IO.Pipes;
using System.Text;
using System.Threading;
class Program{
    // Write to the pipe
    static void WriteToPipe(PipeStream pipeServer){
        try{
            using (StreamWriter writer = new StreamWriter(pipeServer)){
                writer.AutoFlush = true;
                string message = "Hello from the writer thread!";
                writer.WriteLine(message);
                Console.WriteLine($"Writer thread sent: {message}");
                Thread.Sleep(1000);
                writer.WriteLine("This is the second message.");
                Console.WriteLine("Writer thread sent another message.");
            }
        }
        catch (IOException ex){
            Console.WriteLine($"Writer thread error: {ex.Message}");
        }
    }
    // Read from the pipe
    static void ReadFromPipe(PipeStream pipeClient){
        try{
            using (StreamReader reader = new StreamReader(pipeClient)){
                string message;
                while ((message = reader.ReadLine()) != null){
                    Console.WriteLine($"Reader thread received: {message}");
                }
            }
        }
        catch (IOException ex){
            Console.WriteLine($"Reader thread error: {ex.Message}");
        }
    }
    public static void Main(string[] args){
        using (AnonymousPipeServerStream pipeServer = new AnonymousPipeServerStream(PipeDirection.Out))
        using (AnonymousPipeClientStream pipeClient = new AnonymousPipeClientStream(PipeDirection.In, pipeServer.ClientSafePipeHandle)){
            Thread writerThread = new Thread(() => WriteToPipe(pipeServer));
            writerThread.Start();
            Thread readerThread = new Thread(() => ReadFromPipe(pipeClient));
            readerThread.Start();
            writerThread.Join();
            readerThread.Join();
        }
        Console.WriteLine("Pipe communication completed.");
    }
}
