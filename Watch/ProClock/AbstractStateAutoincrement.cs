using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace ProClock
{
    abstract class AbstractStateAutoincrement : AbstractState
    {
        protected Timer autoincrementtimer;
        abstract protected void AutoIncrement(object source, ElapsedEventArgs e);
        abstract protected void StopAutoincrement();
        protected AbstractStateAutoincrement(ProfessionalClock cl)
            : base(cl)
        {
            autoincrementtimer = new Timer(200);
            autoincrementtimer.Elapsed += new ElapsedEventHandler(AutoIncrement);
        }
        public override void Start()
        {
            proClock.clock.TimerStop();
            autoincrementtimer.Start();
            proClock.Position1_visible = true;
            proClock.Position2_visible = true;
            proClock.FunctionalButton.Strategy.Press = null;
            proClock.FunctionalButton.Strategy.Release = StopAutoincrement;
            proClock.FunctionalButton.Strategy.LongPress = null;
            proClock.FunctionalButton.Strategy.ShortPress = null;
            proClock.SettingsButton.Strategy.Press = null;
            proClock.SettingsButton.Strategy.Release = null;
            proClock.SettingsButton.Strategy.LongPress = null;
            proClock.SettingsButton.Strategy.ShortPress = null;
        }
        public override void Stop()
        {
            autoincrementtimer.Stop();
            proClock.clock.TimerStart();
        }
    }
}