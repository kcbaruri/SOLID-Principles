using System;

namespace SolidPrinciple.LiscovSubstitution
{
    public class Fan : ISwitch
    {
        public void Off()
        {
            Console.WriteLine("Fan's off method is being running");
        }

        public void On()
        {
            Console.WriteLine("Fan's on method is being running");
        }

        public void Regulate()
        {
            Console.WriteLine("Fan's regulate method is being running");
        }
    }
}
