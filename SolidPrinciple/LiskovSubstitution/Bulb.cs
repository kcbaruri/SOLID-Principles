using System;

namespace SolidPrinciple.LiscovSubstitution
{
    public class Bulb : ISwitch
    {
        public void Off()
        {
            Console.WriteLine("Bulb's off method is being running");
        }

        public void On()
        {
            Console.WriteLine("Bulb's on method is being running");
        }

        public void Regulate()
        {
            throw new NotImplementedException();
        }
    }
}
