using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace ProClock
{
    abstract class AbstractStateEditTime : AbstractState
    {
        protected Timer blinktimer;
        abstract protected void Increment();
        abstract protected void SwitchEditTime();
        abstract protected void StartAutoincrement();
        abstract protected void BlinkPosition(object source, ElapsedEventArgs e);
        protected AbstractStateEditTime(ProfessionalClock cl)
            : base(cl)
        {
            blinktimer = new Timer(500);
            blinktimer.Elapsed += new ElapsedEventHandler(BlinkPosition);
        }
        protected void StopSettingsMode()
        {
            proClock.ChangeState(ProClockStates.StateDisplayHM_Sec);
        }
        public override void Start()
        {
            proClock.clock.TimerStop();
            proClock.clock.Seconds = 0;
            blinktimer.Start();
            proClock.Position1_visible = true;
            proClock.Position2_visible = true;
            proClock.FunctionalButton.Strategy.Press = null;
            proClock.FunctionalButton.Strategy.Release = null;
            proClock.FunctionalButton.Strategy.LongPress = StartAutoincrement;
            proClock.FunctionalButton.Strategy.ShortPress = Increment;
            proClock.SettingsButton.Strategy.Press = null;
            proClock.SettingsButton.Strategy.Release = null;
            proClock.SettingsButton.Strategy.LongPress = StopSettingsMode;
            proClock.SettingsButton.Strategy.ShortPress = SwitchEditTime;
        }
        public override void Stop()
        {
            blinktimer.Stop();
            proClock.clock.TimerStart();
        }
    }
}

