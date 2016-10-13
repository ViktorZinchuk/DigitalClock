using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace ProClock
{
    class StateEditMinutes : AbstractStateEditTime
    {
        public StateEditMinutes(ProfessionalClock cl)
            : base(cl)
        { }
        protected override void BlinkPosition(object source, ElapsedEventArgs e)
        {
            proClock.Position2_visible = !proClock.Position2_visible;
        }
        protected override void Increment()
        {
            proClock.clock.Minutes++;
            if (proClock.clock.Minutes > 59)
            {
                proClock.clock.Minutes = 0;
            }
        }
        protected override void StartAutoincrement()
        {
            proClock.ChangeState(ProClockStates.StateAutoincrementM);
        }
        protected override void SwitchEditTime()
        {
            proClock.ChangeState(ProClockStates.StateEditPmAm);
        }
    }
}
