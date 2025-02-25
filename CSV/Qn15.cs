using System;
using System.IO;
using System.Globalization;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;
using CsvHelper;
//Employee class
class Employee{
    public int ID { get; set; }
    public string Name { get; set; } = "";  
    public string Email { get; set; } = ""; 
    public string EncryptedSalary { get; set; } = ""; 
}
class EncryptDecryptCSV{
    private static readonly string EncryptionKey = "MySecretKey12345";
    // AES Encryption
    static string Encrypt(string text){
        using (Aes aes = Aes.Create()){
            aes.Key = Encoding.UTF8.GetBytes(EncryptionKey);
            aes.IV = new byte[16]; 
            using (var encryptor = aes.CreateEncryptor(aes.Key, aes.IV)){
                byte[] inputBytes = Encoding.UTF8.GetBytes(text);
                byte[] encryptedBytes = encryptor.TransformFinalBlock(inputBytes, 0, inputBytes.Length);
                return Convert.ToBase64String(encryptedBytes);
            }
        }
    }
    // AES Decryption
    static string Decrypt(string encryptedText){
        using (Aes aes = Aes.Create()){
            aes.Key = Encoding.UTF8.GetBytes(EncryptionKey);
            aes.IV = new byte[16];
            using (var decryptor = aes.CreateDecryptor(aes.Key, aes.IV)){
                byte[] encryptedBytes = Convert.FromBase64String(encryptedText);
                byte[] decryptedBytes = decryptor.TransformFinalBlock(encryptedBytes, 0, encryptedBytes.Length);
                return Encoding.UTF8.GetString(decryptedBytes);
            }
        }
    }
    // Write Encrypted CSV
    static void WriteEncryptedCSV(string path){
        var employees = new List<Employee>{
            new Employee { ID = 1, Name = "Rahul", Email = Encrypt("rahul@gmail.com"), EncryptedSalary = Encrypt("50000") },
            new Employee { ID = 2, Name = "Karan", Email = Encrypt("karan@gmail.com"), EncryptedSalary = Encrypt("60000") }
        };
        using (var writer = new StreamWriter(path))
        using (var csv = new CsvHelper.CsvWriter(writer, CultureInfo.InvariantCulture)){
            csv.WriteRecords(employees);
        }
        Console.WriteLine("Encrypted CSV file written successfully.");
    }
    // Read & Decrypt CSV
    static void ReadDecryptedCSV(string path){
        using (var reader = new StreamReader(path))
        using (var csv = new CsvHelper.CsvReader(reader, CultureInfo.InvariantCulture)){
            var employees = csv.GetRecords<Employee>();
            foreach (var emp in employees){
                Console.WriteLine($"ID: {emp.ID}, Name: {emp.Name}, Email: {Decrypt(emp.Email)}, Salary: {Decrypt(emp.EncryptedSalary)}");
            }
        }
    }
    // Main method
    static void Main(){
        string path = "Employees.csv";
        WriteEncryptedCSV(path);
        Console.WriteLine("\nReading Decrypted Data:");
        ReadDecryptedCSV(path);
    }
}