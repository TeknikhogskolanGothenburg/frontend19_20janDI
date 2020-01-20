using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLib.Utilities
{
    public class NewLogger : ILogger
    {
        public void Log(string message)
        {
            Console.WriteLine($"New Logger { message }");
        }
    }
}
