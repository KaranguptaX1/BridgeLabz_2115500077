using System;
using System.Text.RegularExpressions;

namespace Security
{
    public class PasswordValidator
    {
        public bool IsValid(string password)
        {
            if (string.IsNullOrEmpty(password)) return false;
            if (password.Length < 8) return false;
            if (!Regex.IsMatch(password, @"[A-Z]")) return false;
            if (!Regex.IsMatch(password, @"\d")) return false;

            return true;
        }
    }
}