using StretchApp.src.controllers;
using StretchApp.src.models;
using StretchApp.src.services;
using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace StretchApp
{
    public class TimerForm : Form
    {
        private readonly Color ColDark = ColorTranslator.FromHtml("#765555");
        private readonly Color ColLight = ColorTranslator.FromHtml("#ead8c2");
        private readonly Color ColMid = ColorTranslator.FromHtml("#b89080");
        private readonly Color ColAccent = ColorTranslator.FromHtml("#5a3a3a");
        private readonly Color ColStat = ColorTranslator.FromHtml("#f5ece3");

        private const int BASE_W = 700;
        private const int BASE_H = 1020;

        private readonly SessionService _service = new SessionService();
        private readonly SessionController _controller;

        private RoundedButton FocusTab;
        private RoundedButton BreakTab;

        private Panel PanelCard;
        private Label LabelTime;
        private Label LabelMode;
        private CircleButton ButtonPlay;
        private CircleButton ButtonReset;
        private CircleButton ButtonSettings;

        private StatCard CardSessions;
        private StatCard CardFocus;
        private StatCard CardBreak;

        private Panel PnlHistory;
        private Label LblHistoryTitle;
        private ListBox LstHistory;
        private RoundedButton BtnClear;

        private Panel Settings;
        private bool SettingsOpen = false;

        private Label LblTitle;
        private Label LblSub;

        private NumericUpDown NudFocus;
        private NumericUpDown NudBreak;

        private CircleButton ButtonMinus;
        private CircleButton ButtonPlus;

        public TimerForm()
        {
            _controller = new SessionController(_service, 25, 5);
            _controller.tick += OnTick;
            _controller.StateChange += OnStateChanged;
            _controller.SessionComplete += OnSessionCompleted;

            InitializeForm();
            BuildUi();
            RefreshAll();
        }

        private void InitializeForm()
        {
            Text = "Pomodoro Timer";
            var screen = Screen.PrimaryScreen.WorkingArea;
            int width = (int)(screen.Width * 0.45);
            int height = (int)(screen.Height * 0.85);
            width = Math.Max(600, Math.Min(width, 1000));
            height = Math.Max(800, Math.Min(height, 1200));
            StartPosition = FormStartPosition.CenterScreen;
            MinimumSize = new Size(600, 800);
            ClientSize = new Size(width, height);
            FormBorderStyle = FormBorderStyle.Sizable;
            MaximizeBox = true;
            MinimumSize = new Size(480, 680);
            BackColor = ColLight;
            Font = new System.Drawing.Font("Segoe UI", 10f);
            StartPosition = FormStartPosition.CenterScreen;

            Resize += (S, E) => RepositionControls();
        }

        private void BuildUi()
        {
            LblTitle = new Label
            {
                Text = "Pomodoro Timer",
                Font = new System.Drawing.Font("Segoe UI", 22f, FontStyle.Bold),
                ForeColor = ColAccent,
                AutoSize = false,
                Size = new Size(BASE_W, 40),
                Location = new Point(0, 28),
                TextAlign = ContentAlignment.MiddleCenter,
            };

            LblSub = new Label
            {
                Text = "Stay focused with the Pomodoro Technique",
                Font = new System.Drawing.Font("Segoe UI", 10f),
                ForeColor = ColMid,
                AutoSize = false,
                Size = new Size(BASE_W, 28),
                Location = new Point(0, 70),
                TextAlign = ContentAlignment.MiddleCenter,
            };

            FocusTab = new RoundedButton
            {
                Text = "Focus Time",
                Size = new Size(220, 42),
                Location = new Point(118, 112),
                BackColor = ColDark,
                ForeColor = ColLight,
                Font = new System.Drawing.Font("Segoe UI", 10f, FontStyle.Bold),
                Padding = new Padding(0, 0, 0, 4),
            };
            FocusTab.Click += (S, E) => SwitchMode(SessionType.Focus);

            BreakTab = new RoundedButton
            {
                Text = "Break Time",
                Size = new Size(220, 42),
                Location = new Point(362, 112),
                BackColor = Color.White,
                ForeColor = ColDark,
                Font = new System.Drawing.Font("Segoe UI", 10f),
                Padding = new Padding(0, 0, 0, 4),
            };
            BreakTab.Click += (S, E) => SwitchMode(SessionType.Break);

            PanelCard = new Panel
            {
                Size = new Size(620, 420),
                Location = new Point(40, 172),
                BackColor = ColDark
            };
            PanelCard.Paint += PaintTimerCard;
            RoundCorners(PanelCard, 20);

            LabelTime = new Label
            {
                Text = "25:00",
                Font = new System.Drawing.Font("Segoe UI", 58f, FontStyle.Bold),
                ForeColor = ColLight,
                AutoSize = false,
                Size = new Size(320, 80),
                Location = new Point(150, 150),
                TextAlign = ContentAlignment.MiddleCenter,
                BackColor = Color.Transparent
            };

            LabelMode = new Label
            {
                Text = "Focus Mode",
                Font = new System.Drawing.Font("Segoe UI", 13f),
                ForeColor = ColLight,
                AutoSize = false,
                Size = new Size(320, 30),
                Location = new Point(150, 235),
                TextAlign = ContentAlignment.MiddleCenter,
                BackColor = Color.Transparent
            };

            ButtonReset = new CircleButton
            {
                Size = new Size(52, 52),
                Location = new Point(196, 340),
                Symbol = "⟲",
                BackColor = Color.FromArgb(245, 236, 227),
                ForeColor = ColDark
            };
            ButtonReset.Click += (S, E) => { _controller.Reset(); RefreshStats(); RefreshHistory(); };

            ButtonPlay = new CircleButton
            {
                Size = new Size(72, 72),
                Location = new Point(274, 330),
                Symbol = "▶",
                BackColor = Color.FromArgb(255, 250, 245),
                ForeColor = ColDark
            };
            ButtonPlay.Click += OnPlayPauseClick;

            ButtonSettings = new CircleButton
            {
                Size = new Size(52, 52),
                Location = new Point(372, 340),
                Symbol = "⚙",
                BackColor = Color.FromArgb(245, 236, 227),
                ForeColor = ColDark
            };
            ButtonSettings.Click += ToggleSettings;

            PanelCard.Controls.AddRange(new Control[] { LabelTime, LabelMode, ButtonReset, ButtonPlay, ButtonSettings });

            Settings = BuildSettingsPanel();

            CardSessions = new StatCard { Location = new Point(40, 590), Size = new Size(190, 110), Label = "Sessions Today", Value = "0" };
            CardFocus = new StatCard { Location = new Point(255, 590), Size = new Size(190, 110), Label = "Focus Minutes", Value = "25" };
            CardBreak = new StatCard { Location = new Point(470, 590), Size = new Size(190, 110), Label = "Break Minutes", Value = "5" };
            CardSessions.Init(ColStat, ColAccent, ColMid);
            CardFocus.Init(ColStat, ColAccent, ColMid);
            CardBreak.Init(ColStat, ColAccent, ColMid);

            PnlHistory = new Panel
            {
                Location = new Point(40, 720),
                Size = new Size(620, 260),
                BackColor = ColStat
            };
            RoundCorners(PnlHistory, 16);

            LblHistoryTitle = new Label
            {
                Text = "Session History",
                Font = new System.Drawing.Font("Segoe UI", 13f, FontStyle.Bold),
                ForeColor = ColAccent,
                Location = new Point(18, 14),
                AutoSize = true
            };

            LstHistory = new ListBox
            {
                Location = new Point(14, 50),
                Size = new Size(592, 158),
                Font = new System.Drawing.Font("Segoe UI", 9.5f),
                ForeColor = ColAccent,
                BackColor = ColStat,
                BorderStyle = BorderStyle.None,
                ScrollAlwaysVisible = false
            };

            BtnClear = new RoundedButton
            {
                Text = "Clear History",
                Size = new Size(140, 36),
                Location = new Point(240, 216),
                BackColor = ColMid,
                ForeColor = Color.White,
                Font = new System.Drawing.Font("Segoe UI", 9.5f, FontStyle.Bold)
            };
            BtnClear.Click += (S, E) => { _service.ClearAll(); RefreshStats(); RefreshHistory(); };

            PnlHistory.Controls.AddRange(new Control[] { LblHistoryTitle, LstHistory, BtnClear });

            Controls.AddRange(new Control[]
            {
                LblTitle, LblSub,
                FocusTab, BreakTab,
                PanelCard,
                Settings,
                CardSessions, CardFocus, CardBreak,
                PnlHistory
            });

            RepositionControls();
        }

        private void RepositionControls()
        {
            if (PanelCard == null) return;

            int W = ClientSize.Width;
            int H = ClientSize.Height;

            float Sx = (float)W / BASE_W;
            float Sy = (float)H / BASE_H;
            float S = Math.Min(Sx, Sy);

            int Cx = W / 2;
            int Margin = Math.Max(10, (int)(40 * Sx));
            int Inner = W - Margin * 2;

            LblTitle.Size = new Size(W, (int)(40 * Sy));
            LblTitle.Location = new Point(0, (int)(28 * Sy));
            LblTitle.Font = ScaledFont("Segoe UI", 22f, S, 12f, FontStyle.Bold);

            LblSub.Size = new Size(W, (int)(24 * Sy));
            LblSub.Location = new Point(0, (int)(72 * Sy));

            int TabW = (int)(220 * Sx);
            int TabH = Math.Max(30, (int)(42 * Sy));
            int TabY = (int)(112 * Sy);
            int Gap = (int)(12 * Sx);

            FocusTab.Size = new Size(TabW, TabH);
            FocusTab.Location = new Point(Cx - TabW - Gap, TabY);
            BreakTab.Size = new Size(TabW, TabH);
            BreakTab.Location = new Point(Cx + Gap, TabY);

            int CardTop = TabY + TabH + (int)(18 * Sy);
            int CardH = (int)(420 * Sy);
            PanelCard.Size = new Size(Inner, CardH);
            PanelCard.Location = new Point(Margin, CardTop);

            int Pcx = PanelCard.Width / 2;

            int CircleCy = (int)(CardH * 0.44f);
            int R = (int)(Math.Min(PanelCard.Width, CardH) * 0.32f);

            int TimeW = (int)(320 * Sx);
            int TimeH = (int)(80 * Sy);
            int TimeY = CircleCy - TimeH / 2 - (int)(22 * Sy);
            LabelTime.Size = new Size(TimeW, TimeH);
            LabelTime.Location = new Point(Pcx - TimeW / 2, TimeY);
            LabelTime.Font = ScaledFont("Segoe UI", 52f, S, 20f, FontStyle.Bold);

            int ModeW = (int)(320 * Sx);
            int ModeH = (int)(34 * Sy);
            LabelMode.Size = new Size(ModeW, ModeH);
            LabelMode.Location = new Point(Pcx - ModeW / 2, TimeY + TimeH + (int)(2 * Sy));
            LabelMode.Font = ScaledFont("Segoe UI", 13f, S, 9f);

            int CircleBottom = CircleCy + R;
            int Btn72 = Math.Max(40, (int)(72 * S));
            int Btn52 = Math.Max(30, (int)(52 * S));
            int BtnY = CircleBottom + (int)(18 * Sy);
            int BtnSep = (int)(26 * Sx);

            ButtonPlay.Size = new Size(Btn72, Btn72);
            ButtonPlay.Location = new Point(Pcx - Btn72 / 2, BtnY);
            ButtonReset.Size = new Size(Btn52, Btn52);
            ButtonReset.Location = new Point(Pcx - Btn72 / 2 - BtnSep - Btn52, BtnY + (Btn72 - Btn52) / 2);
            ButtonSettings.Size = new Size(Btn52, Btn52);
            ButtonSettings.Location = new Point(Pcx + Btn72 / 2 + BtnSep, BtnY + (Btn72 - Btn52) / 2);

            PanelCard.Invalidate();

            int SettY = CardTop + CardH + (int)(10 * Sy);
            Settings.Location = new Point(Margin, SettY);
            Settings.Width = Inner;
            if (SettingsOpen)
                Settings.Size = new Size(Inner, (int)(116 * Sy));

            int StatH = Math.Max(80, (int)(110 * Sy));
            int StatW = (Inner - (int)(20 * Sx) * 2) / 3;
            int StatGap = (Inner - StatW * 3) / 2;
            int StatY = SettY + (SettingsOpen ? Settings.Height : 0) + (int)(10 * Sy);

            CardSessions.Size = new Size(StatW, StatH);
            CardSessions.Location = new Point(Margin, StatY);
            CardFocus.Size = new Size(StatW, StatH);
            CardFocus.Location = new Point(Margin + StatW + StatGap, StatY);
            CardBreak.Size = new Size(StatW, StatH);
            CardBreak.Location = new Point(Margin + (StatW + StatGap) * 2, StatY);
            CardSessions.Invalidate();
            CardFocus.Invalidate();
            CardBreak.Invalidate();

            int HistY = StatY + StatH + (int)(10 * Sy);
            int HistH = Math.Max(120, H - HistY - (int)(14 * Sy));
            PnlHistory.Size = new Size(Inner, HistH);
            PnlHistory.Location = new Point(Margin, HistY);
            RoundCorners(PnlHistory, 16);

            int ListH = Math.Max(30,
                PnlHistory.Height
                - LstHistory.Top
                - BtnClear.Height
                - (int)(30 * Sy)
            ); LstHistory.Size = new Size(Inner - 28, ListH);
            LstHistory.Location = new Point(14, 50);
            int BtnBottomMargin = (int)(20 * Sy);
            BtnClear.Location = new Point(
                (PnlHistory.Width - BtnClear.Width) / 2,
                PnlHistory.Height - BtnClear.Height - BtnBottomMargin
            );
        }

        private Panel BuildSettingsPanel()
        {
            var Pnl = new Panel
            {
                Location = new Point(40, 578),
                Size = new Size(620, 0),
                BackColor = ColStat,
                Visible = false
            };
            RoundCorners(Pnl, 14);

            var Lbl = new Label { Text = "Timer Settings", Font = new System.Drawing.Font("Segoe UI", 12f, FontStyle.Bold), ForeColor = ColAccent, Location = new Point(18, 14), AutoSize = true };
            var LblF = new Label { Text = "Focus Duration (min):", ForeColor = ColAccent, Location = new Point(18, 52), AutoSize = true };
            NudFocus = new NumericUpDown { Location = new Point(200, 48), Size = new Size(80, 28), Minimum = 1, Maximum = 120, Value = 25, Font = new System.Drawing.Font("Segoe UI", 11f) };
            NudFocus.ValueChanged += (S, E) => { _controller.SetFocusDuration((int)NudFocus.Value); RefreshStats(); };

            var LblB = new Label { Text = "Break Duration (min):", ForeColor = ColAccent, Location = new Point(18, 90), AutoSize = true };
            NudBreak = new NumericUpDown { Location = new Point(200, 86), Size = new Size(80, 28), Minimum = 1, Maximum = 60, Value = 5, Font = new System.Drawing.Font("Segoe UI", 11f) };
            NudBreak.ValueChanged += (S, E) => { _controller.SetBreakDuration((int)NudBreak.Value); RefreshStats(); };

            var BtnApply = new RoundedButton { Text = "Apply & Close", Size = new Size(140, 34), Location = new Point(460, 62), BackColor = ColDark, ForeColor = ColLight, Font = new System.Drawing.Font("Segoe UI", 9f, FontStyle.Bold) };
            BtnApply.Click += ToggleSettings;

            Pnl.Controls.AddRange(new Control[] { Lbl, LblF, NudFocus, LblB, NudBreak, BtnApply });
            Controls.Add(Pnl);
            return Pnl;
        }

        private void ToggleSettings(object Sender, EventArgs E)
        {
            SettingsOpen = !SettingsOpen;
            if (SettingsOpen)
            {
                Settings.Size = new Size(Settings.Width, (int)(116 * (float)ClientSize.Height / BASE_H));
                Settings.Visible = true;
            }
            else
            {
                Settings.Visible = false;
                Settings.Size = new Size(Settings.Width, 0);
            }
            RepositionControls();
        }

        private void PaintTimerCard(object Sender, PaintEventArgs E)
        {
            var G = E.Graphics;
            G.SmoothingMode = SmoothingMode.AntiAlias;
            var Rect = new Rectangle(0, 0, PanelCard.Width, PanelCard.Height);

            using (var Path = RoundedRect(Rect, 20))
            {
                G.SetClip(Path);

                using (var Br = new LinearGradientBrush(Rect,
                                      ColorTranslator.FromHtml("#8a6060"),
                                      ColorTranslator.FromHtml("#5a3535"),
                                      LinearGradientMode.ForwardDiagonal))
                {
                    G.FillPath(Br, Path);
                }
            }

            int Cx = PanelCard.Width / 2;
            int Cy = (int)(PanelCard.Height * 0.44f);
            int R = (int)(Math.Min(PanelCard.Width, PanelCard.Height) * 0.32f);

            using (var Pen = new Pen(ColLight, Math.Max(4, R / 24)))
                G.DrawEllipse(Pen, Cx - R, Cy - R, R * 2, R * 2);

            if (_controller.State != TimerState.Idle)
            {
                int Total = (_controller.CurrentMode == SessionType.Focus
                    ? _controller.FocusDurMin
                    : _controller.BreakDurationMinutes) * 60;

                float Pct = Total > 0 ? (float)_controller.RemSec / Total : 1f;
                float Sweep = 360f * Pct;

                using (var Pen = new Pen(ColLight, Math.Max(3, R / 30)))
                {
                    Pen.StartCap = LineCap.Round;
                    Pen.EndCap = LineCap.Round;
                    G.DrawArc(Pen, Cx - R, Cy - R, R * 2, R * 2, -90f, Sweep);
                }
            }
        }

        private void OnPlayPauseClick(object Sender, EventArgs E)
        {
            switch (_controller.State)
            {
                case TimerState.Idle: _controller.Start(); break;
                case TimerState.Running: _controller.Pause(); break;
                case TimerState.Paused: _controller.Resume(); break;
            }
        }

        private void OnTick(object Sender, int Seconds)
        {
            if (InvokeRequired) { Invoke(new Action(() => OnTick(Sender, Seconds))); return; }
            LabelTime.Text = $"{Seconds / 60:D2}:{Seconds % 60:D2}";
            PanelCard.Invalidate();
        }

        private void OnStateChanged(object Sender, EventArgs E)
        {
            if (InvokeRequired) { Invoke(new Action(() => OnStateChanged(Sender, E))); return; }
            UpdatePlayButton();
            RefreshStats();
        }

        private void OnSessionCompleted(object Sender, EventArgs E)
        {
            if (InvokeRequired) { Invoke(new Action(() => OnSessionCompleted(Sender, E))); return; }
            RefreshStats();
            RefreshHistory();
            MessageBox.Show(
                _controller.CurrentMode == SessionType.Focus
                    ? "Focus session complete! Time for a break 🎉"
                    : "Break's over! Ready to focus? 💪",
                "Session Complete",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
            SwitchMode(_controller.CurrentMode == SessionType.Focus ? SessionType.Break : SessionType.Focus);
        }

        private void SwitchMode(SessionType Mode)
        {
            _controller.SetMode(Mode);
            bool IsFocus = Mode == SessionType.Focus;

            FocusTab.BackColor = IsFocus ? ColDark : Color.White;
            FocusTab.ForeColor = IsFocus ? ColLight : ColDark;
            BreakTab.BackColor = IsFocus ? Color.White : ColDark;
            BreakTab.ForeColor = IsFocus ? ColDark : ColLight;

            LabelMode.Text = IsFocus ? "Focus  Mode" : "Break  Mode";
            int Secs = (IsFocus ? _controller.FocusDurMin : _controller.BreakDurationMinutes) * 60;
            LabelTime.Text = $"{Secs / 60:D2}:{Secs % 60:D2}";
            PanelCard.Invalidate();
        }

        private void UpdatePlayButton()
        {
            ButtonPlay.Symbol = _controller.State == TimerState.Running ? "⏸" : "▶";
            ButtonPlay.Invalidate();
        }

        private void RefreshAll() { RefreshStats(); RefreshHistory(); }

        private void RefreshStats()
        {
            CardSessions.Value = _service.TotalSessionsToday.ToString();
            CardFocus.Value = _controller.FocusDurMin.ToString();
            CardBreak.Value = _controller.BreakDurationMinutes.ToString();
            CardSessions.Invalidate();
            CardFocus.Invalidate();
            CardBreak.Invalidate();
        }

        private void RefreshHistory()
        {
            LstHistory.Items.Clear();
            var Sessions = _service.GetSessionsToday();
            if (Sessions.Count == 0) { LstHistory.Items.Add("  No sessions yet today."); return; }
            foreach (var Session in Sessions)
                LstHistory.Items.Add(Session.ToString());
        }

        private static System.Drawing.Font ScaledFont(string Family, float BaseSize, float Scale,
                                       float MinSize, FontStyle Style = FontStyle.Regular)
        {
            return new System.Drawing.Font(Family, Math.Max(MinSize, BaseSize * Scale), Style);
        }

        private static GraphicsPath RoundedRect(Rectangle R, int Radius)
        {
            var Path = new GraphicsPath();
            Path.AddArc(R.X, R.Y, Radius * 2, Radius * 2, 180, 90);
            Path.AddArc(R.Right - Radius * 2, R.Y, Radius * 2, Radius * 2, 270, 90);
            Path.AddArc(R.Right - Radius * 2, R.Bottom - Radius * 2, Radius * 2, Radius * 2, 0, 90);
            Path.AddArc(R.X, R.Bottom - Radius * 2, Radius * 2, Radius * 2, 90, 90);
            Path.CloseFigure();
            return Path;
        }

        private static void RoundCorners(Control C, int R)
        {
            void Apply()
            {
                if (C.Width <= 0 || C.Height <= 0) return;

                var path = RoundedRect(new Rectangle(0, 0, C.Width, C.Height), R);
                C.Region = new Region(path);
            }

            Apply();
            C.Resize -= (s, e) => Apply();
            C.Resize += (s, e) => Apply();
        }

        private void InitializeComponent() { }

        protected override void OnFormClosing(FormClosingEventArgs E)
        {
            _controller.Dispose();
            base.OnFormClosing(E);
        }
    }

    public class RoundedButton : Button
    {
        public RoundedButton()
        {
            FlatStyle = FlatStyle.Flat;
            FlatAppearance.BorderSize = 0;
            Cursor = Cursors.Hand;
        }

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);

            using (var path = MakeRounded(ClientRectangle, Height / 2))
            {
                this.Region = new Region(path);
            }
        }

        protected override void OnPaint(PaintEventArgs E)
        {
            var G = E.Graphics;
            G.SmoothingMode = SmoothingMode.AntiAlias;

            using (var path = MakeRounded(ClientRectangle, Height / 2))
            using (var br = new SolidBrush(BackColor))
                G.FillPath(br, path);

            using (var sf = new StringFormat
            {
                Alignment = StringAlignment.Center,
                LineAlignment = StringAlignment.Center
            })
            using (var br = new SolidBrush(ForeColor))
                G.DrawString(Text, Font, br, ClientRectangle, sf);
        }

        private static GraphicsPath MakeRounded(Rectangle R, int Radius)
        {
            var Path = new GraphicsPath();
            Path.AddArc(R.X, R.Y, Radius * 2, Radius * 2, 180, 90);
            Path.AddArc(R.Right - Radius * 2, R.Y, Radius * 2, Radius * 2, 270, 90);
            Path.AddArc(R.Right - Radius * 2, R.Bottom - Radius * 2, Radius * 2, Radius * 2, 0, 90);
            Path.AddArc(R.X, R.Bottom - Radius * 2, Radius * 2, Radius * 2, 90, 90);
            Path.CloseFigure();
            return Path;
        }
    }

    public class CircleButton : Button
    {
        public string Symbol { get; set; } = "▶";

        public CircleButton()
        {
            FlatStyle = FlatStyle.Flat;
            FlatAppearance.BorderSize = 0;
            Cursor = Cursors.Hand;
        }

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);

            GraphicsPath path = new GraphicsPath();
            path.AddEllipse(0, 0, Width, Height);
            this.Region = new Region(path);
        }

        protected override void OnPaint(PaintEventArgs E)
        {
            var G = E.Graphics;
            G.SmoothingMode = SmoothingMode.AntiAlias;

            Rectangle rect = new Rectangle(0, 0, Width - 1, Height - 1);
            using (var shadow = new SolidBrush(Color.FromArgb(40, 0, 0, 0)))
                G.FillEllipse(shadow, rect.X + 2, rect.Y + 3, rect.Width - 2, rect.Height - 2);
            using (var br = new SolidBrush(ControlPaint.Light(BackColor, 0.1f)))
                G.FillEllipse(br, rect);
            using (var pen = new Pen(Color.FromArgb(60, 0, 0, 0), 1.5f))
                G.DrawEllipse(pen, rect);
            Color fg = ForeColor == Color.Empty ? Color.Black : ForeColor;
            float fontSize = Math.Max(10f, Width * 0.32f);

            using (var sf = new StringFormat { Alignment = StringAlignment.Center, LineAlignment = StringAlignment.Center })
            using (var br = new SolidBrush(fg))
            using (var f = new System.Drawing.Font("Segoe UI Symbol", fontSize, FontStyle.Bold))
                G.DrawString(Symbol, f, br, rect, sf);
        }
    }
    public class StatCard : Panel
    {
        public string Label { get; set; }
        public string Value { get; set; }
        private Color _bg, _fg, _sub;

        public void Init(Color Bg, Color Fg, Color Sub)
        {
            _bg = Bg; _fg = Fg; _sub = Sub;
            BackColor = Bg;
        }

        protected override void OnPaint(PaintEventArgs E)
        {
            base.OnPaint(E);
            var G = E.Graphics;
            G.SmoothingMode = SmoothingMode.AntiAlias;

            using (var Path = MakeRounded(ClientRectangle, 16))
            using (var Br = new SolidBrush(_bg))
                G.FillPath(Br, Path);

            float ValueFontSize = Math.Max(14f, Height * 0.26f);
            float LabelFontSize = Math.Max(7f, Height * 0.09f);

            using (var Sf = new StringFormat { Alignment = StringAlignment.Center, LineAlignment = StringAlignment.Center })
            using (var Br = new SolidBrush(_fg))
            using (var F = new System.Drawing.Font("Segoe UI", ValueFontSize, FontStyle.Bold))
                G.DrawString(Value ?? "0", F, Br,
                             new RectangleF(4, 0, Width - 8, Height * 0.65f), Sf);

            using (var Sf = new StringFormat { Alignment = StringAlignment.Center, LineAlignment = StringAlignment.Center })
            using (var Br = new SolidBrush(_sub))
            using (var F = new System.Drawing.Font("Segoe UI", LabelFontSize))
                G.DrawString(Label ?? "", F, Br,
                             new RectangleF(4, Height * 0.62f, Width - 8, Height * 0.38f), Sf);
        }

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            if (Width > 0 && Height > 0)
            {
                var Path = MakeRounded(new Rectangle(0, 0, Width, Height), 16);
                Region = new Region(Path);
            }
        }

        private static GraphicsPath MakeRounded(Rectangle R, int Radius)
        {
            var P = new GraphicsPath();
            P.AddArc(R.X, R.Y, Radius * 2, Radius * 2, 180, 90);
            P.AddArc(R.Right - Radius * 2, R.Y, Radius * 2, Radius * 2, 270, 90);
            P.AddArc(R.Right - Radius * 2, R.Bottom - Radius * 2, Radius * 2, Radius * 2, 0, 90);
            P.AddArc(R.X, R.Bottom - Radius * 2, Radius * 2, Radius * 2, 90, 90);
            P.CloseFigure();
            return P;
        }
    }
}
