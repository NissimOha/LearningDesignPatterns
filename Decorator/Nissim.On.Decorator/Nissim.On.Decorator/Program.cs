using Nissim.On.Decorator.Addons;
using Nissim.On.Decorator.Beverages;
using System;
using System.Collections.Generic;

namespace Nissim.On.Decorator
{
    class Program
    {
        public static void Main(string[] args)
        {
            List<Beverage> beverages = new List<Beverage>()
            {
                new CaramelDecorator(new Expresso()),
                new Tea(),
                new ChocolateDecorator(new Choco())
            };

            foreach (var beverage in beverages)
            {
                Console.WriteLine(beverage.Description + "\tCosts: " + beverage.Cost());
            }
        }
    }
}
