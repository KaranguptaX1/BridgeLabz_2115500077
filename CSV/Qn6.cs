using System;
using System.IO;
using CsvHelper;
using System.Globalization;
using System.Collections.Generic;
class Employee{
    public int ID{get;set;}
    public string Name{get; set;}
    public string Department{get;set;}
    public double Salary{get;set;}
    }
class Modify{
    static void IncreaseSalary(string path,double percentbonus,string department){
        try{
            //read the records
            using(StreamReader sr= new StreamReader(path))
            using (CsvReader csv= new CsvReader(sr,CultureInfo.InvariantCulture)){
                var employees= csv.GetRecords<Employee>();
                List<Employee> newList= new List<Employee>();
                //update the records
                foreach(var employee in employees){
                    if(employee.Department==department){
                        //Increase the salary
                        employee.Salary+=employee.Salary*(percentbonus/100);
                        newList.Add(employee);
                }
            }
            //write the records
            using (StreamWriter sw = new StreamWriter("new"+path))
            using (CsvWriter writer = new CsvWriter(sw,CultureInfo.InvariantCulture)){
                writer.WriteRecords(newList);
            }
            Console.WriteLine("Records Written Successfully.");
        }
    }
    //handle exceptions
    catch(Exception ex){
        Console.WriteLine(ex.Message);
    }
    }
    //Main Method
    static void Main(string [] args){
        string Path = "Employees.csv"; 
        IncreaseSalary(Path,10,"it");
    }   
}