using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace ProClock
{
    class StateEditPmAm : AbstractState
    {
        private Timer blinktimer;
        public StateEditPmAm(ProfessionalClock cl)
            : base(cl)
        {
            blinktimer = new Timer(500);
            blinktimer.Elapsed += new ElapsedEventHandler(BlinkPosition);
        }
        private void BlinkPosition(object source, ElapsedEventArgs e)
        {
            proClock.PositionPm_visible = !proClock.PositionPm_visible;
        }
        private void SwitchPaAm()
        {
            proClock.PM = !proClock.PM;   
        }
        protected void SwitchEditTime()
        {
            proClock.ChangeState(ProClockStates.StateEditHours);
        }
        private void StopSettingMode()
        {
            proClock.ChangeState(ProClockStates.StateDisplayHM_Sec);
        }
        public override void Start()
        {
            blinktimer.Start();
            proClock.Position1_visible = true;
            proClock.Position2_visible = true;
            proClock.PositionPm_visible = true;
            proClock.FunctionalButton.Strategy.Press = null;
            proClock.FunctionalButton.Strategy.Release = null;
            proClock.FunctionalButton.Strategy.LongPress = null;
            proClock.FunctionalButton.Strategy.ShortPress = SwitchPaAm;
            proClock.SettingsButton.Strategy.Press = null;
            proClock.SettingsButton.Strategy.Release = null;
            proClock.SettingsButton.Strategy.LongPress = StopSettingMode;
            proClock.SettingsButton.Strategy.ShortPress = SwitchEditTime;
            proClock.clock.TimerStop();
        }
        public override void Stop()
        {
            blinktimer.Stop();
            proClock.clock.TimerStart();
            proClock.PositionPm_visible = true;
        }
    }
}