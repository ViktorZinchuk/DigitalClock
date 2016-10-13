using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace StopwatchLib
{
    abstract class AbstractState
    {
        abstract public void Start();
        abstract public void Stop();
    }
}
