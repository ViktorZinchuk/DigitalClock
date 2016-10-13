using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WatchButton;
using DigitalClock;
using WatchInterfaces;

namespace SimpleClock
{
    public enum SimpleClockStates
    {
        StateDisplayHM_Sec,
        StateEditHours,
        StateEditMinutes,
        StateAutoincrementH,
        StateAutoincrementM
    };
    public class Simpleclock : ISimpleClock, IWatchDevice
    {
        public Clock clock;
        public event Action ValueChanged;
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
        public bool Separator
        {
            get { return clock.Separator; }
        }
        public int Hours
        {
            get { return clock.Hours; }
        }
        public int Minutes
        {
            get { return clock.Minutes; }
        }
        public int Seconds
        {
            get { return clock.Seconds; }

        }
        private bool displaySeconds;
        public bool DisplaySeconds
        {
            get { return displaySeconds; }
            set
            {
                if (displaySeconds != value)
                {
                    displaySeconds = value;
                    if (ValueChanged != null)
                        ValueChanged();
                }
            }
        }
        private AbstractState currentState;
        private Dictionary<SimpleClockStates, AbstractState> states;
        public Button FunctionalButton { get; set; }
        public Button SettingsButton { get; set; }
        private void ClockValueChanged()
        {
            if (ValueChanged != null)
                ValueChanged();
        }
        public Simpleclock(Button functional, Button settings)
        {
            clock = Clock.Instance;
            Position1_visible = true;
            Position2_visible = true;
            FunctionalButton = functional;
            SettingsButton = settings;
            states = new Dictionary<SimpleClockStates, AbstractState>();
            states.Add(SimpleClockStates.StateDisplayHM_Sec, new StateDisplayHM_Sec(this));
            states.Add(SimpleClockStates.StateEditHours, new StateEditHours(this));
            states.Add(SimpleClockStates.StateEditMinutes, new StateEditMinutes(this));
            states.Add(SimpleClockStates.StateAutoincrementH, new StateAutoincrementHours(this));
            states.Add(SimpleClockStates.StateAutoincrementM, new StateAutoincrementMinutes(this));
        }
        public void ChangeState(SimpleClockStates changestate)
        {
            currentState.Stop();
            currentState = states[changestate];
            currentState.Start();
        }
        public void Start()
        {
            On = true;
            clock.ClockValueChanged += ClockValueChanged;
            currentState = states[SimpleClockStates.StateDisplayHM_Sec];
            currentState.Start();
        }
        public void Stop()
        {
            On = false;
            clock.ClockValueChanged += ClockValueChanged;
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
