using StretchApp.src.controllers;
using StretchApp.src.models;

namespace StretchApp.src.views
{
    public partial class TimerView : UserControl
    {
        private SessionController _controller;

        public TimerView()
        {
            InitializeComponent();
            ApplyUIStyling();

            _controller = new SessionController();

            _controller.Tick += UpdateTimerDisplay;
            _controller.SessionChanged += UpdateSessionLabel;

            UpdateTimerDisplay(_controller.RemainingTime);
            UpdateSessionLabel(_controller.CurrentSessionType);
        }

        private void ApplyUIStyling()
        {
            // Main Panel
            Helper.SetRoundness(panel1, 20);

            // Circular-ish icon buttons
            Helper.StyleRoundedButton(StartButton);
            Helper.StyleRoundedButton(RestartButton);

            Helper.MakeCircular(StartButton);
            Helper.MakeCircular(RestartButton);

            // Timer option buttons
            Helper.StyleRoundedButton(TimerOpt1Btn);
            Helper.StyleRoundedButton(TimerOpt2Btn);
            Helper.StyleRoundedButton(TimerOpt3Btn);

            Helper.SetRoundness(TimerOpt1Btn, 12);
            Helper.SetRoundness(TimerOpt2Btn, 12);
            Helper.SetRoundness(TimerOpt3Btn, 12);
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
