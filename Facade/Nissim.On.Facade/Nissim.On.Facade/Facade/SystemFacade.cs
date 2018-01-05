using Nissim.On.Facade.Devices;

namespace Nissim.On.Facade.Facade
{
    class SystemFacade
    {
        public SystemFacade()
        {
            m_controlSystem = new ControlSystem();
            m_monitorSystem = new MonitorSystem();
            m_navigationSystem = new NavigationSystem();
        }

        //Turn all the system off.
        public void TurnSystemOff()
        {
            m_controlSystem.ControlSystemOff();
            m_monitorSystem.MonitorSystemOff();
            m_navigationSystem.NavigationSystemOff();
        }

        //Turn all the system on.
        public void TurnSystemOn()
        {
            m_controlSystem.ControlSystemOn();
            m_monitorSystem.MonitorSystemOn();
            m_navigationSystem.NavigationSystemOn();
        }

        private ControlSystem m_controlSystem;
        private MonitorSystem m_monitorSystem;
        private NavigationSystem m_navigationSystem;
    }
}
