namespace Nissim.On.Decorator
{
    public abstract class Beverage
    {
        private string m_description;

        public string Description
        {
            get { return m_description; }

            set
            {
                if(!m_description.Contains(value))
                    m_description += "\n" + value;
            }
        }

        public Beverage()
        {
            m_description = Consts.DESCRIPTION;
        }

        public abstract int Cost();
    }
}
