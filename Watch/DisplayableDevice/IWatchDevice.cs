using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WatchInterfaces
{
    public interface IWatchDevice : IDisplayableDevice
    {
        void Start();
        void Stop();
    }
}
