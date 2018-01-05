using Nissim.On.Strategy;
using Nissim.On.Strategy.BLStrategy;
using Nissim.On.Strategy.BLStrategy.Eat;
using Nissim.On.Strategy.BLStrategy.Type;

namespace Main
{
    class Program
    {
        static void Main(string[] args)
        {
            Dog boolDog = new Dog(new DisplayBooldog(), new EatMealStrategy(), new TypeBooldogStrategy());

            boolDog.Eat();
            boolDog.Type();
            boolDog.Display();
        }
    }
}
