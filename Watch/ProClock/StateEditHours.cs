using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace ProClock
{
    class StateEditHours : AbstractStateEditTime
    {
        public StateEditHours(ProfessionalClock cl)
            : base(cl)
        { }
        protected override void BlinkPosition(object source, ElapsedEventArgs e)
        {
            proClock.Position1_visible = !proClock.Position1_visible;
        }
        protected override void Increment()
        {
            proClock.clock.Hours++;
            if (proClock.clock.Hours > 23)
            {
                proClock.clock.Hours = 0;
            }   
        }
        protected override void StartAutoincrement()
        {
            proClock.ChangeState(ProClockStates.StateAutoincrementH);
        }
        protected override void SwitchEditTime()
        {
            proClock.ChangeState(ProClockStates.StateEditMinutes);
        }
    }
}
