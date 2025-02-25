using System;
namespace Obsolete{
    class LegacyAPI{
        //declaring OldFeature as Obsolete,by using true we make it a error instead of warning
        [Obsolete("This is old Feature. Use NewFeature() instead.",true)]
        static void OldFeature(){
            Console.WriteLine("This is Old Feature.");
        }
        //NewFeature function
        static void NewFeature(){
            Console.WriteLine("This is new feature.");
        }
        //Main method
        static void Main(string[] args){
            //call the methods
            NewFeature();
            //It gives the error
            OldFeature();
        }
    }
    
}