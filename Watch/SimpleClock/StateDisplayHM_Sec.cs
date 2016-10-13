using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleClock
{
    class StateDisplayHM_Sec : AbstractState
    {
        public StateDisplayHM_Sec(Simpleclock cl)
            : base(cl)
        {
        }
        public override void Start()
        {
            simpleclock.Position1_visible = true;
            simpleclock.Position2_visible = true;
            simpleclock.FunctionalButton.Strategy.Press = ConnectDisplaySec;
            simpleclock.FunctionalButton.Strategy.Release = ConnectDisplayHM;
            simpleclock.FunctionalButton.Strategy.LongPress = null;
            simpleclock.FunctionalButton.Strategy.ShortPress = null;
            simpleclock.SettingsButton.Strategy.Press = null;
            simpleclock.SettingsButton.Strategy.Release = null;
            simpleclock.SettingsButton.Strategy.LongPress = StartSettingMode;
            simpleclock.SettingsButton.Strategy.ShortPress = null;
        }
        public override void Stop()
        {
        }
       
        private void ConnectDisplaySec()
        {
            simpleclock.DisplaySeconds = true;
        }
        private void ConnectDisplayHM()
        {
            simpleclock.DisplaySeconds = false;
        }
        private void StartSettingMode()
        {
            simpleclock.ChangeState(SimpleClockStates.StateEditHours);
        }
    }
}
