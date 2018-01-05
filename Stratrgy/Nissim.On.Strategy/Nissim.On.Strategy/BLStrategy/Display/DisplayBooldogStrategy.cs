using Nissim.On.Strategy.BLStrategy.Display;
using Nissim.On.Strategy.IfcStrategy;
using System.Configuration;

namespace Nissim.On.Strategy.BLStrategy
{
    public class DisplayBooldogStrategy : IDisplayStrategy
    {
        public void Display()
        {
            var image = ConfigurationManager.AppSettings["BooldogImage"];
            DrawImage.DrawImageInConsole(image);
        }
    }
}
