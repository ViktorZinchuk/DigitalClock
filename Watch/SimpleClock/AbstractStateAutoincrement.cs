using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace SimpleClock
{
    abstract class AbstractStateAutoincrement : AbstractState
    {
        protected Timer autoincrementtimer;
        abstract protected void AutoIncrement(object source, ElapsedEventArgs e);
        abstract protected void StopAutoincrement();
        protected AbstractStateAutoincrement(Simpleclock cl)
            : base(cl)
        {
            autoincrementtimer = new Timer(200);
            autoincrementtimer.Elapsed += new ElapsedEventHandler(AutoIncrement);
        }
        public override void Start()
        {
            simpleclock.clock.TimerStop();
            autoincrementtimer.Start();
            simpleclock.clock.Separator = true;
            simpleclock.Position1_visible = true;
            simpleclock.Position2_visible = true;
            simpleclock.FunctionalButton.Strategy.Press = null;
            simpleclock.FunctionalButton.Strategy.Release = StopAutoincrement;
            simpleclock.FunctionalButton.Strategy.LongPress = null;
            simpleclock.FunctionalButton.Strategy.ShortPress = null;
            simpleclock.SettingsButton.Strategy.Press = null;
            simpleclock.SettingsButton.Strategy.Release = null;
            simpleclock.SettingsButton.Strategy.LongPress = null;
            simpleclock.SettingsButton.Strategy.ShortPress = null;
        }
        public override void Stop()
        {
            autoincrementtimer.Stop();
            simpleclock.clock.TimerStart();
        }
    }
}
