using System.Drawing;

namespace Nissim.On.Factory.Cars
{
    public class Honda : Car
    {
        public Honda(Color p_color) : base(p_color, Consts.CarType.Honda) { }

        public override float price()
        {
            return Consts.HONADPRICE;
        }
    }
}
