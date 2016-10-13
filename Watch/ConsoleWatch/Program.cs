using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WatchInterfaces;
using DigitalWatch;

namespace ConsoleWatch
{
    class Program
    {
        public static void DisplayConnect(IDisplayableDevice device, ILightBulb bulb)
        {
            if (device is IProClock)
            {
                new ConsoleDisplayProClock((IProClock)device, bulb);
            }
            else if (device is ISimpleClock)
            {
                new ConsoleDisplaySimpleClock((ISimpleClock)device, bulb);
            }
            else if (device is IStopwatch)
            {
                new ConsoleDisplayStopwatch((IStopwatch)device, bulb);
            }
            else if (device is ITimer)
            {
                new ConsoleDisplayTimer((ITimer)device, bulb);
            }
        }
        static void Main(string[] args)
        {
            Watch digitalWatch = WatchBuilder.Build(DisplayConnect);
            digitalWatch.Run();

            ConsoleWatchControler controler = new ConsoleWatchControler(digitalWatch);
            controler.Run();
        }
    }
}
