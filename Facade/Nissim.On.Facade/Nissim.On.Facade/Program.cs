using Nissim.On.Facade.Devices;
using Nissim.On.Facade.Facade;

namespace Nissim.On.Facade
{
    class Program
    {
        static void Main(string[] args)
        {
            //Without Facade
            var controlSystem = new ControlSystem();
            var monitorSystem = new MonitorSystem();
            var navigationSystem = new NavigationSystem();
            //TurnOff
            controlSystem.ControlSystemOff();
            monitorSystem.MonitorSystemOff();
            navigationSystem.NavigationSystemOff();
            //TurnOn
            controlSystem.ControlSystemOn();
            monitorSystem.MonitorSystemOn();
            navigationSystem.NavigationSystemOn();

            //With Facade
            var mySystemFacade = new SystemFacade();
            mySystemFacade.TurnSystemOff();
            mySystemFacade.TurnSystemOn();
        }
    }
}
