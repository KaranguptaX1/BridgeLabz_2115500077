using NUnit.Framework;
using MathOperations;
using System;
namespace CalculatorTests
{
    [TestFixture]
    public class CalculatorTests
    {
        private Calculator _calculator;

        [SetUp]
        public void Setup()
        {
            _calculator = new Calculator();
        }

        [Test]
        public void TestDivide_ValidDivision()
        {
            int result = _calculator.Divide(10, 2);
            Assert.That(result, Is.EqualTo(5));
        }

        [Test]
        public void TestDivide_ByZero_ThrowsArithmeticException()
        {
            Assert.Throws<ArithmeticException>(() => _calculator.Divide(10, 0));
        }
    }
}