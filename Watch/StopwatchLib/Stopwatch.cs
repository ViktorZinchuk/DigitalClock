using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using WatchButton;
using WatchInterfaces;

namespace StopwatchLib
{
    public enum StopwatchStates 
    { 
        StateStopwatchOff,  
        StateStopwatchON
    };
    public class Stopwatch : IStopwatch, IWatchDevice
    {
        public event Action ValueChanged;
        private int minutes;
        public int Minutes
        {
            get { return minutes; }
            set
            {
                if (minutes != value)
                {
                    minutes = value;
                    if (ValueChanged != null)
                        ValueChanged();
                }
            }
        }
        private int seconds;
        public int Seconds
        {
            get { return seconds; }
            set
            {
                if (seconds != value)
                {
                    if (value > 59)
                    {
                        value = 0;
                        Minutes++;
                    }
                    seconds = value;
                    if (ValueChanged != null)
                        ValueChanged();
                }
            }
        }

        private bool position1_visible;
        public bool Position1_visible
        {
            get { return position1_visible; }
            set
            {
                if (position1_visible != value)
                {
                    position1_visible = value;
                    if (ValueChanged != null)
                        ValueChanged();
                }
            }
        }
        private bool position2_visible;
        public bool Position2_visible
        {
            get { return position2_visible; }
            set
            {
                if (position2_visible != value)
                {
                    position2_visible = value;
                    if (ValueChanged != null)
                        ValueChanged();
                }
            }
        }
        private AbstractState currentState;
        private Dictionary<StopwatchStates, AbstractState> states;
        public Button FunctionalButton { get; set; }
        public Button SettingsButton { get; set; }

        public Stopwatch(Button functional, Button settings)
        {
            Position1_visible = true;
            Position2_visible = true;
            Minutes = 0;
            Seconds = 0;
            currentState = null;
            FunctionalButton = functional;
            SettingsButton = settings;
            states = new Dictionary<StopwatchStates, AbstractState>();
            states.Add(StopwatchStates.StateStopwatchOff, new StateStopwatchOff(this));
            states.Add(StopwatchStates.StateStopwatchON, new StartStopwatch(this));
        }
        public void ChangeState(StopwatchStates changestate)
        {
            currentState.Stop();
            currentState = states[changestate];
            currentState.Start();           
        }
        public void Start()
        {
            Seconds = 0;
            Minutes = 0;
            On = true;
            currentState = states[StopwatchStates.StateStopwatchOff];
            currentState.Start();
        }
        public void Stop()
        {
            On = false;
            currentState.Stop();
        }
        private bool on;
        public bool On
        {
            get { return on; }
            set
            {
                if (on != value)
                {
                    on = value;
                    if (ValueChanged != null)
                        ValueChanged();
                }
            }
        }
    }
}
