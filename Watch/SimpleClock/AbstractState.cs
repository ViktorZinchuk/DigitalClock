using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleClock
{
    abstract class AbstractState
    {  
        protected Simpleclock simpleclock;
        abstract public void Start();
        abstract public void Stop();
        public AbstractState(Simpleclock cl)
        {
            simpleclock = cl;
        }
    }
}
