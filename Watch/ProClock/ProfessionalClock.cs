using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WatchButton;
using DigitalClock;
using WatchInterfaces;

namespace ProClock
{
    public enum ProClockStates
    {
        StateDisplayHM_Sec,
        StateEditHours,
        StateEditMinutes,
        StateAutoincrementH,
        StateAutoincrementM,
        StateEditPmAm
    };
    public class ProfessionalClock : IProClock,IWatchDevice
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
        private bool positionPm_visible;
        public bool PositionPm_visible
        {
            get { return positionPm_visible; }
            set
            {
                if (positionPm_visible != value)
                {
                    positionPm_visible = value;
                    if (ValueChanged != null)
                        ValueChanged();
                }
            }
        }
        public bool PM
        {
            get { return clock.Hours>11 ? true : false; }
            set
            {
                if (PM != value)
                {
                    clock.Hours += 12;
                    clock.Hours %= 24;
                    if (ValueChanged != null)
                        ValueChanged();
                }
            }
        }
        public int Hours
        {
            get
            {
                if(clock.Hours==0)
                {
                    return 12;
                }
                else
                {
                    return clock.Hours >12 ? clock.Hours % 12 : clock.Hours;
                }            
            }
        }
        public int Minutes
        {
            get { return clock.Minutes; }
        }
        public int Seconds
        {
            get { return clock.Seconds; }
        }
        private AbstractState currentState;
        private Dictionary<ProClockStates, AbstractState> states;
        public Button FunctionalButton { get; set; }
        public Button SettingsButton { get; set; }

        private void ClockValueChanged()
        {
            if (ValueChanged != null)
                ValueChanged();
        }
        public ProfessionalClock(Button functional, Button settings)
        {
            clock = Clock.Instance;
            Position1_visible = true;
            Position2_visible = true;
            PositionPm_visible = true;
            FunctionalButton = functional;
            SettingsButton = settings;
            states = new Dictionary<ProClockStates, AbstractState>();
            states.Add(ProClockStates.StateDisplayHM_Sec, new StateDisplayProClock(this));
            states.Add(ProClockStates.StateEditHours, new StateEditHours(this));
            states.Add(ProClockStates.StateEditMinutes, new StateEditMinutes(this));
            states.Add(ProClockStates.StateAutoincrementH, new StateAutoincrementHours(this));
            states.Add(ProClockStates.StateAutoincrementM, new StateAutoincrementMinutes(this));
            states.Add(ProClockStates.StateEditPmAm, new StateEditPmAm(this));
        }
        public void ChangeState(ProClockStates changestate)
        {
            currentState.Stop();
            currentState = states[changestate];
            currentState.Start();
        }
        public void Start()
        {
            On = true;
            clock.ClockValueChanged += ClockValueChanged;
            currentState = states[ProClockStates.StateDisplayHM_Sec];
            currentState.Start();
        }
        public void Stop()
        {
            On = false;
            clock.ClockValueChanged -= ClockValueChanged;
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
