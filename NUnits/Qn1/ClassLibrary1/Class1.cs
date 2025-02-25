using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Test1;
namespace ClassLibrary1
{
    [TestFixture]
    public class Class1
    {
        private Calculator calc;

        [SetUp]
        public void Setup()
        {
            calc = new Calculator();
        }
        [Test]
        public void TestDivide()
        {
            try
            { 
                Assert.That(calc.Divide(6, 3), Is.EqualTo(2)); 
            }
            catch (DivideByZeroException)
            {
                Assert.Fail("Divide by zero exception");
            }
        }
    }
}
