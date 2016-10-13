using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace SimpleClock
{
    class StateAutoincrementMinutes : AbstractStateAutoincrement
    {
        public StateAutoincrementMinutes(Simpleclock cl)
            : base(cl)
        { }
        protected override void AutoIncrement(object source, ElapsedEventArgs e)
        {
            simpleclock.clock.Minutes += 1;
            if (simpleclock.clock.Minutes > 59)
            {
                simpleclock.clock.Minutes = 0;
            }
        }
        protected override void StopAutoincrement()
        {
            simpleclock.ChangeState(SimpleClockStates.StateEditMinutes);
        }
    }
}
