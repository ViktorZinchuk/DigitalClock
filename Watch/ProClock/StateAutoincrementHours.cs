using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace ProClock
{
    class StateAutoincrementHours : AbstractStateAutoincrement
    {
        public StateAutoincrementHours(ProfessionalClock cl)
            : base(cl)
        { }
        protected override void AutoIncrement(object source, ElapsedEventArgs e)
        {
            proClock.clock.Hours++;
            if (proClock.clock.Hours > 23)
            {
                proClock.clock.Hours = 0;
            }
        }
        protected override void StopAutoincrement()
        {
            proClock.ChangeState(ProClockStates.StateEditHours);
        }
    }
}
