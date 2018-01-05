using Nissim.On.Command.BL;
using Nissim.On.Command.Ifc;

namespace Nissim.On.Command.Commands
{
    class AirConditionerCommand : ICommand
    {
        public AirConditionerCommand(Consts.startingPosition p_isOn, Worker p_worker)
        {
            m_isOn = p_isOn == Consts.startingPosition.On;
            m_worker = p_worker;
        }

        public void execute()
        {
            if (m_isOn)
                m_worker.DoWork(@"Air-Condition turn on", m_isOn);
            else
                m_worker.DoWork(@"Air-Condition turn off", m_isOn);
            m_isOn = !m_isOn;
        }

        public void unexecute()
        {
            if (m_isOn)
                m_worker.DoWork(@"Air-Condition turn on", m_isOn);
            else
                m_worker.DoWork(@"Air-Condition turn off", m_isOn);
            m_isOn = !m_isOn;
        }

        private bool m_isOn { get; set; }
        private Worker m_worker;
    }
}
