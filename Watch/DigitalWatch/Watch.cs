using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SimpleClock;
using ProClock;
using WatchButton;
using StopwatchLib;
using WatchTimer;
using WatchInterfaces;

namespace DigitalWatch
{
    public class Watch : ILightBulb
    {
        private int currentDevice;
        public event Action BacklightChanged;
        
        public Button ModeButton = new Button();
        public Button BackLightButton = new Button();
        public Button FunctionalButton = new Button();
        public Button SettingsButton = new Button();

        private List<IWatchDevice>watchMode = new List<IWatchDevice>();

        public Watch()
        {
            backlight = false;
            ModeButton = new Button();
            BackLightButton = new Button();
            FunctionalButton = new Button();
            SettingsButton = new Button();

            ModeButton.Strategy.Press = null;
            ModeButton.Strategy.Release = null;
            ModeButton.Strategy.ShortPress = ChangeMode;
            ModeButton.Strategy.LongPress = null;

            BackLightButton.Strategy.Press=BacklightOn;
            BackLightButton.Strategy.Release=BacklightOff;
            BackLightButton.Strategy.ShortPress = null;
            BackLightButton.Strategy.ShortPress = null;          
        }
        public void Run()
        {
            currentDevice = 0;
            watchMode[currentDevice].Start();
        }
        public void Add(IWatchDevice device)
        {
            watchMode.Add(device);
        }
        private bool backlight;
        public bool Backlight 
        {
            get { return backlight;}
            set
            {
                if (backlight != value)
                {
                    backlight = value;
                    if (BacklightChanged != null)
                        BacklightChanged();
                }
            }
        }
        public void ChangeMode()
        {
            watchMode[currentDevice].Stop();
            currentDevice++;
            currentDevice %= watchMode.Count;
            watchMode[currentDevice].Start();
        }
        private void BacklightOn()
        {
            Backlight = true;
        }
        private void BacklightOff()
        {
            Backlight = false;
        }
    }
}
