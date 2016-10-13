using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace SimpleClock
{
    class StateAutoincrementHours : AbstractStateAutoincrement
    {
        public StateAutoincrementHours(Simpleclock cl)
            : base(cl)
        { }
        protected override void AutoIncrement(object source, ElapsedEventArgs e)
        {
            simpleclock.clock.Hours += 1;
            if (simpleclock.clock.Hours > 23)
            {
                simpleclock.clock.Hours = 0;
            }          
        }
        protected override void StopAutoincrement()
        {
            simpleclock.ChangeState(SimpleClockStates.StateEditHours);
        }
    }
}
