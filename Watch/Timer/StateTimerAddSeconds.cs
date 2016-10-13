using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace WatchTimer
{
    class StateTimerAddSeconds : StateAddTime
    {
        public StateTimerAddSeconds(ClockTimer cl) : base(cl)
        {
        }
        protected override void BlinkPosition(object source, ElapsedEventArgs e)
        {
            clock.Position2_visible = !clock.Position2_visible;
        }
        protected override void SwitchTime()
        {
            clock.ChangeState(TimerStates.StateTimerAddMinutes);
        }
        protected override void AddTime()
        {
            clock.Seconds++; 
        }
    }
}
