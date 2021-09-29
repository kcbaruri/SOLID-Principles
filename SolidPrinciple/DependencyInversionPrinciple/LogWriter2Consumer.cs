namespace SolidPrinciple.DependencyInversionPrinciple
{
    public class LogWriter2Consumer
    {
        LogWriter1 logWriter1 = null;

        public LogWriter2Consumer(LogWriter1 logWriter)
        {
            logWriter1 = logWriter;
        }

        public void NotifyByEmail(string message)
        {
            logWriter1.WriteEmail(message);
        }

        public void NotifyByEventLog(string message)
        {
            logWriter1.WriteEmail(message);
        }
    }
}
