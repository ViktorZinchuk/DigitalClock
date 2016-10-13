using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace SimpleClock
{
    class StateEditMinutes : AbstractStateEditeTime
    {
        public StateEditMinutes(Simpleclock cl)
            : base(cl)
        { }
        protected override void BlinkPosition(object source, ElapsedEventArgs e)
        {
            simpleclock.Position2_visible = !simpleclock.Position2_visible;
        }
        protected override void Increment()
        {
            simpleclock.clock.Minutes++;
            if (simpleclock.clock.Minutes > 59)
            {
                simpleclock.clock.Minutes = 0;
            }
        }
        protected override void StartAutoincrement()
        {
            simpleclock.ChangeState(SimpleClockStates.StateAutoincrementM);
        }
        protected override void SwitchEditTime()
        {
            simpleclock.ChangeState(SimpleClockStates.StateEditHours);
        }
         
    }
}