using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WatchInterfaces;
using DigitalWatch;

namespace ConsoleWatch
{
    internal class ConsoleDisplayStopwatch
    {
        private ILightBulb bulb;
        private IStopwatch clock;
        public ConsoleDisplayStopwatch(IStopwatch clock, ILightBulb w)
        {
            bulb = w;
            bulb.BacklightChanged += Update;
            this.clock = clock;
            this.clock.ValueChanged += Update;
            
        }
        public void Update()
        {
            if (clock.On)
            {
                Console.BackgroundColor = bulb.Backlight ? ConsoleColor.Blue : ConsoleColor.Black;
                Console.Clear();                 
                Console.WriteLine("{0}:{1}", clock.Position1_visible ? clock.Minutes.ToString("D2") : "  ",
                    clock.Position2_visible ? clock.Seconds.ToString("D2") : "  ");
            }
        }
    }
}
