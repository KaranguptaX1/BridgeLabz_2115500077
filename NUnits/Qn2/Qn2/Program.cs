using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Qn2
{
    public class Program
    {
        static void Main(string[] args)
        {
            StringMethods stringMethods = new StringMethods();
            Console.WriteLine(stringMethods.Reverse("TestCase"));
            Console.WriteLine(stringMethods.IsPalindrome("TestCase"));
            Console.WriteLine(stringMethods.ToUpperCase("TestCase"));
        }
    }
}