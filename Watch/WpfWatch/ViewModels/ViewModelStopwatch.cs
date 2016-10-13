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
    public class ViewModelStopwatch : ViewModelBase
    {
        private IStopwatch clock;
        private ILightBulb bulb;
        private string position1;
        private string position2;
        private Visibility position1_visible;
        private Visibility position2_visible;
        private Visibility displayON;
        public ViewModelStopwatch(IStopwatch cl, ILightBulb b)
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

                Position1 = clock.Minutes.ToString("D2");
                Position2 = clock.Seconds.ToString("D2");
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
