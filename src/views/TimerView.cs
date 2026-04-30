using StretchApp.src.controllers;
using StretchApp.src.models;
using System;
using System.Windows.Forms;

namespace StretchApp.src.views
{
    public partial class TimerView : UserControl
    {
        private SessionController _controller;

        public TimerView()
        {
            InitializeComponent();

            _controller = new SessionController();

            _controller.Tick += UpdateTimerDisplay;
            _controller.SessionChanged += UpdateSessionLabel;

            UpdateTimerDisplay(_controller.RemainingTime);
            UpdateSessionLabel(_controller.CurrentSessionType);
        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            _controller.Start();
        }

        private void RestartButton_Click(object sender, EventArgs e)
        {
            _controller.Reset();
        }

        private void TimerOpt1Btn_Click(object sender, EventArgs e)
        {
            _controller.SetFocusDuration(5);
        }

        private void TimerOpt2Btn_Click(object sender, EventArgs e)
        {
            _controller.SetFocusDuration(15);
        }

        private void TimerOpt3Btn_Click(object sender, EventArgs e)
        {
            _controller.SetFocusDuration(25);
        }

        private void UpdateTimerDisplay(TimeSpan time)
        {
            TimerLabel.Text = time.ToString(@"mm\:ss");
        }

        private void UpdateSessionLabel(SessionType type)
        {
            SessionTypeLabel.Text = $"{type} Time";
        }
    }
}
