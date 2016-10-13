using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace WatchTimer
{
    abstract class StateAddTime : AbstractState
    {
        protected Timer timer;
        protected ClockTimer clock;
        public StateAddTime(ClockTimer cl)
        {
            clock = cl;
            timer = new Timer(500);
            timer.Elapsed += new ElapsedEventHandler(BlinkPosition);    
        }
        public override void Start()
        {
            timer.Start();
            clock.Position1_visible = true;
            clock.Position2_visible = true;
            clock.FunctionalButton.Strategy.Press = null;
            clock.FunctionalButton.Strategy.Release = null;
            clock.FunctionalButton.Strategy.LongPress = null;
            clock.FunctionalButton.Strategy.ShortPress = StartTimer;
            clock.SettingsButton.Strategy.Press = null;
            clock.SettingsButton.Strategy.Release = null;
            clock.SettingsButton.Strategy.LongPress = SwitchTime;
            clock.SettingsButton.Strategy.ShortPress = AddTime;
        }
        public override void Stop()
        {
            timer.Stop();
        }
        abstract protected void AddTime();
        abstract protected void SwitchTime();
        abstract protected void BlinkPosition(object source, ElapsedEventArgs e);
        private void StartTimer()
        {
            clock.ChangeState(TimerStates.StateTimerON);
        }   
    }
}
