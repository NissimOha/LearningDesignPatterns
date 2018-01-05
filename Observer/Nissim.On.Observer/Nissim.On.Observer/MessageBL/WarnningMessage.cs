using Nissim.On.Observer.Ifc;
using System.Windows.Forms;

namespace Nissim.On.Observer.BL
{
    class WarnningMessage : IObserver
    {
        public WarnningMessage(IInfo p_info)
        {
            m_info = p_info;
        }

        public void Update()
        {
            if (m_info.Info == Consts.WARNNING)
            {
                MessageBox.Show("Warnning call", "WarnningMessage", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private IInfo m_info;
    }
}
