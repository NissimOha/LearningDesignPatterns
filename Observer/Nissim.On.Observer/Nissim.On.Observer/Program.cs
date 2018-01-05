using Nissim.On.Observer.BL;
using Nissim.On.Observer.ConsoleBL;
using System;

namespace Nissim.On.Observer
{
    class Program
    {
        static void Main(string[] args)
        {
            var whetherStation = new ObservableMessageStation();

            whetherStation.AddObserver(new ErrorMessage(whetherStation));
            whetherStation.AddObserver(new RegularMessage(whetherStation));
            whetherStation.AddObserver(new WarnningMessage(whetherStation));

            whetherStation.Info = Consts.REGULAR;
            whetherStation.Notify();

            whetherStation.Info = Consts.WARNNING;
            whetherStation.Notify();

            whetherStation.Info = Consts.ERROR;
            whetherStation.Notify();

            Random r = new Random();
            ConsoleMessage cm = new ConsoleMessage();
            cm.Info = r.Next() % 3;
            whetherStation.AddObserver(new RandomMessage(cm));
            whetherStation.Notify();
        }
    }
}
