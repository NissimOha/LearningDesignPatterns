using System.Drawing;

namespace Nissim.On.Factory.Cars
{
    class Mitsubishi : Car
    {
        public Mitsubishi(Color p_color) : base(p_color, Consts.CarType.Mitsubishi) { }

        public override float price()
        {
            return Consts.MITSUBISHIPRICE;
        }
    }
}
