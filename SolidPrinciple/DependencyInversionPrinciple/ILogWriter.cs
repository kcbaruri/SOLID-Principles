namespace SolidPrinciple.DependencyInversionPrinciple
{
   public interface ILogWriter
    {
        void WriteEmail(string message);
        void WriteEventLog(string message);
    }
}
