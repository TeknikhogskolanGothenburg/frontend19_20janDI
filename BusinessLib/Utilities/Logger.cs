using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLib.Utilities
{
    public class Logger : ILogger
    {
        public void Log(string message)
        {
            Console.WriteLine($"Logging { message }");
        }
    }
}
