using Nissim.On.Strategy.BLStrategy;
using Nissim.On.Strategy.BLStrategy.Display;
using Nissim.On.Strategy.BLStrategy.Eat;
using Nissim.On.Strategy.BLStrategy.Type;

namespace Nissim.On.Strategy
{
    class Program
    {
        static void Main(string[] args)
        {
            Dog boolDog = new Dog(new DisplayBooldogStrategy(), new EatMealStrategy(), new TypeBooldogStrategy());

            boolDog.Eat();
            boolDog.Type();
            boolDog.Display();

            Dog pincher = new Dog(new DisplayPincherStrategy(), new EatVegitarianStrategy(), new TypePincherStrategy());
            pincher.Eat();
            pincher.Type();
            pincher.Display();
        }
    }
}
