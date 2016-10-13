using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WatchInterfaces
{
    public interface IStopwatch : IDisplayableDevice
    {
        int Minutes { get; set; }
        int Seconds { get; set; }
        bool Position1_visible { get; set; }
        bool Position2_visible { get; set; }
        event Action ValueChanged;
        bool On { get; }
    }
}
