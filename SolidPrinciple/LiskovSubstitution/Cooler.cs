using System;

namespace SolidPrinciple.LiscovSubstitution
{
    public class Cooler : ISwitch
    {
        public void Off()
        {
            Console.WriteLine("Cooler's off method is being running");
        }

        public void On()
        {
            Console.WriteLine("Cooler's on method is being running");
        }

        public void Regulate()
        {
            Console.WriteLine("Cooler's regulate method is being running");
        }
    }
}
