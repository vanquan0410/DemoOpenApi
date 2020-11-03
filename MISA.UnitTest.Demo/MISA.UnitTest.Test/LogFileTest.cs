using System;
using System.Collections.Generic;
using System.Text;
using NSubstitute;
using NUnit.Framework;
using MISA.UnitTest.Demo;

namespace MISA.UnitTest.Test
{
    [TestFixture]
    class LogFileTest
    {
        #region fake(stub ,mock)
        //stubs
        [Test]
        public void ShouldReturnTrueEveryFileNameWhenCheckIsValid()
        {
            var filename = string.Empty;
            var fileExtensionManager = new StubExtensionManager();
            var logFile = new LogFile(fileExtensionManager);
            Assert.IsTrue(logFile.CheckExtension(filename));
        }
        //mock
        [Test]
        public void CheckLastMessageErrorWhenShortFileName()
        {
            var fileName = "a.log";
            var fileExtensionManager = new MockExtensionManager();
            var logFile = new LogFile(fileExtensionManager);
            logFile.WriteToFile(fileName);
            Assert.AreEqual(fileExtensionManager.LasterrorMessage, "File name to short: a.log");

        }
        #endregion


        #region NSubstitute
        //stubs
        [Test]
        public void NSubstituteShouldReturnTrueEveryFileNameWhenCheckIsValid()
        {
            IExtensionManager extensionManager = Substitute.For<IExtensionManager>();
            extensionManager.ExtentionIsValid(string.Empty).Returns(true);
            var logFile = new LogFile(extensionManager);
            Assert.IsTrue(logFile.CheckExtension(string.Empty));
        }


        //mock
        [Test]
        public void NSubstituteCheckLastMessageErrorWhenShortFileName()
        {
            IExtensionManager mockExtensionManager = Substitute.For<IExtensionManager>();
            var fileName = "a.log";
            var logFile = new LogFile(mockExtensionManager);
            logFile.WriteToFile(fileName);
            mockExtensionManager.Received().MesssageError("File name to short: a.log");

        }
        #endregion

    }

    //case stubs
    public class StubExtensionManager : IExtensionManager
    {
        public string LasterrorMessage = null;
        public bool ExtentionIsValid(string fileName)
        {
            return true;
        }

        public string GetLastMessageError()
        {
            throw new NotImplementedException();
        }

        public void MesssageError(string message)
        {
            throw new NotImplementedException();
        }
    }

    //case Mock
    public class MockExtensionManager : IExtensionManager
    {
        public string LasterrorMessage = null;
        public bool ExtentionIsValid(string fileName)
        {
            throw new NotImplementedException();
        }

        public string GetLastMessageError()
        {
            throw new NotImplementedException();
        }

        public void MesssageError(string message)
        {
            LasterrorMessage = message;
        }
    }
}
