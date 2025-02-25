using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Qn2;
namespace ClassLibrary1
{
    [TestFixture]
    public class StringTests
    {
        private StringMethods str;

        [SetUp]
        public void Setup()
        {
            str = new StringMethods();
        }

        [Test]
        public void TestReverse()
        {
            Assert.That(str.Reverse("hello"), Is.EqualTo("olleh"));
            Assert.That(str.Reverse("abc"), Is.EqualTo("cba"));
            Assert.That(str.Reverse("A"), Is.EqualTo("A"));
        }

        [Test]
        public void TestIsPalindrome()
        {
            Assert.That(str.IsPalindrome("madam"), Is.True);
            Assert.That(str.IsPalindrome("racecar"), Is.True);
            Assert.That(str.IsPalindrome("hello"), Is.False);
        }

        [Test]
        public void TestToUpperCase()
        {
            Assert.That(str.ToUpperCase("hello"), Is.EqualTo("HELLO"));
            Assert.That(str.ToUpperCase("world"), Is.EqualTo("WORLD"));
            Assert.That(str.ToUpperCase("TeSt"), Is.EqualTo("TEST"));
        }
    }
}