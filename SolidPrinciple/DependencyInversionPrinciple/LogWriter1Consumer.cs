namespace SolidPrinciple.DependencyInversionPrinciple
{
    /// <summary>
    ///  Bad design without using Dependency Injection.
    /// </summary>
    public class LogWriter1Consumer
    {
        LogWriter1 logWriter1 = null;
        public void NotifyByEmail(string message)
        {
            if (logWriter1 == null)
            {
                logWriter1 = new LogWriter1();
            }
            logWriter1.WriteEmail(message);
        }

        public void NotifyByEventLog(string message)
        {
            if (logWriter1 == null)
            {
                logWriter1 = new LogWriter1();
            }
            logWriter1.WriteEmail(message);
        }
    }
}
