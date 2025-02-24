using System;
using System.IO;
//ImageConvert class
class ImageConverter{
    //Image to byte method
    public static byte[] ImageToByteArray(string imagePath){
        //try block
        try{
            using (FileStream fs = new FileStream(imagePath, FileMode.Open, FileAccess.Read))
            using (MemoryStream ms = new MemoryStream()){
                fs.CopyTo(ms);
                return ms.ToArray();
            }
        }
        //catch block
        catch (IOException ex){
            Console.WriteLine($"Error: {ex.Message}");
            return null;
        }
    }
    //Byte to image method
    public static void ByteArrayToImage(byte[] imageData, string outputPath){
        //try block
        try{
            if (imageData == null){
                Console.WriteLine("No image data to write.");
                return;
            }
            using (MemoryStream ms = new MemoryStream(imageData))
            using (FileStream fs = new FileStream(outputPath, FileMode.Create, FileAccess.Write)){
                ms.CopyTo(fs);
            }
            Console.WriteLine("Image written successfully.");
        }
        //catch block
        catch (IOException ex){
            Console.WriteLine($"Error: {ex.Message}");
        }
    }
    //Main Method
    public static void Main(string[] args){
        string img = "Assignment28/project/source.jpg";
        string copy = "copy.jpg";
        byte[] imgByte = ImageToByteArray(img);
        ByteArrayToImage(imgByte, copy);
    }
}
