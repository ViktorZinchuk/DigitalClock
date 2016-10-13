using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace DigitalClock
{
    public class Clock
    {
        public event Action ClockValueChanged;
        private int hours;
        private int minutes;
        private int seconds;
        private bool separator;
        public int Hours
        {
            get { return hours; }
            set
            {
                if (hours != value)
                {
                    hours = value;
                    if (ClockValueChanged != null)
                        ClockValueChanged();
                }
            }
        }
        public int Minutes
        {
            get { return minutes; }
            set
            {
                if (minutes != value)
                {
                    minutes = value;
                    if (ClockValueChanged != null)
                        ClockValueChanged();
                }
            }
        }
        public int Seconds
        {
            get { return seconds; }
            set
            {
                if (seconds != value)
                {

                    seconds = value;
                    if (ClockValueChanged != null)
                        ClockValueChanged();
                }
            }
        }
        public bool Separator
        {
            get { return separator; }
            set
            {
                if (separator != value)
                {
                    separator = value;
                    if (ClockValueChanged != null)
                        ClockValueChanged();
                }
            }
        }
        private Timer timer;
        private static Clock instance;
        private Clock()
        {
            hours = 0;
            minutes = 0;
            seconds = 0;
            separator = false;
            timer = new Timer(500);
            timer.Elapsed += new ElapsedEventHandler(ChangeTime);
            timer.Start();
        }
        public static Clock Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new Clock();
                }
                return instance;
            }
        }
        private void ChangeTime(object source, ElapsedEventArgs e)
        {
            Separator = !Separator;
            if (Separator)
            {
                Seconds++;
                if (Seconds > 59)
                {
                    Seconds = 0;
                    Minutes++;
                }
                if (Minutes > 59)
                {
                    Minutes = 0;
                    Hours++;
                }
                if (Hours > 23)
                {
                    Hours = 0;
                }
            }
        }
        public void TimerStart()
        {
            timer.Start();
        }
        public void TimerStop()
        {
            timer.Stop();
        }
    }
}