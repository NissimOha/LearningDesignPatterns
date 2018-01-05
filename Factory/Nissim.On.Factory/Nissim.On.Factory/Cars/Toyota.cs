using System.Drawing;

namespace Nissim.On.Factory.Cars
{
    class Toyota : Car
    {
        public Toyota(Color p_color) : base(p_color, Consts.CarType.Toyota) { }

        public override float price()
        {
            return Consts.TOYOTAPRICE;
        }
    }
}
