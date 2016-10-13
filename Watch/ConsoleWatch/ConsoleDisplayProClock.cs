using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DigitalClock;
using ProClock;
using DigitalWatch;
using WatchInterfaces;

namespace ConsoleWatch
{
    internal class ConsoleDisplayProClock
    {
        private ILightBulb bulb;
        public IProClock clock;
        public ConsoleDisplayProClock(IProClock clock, ILightBulb w)
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
               
                Console.WriteLine("{0}:{1} {2} {3}", clock.Position1_visible ? clock.Hours.ToString("D2") : "  ", clock.Position2_visible ? clock.Minutes.ToString("D2") : "  ",
                    clock.Seconds.ToString("D2"), clock.PositionPm_visible ? clock.PM ? "PM" : "AM" : "");
            }
        }
    }
}

