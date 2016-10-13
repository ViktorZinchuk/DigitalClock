using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DigitalWatch;
using WatchButton;

namespace ConsoleWatch
{
    class ConsoleWatchControler
    {
        private Watch watch;
        public ConsoleWatchControler(Watch cl)
        {
            watch = cl;
        }
        public void Run()
        {
            bool functionalbtn = false;
            bool modebtn = false;
            bool settingsbtn = false;
            bool backlightbtn = false;
            ConsoleKeyInfo key;
            key = Console.ReadKey(true);
            while (key.Key != ConsoleKey.X)
            {
                if (key.Key == ConsoleKey.NumPad7)
                {
                    if (!modebtn)
                    {
                        watch.ModeButton.KeyDown();
                    }
                    else
                    {
                        watch.ModeButton.KeyUp();
                    }
                    modebtn = !modebtn;
                }
                if (key.Key == ConsoleKey.NumPad3)
                {
                    if (!functionalbtn)
                    {
                        watch.FunctionalButton.KeyDown();
                    }
                    else
                    {
                        watch.FunctionalButton.KeyUp();
                    }
                    functionalbtn = !functionalbtn;
                }
                if (key.Key == ConsoleKey.NumPad9)
                {
                    if (!settingsbtn)
                    {
                        watch.SettingsButton.KeyDown();
                    }
                    else
                    {
                        watch.SettingsButton.KeyUp();
                    }
                    settingsbtn = !settingsbtn;
                }
                if (key.Key == ConsoleKey.NumPad1)
                {
                    if (!backlightbtn)
                    {
                        watch.BackLightButton.KeyDown();
                    }
                    else
                    {
                        watch.BackLightButton.KeyUp();
                    }
                    backlightbtn = !backlightbtn; 
                }                
                key = Console.ReadKey(true);
            }
        }
    }
}
