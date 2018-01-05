using Nissim.On.Observer.BL;
using Nissim.On.Observer.Ifc;
using System.Windows.Forms;

namespace Nissim.On.Observer.ConsoleBL
{
    class RandomMessage : IObserver
    {
        public RandomMessage(IInfo p_info)
        {
            m_info = p_info;
        }

        public void Update()
        {
            if (m_info.Info == Consts.WARNNING)
            {
                MessageBox.Show("Random call", "RandomMessage", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            if (m_info.Info == Consts.ERROR)
            {
                MessageBox.Show("Random call", "RandomMessage", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (m_info.Info == Consts.REGULAR)
            {
                MessageBox.Show("Random call", "RandomMessage", MessageBoxButtons.OK, MessageBoxIcon.None);
            }
        }

        private IInfo m_info;
    }
}
