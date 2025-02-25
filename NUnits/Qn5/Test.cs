using NUnit.Framework;
using DatabaseModule;
using System;
namespace DatabaseTests
{
    [TestFixture]
    public class DatabaseConnectionTests
    {
        private DatabaseConnection _dbConnection;

        [SetUp]
        public void Setup()
        {
            _dbConnection = new DatabaseConnection();
            _dbConnection.Connect();
        }
        [TearDown]
        public void Cleanup()
        {
            _dbConnection.Disconnect();
        }
        [Test]
        public void TestConnection_IsConnected()
        {
            Assert.That(_dbConnection.IsConnected, Is.True);
        }
        [Test]
        public void TestDisconnect_IsDisconnected()
        {
            _dbConnection.Disconnect();
            Assert.That(_dbConnection.IsConnected, Is.False);
        }
        [Test]
        public void TestConnect_AlreadyConnected_ThrowsException()
        {
            Assert.Throws<InvalidOperationException>(() => _dbConnection.Connect());
        }
        [Test]
        public void TestDisconnect_AlreadyDisconnected_ThrowsException()
        {
            _dbConnection.Disconnect();
            Assert.Throws<InvalidOperationException>(() => _dbConnection.Disconnect());
        }
    }
}