using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace WatchTimer
{
    class StateTimerAutouncrement : AbstractState
    {
        private Timer timer;
        private ClockTimer clock;
        public StateTimerAutouncrement(ClockTimer cl)
        {
            clock = cl;
            timer = new Timer(1000);
            timer.Elapsed += new ElapsedEventHandler(AddSeconds);    
        }
        public override void Start()
        {
            timer.Start();
            clock.Position1_visible = true;
            clock.Position2_visible = true;
            clock.FunctionalButton.Strategy.Press = null;
            clock.FunctionalButton.Strategy.Release = StopAutoincrement;
            clock.FunctionalButton.Strategy.LongPress = null;
            clock.FunctionalButton.Strategy.ShortPress = null;
            clock.SettingsButton.Strategy.Press = null;
            clock.SettingsButton.Strategy.Release = null;
            clock.SettingsButton.Strategy.LongPress = null;
            clock.SettingsButton.Strategy.ShortPress = null;
        }
        public override void Stop()
        {
            timer.Stop();
        }
        private void AddSeconds(object source, ElapsedEventArgs e)
        {
            clock.Seconds+=20;
            if (clock.Seconds > 59)
            {
                clock.Seconds = 0;
                clock.Minutes++;
            }
        }
        private void StopAutoincrement()
        {
            clock.ChangeState(States.StateTimerOff);
        }
    }
}
