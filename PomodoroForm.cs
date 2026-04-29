using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace StretchApp
{
    public partial class PomodoroControl
    {
        // ── Control declarations ──────────────────────────────────────────────
        private Panel PanelCard;
        private Label LabelTime;
        private CircleButton ButtonPlay;
        private CircleButton ButtonReset;

        private RoundedButton Btn5Min;
        private RoundedButton Btn15Min;
        private RoundedButton Btn25Min;

        // ────────────────────────────────────────────────────────────────────
        //  Control construction
        // ────────────────────────────────────────────────────────────────────
        private void BuildUi()
        {
            // Timer card
            PanelCard = new Panel
            {
                Size = new Size(620, 420),
                Location = new Point(40, 20),
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
                Size = new Size(330, 80),
                Location = new Point(0, 0),
                TextAlign = ContentAlignment.MiddleCenter,
                BackColor = Color.Transparent
            };

            ButtonReset = new CircleButton
            {
                Size = new Size(55, 55),
                Symbol = "⟲",
                BackColor = Color.FromArgb(245, 236, 227),
                ForeColor = ColDark
            };
            ButtonReset.Click += (s, e) => { _controller.Reset(); };

            ButtonPlay = new CircleButton
            {
                Size = new Size(72, 72),
                Symbol = "▶",
                BackColor = Color.FromArgb(255, 250, 245),
                ForeColor = ColDark
            };
            ButtonPlay.Click += OnPlayPauseClick;

            PanelCard.Controls.AddRange(new Control[] { LabelTime, ButtonReset, ButtonPlay });

            Btn5Min = new RoundedButton
            {
                Text = "5 min",
                BackColor = ColStat,
                ForeColor = ColAccent,
                Font = new System.Drawing.Font("Segoe UI", 10f, FontStyle.Bold),
            };
            Btn5Min.Click += (s, e) => OnPresetClick(5);

            Btn15Min = new RoundedButton
            {
                Text = "15 min",
                BackColor = ColStat,
                ForeColor = ColAccent,
                Font = new System.Drawing.Font("Segoe UI", 10f, FontStyle.Bold),
            };
            Btn15Min.Click += (s, e) => OnPresetClick(15);

            Btn25Min = new RoundedButton
            {
                Text = "25 min",
                BackColor = ColDark,
                ForeColor = ColLight,
                Font = new System.Drawing.Font("Segoe UI", 10f, FontStyle.Bold),
            };
            Btn25Min.Click += (s, e) => OnPresetClick(25);

            PanelCard.Controls.AddRange(new Control[]
            {
                Btn5Min, Btn15Min, Btn25Min
            });

            Controls.Add(PanelCard);

            RepositionControls();
        }

        // ────────────────────────────────────────────────────────────────────
        //  Responsive layout
        // ────────────────────────────────────────────────────────────────────
        private void RepositionControls()
        {
            if (PanelCard == null) return;

            int W = ClientSize.Width;
            int H = ClientSize.Height;
            float Sx = (float)W / BASE_W;
            float Sy = (float)H / BASE_H;
            float S = Math.Min(Sx, Sy);

            int Up = -18;
            int SizeCut = 10;

            int Margin = Math.Max(10, (int)(40 * Sx));
            int Inner = W - Margin * 2;
            int Gap = (int)(10 * Sx);

            int CardTop = (int)(10 * Sy) + Up;
            int CardH = (int)(300 * Sy) - SizeCut;
            PanelCard.Size = new Size(Inner, CardH);
            PanelCard.Location = new Point(Margin, CardTop);

            int Pcx = PanelCard.Width / 2;
            int CircleCy = (int)(CardH * 0.25f) + Up;
            int R = (int)(Math.Min(PanelCard.Width, CardH) * 0.32f) - 5;

            int TimeW = (int)(320 * Sx) - 10;
            int TimeH = (int)(80 * Sy) - 5;
            int BlockY = CircleCy - TimeH / 2;

            LabelTime.Size = new Size(TimeW, TimeH);
            LabelTime.Location = new Point(Pcx - TimeW / 2, BlockY);
            LabelTime.Font = ScaledFont("Segoe UI", 48f, S, 20f, FontStyle.Bold);

            int CircleBottom = CircleCy + R;
            int Btn72 = Math.Max(40, (int)(72 * S) - 5);
            int Btn52 = Math.Max(30, (int)(52 * S) - 4);
            int BtnY = LabelTime.Bottom + (int)(28 * Sy);
            int BtnSep = (int)(26 * Sx);

            ButtonPlay.Size = new Size(Btn72, Btn72);
            ButtonPlay.Location = new Point(Pcx - Btn72 / 2, BtnY);

            ButtonReset.Size = new Size(Btn52, Btn52);
            ButtonReset.Location = new Point(Pcx - Btn72 / 2 - BtnSep - Btn52, BtnY + (Btn72 - Btn52) / 2);

            int PresetY = ButtonPlay.Bottom + (int)(10 * Sy);
            int PresetH = Math.Max(34, (int)(44 * Sy) - 4);
            int PresetGap = (int)(12 * Sx);
            int PresetW = (PanelCard.Width - Margin * 2 - PresetGap * 2) / 3;
            int PresetX = (PanelCard.Width - (PresetW * 3 + PresetGap * 2)) / 2;

            Btn5Min.Size = new Size(PresetW, PresetH);
            Btn5Min.Location = new Point(PresetX, PresetY);

            Btn15Min.Size = new Size(PresetW, PresetH);
            Btn15Min.Location = new Point(PresetX + PresetW + PresetGap, PresetY);

            Btn25Min.Size = new Size(PresetW, PresetH);
            Btn25Min.Location = new Point(PresetX + (PresetW + PresetGap) * 2, PresetY);

            PanelCard.Invalidate();
        }

        // ────────────────────────────────────────────────────────────────────
        //  Timer card painting
        // ────────────────────────────────────────────────────────────────────
        private void PaintTimerCard(object sender, PaintEventArgs e)
        {
            var G = e.Graphics;
            G.SmoothingMode = SmoothingMode.AntiAlias;
            var Rect = new Rectangle(0, 0, PanelCard.Width, PanelCard.Height);

            using (var path = RoundedRect(Rect, 20))
            {
                G.SetClip(path);
                using (var br = new LinearGradientBrush(Rect,
                                      ColorTranslator.FromHtml("#8a6060"),
                                      ColorTranslator.FromHtml("#5a3535"),
                                      LinearGradientMode.ForwardDiagonal))
                    G.FillPath(br, path);
            }

            int Cx = PanelCard.Width / 2;
            int Cy = (int)(PanelCard.Height * 0.44f);
            int R = (int)(Math.Min(PanelCard.Width, PanelCard.Height) * 0.32f);

        }

        // ────────────────────────────────────────────────────────────────────
        //  Drawing utilities
        // ────────────────────────────────────────────────────────────────────
        private static System.Drawing.Font ScaledFont(string family, float baseSize, float scale,
                                                       float minSize, FontStyle style = FontStyle.Regular)
            => new System.Drawing.Font(family, Math.Max(minSize, baseSize * scale), style);

        private static GraphicsPath RoundedRect(Rectangle r, int radius)
        {
            var p = new GraphicsPath();
            p.AddArc(r.X, r.Y, radius * 2, radius * 2, 180, 90);
            p.AddArc(r.Right - radius * 2, r.Y, radius * 2, radius * 2, 270, 90);
            p.AddArc(r.Right - radius * 2, r.Bottom - radius * 2, radius * 2, radius * 2, 0, 90);
            p.AddArc(r.X, r.Bottom - radius * 2, radius * 2, radius * 2, 90, 90);
            p.CloseFigure();
            return p;
        }

        private static void RoundCorners(Control c, int r)
        {
            void Apply()
            {
                if (c.Width <= 0 || c.Height <= 0) return;
                c.Region = new Region(RoundedRect(new Rectangle(0, 0, c.Width, c.Height), r));
            }
            Apply();
            c.Resize -= (s, e) => Apply();
            c.Resize += (s, e) => Apply();
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
                Region = new Region(path);
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            var g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;
            using (var path = MakeRounded(ClientRectangle, Height / 2))
            using (var br = new SolidBrush(BackColor))
                g.FillPath(br, path);

            using (var sf = new StringFormat { Alignment = StringAlignment.Center, LineAlignment = StringAlignment.Center })
            using (var br = new SolidBrush(ForeColor))
                g.DrawString(Text, Font, br, ClientRectangle, sf);
        }

        private static GraphicsPath MakeRounded(Rectangle r, int radius)
        {
            var p = new GraphicsPath();
            p.AddArc(r.X, r.Y, radius * 2, radius * 2, 180, 90);
            p.AddArc(r.Right - radius * 2, r.Y, radius * 2, radius * 2, 270, 90);
            p.AddArc(r.Right - radius * 2, r.Bottom - radius * 2, radius * 2, radius * 2, 0, 90);
            p.AddArc(r.X, r.Bottom - radius * 2, radius * 2, radius * 2, 90, 90);
            p.CloseFigure();
            return p;
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
            var path = new GraphicsPath();
            path.AddEllipse(0, 0, Width, Height);
            Region = new Region(path);
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            var g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;
            var rect = new Rectangle(0, 0, Width - 1, Height - 1);

            using (var br = new SolidBrush(Color.FromArgb(40, 0, 0, 0)))
                g.FillEllipse(br, rect.X + 2, rect.Y + 3, rect.Width - 2, rect.Height - 2);
            using (var br = new SolidBrush(ControlPaint.Light(BackColor, 0.1f)))
                g.FillEllipse(br, rect);
            using (var pen = new Pen(Color.FromArgb(60, 0, 0, 0), 1.5f))
                g.DrawEllipse(pen, rect);

            float fontSize = Math.Max(10f, Width * 0.32f);
            using (var sf = new StringFormat { Alignment = StringAlignment.Center, LineAlignment = StringAlignment.Center })
            using (var br = new SolidBrush(ForeColor == Color.Empty ? Color.Black : ForeColor))
            using (var f = new System.Drawing.Font("Segoe UI Symbol", fontSize, FontStyle.Bold))
                g.DrawString(Symbol, f, br, rect, sf);
        }
    }
}
