using System.Configuration;
using Nissim.On.Strategy.IfcStrategy;

namespace Nissim.On.Strategy.BLStrategy.Display
{
    public class DisplayPincherStrategy : IDisplayStrategy
    {
        public void Display()
        {
            var image = ConfigurationManager.AppSettings["PincherImage"];
            DrawImage.DrawImageInConsole(image);            
        }
    }
}
