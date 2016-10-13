using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WatchButton;
using WatchInterfaces;
using SimpleClock;
using DigitalClock;
using DigitalWatch;

namespace WindowsFormsWatch
{
    public partial class DigitalWatch : Form
    {
        public Watch watch;
        public DigitalWatch()
        {
            InitializeComponent();
            watch = WatchBuilder.Build(ConnectDisplayableDevice);
            watch.Run();                     
        }
      
        public void ConnectDisplayableDevice(IDisplayableDevice device, ILightBulb w)
        {
            if(device is ISimpleClock)
            {
                displaySimpleClock1.ConnectDisplay((ISimpleClock)device, w); 
            }
            else if(device is IProClock)
            {
                displayProClock1.ConnectDisplay((IProClock)device, w);
            }
            else if (device is IStopwatch)
            {
                displayStopwatch1.ConnectDisplay((IStopwatch)device, w);
            }
            else if (device is ITimer)
            {
                displayTimer1.ConnectDisplay((ITimer)device, w);
            }
        }

        private void Functional_Button_MouseDown(object sender, MouseEventArgs e)
        {
            watch.FunctionalButton.KeyDown();
        }
        private void Functional_Button_MouseUp(object sender, MouseEventArgs e)
        {
            watch.FunctionalButton.KeyUp();
        }

        private void SettingButton_MouseDown(object sender, MouseEventArgs e)
        {
            watch.SettingsButton.KeyDown();
        }
        private void SettingButton_MouseUp(object sender, MouseEventArgs e)
        {
            watch.SettingsButton.KeyUp();
        }

        private void ModeButton_MouseDown(object sender, MouseEventArgs e)
        {
            watch.ModeButton.KeyDown();
        }
        private void ModeButton_MouseUp(object sender, MouseEventArgs e)
        {
            watch.ModeButton.KeyUp();
        }

        private void BacklightButton_MouseDown(object sender, MouseEventArgs e)
        {
            watch.BackLightButton.KeyDown();
        }
        private void BacklightButton_MouseUp(object sender, MouseEventArgs e)
        {
            watch.BackLightButton.KeyUp();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.NumPad7)
            {
                watch.ModeButton.KeyDown(); 
            }
            else if (e.KeyCode == Keys.NumPad1)
            {
                watch.BackLightButton.KeyDown();
            }
            else if (e.KeyCode == Keys.NumPad9)
            {
                watch.SettingsButton.KeyDown();
            }
            else if (e.KeyCode == Keys.NumPad3)
            {
                watch.FunctionalButton.KeyDown();
            }
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.NumPad7)
            {
                watch.ModeButton.KeyUp();
            }
            else if (e.KeyCode == Keys.NumPad1)
            {
                watch.BackLightButton.KeyUp();
            }
            else if (e.KeyCode == Keys.NumPad9)
            {
                watch.SettingsButton.KeyUp();
            }
            else if (e.KeyCode == Keys.NumPad3)
            {
                watch.FunctionalButton.KeyUp();
            }
        }  
    }
}
