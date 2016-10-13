using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace WatchTimer
{
    class StateTimerAddMinutes : StateAddTime
    {
        public StateTimerAddMinutes(ClockTimer cl)
            : base(cl)
        { }
        protected override void BlinkPosition(object source, ElapsedEventArgs e)
        {
            clock.Position1_visible = !clock.Position1_visible;
        }
        protected override void AddTime()
        {
            clock.Minutes++;
        }
        protected override void SwitchTime()
        {
            clock.ChangeState(TimerStates.StateTimerAddSeconds);
        }
    }
}
