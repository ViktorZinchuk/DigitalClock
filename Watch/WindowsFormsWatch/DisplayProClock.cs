using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WatchInterfaces;

namespace WindowsFormsWatch
{
    public partial class DisplayProClock : UserControl
    {
        private IProClock clock;
        private ILightBulb bulb;
        public DisplayProClock()
        {
            InitializeComponent();     
        }
        public void ConnectDisplay(IProClock cl, ILightBulb b)
        {
            clock = cl;
            clock.ValueChanged += UpdateDisplay;
            bulb = b;
            bulb.BacklightChanged += Backlight;
            this.Visible = clock.On;
        }
        public void Backlight()
        {
            this.BackColor = bulb.Backlight ? Color.DarkBlue : Color.Black;
        }
        public void UpdateDisplay()
        {
            if (this.InvokeRequired)
            {
                this.Invoke(new Action(UpdateDisplay));
            }
            else
            {
                if (clock.On)
                {
                    this.Visible = true;
                    PositionH.Visible = clock.Position1_visible;
                    PositionH.Text = clock.Hours.ToString("D2");
                    PositionSeparator.Visible = true;
                    PositionM.Visible = clock.Position2_visible;
                    PositionM.Text = clock.Minutes.ToString("D2");
                    PositionSeconds.Text = clock.Seconds.ToString("D2");
                    AmPm.Visible = clock.PositionPm_visible;
                    AmPm.Text = clock.PM ? "pm" : "am";
                }
                else
                {
                    this.Visible = false;
                }
            }
        }
    }
}
