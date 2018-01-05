using Nissim.On.Observer.Ifc;
using System.Windows.Forms;

namespace Nissim.On.Observer.BL
{
    public class RegularMessage : IObserver
    {
        public RegularMessage(IInfo p_info)
        {
            m_info = p_info;
        }

        public void Update()
        {
            if(m_info.Info == Consts.REGULAR)
            {
                MessageBox.Show("Regular call", "RegularMessage", MessageBoxButtons.OK, MessageBoxIcon.None);
            }
        }

        private IInfo m_info;
    }
}
