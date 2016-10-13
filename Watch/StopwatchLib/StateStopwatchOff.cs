using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StopwatchLib
{
    class StateStopwatchOff : AbstractState
    {
        private Stopwatch clock;
        public StateStopwatchOff( Stopwatch cl)
        {
            clock = cl;
        }
        public override void Start()
        {
            clock.Position1_visible = true;
            clock.Position2_visible = true;
            clock.FunctionalButton.Strategy.Press = null;
            clock.FunctionalButton.Strategy.Release = null;
            clock.FunctionalButton.Strategy.LongPress = null;
            clock.FunctionalButton.Strategy.ShortPress = OnStopwatch;
            clock.SettingsButton.Strategy.Press = null;
            clock.SettingsButton.Strategy.Release = null;
            clock.SettingsButton.Strategy.LongPress = null;
            clock.SettingsButton.Strategy.ShortPress = Reset;
        }
        public override void Stop()
        {
            clock.Position1_visible = false;
            clock.Position2_visible = false;
        }
        private void Reset()
        {
            clock.Minutes = 0;
            clock.Seconds = 0;
        }
        private void OnStopwatch()
        {
            clock.ChangeState(StopwatchStates.StateStopwatchON);
        }
    }
}
