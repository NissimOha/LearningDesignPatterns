using Nissim.On.Command.BL;
using Nissim.On.Command.Commands;
using Nissim.On.Command.Ifc;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Nissim.On.Command
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            var worker = new Worker();
            var smartHomeControler = new smartHomeController(
                new List<ICommand>()
                {
                    new AirConditionerCommand(Consts.startingPosition.Off, worker),
                    new LightCommand(Consts.startingPosition.On, worker),
                    new OvenCommand(Consts.startingPosition.Off, worker),
                    new TVCommand(Consts.startingPosition.On, worker)
                }, worker);
                        
            Application.Run(smartHomeControler);
        }
    }

}
