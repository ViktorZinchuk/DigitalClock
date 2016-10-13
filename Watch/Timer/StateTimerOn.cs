using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace WatchTimer
{
    class StateTimerOn : AbstractState
    {
        private ClockTimer clock;
        private Timer timer;
        public StateTimerOn(ClockTimer cl)
        {
            clock = cl;
            timer = new Timer(1000);
            timer.Elapsed += new ElapsedEventHandler(TimerON);
            
        }
        private void TimerON(object source, ElapsedEventArgs e)
        {
            clock.Seconds--;
            if(clock.Seconds==0 && clock.Minutes==0)
            {
                clock.ChangeState(TimerStates.StateTimerEnd);
            }
        }
        public override void Start()
        {
            timer.Start();
            clock.Position1_visible = true;
            clock.Position2_visible = true;
            clock.FunctionalButton.Strategy.Press = null;
            clock.FunctionalButton.Strategy.Release = null;
            clock.FunctionalButton.Strategy.LongPress = null;
            clock.FunctionalButton.Strategy.ShortPress = StopTimer;
            clock.SettingsButton.Strategy.Press = null;
            clock.SettingsButton.Strategy.Release = null;
            clock.SettingsButton.Strategy.LongPress = null;
            clock.SettingsButton.Strategy.ShortPress = Reset;
        }
        public override void Stop()
        {
            timer.Stop();
        }
        private void StopTimer()
        {
            clock.ChangeState(TimerStates.StateTimerStop);
        }
        private void Reset()
        {
            clock.Minutes = 0;
            clock.Seconds = 0;
            clock.ChangeState(TimerStates.StateTimerOff);
        }
        private void TimerEnd()
        {
            clock.ChangeState(TimerStates.StateTimerEnd);
        }
    }
}
