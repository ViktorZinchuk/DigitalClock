using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WatchInterfaces;
using DigitalWatch;
using SimpleClock;
using System.Windows;
using System.Windows.Media;
using System.Windows.Controls;

namespace WpfWatch.ViewModels
{
    public class ViewModelSimpleClock : ViewModelBase
    {
        private ISimpleClock clock;
        private ILightBulb bulb;
        private string position1;
        private string position2;
        private Visibility position1_visible;
        private Visibility position2_visible;
        private Visibility displayON;
        private Visibility separator;
       
        public ViewModelSimpleClock(ISimpleClock cl, ILightBulb b)
        {
            clock = cl;
            bulb = b;
            clock.ValueChanged += UpdateDisplay;
        }
        public void UpdateDisplay()
        {
            DisplayON = clock.On ? Visibility.Visible : Visibility.Hidden;
            if (clock.On)
            {
                if (!clock.DisplaySeconds)
                {
                    Position1_visible = clock.Position1_visible ? Visibility.Visible : Visibility.Hidden;
                    Position2_visible = clock.Position2_visible ? Visibility.Visible : Visibility.Hidden;
                    Separator = clock.Separator ? Visibility.Visible : Visibility.Hidden;

                    Position1 = clock.Hours.ToString("D2");
                    Position2 = clock.Minutes.ToString("D2");
                }
                else
                {
                    Position1 = clock.Seconds.ToString("D2");
                    Position2_visible = System.Windows.Visibility.Hidden;
                    Separator = Visibility.Hidden; 
                }
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
                if(position1 !=value)
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
        public Visibility Separator
        {
            get
            {
                return separator;
            }
            private set
            {
                if (separator != value)
                {
                    separator = value;
                    OnPropertyChanged("Separator");
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
