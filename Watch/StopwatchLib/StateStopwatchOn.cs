using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace StopwatchLib
{
    class StartStopwatch : AbstractState
    {
        private Stopwatch clock;
        private Timer StopatchTimer;
        public StartStopwatch(Stopwatch cl)
        {
            clock = cl;
            StopatchTimer = new Timer(1000);
            StopatchTimer.Elapsed+=new ElapsedEventHandler(StopwatchON);
        }
        private void StopwatchON(object source, ElapsedEventArgs e)
        {
            clock.Seconds++;
        }
        public override void Start()
        {
            StopatchTimer.Start();
            clock.Position1_visible = true;
            clock.Position2_visible = true;
            clock.FunctionalButton.Strategy.Press = null;
            clock.FunctionalButton.Strategy.Release = null;
            clock.FunctionalButton.Strategy.LongPress = null;
            clock.FunctionalButton.Strategy.ShortPress = StopStopwatch;
            clock.SettingsButton.Strategy.Press = null;
            clock.SettingsButton.Strategy.Release = null;
            clock.SettingsButton.Strategy.LongPress = null;
            clock.SettingsButton.Strategy.ShortPress = Reset;
        }
        public override void Stop()
        {
            StopatchTimer.Stop();
        }
        private void StopStopwatch()
        {
            clock.ChangeState(StopwatchStates.StateStopwatchOff);
        }
        private void Reset()
        {
            clock.Minutes = 0;
            clock.Seconds = 0;
        }         
    }
}
