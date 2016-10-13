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
    public partial class DisplayTimer : UserControl
    {
        private ITimer clock;
        private ILightBulb bulb;
        public DisplayTimer()
        {
            InitializeComponent();
        }
        public void ConnectDisplay(ITimer cl, ILightBulb b)
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
                    PositionM.Visible = clock.Position1_visible;
                    PositionM.Text = clock.Minutes.ToString("D2");
                    PositionSec.Text = clock.Seconds.ToString("D2");
                    PositionSec.Visible = clock.Position2_visible;
                }
                else
                {
                    this.Visible = false;
                }
            }
        }
    }
}
