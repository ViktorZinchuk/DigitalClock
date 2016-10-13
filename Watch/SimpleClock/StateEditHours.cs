using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace SimpleClock
{
    class StateEditHours : AbstractStateEditeTime
    {
        public StateEditHours(Simpleclock cl)
            : base(cl)
        { }
        protected override void BlinkPosition(object source, ElapsedEventArgs e)
        {
            simpleclock.Position1_visible = !simpleclock.Position1_visible;
        }
        protected override void Increment()
        {
            simpleclock.clock.Hours++;
            if (simpleclock.clock.Hours > 23)
            {
                simpleclock.clock.Hours = 0;
            }
        }
        protected override void StartAutoincrement()
        {
            simpleclock.ChangeState(SimpleClockStates.StateAutoincrementH);
        }
        protected override void SwitchEditTime()
        {
            simpleclock.ChangeState(SimpleClockStates.StateEditMinutes);
        }
    }
}
