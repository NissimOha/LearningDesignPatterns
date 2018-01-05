namespace Nissim.On.Decorator.Addons
{
    public class CaramelDecorator : AddonDecorator
    {
        private Beverage m_beverage;

        public CaramelDecorator(Beverage p_beverage)
        {
            m_beverage = p_beverage;
        }

        public override int Cost()
        {
            return m_beverage.Cost() + Consts.CARAMELCOST;
        }
    }
}
