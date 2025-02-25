using System;
using System.Data.SqlClient;
using System.IO;
class Program{
    static void Main(string[] args){
        string connectionString = "Server=your_server_name;Database=your_database_name;User Id=your_username;Password=your_password;";
        string csvFilePath = "employees_report.csv";
        string query = "SELECT EmployeeID, Name, Department, Salary FROM Employees";
        using (SqlConnection connection = new SqlConnection(connectionString)){
            connection.Open();
            using (SqlCommand command = new SqlCommand(query, connection)){
                using (SqlDataReader reader = command.ExecuteReader()){
                    WriteToCsv(reader, csvFilePath);
                }
            }
        }
        Console.WriteLine("CSV report has been generated at: " + csvFilePath);
    }
    static void WriteToCsv(SqlDataReader reader, string filePath){
        using (StreamWriter writer = new StreamWriter(filePath)){
            writer.WriteLine("Employee ID,Name,Department,Salary");
            while (reader.Read()){
                string employeeId = reader["EmployeeID"].ToString();
                string name = reader["Name"].ToString();
                string department = reader["Department"].ToString();
                string salary = reader["Salary"].ToString();
                writer.WriteLine($"{employeeId},{name},{department},{salary}");
            }
        }
    }
}