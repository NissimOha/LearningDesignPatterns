using System.Drawing;

namespace Nissim.On.Factory
{
    public abstract class Car
    {
        public Car(Color p_color, Consts.CarType p_carType)
        {
            Color = p_color;
            CarType = p_carType;
        }

        public Color Color {get; private set;}

        public Consts.CarType CarType { get; private set; }

        public abstract float price();
    }
}
