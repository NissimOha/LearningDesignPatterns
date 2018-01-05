using Nissim.On.Observer.Ifc;
using System.Windows.Forms;

namespace Nissim.On.Observer.BL
{
    class ErrorMessage : IObserver
    {
        public ErrorMessage(IInfo p_info)
        {
            m_info = p_info;
        }

        public void Update()
        {
            if (m_info.Info == Consts.ERROR)
            {
                MessageBox.Show("Error call", "ErrorMessage", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private IInfo m_info;
    }
}
