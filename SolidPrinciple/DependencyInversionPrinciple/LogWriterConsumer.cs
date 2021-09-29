namespace SolidPrinciple.DependencyInversionPrinciple
{
    public class LogWriterConsumer
    {
       public ILogWriter iLogWriter = null;

        public LogWriterConsumer(ILogWriter logWriter)
        {
            iLogWriter = logWriter;
        }

        public void NotifyByEmail(string message)
        {
            iLogWriter.WriteEmail(message);
        }

        public void NotifyByEventLog(string message)
        {
            iLogWriter.WriteEmail(message);
        }
    }
}
