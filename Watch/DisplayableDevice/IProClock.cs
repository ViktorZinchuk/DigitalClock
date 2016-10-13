using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WatchInterfaces
{
    public interface IProClock : IDisplayableDevice
    {
        bool On { get; }
        int Hours { get; }
        int Minutes { get; }
        int Seconds { get; }
        bool PositionPm_visible { get; }
        bool Position1_visible { get; }
        bool Position2_visible { get; }
        event Action ValueChanged;
        bool PM { get; }
    }
}
