using SolidPrinciple.DependencyInversionPrinciple;
using SolidPrinciple.InterfaceSegregationPrinciple;
using SolidPrinciple.LiscovSubstitution;
using SolidPrinciple.OpenClosed;
using SolidPrinciple.SingleResponsibility;
using System.Collections.Generic;

namespace SolidPrinciple
{
    class Program
    {
        static void Main(string[] args)
        {
            #region "Single responsibility principle"
            bool isValidated = XmlValidator.Validate(); // Validator is only responsible for validation activity.

            if (isValidated)
            {
                XmlUpdate.DoUpdate(); // Updating operation is being performed by a different class than validator.
            }
            #endregion

            #region "Open closed principle"
            Customer customer1 = new Customer();
            customer1.InvoiceNumber = 12;

            CustomerNew customer2 = new CustomerNew(); // CustomerNew is inherited from customer 1 where invoice was numeric.
            customer2.InvoiceNumber = "INVN12345";

            #endregion

            #region "Liskov substitution principle"
            List<ISwitch> switchList = new List<ISwitch>();
            switchList.Add(new Cooler());
            switchList.Add(new Fan());
            switchList.Add(new Bulb());

            foreach (var switchItem in switchList)
            {
               // switchItem.Regulate(); // In case of Buld, this will throw an error due to unimplemented method.

               // To avoid the above exception, it needs to put a check as below which violates LSP.
               // To resolve this problem, it needs to follow interface segregation principle.
               if(switchItem is Bulb)
                {
                    continue;
                }
                switchItem.Regulate();
            }

            #endregion

            #region "Interface segregation principle"
            IRestaurant onlineClient1 = new OnlineClient1(); // Implemented only two methods - 1. acceptOnlineOrder, 2. payOnline
            onlineClient1.acceptOnlineOrder();
            onlineClient1.payOnline();

            IRestaurant onlineClient2 = new OnlineClient2(); // Implemented all the methods.
            onlineClient2.acceptOnlineOrder();
            onlineClient2.payInPerson();
            onlineClient2.payOnline();
            onlineClient2.takeTelephoneOrder();
            onlineClient2.walkInCustomerOrder();

            // IRestaurant is fat interface w.r.t "OnlineClient1" as it implements only one methods.
            // To avoid it, two segregated interface named "ISegregatedRestaurant1" can be used.

           ISegregatedRestaurant1 segregatedOnlineClient1 = new OnlineClient1_Segregated();
           segregatedOnlineClient1.acceptOnlineOrder();
           segregatedOnlineClient1.payOnline();

            #endregion

            #region "Dependency inversion principle"
            //Bad design as there is no dependency injection applied
            LogWriter1Consumer logWriter1Consumer = new LogWriter1Consumer();
            logWriter1Consumer.NotifyByEmail("Sending email");
            logWriter1Consumer.NotifyByEventLog("Writing event logs");

            // Bad design. If there is any change in logWriter1 class, it needs to distribute again to the "LogWriter2Consumer" class
            LogWriter1 logWriter1 = new LogWriter1();
            LogWriter2Consumer logWriter2Consumer = new LogWriter2Consumer(logWriter1);
            logWriter2Consumer.NotifyByEmail("Sending email");
            logWriter2Consumer.NotifyByEventLog("Writing event logs");

            // With Dependency Injection 
            ILogWriter iLogWriter = new LogWriter();
            LogWriterConsumer writerConsumer = new LogWriterConsumer(iLogWriter);
            writerConsumer.NotifyByEmail("Sending email");
            writerConsumer.NotifyByEventLog("Writing event logs");

            #endregion
        }
    }
}
