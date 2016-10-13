using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace SimpleClock
{
    abstract class AbstractStateEditeTime : AbstractState
    {
        protected Timer blinktimer;
        abstract protected void Increment();
        abstract protected void SwitchEditTime();
        abstract protected void StartAutoincrement();
        abstract protected void BlinkPosition(object source, ElapsedEventArgs e);
        protected AbstractStateEditeTime(Simpleclock cl)
            : base(cl)
        {
            blinktimer = new Timer(500);
            blinktimer.Elapsed += new ElapsedEventHandler(BlinkPosition);
        }
        protected void StopSettingsMode()
        {
            simpleclock.ChangeState(SimpleClockStates.StateDisplayHM_Sec);
        }
        public override void Start()
        {
            simpleclock.clock.TimerStop();
            simpleclock.clock.Seconds = 0;
            blinktimer.Start();
            simpleclock.clock.Separator = true;
            simpleclock.Position1_visible = true;
            simpleclock.Position2_visible = true;
            simpleclock.FunctionalButton.Strategy.Press = null;
            simpleclock.FunctionalButton.Strategy.Release = null;
            simpleclock.FunctionalButton.Strategy.LongPress = StartAutoincrement;
            simpleclock.FunctionalButton.Strategy.ShortPress = Increment;
            simpleclock.SettingsButton.Strategy.Press = null;
            simpleclock.SettingsButton.Strategy.Release = null;
            simpleclock.SettingsButton.Strategy.LongPress = StopSettingsMode;
            simpleclock.SettingsButton.Strategy.ShortPress = SwitchEditTime;
        }
        public override void Stop()
        {
            blinktimer.Stop();
            simpleclock.clock.TimerStart();
        }
    }
}
