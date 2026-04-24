using StretchApp.src.models;
using StretchApp.src.services;
using System;
using System.Collections.Generic;
using System.Text;

namespace StretchApp.src.controllers
{
    public enum TimerState
    {
        Idle,
        Running,
        Paused
    }
    class SessionController
    {
        private readonly SessionService _sessionService;
        private readonly System.Windows.Forms.Timer _timer;
        private Session _currentSession;
        private int _remainSec;
        private int _focusDurMin;
        private int _breakDurMin;

        public TimerState State { get; private set; } = TimerState.Idle;
        public SessionType CurrentMode { get; private set; } = SessionType.Focus;
        public int RemSec => _remainSec;
        public int FocusDurMin => _focusDurMin;
        public int BreakDurationMinutes => _breakDurMin;
        public event EventHandler<int> tick;
        public event EventHandler SessionComplete;
        public event EventHandler StateChange;

        public SessionController(SessionService sessionService, int FocusMins = 25, int BreakMins = 5)
        {
            _sessionService = sessionService;
            _focusDurMin = FocusMins;
            _breakDurMin = BreakMins;
            _remainSec = FocusMins * 60;

            _timer = new System.Windows.Forms.Timer();
            _timer.Interval = 1000;
            _timer.Tick += OnTimerTick;
        }

        public void Start()
        {
            if (State == TimerState.Idle)
            {
                int duration = CurrentMode == SessionType.Focus ? _focusDurMin : _breakDurMin;
                _currentSession = _sessionService.CreateSession(CurrentMode, duration);
                _remainSec = duration * 60;
            }
            State = TimerState.Running;
            _timer.Start();
            StateChange?.Invoke(this, EventArgs.Empty);
        }

        public void Pause()
        {
            if (State == TimerState.Running)
            {
                State = TimerState.Paused;
                _timer.Stop();
                StateChange?.Invoke(this, EventArgs.Empty);
            }
        }

        public void Resume()
        {
            if (State == TimerState.Paused)
            {
                State = TimerState.Running;
                _timer.Start();
                StateChange?.Invoke(this, EventArgs.Empty);
            }
        }

        public void Reset()
        {
            _timer.Stop();

            if (_currentSession != null && !_currentSession.IsCompleted)
                _sessionService.RemoveIncompleteSession(_currentSession);

            _currentSession = null;
            State = TimerState.Idle;
            int duration = CurrentMode == SessionType.Focus ? _focusDurMin : _breakDurMin;
            _remainSec = duration * 60;
            StateChange?.Invoke(this, EventArgs.Empty);
            tick?.Invoke(this, _remainSec);
        }

        public void SetMode(SessionType mode)
        {
            if (State == TimerState.Running || State == TimerState.Paused)
                Reset();

            CurrentMode = mode;
            int duration = mode == SessionType.Focus ? _focusDurMin : _breakDurMin;
            _remainSec = duration * 60;
            StateChange?.Invoke(this, EventArgs.Empty);
            tick?.Invoke(this, _remainSec);
        }

        public void SetFocusDuration(int minutes)
        {
            _focusDurMin = minutes;
            if (CurrentMode == SessionType.Focus && State == TimerState.Idle)
            {
                _remainSec = minutes * 60;
                tick?.Invoke(this, _remainSec);
            }
        }

        public void SetBreakDuration(int minutes)
        {
            _breakDurMin = minutes;
            if (CurrentMode == SessionType.Break && State == TimerState.Idle)
            {
                _remainSec = minutes * 60;
                tick?.Invoke(this, _remainSec);
            }
        }

        private void OnTimerTick(object sender, EventArgs e)
        {
            _remainSec--;
            tick?.Invoke(this, _remainSec);
            if (_remainSec <= 0)
            {
                _timer.Stop();
                State = TimerState.Idle;
                if (_currentSession != null)
                    _sessionService.CompleteSession(_currentSession);
                _currentSession = null;
                SessionComplete?.Invoke(this, EventArgs.Empty);
                StateChange?.Invoke(this, EventArgs.Empty);
            }
        }

        public void AdjustTime(int minutes)
        {
            if (State != TimerState.Idle) return;

            int duration = CurrentMode == SessionType.Focus ? _focusDurMin : _breakDurMin;
            int minSeconds = 60;
            int maxSeconds = 120 * 60;

            _remainSec = Math.Clamp(_remainSec + minutes * 60, minSeconds, maxSeconds);
            tick?.Invoke(this, _remainSec);
        }

        public void Dispose()
        {
            _timer?.Dispose();
        }
    }
}
