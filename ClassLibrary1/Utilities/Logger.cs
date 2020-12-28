using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary1.Utilities
{
    class Logger : ILogger
    {
        public void Log(string message)
        {
            Console.WriteLine($"Logging {message}");
        }
    }
}
