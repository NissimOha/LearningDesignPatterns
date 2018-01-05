using Nissim.On.Adapter.Adaptees;

namespace Nissim.On.Adapter
{
    class UniversalAdapter : ITargetAdapter
    {
        private UkAdaptee m_ukAdaptee;
        private UsaAadaptee m_usaAdaptee;
        private CanadaAdaptee m_canadaAdaptee;

        public UniversalAdapter(Adapter adapter)
        {
            switch (adapter)
            {
                case Adapter.Uk: m_ukAdaptee = new UkAdaptee();
                    break;
                case Adapter.Usa: m_usaAdaptee = new UsaAadaptee();
                    break;
                case Adapter.Canada: m_canadaAdaptee = new CanadaAdaptee();
                    break;
            }
        }

        public void Request()
        {
            if (m_canadaAdaptee != null) m_canadaAdaptee.CanadaRequest();
            if (m_ukAdaptee != null) m_ukAdaptee.UkRequest();
            if (m_usaAdaptee != null) m_usaAdaptee.UsaRequest();
        }

        public enum Adapter
        {
            Uk,
            Usa,
            Canada
        }
    }
}
