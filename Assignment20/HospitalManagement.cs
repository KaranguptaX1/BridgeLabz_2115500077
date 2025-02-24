using System;
using System.Collections.Generic;
// Abstract parent class
abstract class Patient{
    //Protected variables
    protected int patientId;
    protected string name;
    protected int age;
    protected string diagnosis;
    // Constructor 
    public Patient(int patientId, string name, int age, string diagnosis){
        this.patientId = patientId;
        this.name = name;
        this.age = age;
        this.diagnosis = diagnosis;
    }
    // Method to display patient details
    public void GetPatientDetails(){
        Console.WriteLine($"Patients Details \nID: {patientId}\nName: {name}\nAge: {age}\nDiagnosis: {diagnosis}");
    }
    // Abstract method to calculate bill
    public abstract double CalculateBill();
}
// Interface 
interface IMedicalRecord{
    void AddRecord(string record);
    void ViewRecords();
}

// InPatient subclass
class InPatient : Patient, IMedicalRecord{
    private double roomChargePerDay;
    private int days;
    private List<string> medicalRecords = new List<string>();
    //constructor
    public InPatient(int patientId, string name, int age, string diagnosis, double roomChargePerDay, int days): base(patientId, name, age, diagnosis){
        this.roomChargePerDay = roomChargePerDay;
        this.days = days;
    }
    // CalculatesBill method
    public override double CalculateBill(){
        return roomChargePerDay * days;
    }
    //Add record method
    public void AddRecord(string record){
        medicalRecords.Add(record);
    }
    //viewRecords method
    public void ViewRecords(){
        Console.WriteLine($"Medical Records for {name}:");
        foreach (var record in medicalRecords){
            Console.WriteLine($"{record}");
        }
    }
}
// OutPatient subclass
class OutPatient : Patient, IMedicalRecord{
    //Private variables
    private double consultationFee;
    private List<string> medicalRecords = new List<string>();
    //Constructor
    public OutPatient(int patientId, string name, int age, string diagnosis, double consultationFee): base(patientId, name, age, diagnosis){
        this.consultationFee = consultationFee;
    }
    public override double CalculateBill(){
        return consultationFee;
    }
    public void AddRecord(string record){
        medicalRecords.Add(record);
    }

    public void ViewRecords(){
        Console.WriteLine($"Medical Records for {name}:");
        foreach (var record in medicalRecords){
            Console.WriteLine($"{record}");
        }
    }
}
class HospitalManagement{
    static void Main(string[] args){
        //patients list
        List<Patient> patients = new List<Patient>();
        InPatient patient1 = new InPatient(101, "Rahul Kumar", 25, "Fever", 1500, 3);
        OutPatient patient2 = new OutPatient(102, "Karan", 30, "Cough", 500);
        patients.Add(patient1);
        patients.Add(patient2);
        patient1.AddRecord("Blood Test - Normal");
        patient1.AddRecord("Prescribed Paracetamol");
        patient2.AddRecord("Cough Syrup prescribed");
        //Display Output
        foreach (var patient in patients){
            patient.GetPatientDetails();
            Console.WriteLine($"Total Bill: {patient.CalculateBill()}");
            if (patient is IMedicalRecord medicalRecord){
                medicalRecord.ViewRecords();
            }
            Console.WriteLine("------------------------");
        }
    }
}
