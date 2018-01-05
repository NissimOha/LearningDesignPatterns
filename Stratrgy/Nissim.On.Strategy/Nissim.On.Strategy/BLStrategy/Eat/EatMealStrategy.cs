using Nissim.On.Strategy.IfcStrategy;
using System;

namespace Nissim.On.Strategy.BLStrategy.Eat
{
    public class EatMealStrategy : IEatStrategy
    {
        public void Eat()
        {
            Console.WriteLine("I Eat Meat");
        }
    }
}
