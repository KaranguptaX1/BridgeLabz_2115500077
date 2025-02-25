using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Qn2
{
    public class StringMethods
    {
        public string Reverse(string str)
        {
            char[] charArray = str.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }

        public bool IsPalindrome(string str)
        {
            string reversed = Reverse(str);
            return string.Equals(str, reversed, StringComparison.OrdinalIgnoreCase);
        }

        public string ToUpperCase(string str)
        {
            return str.ToUpper();
        }
    }
}