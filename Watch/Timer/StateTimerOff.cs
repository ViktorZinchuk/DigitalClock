using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace WatchTimer
{
    class StateTimerOff : AbstractState
    {
        private ClockTimer clock;
        public StateTimerOff( ClockTimer cl)
        {
            clock = cl;
        }
        public override void Start()
        {
            clock.Minutes = 0;
            clock.Seconds = 30;
            clock.Position1_visible = true;
            clock.Position2_visible = true;
            clock.FunctionalButton.Strategy.Press = null;
            clock.FunctionalButton.Strategy.Release = null;
            clock.FunctionalButton.Strategy.LongPress = null;
            clock.FunctionalButton.Strategy.ShortPress = OnStopwatch;
            clock.SettingsButton.Strategy.Press = null;
            clock.SettingsButton.Strategy.Release = null;
            clock.SettingsButton.Strategy.LongPress = null;
            clock.SettingsButton.Strategy.ShortPress = Addseconds;
        }
        public override void Stop()
        {
            clock.Position1_visible = false;
            clock.Position2_visible = false;
        }
        private void AddMinutes()
        {
            clock.Seconds++;
            if (clock.Seconds > 59)
            {
                clock.Seconds = 0;
                clock.Minutes ++;
            }
        }
        private void OnStopwatch()
        {
            if(clock.Seconds!=0 || clock.Minutes!=0)
            clock.ChangeState(TimerStates.StateTimerON);
        }
        private void Addseconds()
        {
            clock.ChangeState(TimerStates.StateTimerAddSeconds);
        }
    }
}
