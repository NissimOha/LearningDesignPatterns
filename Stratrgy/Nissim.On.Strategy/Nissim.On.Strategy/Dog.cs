using Nissim.On.Strategy.IfcStrategy;

namespace Nissim.On.Strategy
{
    public class Dog
    {
        public Dog(IDisplayStrategy p_displayStrategy, IEatStrategy p_eatStrategy, ITypeStrategy p_typeStrategy)
        {
            m_displayStrategy = p_displayStrategy;
            m_eatStrategy = p_eatStrategy;
            m_typeStrategy = p_typeStrategy;
        }

        public void Type()
        {
            m_typeStrategy.Type();
        }

        public void Display()
        {
            m_displayStrategy.Display();
        }

        public void Eat()
        {
            m_eatStrategy.Eat();
        }

        private IDisplayStrategy m_displayStrategy;
        private IEatStrategy m_eatStrategy;
        private ITypeStrategy m_typeStrategy;
    }
}
