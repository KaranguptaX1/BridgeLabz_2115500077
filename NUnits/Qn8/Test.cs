using NUnit.Framework;
using FileHandling;
using System;
using System.IO;
namespace FileHandlingTests
{
    [TestFixture]
    public class FileProcessorTests
    {
        private FileProcessor _fileProcessor;
        private string _testFile;

        [SetUp]
        public void Setup()
        {
            _fileProcessor = new FileProcessor();
            _testFile = "testfile.txt";
        }

        [TearDown]
        public void Cleanup()
        {
            if (File.Exists(_testFile))
                File.Delete(_testFile);
        }

        [Test]
        public void TestWriteToFile_FileExists()
        {
            _fileProcessor.WriteToFile(_testFile, "Hello, world!");
            Assert.That(File.Exists(_testFile), Is.True);
        }

        [Test]
        public void TestWriteAndReadFromFile_CorrectContent()
        {
            string content = "Unit testing in C#";
            _fileProcessor.WriteToFile(_testFile, content);

            string readContent = _fileProcessor.ReadFromFile(_testFile);
            Assert.That(readContent, Is.EqualTo(content));
        }
        [Test]
        public void TestReadFromFile_FileNotFound_ThrowsIOException()
        {
            Assert.Throws<IOException>(() => _fileProcessor.ReadFromFile("nonexistent.txt"));
        }
    }
}