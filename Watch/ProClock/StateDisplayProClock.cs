using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProClock
{
    class StateDisplayProClock : AbstractState
    {
        public StateDisplayProClock(ProfessionalClock cl)
            : base(cl)
        {
        }
        public override void Start()
        {
            proClock.Position1_visible = true;
            proClock.Position2_visible = true;
            proClock.FunctionalButton.Strategy.Press = null;
            proClock.FunctionalButton.Strategy.Release = null;
            proClock.FunctionalButton.Strategy.LongPress = null;
            proClock.FunctionalButton.Strategy.ShortPress = null;
            proClock.SettingsButton.Strategy.Press = null;
            proClock.SettingsButton.Strategy.Release = null;
            proClock.SettingsButton.Strategy.LongPress = StartSettingMode;
            proClock.SettingsButton.Strategy.ShortPress = null;
        }
        public override void Stop()
        {
        }
        private void StartSettingMode()
        {
            proClock.ChangeState(ProClockStates.StateEditHours);
        }
    }
}
