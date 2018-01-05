using Nissim.On.Strategy.IfcStrategy;
using System;

namespace Nissim.On.Strategy.BLStrategy.Eat
{
    public class EatVegitarianStrategy : IEatStrategy
    {
        public void Eat()
        {
            Console.WriteLine("I am a vegetarian dog");
        }
    }
}
