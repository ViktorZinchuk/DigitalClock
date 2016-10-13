using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media;
using WatchInterfaces;

namespace WpfWatch.ViewModels
{
    public class ViewModelProClock : ViewModelBase
    {
        private IProClock clock;
        private ILightBulb bulb;
        private string position1;
        private string position2;
        private string position3;
        private Visibility position1_visible;
        private Visibility position2_visible;
        private Visibility position_visiblePmAm;
        private Visibility displayON;
        private string pm;
        public ViewModelProClock(IProClock cl, ILightBulb b)
        {
            clock = cl;
            bulb = b;
            clock.ValueChanged += UpdateDisplay;
            DisplayON = Visibility.Hidden;
        }
        public void UpdateDisplay()
        {
            DisplayON = clock.On ? Visibility.Visible : Visibility.Hidden;
            if (clock.On)
            {
                Position1_visible = clock.Position1_visible ? Visibility.Visible : Visibility.Hidden;
                Position2_visible = clock.Position2_visible ? Visibility.Visible : Visibility.Hidden;
                Position_visiblePMAM = clock.PositionPm_visible ? Visibility.Visible : Visibility.Hidden;
                PM = clock.PM ? "pm" : "am ";
                Position1 = clock.Hours.ToString("D2");
                Position2 = clock.Minutes.ToString("D2");
                Position3 = clock.Seconds.ToString("D2");
            }
        }
        public string Position1
        {
            get
            {
                return position1;
            }
            private set
            {
                if (position1 != value)
                {
                    position1 = value;
                    OnPropertyChanged("Position1");
                }
            }
        }
        public string Position2
        {
            get
            {
                return position2;
            }
            private set
            {
                if (position2 != value)
                {
                    position2 = value;
                    OnPropertyChanged("Position2");
                }
            }
        }
        public string Position3
        {
            get
            {
                return position3;
            }
            private set
            {
                if (position3 != value)
                {
                    position3 = value;
                    OnPropertyChanged("Position3");
                }
            }
        }
        public string PM
        {
            get
            {
                return pm;
            }
            private set
            {
                if (pm != value)
                {
                    pm = value;
                    OnPropertyChanged("PM");
                }
            }
        }
        public Visibility Position1_visible
        {
            get
            {
                return position1_visible;
            }
            private set
            {
                if (position1_visible != value)
                {
                    position1_visible = value;
                    OnPropertyChanged("Position1_visible");
                }
            }
        }
        public Visibility Position2_visible
        {
            get
            {
                return position2_visible;
            }
            private set
            {
                if (position2_visible != value)
                {
                    position2_visible = value;
                    OnPropertyChanged("Position2_visible");
                }
            }
        }
        public Visibility Position_visiblePMAM
        {
            get
            {
                return position_visiblePmAm;
            }
            private set
            {
                if (position_visiblePmAm != value)
                {
                    position_visiblePmAm = value;
                    OnPropertyChanged("Position_visiblePMAM");
                }
            }
        }
        public Visibility DisplayON
        {
            get
            {
                return displayON;
            }
            private set
            {
                if (displayON != value)
                {
                    displayON = value;
                    OnPropertyChanged("DisplayON");
                }
            }
        }
    }
}