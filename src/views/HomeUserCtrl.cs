using System;
using System.Drawing;
using System.Windows.Forms;

namespace StretchApp.src.views
{
    public partial class HomeUserCtrl : UserControl
    {

        public HomeUserCtrl()
        {
            InitializeComponent();
            LoadTimerControl();

            splitContainer1.Panel1.Resize += (s, e) => CenterTimer();
        }

        private void LoadTimerControl()
        {
            timerControl = new StretchApp.src.views.Timer();

            timerControl.Dock = DockStyle.None;
            timerControl.Size = new Size(664, 267);

            splitContainer1.Panel1.Controls.Clear();
            splitContainer1.Panel1.Controls.Add(timerControl);

            CenterTimer();
        }

        private void CenterTimer()
        {
            if (timerControl == null) return;

            timerControl.Location = new Point(
                (splitContainer1.Panel1.Width - timerControl.Width) / 2,
                (splitContainer1.Panel1.Height - timerControl.Height) / 2
            );
        }
    }
}
