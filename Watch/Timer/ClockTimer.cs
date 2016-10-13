using WatchInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using WatchButton;
using WatchInterfaces;

namespace WatchTimer
{
    public enum TimerStates 
    { 
        StateTimerOff,  
        StateTimerON,
        StateTimerEnd,
        StateTimerAddMinutes,
        StateTimerAddSeconds,
        StateTimerStop
    };
    public class ClockTimer : ITimer, IWatchDevice
    {
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
                if (minutes > 59)
                {
                    minutes = 0;
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
                    if (value < 0)
                    {
                        value = 59;
                        Minutes--;
                    }
                    seconds = value;
                    if (ValueChanged != null)
                        ValueChanged();
                    if (seconds > 59)
                    {
                        seconds = 0;
                    }
                }
            }
        }
        private AbstractState currentState;
        private Dictionary<TimerStates, AbstractState> states;
        public Button FunctionalButton { get; set; }
        public Button SettingsButton { get; set; }

        public ClockTimer(Button functional, Button settings)
        {
            Position1_visible = false;
            Position2_visible = false;
            Minutes = 0;
            Seconds = 0;
            currentState = null;
            FunctionalButton = functional;
            SettingsButton = settings;
            states = new Dictionary<TimerStates, AbstractState>();
            states.Add(TimerStates.StateTimerOff, new StateTimerOff(this));
            states.Add(TimerStates.StateTimerON, new StateTimerOn(this));
            states.Add(TimerStates.StateTimerEnd, new StateTimerEnd(this));
            states.Add(TimerStates.StateTimerAddSeconds, new StateTimerAddSeconds(this));
            states.Add(TimerStates.StateTimerAddMinutes, new StateTimerAddMinutes(this));
            states.Add(TimerStates.StateTimerStop, new StateTimerStop(this));
        }
        public void ChangeState(TimerStates changestate)
        {
            currentState.Stop();
            currentState = states[changestate];
            currentState.Start();           
        }
        public void Start()
        {
            On = true;
            currentState = states[TimerStates.StateTimerOff];
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
