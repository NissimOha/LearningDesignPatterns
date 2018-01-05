namespace Nissim.On.Decorator.Beverages
{
    class Expresso : Beverage
    {
        public override int Cost()
        {
            return Consts.EXPRESSOCOST;
        }
    }
}
