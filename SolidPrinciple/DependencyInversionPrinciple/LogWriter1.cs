using System;

namespace SolidPrinciple.DependencyInversionPrinciple
{
    public class LogWriter1
    {
        public void WriteEmail(string message)
        {
            Console.WriteLine("Sending emial: " + message);
        }

        public void WriteEventLog(string message)
        {
            Console.WriteLine("Writing event log: " + message);
        }
    }
}
