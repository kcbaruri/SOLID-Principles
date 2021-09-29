namespace SolidPrinciple.InterfaceSegregationPrinciple
{
    interface IRestaurant
    {
         void acceptOnlineOrder();
         void takeTelephoneOrder();
         void payOnline();
         void walkInCustomerOrder();
         void payInPerson();
    }
}
