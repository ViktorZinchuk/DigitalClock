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
    public partial class DisplaySimpleClock : UserControl
    {
        ISimpleClock clock;
        ILightBulb bulb;
        public DisplaySimpleClock()
        {
            InitializeComponent();
        }
        public void ConnectDisplay(ISimpleClock cl, ILightBulb b)
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
            if(this.InvokeRequired)
            {
                this.Invoke(new Action(UpdateDisplay));
            }
            else
            {
                if (clock.On)
                {
                    this.Visible = true;
                    if (!clock.DisplaySeconds)
                    {
                        PositionH.Visible = clock.Position1_visible;
                        PositionH.Text = clock.Hours.ToString("D2");

                        PositionSeparator.Visible = clock.Separator;

                        PositionM.Visible = clock.Position2_visible;
                        PositionM.Text = clock.Minutes.ToString("D2");
                    }
                    else
                    {
                        PositionH.Text = clock.Seconds.ToString("D2");
                        PositionSeparator.Visible=false;
                        PositionM.Visible=false;
                    }
                }
                else
                {
                    this.Visible = false;
                }   
            }
        }
    }
}
