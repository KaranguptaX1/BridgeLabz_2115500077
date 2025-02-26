using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using Newtonsoft.Json;
public class User{
    public string Name { get; set; }
    public int Age { get; set; }
}
class Program{
    static void Main(string[] args){
        string connectionString = "ThisIsANewConnectionString";
        using var connection = new SqlConnection(connectionString);
        connection.Open();
        var command = new SqlCommand("SELECT * FROM Users", connection);
        var reader = command.ExecuteReader();
        var users = new List<User>();
        while (reader.Read()){
            users.Add(new User{
                Name = reader["Name"].ToString(),
                Age = Convert.ToInt32(reader["Age"])
            });
        }
        string json = JsonConvert.SerializeObject(users, Formatting.Indented);
        Console.WriteLine(json);
    }
}