using System;
using System.Drawing;
using System.Windows.Forms;

namespace StretchApp
{
    /// <summary>
    /// Logic half of the Pomodoro UserControl.
    /// UI construction lives in PomodoroControlForm.cs.
    /// </summary>
    public partial class PomodoroControl : UserControl
    {
        // ── Palette ───────────────────────────────────────────────────────────
        private readonly Color ColDark = ColorTranslator.FromHtml("#765555");
        private readonly Color ColLight = ColorTranslator.FromHtml("#ead8c2");
        private readonly Color ColMid = ColorTranslator.FromHtml("#b89080");
        private readonly Color ColAccent = ColorTranslator.FromHtml("#5a3a3a");
        private readonly Color ColStat = ColorTranslator.FromHtml("#f5ece3");

        // ── Layout baseline ───────────────────────────────────────────────────
        private const int BASE_W = 700;
        private const int BASE_H = 620;

        // ── Domain objects ────────────────────────────────────────────────────
        private readonly SessionService _service;
        private readonly SessionController _controller;

        // ── Selected preset tracking ──────────────────────────────────────────
        private int _selectedPresetMinutes = 25;

        // ────────────────────────────────────────────────────────────────────
        //  Constructors
        // ────────────────────────────────────────────────────────────────────
        public PomodoroControl() : this(25) { }

        public PomodoroControl(int initialMinutes = 25)
        {
            _service = new SessionService();
            _controller = new SessionController(_service, initialMinutes, initialMinutes);

            _controller.tick += OnTick;
            _controller.StateChange += OnStateChanged;
            _controller.SessionComplete += OnSessionCompleted;

            DoubleBuffered = true;
            BackColor = ColLight;
            Font = new System.Drawing.Font("Segoe UI", 10f);
            MinimumSize = new Size(380, 480);

            BuildUi();

            Resize += (s, e) => RepositionControls();
        }

        // ────────────────────────────────────────────────────────────────────
        //  Timer event handlers
        // ────────────────────────────────────────────────────────────────────
        private void OnTick(object sender, int seconds)
        {
            if (InvokeRequired) { Invoke(new Action(() => OnTick(sender, seconds))); return; }
            LabelTime.Text = $"{seconds / 60:D2}:{seconds % 60:D2}";
            PanelCard.Invalidate();
        }

        private void OnStateChanged(object sender, EventArgs e)
        {
            if (InvokeRequired) { Invoke(new Action(() => OnStateChanged(sender, e))); return; }
            UpdatePlayButton();
        }

        private void OnSessionCompleted(object sender, EventArgs e)
        {
            if (InvokeRequired) { Invoke(new Action(() => OnSessionCompleted(sender, e))); return; }
            MessageBox.Show(
                "Session complete! Take a moment to stretch 🎉",
                "Session Complete",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
            // Reset to idle so a new session can be started
            _controller.Reset();
        }

        // ────────────────────────────────────────────────────────────────────
        //  Button click handlers
        // ────────────────────────────────────────────────────────────────────
        private void OnPlayPauseClick(object sender, EventArgs e)
        {
            switch (_controller.State)
            {
                case TimerState.Idle: _controller.Start(); break;
                case TimerState.Running: _controller.Pause(); break;
                case TimerState.Paused: _controller.Resume(); break;
            }
        }

        private void OnPresetClick(int minutes)
        {
            // Only allow changing preset when not running/paused
            if (_controller.State != TimerState.Idle) return;

            _selectedPresetMinutes = minutes;
            _controller.SetFocusDuration(minutes);
            _controller.SetBreakDuration(minutes);
            _controller.SetMode(SessionType.Focus);

            UpdatePresetButtons();

            LabelTime.Text = $"{minutes:D2}:00";
            PanelCard.Invalidate();
        }

        // ────────────────────────────────────────────────────────────────────
        //  UI state helpers
        // ────────────────────────────────────────────────────────────────────
        private void UpdatePlayButton()
        {
            ButtonPlay.Symbol = _controller.State == TimerState.Running ? "⏸" : "▶";
            ButtonPlay.Invalidate();
        }

        private void UpdatePresetButtons()
        {
            Btn5Min.BackColor = _selectedPresetMinutes == 5 ? ColDark : ColStat;
            Btn5Min.ForeColor = _selectedPresetMinutes == 5 ? ColLight : ColAccent;
            Btn15Min.BackColor = _selectedPresetMinutes == 15 ? ColDark : ColStat;
            Btn15Min.ForeColor = _selectedPresetMinutes == 15 ? ColLight : ColAccent;
            Btn25Min.BackColor = _selectedPresetMinutes == 25 ? ColDark : ColStat;
            Btn25Min.ForeColor = _selectedPresetMinutes == 25 ? ColLight : ColAccent;
            Btn5Min.Invalidate();
            Btn15Min.Invalidate();
            Btn25Min.Invalidate();
        }

        // ────────────────────────────────────────────────────────────────────
        //  Cleanup
        // ────────────────────────────────────────────────────────────────────
        protected override void Dispose(bool disposing)
        {
            if (disposing)
                _controller?.Dispose();
            base.Dispose(disposing);
        }
    }
}
