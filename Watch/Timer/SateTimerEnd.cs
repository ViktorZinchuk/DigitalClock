using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace WatchTimer
{
    class StateTimerEnd : AbstractState
    {
        private Timer blinktimer;
        private ClockTimer clock;
        public StateTimerEnd( ClockTimer cl)
        {
            clock = cl;
            blinktimer = new Timer(500);
            blinktimer.Elapsed += new ElapsedEventHandler(BlinkPosition);
        }
        public override void Start()
        {
            blinktimer.Start();
            clock.Position1_visible = true;
            clock.Position2_visible = true;
            clock.FunctionalButton.Strategy.Press = null;
            clock.FunctionalButton.Strategy.Release = null;
            clock.FunctionalButton.Strategy.LongPress = null;
            clock.FunctionalButton.Strategy.ShortPress = null;
            clock.SettingsButton.Strategy.Press = null;
            clock.SettingsButton.Strategy.Release = null;
            clock.SettingsButton.Strategy.LongPress = null;
            clock.SettingsButton.Strategy.ShortPress = Reset;
        }
        public override void Stop()
        {
            blinktimer.Stop();
        }
        private void BlinkPosition(object source, ElapsedEventArgs e)
        {
            clock.Position2_visible = !clock.Position2_visible;
        }
        private void Reset()
        {
            clock.ChangeState(States.StateTimerOff);
        }
       
    }
}
