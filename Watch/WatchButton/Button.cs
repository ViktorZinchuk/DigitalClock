using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace WatchButton
{
    public class Button
    {
        private bool pressed3sec;
        private Timer timerlongpress;
        public ButtonStrategy Strategy;

        public Button()
        {
            Strategy = new ButtonStrategy();
            pressed3sec = false;
            timerlongpress = new Timer(3000);
            timerlongpress.Elapsed += new ElapsedEventHandler(OnTimerLongPress);
            timerlongpress.AutoReset = false;
        }
        private void OnTimerLongPress(object source, ElapsedEventArgs e)
        {
            if (Strategy.LongPress != null)
            {
                Strategy.LongPress();
            }
            pressed3sec = true;
        }
        public void KeyDown()
        {
            timerlongpress.Start();
            if (Strategy.Press != null)
            {
                Strategy.Press();
            }
        }
        public void KeyUp()
        {
            timerlongpress.Stop();
            if (Strategy.Release != null)
            {
                Strategy.Release();
            }
            if (!pressed3sec)
            {
                if (Strategy.ShortPress != null)
                {
                    Strategy.ShortPress();
                }
            }
            pressed3sec = false;
        }
    }
}
