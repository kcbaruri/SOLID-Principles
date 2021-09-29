namespace SolidPrinciple.InterfaceSegregationPrinciple
{
    public class OnlineClient2 : IRestaurant
    {
        public void acceptOnlineOrder()
        {
            //logic for placing online order
        }

        public void payInPerson()
        {
            //logic for paying by person physically
        }

        public void payOnline()
        {
            //logic for pyaing online
        }

        public void takeTelephoneOrder()
        {
            //logic for placing telephonic order
        }

        public void walkInCustomerOrder()
        {
            //logic for placing physically-appeared order
        }
    }
}
