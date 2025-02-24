using System;
using System.IO;
class WriteFromUser{
    //Main Method
    static void Main(string [] args){
        //File Path
        string destinationPath="UserInput.txt";
        try{
        //using StreamReader to read the user input
        using (StreamReader sr= new StreamReader(Console.OpenStandardInput()))
        //Using StreamWriter to write the file
        using(StreamWriter sw= new StreamWriter(destinationPath)){
            //Take input from user and write in file
            Console.Write("Enter the Name :");
            sw.WriteLine("\nName: "+sr.ReadLine());
            int age;
            while(true){
                Console.Write("Enter the Age :");
                string ageInput= sr.ReadLine();
                if(int.TryParse(ageInput,out age )){
                    if(age>-1){
                        sw.WriteLine("Age: "+age);
                        break;}
                    else{
                        Console.WriteLine("Age is Negative.");
                    }
                }
                else{
                    Console.WriteLine("Enter Age in Correct Format.");
                }
            } 
            Console.Write("Enter the Favourite Programming language :");
            sw.WriteLine("Language: "+sr.ReadLine());
            }}
        //handle IO Exceptions
        catch(IOException ex){
            Console.WriteLine("Error with File "+ ex.Message);
        }
        //Handle Other Exceptions
        catch(Exception ex){
            Console.WriteLine(ex.Message);
        }

    }
}
