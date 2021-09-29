using System;

namespace SolidPrinciple.InterfaceSegregationPrinciple
{
    public class OnlineClient1 : IRestaurant
    {
        public void acceptOnlineOrder()
        {
            //logic for placing online order
        }

        public void payInPerson()
        {
            //Not Applicable for Online Order
            throw new NotImplementedException();
        }

        public void payOnline()
        {
            //logic for paying online  
        }

        public void takeTelephoneOrder()
        {
            //Not Applicable for Online Order
            throw new NotImplementedException();
        }

        public void walkInCustomerOrder()
        {
            //Not Applicable for Online Order
            throw new NotImplementedException();
        }
    }
}
