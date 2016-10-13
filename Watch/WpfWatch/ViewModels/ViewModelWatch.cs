using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DigitalWatch;
using WatchInterfaces;
using System.ComponentModel;
using System.Windows;
using System.Windows.Controls.Primitives;
using System.Windows.Media;

namespace WpfWatch.ViewModels
{
    public class ViewModelWatch : ViewModelBase
    {
        public Watch watch { get; private set; }
        public ViewModelSimpleClock VMSimpleClock { get; private set; }
        public ViewModelProClock VMProClock { get; private set; }
        public ViewModelStopwatch VMStopwatch { get; private set; }
        public ViewModelTimer VMTimer { get; private set; }
        private void ConnectDispalayableDevice(IDisplayableDevice device, ILightBulb bulb)
        {
            if (device is ISimpleClock)
            {
                VMSimpleClock = new ViewModelSimpleClock((ISimpleClock)device, bulb);
            }
            else if (device is IProClock)
            {
                VMProClock = new ViewModelProClock((IProClock)device, bulb);
            }
            else if (device is IStopwatch)
            {
                VMStopwatch = new ViewModelStopwatch((IStopwatch)device, bulb);
            }
            else
            {
                VMTimer = new ViewModelTimer((ITimer)device, bulb);
            }
        }
        public ViewModelWatch()
        {
            watch = WatchBuilder.Build(ConnectDispalayableDevice);
            watch.Run();
            ModeButtonKeyDown = new RelayCommand(() => { watch.ModeButton.KeyDown(); });
            ModeButtonKeyUp = new RelayCommand(() => { watch.ModeButton.KeyUp(); });
            SettingsButtonKeyDown = new RelayCommand(() => { watch.SettingsButton.KeyDown(); });
            SettingsButtonKeyUp = new RelayCommand(() => { watch.SettingsButton.KeyUp(); });
            FunctionalButtonKeyDown = new RelayCommand(() => { watch.FunctionalButton.KeyDown(); });
            FunctionalButtonKeyUp = new RelayCommand(() => { watch.FunctionalButton.KeyUp(); });
            BacklightButtonKeyDown = new RelayCommand(() => { watch.BackLightButton.KeyDown(); });
            BacklightButtonKeyUp = new RelayCommand(() => { watch.BackLightButton.KeyUp(); });
            watch.BacklightChanged += BackLightChange;
        }
        private bool backlight;
        public bool Backlight
        {
            get { return backlight; }
            set
            {
                if (backlight != value)
                {
                    backlight = value;
                    OnPropertyChanged("Backlight");
                }
            }
        }
        public void BackLightChange()
        {
            Backlight = watch.Backlight;
        }
        public RelayCommand ModeButtonKeyDown { get; private set; }
        public RelayCommand ModeButtonKeyUp { get; private set; }
        public RelayCommand SettingsButtonKeyDown { get; private set; }
        public RelayCommand SettingsButtonKeyUp { get; private set; }
        public RelayCommand FunctionalButtonKeyDown { get; private set; }
        public RelayCommand FunctionalButtonKeyUp { get; private set; }
        public RelayCommand BacklightButtonKeyDown { get; private set; }
        public RelayCommand BacklightButtonKeyUp { get; private set;}
    }
}
