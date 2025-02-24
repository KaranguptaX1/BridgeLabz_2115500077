using System;
class Patient{
    //Initialize variables
    private static string hospitalName="Jai GuruDev Hospital";
    private static int totalPatients=0;
    private string Name,Ailment;
    private int Age;
    private readonly int PatientID;
    //Method to get total Patients
    public static void GetTotalPatients(){
        Console.WriteLine($"The total number of Patients: {totalPatients}");
    }
    //Constructor
    public Patient(int PatientID,string Name,int Age,string Ailment){
        this.PatientID=PatientID;
        this.Name=Name;
        this.Age=Age;
        this.Ailment=Ailment;
        totalPatients++;
    }
    //Display method
    public void DisplayPatientDetails(){
        Console.WriteLine("------------------------------------");
        Console.WriteLine(hospitalName);
        Console.WriteLine($"The Patient Id is : {PatientID}");
        Console.WriteLine($"The Patient Name is : {Name} ");
        Console.WriteLine($"The age is: {Age}");
        Console.WriteLine($"The Ailment is : {Ailment}");
        Console.WriteLine("------------------------------------");
    }
}
class Program{
    static void Main(string[] args){
        //make the instance
        Patient patient1= new Patient(123,"Rahul",22,"Fever");
        Patient patient2= new Patient(112,"Aman",40,"Dry Throat");
        if (patient1 is Patient){
            patient1.DisplayPatientDetails();
        }
        if (patient2 is Patient){
            patient2.DisplayPatientDetails();
        }
        //Display total students
        Patient.GetTotalPatients();
    }
}