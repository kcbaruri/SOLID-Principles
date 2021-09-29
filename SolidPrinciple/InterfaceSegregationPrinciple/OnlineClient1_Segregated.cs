namespace SolidPrinciple.InterfaceSegregationPrinciple
{
   public class OnlineClient1_Segregated : ISegregatedRestaurant1
    {
        public void acceptOnlineOrder()
        {
            //logic for placing online order
        }

        public void login()
        {
            //Logic for user login.
        }

        public void payOnline()
        {
            //logic for paying online  
        }
    }
}
