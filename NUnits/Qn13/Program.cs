using System;
using System.Text.RegularExpressions;

namespace UserManagement
{
    public class UserRegistration
    {
        public bool RegisterUser(string username, string email, string password)
        {
            if (string.IsNullOrWhiteSpace(username))
                throw new ArgumentException("Username cannot be empty");

            if (!Regex.IsMatch(email, @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
                throw new ArgumentException("Invalid email format");

            if (password.Length < 8 || !Regex.IsMatch(password, @"[A-Z]") || !Regex.IsMatch(password, @"\d"))
                throw new ArgumentException("Password must be at least 8 characters long, contain one uppercase letter, and one digit");

            return true;
        }
    }
}