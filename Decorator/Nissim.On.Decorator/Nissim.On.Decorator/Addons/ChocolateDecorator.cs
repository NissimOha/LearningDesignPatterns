namespace Nissim.On.Decorator.Addons
{
    public class ChocolateDecorator : AddonDecorator
    {
        private Beverage m_beverage;

        public ChocolateDecorator(Beverage p_beverage)
        {
            m_beverage = p_beverage;
        }

        public override int Cost()
        {
            return m_beverage.Cost() + Consts.CHOCOLATECOST;
        }
    }
}
