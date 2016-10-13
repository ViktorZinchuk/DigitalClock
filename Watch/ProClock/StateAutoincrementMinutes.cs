using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace ProClock
{
    class StateAutoincrementMinutes : AbstractStateAutoincrement
    {
        public StateAutoincrementMinutes(ProfessionalClock cl)
            : base(cl)
        { }
        protected override void AutoIncrement(object source, ElapsedEventArgs e)
        {
            proClock.clock.Minutes++;
            if (proClock.clock.Minutes > 59)
            {
                proClock.clock.Minutes = 0;
            }
        }
        protected override void StopAutoincrement()
        {
            proClock.ChangeState(ProClockStates.StateEditMinutes);
        }
    }
}