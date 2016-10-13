using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DigitalClock;
using SimpleClock;
using DigitalWatch;
using WatchInterfaces;

namespace ConsoleWatch
{
    internal class ConsoleDisplaySimpleClock
    {
        private ISimpleClock clock;
        private ILightBulb bulb;
        public ConsoleDisplaySimpleClock(ISimpleClock clock, ILightBulb w)
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
                if (!clock.DisplaySeconds)
                {
                    Console.WriteLine("{0}{1}{2}", clock.Position1_visible ? clock.Hours.ToString("D2") : "  ", clock.Separator ? ":" : " ",
                        clock.Position2_visible ? clock.Minutes.ToString("D2") : "  ");
                }
                else
                {
                    Console.WriteLine("{0}", clock.Position1_visible ? clock.Seconds.ToString("D2") : "  ");
                }
            }
        }
    }
}