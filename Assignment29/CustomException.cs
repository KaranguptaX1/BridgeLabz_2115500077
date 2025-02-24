using System;
using System.IO;
//InvalidAgeException class
class InvalidAgeException:Exception{
    public InvalidAgeException(string message):base(message){}
}
class Age{
    //Validate Age method
    static void ValidateAge(int age){
            if(age<18){
                //throw custom Exception
                throw new InvalidAgeException("Age must be greater than 18.");
            }
            Console.WriteLine("Access Granted");
        }
    //Main method
    static void Main(){
        try{
            Console.Write("Enter the Age: ");
            int age= int.Parse(Console.ReadLine());
            ValidateAge(age);
        }
        //catch Format exception
        catch(FormatException){
            Console.WriteLine("Format of input is not correct");
        }
        //Invalid Age Exception
        catch(InvalidAgeException ex){
            Console.WriteLine(ex.Message);
        }
        //Other Exceptions
        catch(Exception ex){
            Console.WriteLine(ex.Message);
        }
    }
}