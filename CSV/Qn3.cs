using System;
using System.IO;
using CsvHelper;
using System.Globalization;
class Records{
    //method to count the records
    static int CountRecords(string path){
        try{
            int count=0;
            //reading the csv file
            using (StreamReader sr= new StreamReader(path))
            using (CsvReader csv= new CsvReader(sr,CultureInfo.InvariantCulture)){
                //use dynamic to handle different types of csv formats
                var records=csv.GetRecords<dynamic>();
                foreach(var record in records){
                    //Increase the count
                    count++;
                }
            }
            return count;
        }

        catch(Exception){
            throw new Exception("Exception occured.");
        }
    }
    //Main Method
    static void Main(string [] args){
        string path="Students.csv";
        try{
            int count= CountRecords(path);
            Console.WriteLine("No. of Records: "+count);
        }
        catch(Exception ex){
            Console.WriteLine(ex.Message);
        }
    }
}