using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WatchButton
{
    public class ButtonStrategy
    {
        public Action Press;
        public Action LongPress;
        public Action ShortPress;
        public Action Release;
    }
}