using NUnit.Framework;
using UserManagement;
using System;

namespace UserManagementTests
{
    [TestFixture]
    public class UserRegistrationTests
    {
        private UserRegistration _registration;

        [SetUp]
        public void Setup()
        {
            _registration = new UserRegistration();
        }

        [Test]
        [TestCase("JohnDoe", "john@example.com", "Password1", ExpectedResult = true)]
        [TestCase("Alice", "alice@example.com", "Secure123", ExpectedResult = true)]  
        public bool TestValidUserRegistration(string username, string email, string password)
        {
            return _registration.RegisterUser(username, email, password);
        }

        [Test]
        public void TestEmptyUsername_ShouldThrowArgumentException()
        {
            Assert.Throws<ArgumentException>(() => _registration.RegisterUser("", "test@example.com", "Password1"));
        }

        [Test]
        public void TestInvalidEmail_ShouldThrowArgumentException()
        {
            Assert.Throws<ArgumentException>(() => _registration.RegisterUser("JohnDoe", "invalid-email", "Password1"));
        }

        [Test]
        public void TestWeakPassword_ShouldThrowArgumentException()
        {
            Assert.Throws<ArgumentException>(() => _registration.RegisterUser("JohnDoe", "john@example.com", "weak"));
        }

        [Test]
        public void TestPasswordWithoutUppercase_ShouldThrowArgumentException()
        {
            Assert.Throws<ArgumentException>(() => _registration.RegisterUser("JohnDoe", "john@example.com", "password1"));
        }

        [Test]
        public void TestPasswordWithoutDigit_ShouldThrowArgumentException()
        {
            Assert.Throws<ArgumentException>(() => _registration.RegisterUser("JohnDoe", "john@example.com", "Password"));
        }
    }
}
