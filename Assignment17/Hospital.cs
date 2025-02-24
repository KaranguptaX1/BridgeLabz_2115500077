using System;
using System.Collections.Generic;
class Hospital{
    public string Name { get; set; }
    public List<Doctor> Doctors { get; set; }
    public List<Patient> Patients { get; set; }
    // Constructor
    public Hospital(string name){
        Name = name;
        Doctors = new List<Doctor>();
        Patients = new List<Patient>();
    }
}
class Doctor{
    public string Name { get; set; }
    // Constructor 
    public Doctor(string name){
        Name = name;
    }
    // Method to consult a patient
    public void Consult(Patient patient){
        Console.WriteLine($"{Name} is consulting {patient.Name}.");
    }
}

class Patient{
    public string Name { get; set; }
    // Constructor to initialize patient with a name
    public Patient(string name){
        Name = name;
    }
    // Method for a patient to consult with a doctor
    public void ConsultWithDoctor(Doctor doctor){
        doctor.Consult(this);
    }
}
class Program{
    static void Main(){
        var hospital = new Hospital("City Hospital");
        var doctor1 = new Doctor("Dr. Adams");
        var doctor2 = new Doctor("Dr. Green");
        var patient1 = new Patient("John Doe");
        var patient2 = new Patient("Jane Doe");
        // Adding doctors and patients to the hospital
        hospital.Doctors.Add(doctor1);
        hospital.Patients.Add(patient1);
        // Simulating consultations between doctors and patients
        patient1.ConsultWithDoctor(doctor1);
        patient2.ConsultWithDoctor(doctor2);
    }
}
