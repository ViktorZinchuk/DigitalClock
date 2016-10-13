using WatchInterfaces;
using ProClock;
using SimpleClock;
using StopwatchLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WatchTimer;

namespace DigitalWatch
{
    public delegate void ConnectDisplayHandler(IDisplayableDevice device, ILightBulb watch); 
    public class WatchBuilder
    {  
        public static Watch Build(ConnectDisplayHandler ConnectDisplay)
        {
            Watch watch = new Watch();

            IWatchDevice device;
            device = new Simpleclock(watch.FunctionalButton, watch.SettingsButton);
            watch.Add(device);
            ConnectDisplay(device, watch);

            device = new ProfessionalClock(watch.FunctionalButton, watch.SettingsButton);
            watch.Add(device);
            ConnectDisplay(device, watch);

            device = new Stopwatch(watch.FunctionalButton, watch.SettingsButton);
            watch.Add(device);
            ConnectDisplay(device, watch);

            device = new ClockTimer(watch.FunctionalButton, watch.SettingsButton);
            watch.Add(device);
            ConnectDisplay(device, watch);
            return watch;
        }
    }
}
