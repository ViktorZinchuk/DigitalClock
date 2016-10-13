using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WatchInterfaces
{
    public interface ILightBulb
    {
        event Action BacklightChanged;
        bool Backlight { get; } 
    }
}
