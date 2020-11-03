using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace MISA.UnitTest.Demo
{
    public class LogFile
    {
        private readonly IExtensionManager _extensionManager;
        public LogFile()
        {
            _extensionManager = new FileExtensionManager();
        }

        public LogFile(IExtensionManager extensionManager)
        {
            _extensionManager = extensionManager;
        }

        public bool CheckExtension(string fileName)
        {
            return _extensionManager.ExtentionIsValid(fileName);
        }

        public void WriteToFile(string fileName)
        {
            if (fileName.Length < 15)
            {
                _extensionManager.MesssageError($"File name to short: {fileName}");
            }
        }

        public string MessageError()
        {
            return _extensionManager.GetLastMessageError();
        }

    }

    class FileExtensionManager : IExtensionManager
    {
        public string _message;
        public bool ExtentionIsValid(string fileName)
        {
            return Path.GetExtension(fileName) == ".log" ? true : false;
        }

        public string GetLastMessageError()
        {
            return _message;
        }

        public void MesssageError(string message)
        {
            _message = message;
        }
    }

    public interface IExtensionManager
    {
        bool ExtentionIsValid(string fileName);
        void MesssageError(string message);
        string GetLastMessageError();
    }
}
