using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProClock
{
    abstract class AbstractState
    {
        protected ProfessionalClock proClock;
        abstract public void Start();
        abstract public void Stop();
        public AbstractState(ProfessionalClock cl)
        {
            proClock = cl;
        }
    }
}