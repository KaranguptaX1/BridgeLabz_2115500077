using System;
using System.IO;
using CsvHelper;
using System.Globalization;
using System.Collections.Generic;
class WriteData{
    //Employee class
    class Employee{
        //Properties
        public int ID{get;}
        public string Name{get;set;}
        public string Department{get;set;}
        public double Salary{get;set;}
        //Constructor
        public Employee(int id,string name,string department,double salary){
            ID=id;
            Name=name;
            Salary=salary;
            Department=department;
        }
    }
    static void Main(string[] args){
        //Path for file
        string path="Employees.csv";
        try{
            //using streamwriter and CsvWriter
            using(StreamWriter sr= new StreamWriter(path))
            using(var csv= new CsvWriter(sr,CultureInfo.InvariantCulture)){
                var records= new List<Employee>();
                //Enter the number of employees
                Console.Write("Enter the number of Records:");
                int size=int.Parse(Console.ReadLine());
                Console.WriteLine("Enter the Employee Details:\n");
                for(int i=0;i<size;i++){
                    Console.Write("Enter the ID: ");
                    int id=int.Parse(Console.ReadLine());
                    Console.Write("Enter the Name: ");
                    string name=Console.ReadLine();
                    Console.Write("Enter the Department: ");
                    string department=Console.ReadLine();
                    Console.Write("Enter the Salary: ");
                    double salary=double.Parse(Console.ReadLine());
                    Console.WriteLine();
                    records.Add(new Employee(id,name,department,salary));   
                }
            //Write the records successfully
            csv.WriteRecords(records);
        }
        Console.WriteLine("Records written successfully.");
    }
    //catch exceptions
    catch(Exception ex){
        Console.WriteLine(ex.Message);
    }}
}