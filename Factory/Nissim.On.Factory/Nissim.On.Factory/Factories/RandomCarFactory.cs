using System;
using Nissim.On.Factory.Cars;
using System.Drawing;

namespace Nissim.On.Factory
{
    public class RandomCarFactory : CarFactory
    {
        private Random m_random;

        public RandomCarFactory()
        {
            m_random = new Random();
        }

        public Car CarGenerator(Consts.CarType p_carType)
        {
            switch (p_carType)
            {
                case Consts.CarType.Honda: return new Honda(Color.Red);
                case Consts.CarType.Toyota: return new Toyota(Color.Blue);
                case Consts.CarType.Mitsubishi: return new Mitsubishi(Color.Gold);
                default:
                    return new Honda(Color.Red);
            }
        }

        public override Car GenerateRandomCar()
        {
            var randomType = m_random.Next(Enum.GetNames(typeof(Consts.CarType)).Length);
            var typeName = Enum.GetName(typeof(Consts.CarType), randomType);

            return CarGenerator((Consts.CarType)Enum.Parse(typeof(Consts.CarType), typeName));
        }
    }
}
