using StretchApp.src.models;
using StretchApp.src.services;

namespace StretchApp.src.controllers
{
    public class SessionController
    {
        private readonly System.Windows.Forms.Timer _timer;
        private readonly SessionService _service;

        public TimeSpan RemainingTime { get; private set; }
        public SessionType CurrentSessionType { get; private set; }

        public event Action<TimeSpan> Tick;
        public event Action<SessionType> SessionChanged;

        private int _focusDuration = 25;

        public SessionController()
        {
            _service = new SessionService();

            CurrentSessionType = SessionType.Focus;
            RemainingTime = TimeSpan.FromMinutes(_focusDuration);

            _timer = new System.Windows.Forms.Timer();
            _timer.Interval = 1000;
            _timer.Tick += OnTick;
        }

        public void Start()
        {
            _service.StartSession(CurrentSessionType, (int)RemainingTime.TotalMinutes);
            _timer.Start();
        }

        public void Reset()
        {
            _timer.Stop();

            RemainingTime = CurrentSessionType == SessionType.Focus
                ? TimeSpan.FromMinutes(_focusDuration)
                : TimeSpan.FromMinutes(5);

            Tick?.Invoke(RemainingTime);

            _timer.Start();
        }

        public void SetFocusDuration(int minutes)
        {
            _focusDuration = minutes;
            RemainingTime = TimeSpan.FromMinutes(minutes);

            Tick?.Invoke(RemainingTime);
        }

        private void OnTick(object sender, EventArgs e)
        {
            RemainingTime = RemainingTime.Subtract(TimeSpan.FromSeconds(1));

            Tick?.Invoke(RemainingTime);

            if (RemainingTime <= TimeSpan.Zero)
            {
                _timer.Stop();

                _service.CompleteCurrentSession();

                SwitchSession();
            }
        }

        private void SwitchSession()
        {
            CurrentSessionType = CurrentSessionType == SessionType.Focus
                ? SessionType.Break
                : SessionType.Focus;

            RemainingTime = CurrentSessionType == SessionType.Focus
                ? TimeSpan.FromMinutes(_focusDuration)
                : TimeSpan.FromMinutes(5);

            SessionChanged?.Invoke(CurrentSessionType);
            Tick?.Invoke(RemainingTime);
        }
    }
}