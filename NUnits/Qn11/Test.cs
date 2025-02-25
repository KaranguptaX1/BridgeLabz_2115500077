using NUnit.Framework;
using Utilities;

namespace UtilitiesTests
{
    [TestFixture]
    public class TemperatureConverterTests
    {
        private TemperatureConverter _converter;

        [SetUp]
        public void Setup()
        {
            _converter = new TemperatureConverter();
        }

        [Test]
        [TestCase(0, ExpectedResult = 32)]         [TestCase(100, ExpectedResult = 212)]        [TestCase(-40, ExpectedResult = -40)]         [TestCase(37, ExpectedResult = 98.6)]
        public double TestCelsiusToFahrenheit(double celsius)
        {
            return _converter.CelsiusToFahrenheit(celsius);
        }

        [Test]
        [TestCase(32, ExpectedResult = 0)]           [TestCase(212, ExpectedResult = 100)]        [TestCase(-40, ExpectedResult = -40)]         [TestCase(98.6, ExpectedResult = 37)]         public double TestFahrenheitToCelsius(double fahrenheit)
        {
            return _converter.FahrenheitToCelsius(fahrenheit);
        }
    }
}